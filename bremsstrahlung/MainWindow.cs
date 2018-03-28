//     Copyright 2018 ©, Yuri S. Mirgorod, Svetlana M. Kachan, Yana A. Salkevich
//     All rights reserved.
// 
//     This file is part of Bremsstahlung.
// 
//     Bremsstahlung is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     Bremsstahlung is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with Bremsstahlung.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace bremsstrahlung
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //Задание размеров и положений элементов окна
            GammaSpectrChart.Height = this.ClientSize.Height - 144;
            GammaSpectrChart.Width = this.ClientSize.Width - 20;
            GammaSpectrRangeControl.Top = 44 + GammaSpectrChart.Height;
            GammaSpectrRangeControl.Left = 10;
            GammaSpectrRangeControl.Width = GammaSpectrChart.Width;
            //Чтение фона
            SetBackgroundProcedure();
        }

        [Serializable]
        public class SpectrFile:ICloneable
        {
            public string FileName { get; set; }
            public string[] FileLines { get; set; }
            public int Time { get; set; }
            public int Geometry { get; set; }
            public int GammaSpectrStartPosition { get; set; }
            public int BetaSpectrStartPosition { get; set; }
            public int ResolutionStartPosition { get; set; }
            public int EnergyStartPosition { get; set; }
            public double[] GammaSpectr = new double[1024];
            public double[] BetaSpectr = new double[1024];
            public double[] Energy = new double[1024];
            public double[] Resolution = new double[1024];

            public object Clone()
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    if (this.GetType().IsSerializable)
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, this);
                        stream.Position = 0;
                        return formatter.Deserialize(stream);
                    }
                    return null;
                }
            }
        }

        public SpectrFile Spectr = new SpectrFile();
        public SpectrFile Background = new SpectrFile();
        public SpectrFile WorkingSpectr = new SpectrFile();


        void OpenFileProcedure()
        {            
            Spectr.FileLines = System.IO.File.ReadAllLines(Spectr.FileName);
            for (int counterI = 0; counterI < Spectr.FileLines.Length; counterI++)
            {
                if (Spectr.FileLines[counterI].Substring(0, 4) == "TIME") Spectr.Time = int.Parse(Spectr.FileLines[counterI].Substring(7));
                if (Spectr.FileLines[counterI].Length > 8 && Spectr.FileLines[counterI].Substring(0, 8) == "GEOMETRY") Spectr.Geometry = int.Parse(Spectr.FileLines[counterI].Substring(11));
                if (Spectr.FileLines[counterI].Substring(0, 6) == "SPECTR") Spectr.GammaSpectrStartPosition = counterI + 1;
                if (Spectr.FileLines[counterI].Length > 12 && Spectr.FileLines[counterI].Substring(0, 12) == "RCALIBRATION") Spectr.ResolutionStartPosition = counterI + 1;
                if (Spectr.FileLines[counterI].Length > 12 && Spectr.FileLines[counterI].Substring(0, 12) == "ECALIBRATION") Spectr.EnergyStartPosition = counterI + 1;
                if (Spectr.FileLines[counterI].Length > 14 && Spectr.FileLines[counterI].Substring(0, 14) == "EFFCALIBRATION") Spectr.BetaSpectrStartPosition = counterI + 1;
            }
            switch (Spectr.Geometry)
            {
                case 4:
                    Spectr.Geometry = 0;
                    break;
                case 2:
                    Spectr.Geometry = 1;
                    break;
                case 5:
                    Spectr.Geometry = 2;
                    break;
            }
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                Spectr.GammaSpectr[counterI] = double.Parse(Spectr.FileLines[counterI + Spectr.GammaSpectrStartPosition].Replace('.', ','));
                Spectr.BetaSpectr[counterI] = double.Parse(Spectr.FileLines[counterI + Spectr.BetaSpectrStartPosition].Replace('.', ','));
                Spectr.Resolution[counterI] = double.Parse(Spectr.FileLines[counterI + Spectr.ResolutionStartPosition].Replace('.', ','));
                Spectr.Energy[counterI] = double.Parse(Spectr.FileLines[counterI + Spectr.EnergyStartPosition].Replace('.', ','));
            }
            SetBackgroundProcedure();
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                if (Background.Energy[counterI] != Spectr.Energy[counterI])
                {
                    MessageBox.Show("Энергетическая калибровка спектра не совпадает с энергетической калибровкой фона. Проверьте правильность устновленного фона",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            //Сдвиг массива энергий на 1 влево
            for (int counterI = 0; counterI < 1023; counterI++)
            {
                Spectr.Energy[counterI] = double.Parse(Spectr.FileLines[counterI + Spectr.EnergyStartPosition + 1].Replace('.', ','));
            }
            Spectr.Energy[1023] = Spectr.Energy[1022];
            ChooseWithOrWithoutBackground();
        }

        public void ClearAllSeriesProcedure()
        {
            XYDiagram GammaSpectrDiagram = (XYDiagram)GammaSpectrChart.Diagram;
            GammaSpectrChart.Series["Спектр"].Points.Clear();
            GammaSpectrChart.Series["Энергия"].Points.Clear();
            GammaSpectrChart.Series["Сглаживание"].Points.Clear();
            GammaSpectrChart.Series["baseline"].Points.Clear();
            GammaSpectrDiagram.AxisX.ConstantLines.Clear();
        }

        void ChooseWithOrWithoutBackground()
        {
            WorkingSpectr = Spectr.Clone() as SpectrFile;
            if (BackgroundSubstraction.Checked == true)
            {
                for (int counterI = 0; counterI < 1024; counterI++)
                {
                    WorkingSpectr.GammaSpectr[counterI] = Spectr.GammaSpectr[counterI] - Background.GammaSpectr[counterI] * Spectr.Time / Background.Time;
                    WorkingSpectr.BetaSpectr[counterI] = Spectr.BetaSpectr[counterI] - Background.BetaSpectr[counterI] * Spectr.Time / Background.Time;
                }
            }
            DrawChartProcedure(WorkingSpectr);
        }

        public void SetBackgroundProcedure()
        {
            Background.FileLines = System.IO.File.ReadAllLines(Properties.BackgroundSettings.Default.Geometries[Spectr.Geometry]);
            for (int counterI = 0; counterI < Background.FileLines.Length; counterI++)
            {
                 if (Background.FileLines[counterI].Substring(0, 4) == "TIME") Background.Time = int.Parse(Background.FileLines[counterI].Substring(7));
                 if (Background.FileLines[counterI].Substring(0, 6) == "SPECTR") Background.GammaSpectrStartPosition = counterI + 1;
                 if (Background.FileLines[counterI].Length > 12 && Background.FileLines[counterI].Substring(0, 12) == "RCALIBRATION") Background.ResolutionStartPosition = counterI + 1;
                 if (Background.FileLines[counterI].Length > 12 && Background.FileLines[counterI].Substring(0, 12) == "ECALIBRATION") Background.EnergyStartPosition = counterI + 1;
                 if (Background.FileLines[counterI].Length > 14 && Background.FileLines[counterI].Substring(0, 14) == "EFFCALIBRATION") Background.BetaSpectrStartPosition = counterI + 1;
            }
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                Background.GammaSpectr[counterI] = double.Parse(Background.FileLines[counterI + Background.GammaSpectrStartPosition].Replace('.', ','));
                Background.BetaSpectr[counterI] = double.Parse(Background.FileLines[counterI + Background.BetaSpectrStartPosition].Replace('.', ','));
                Background.Energy[counterI] = double.Parse(Background.FileLines[counterI + Background.EnergyStartPosition].Replace('.', ','));
                Background.Resolution[counterI] = double.Parse(Background.FileLines[counterI + Background.ResolutionStartPosition].Replace('.', ','));
            }
        }

        void DrawChartProcedure(SpectrFile Source)
        {
            ClearAllSeriesProcedure();
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                GammaSpectrChart.Series["Спектр"].Points.Add(new SeriesPoint(counterI + 1, Math.Round(Source.GammaSpectr[counterI],2)));
                GammaSpectrChart.Series["Энергия"].Points.Add(new SeriesPoint(counterI + 1, Math.Round(Source.Energy[counterI],2)));//Math.Round(Source.Energy[counterI])));
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            GammaSpectrChart.Height = this.ClientSize.Height - 144;
            GammaSpectrChart.Width = this.ClientSize.Width - 20;
            GammaSpectrRangeControl.Top = 44 + GammaSpectrChart.Height;
            GammaSpectrRangeControl.Left = 10;
            GammaSpectrRangeControl.Width = GammaSpectrChart.Width;
        }

        private void BackgroundSettingsMenuButton_Click(object sender, EventArgs e)
        {
            BackgroundSettings backgroundSettings = new BackgroundSettings();
            backgroundSettings.Owner = this;
            backgroundSettings.Show();
        }

        private void SpectrometryHandlerMenuButton_Click(object sender, EventArgs e)
        {
            SpectrometryHandler spectrometryHandler = new SpectrometryHandler();
            spectrometryHandler.Owner = this;
            spectrometryHandler.Show();
        }

        private void BackgroundSunstraction_Click(object sender, EventArgs e)
        {
            if (BackgroundSubstraction.Checked == true)
            {
                BackgroundSubstraction.Checked = false;
                BackgroundSubstraction.Image = Properties.Resources.Report_16x;
                BackgroundSubstraction.Text = "Фон не вычтен";
            }
            else
            {
                BackgroundSubstraction.Checked = true;
                BackgroundSubstraction.Image = Properties.Resources.SubReport_16x;
                BackgroundSubstraction.Text = "Фон вычтен";
            }
            ChooseWithOrWithoutBackground();
        }

        private void OpenSpectrMenuButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "АТОМТЕХ Спектр (*.ats)|*.ats";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Text = "Bremsstrahlung - " + openFileDialog.SafeFileName;
                    Spectr.FileName = openFileDialog.FileName;
                    OpenFileProcedure();
                }
            }
        }

        private void XAxisZoomingMenuItem_Click(object sender, EventArgs e)
        {
            XYDiagram GammaSpectrDiagram = (XYDiagram)GammaSpectrChart.Diagram;
            if (XAxisZoomingMenuItem.Checked == true)
            {
                XAxisZoomingMenuItem.Checked = false;
                GammaSpectrDiagram.EnableAxisXZooming = false;
                XAxisZoomingMenuItem.Image = bremsstrahlung.Properties.Resources.Zoom_16x;
            }
            else
            {
                XAxisZoomingMenuItem.Checked = true;
                GammaSpectrDiagram.EnableAxisXZooming = true;
                XAxisZoomingMenuItem.Image = bremsstrahlung.Properties.Resources.ZoomIn_16x;
            }
        }

        private void YAxisZoomingMenuItem_Click(object sender, EventArgs e)
        {
            XYDiagram GammaSpectrDiagram = (XYDiagram)GammaSpectrChart.Diagram;
            if (YAxisZoomingMenuItem.Checked == true)
            {
                YAxisZoomingMenuItem.Checked = false;
                GammaSpectrDiagram.EnableAxisYZooming = false;
                YAxisZoomingMenuItem.Image = bremsstrahlung.Properties.Resources.Zoom_16x;
            }
            else
            {
                YAxisZoomingMenuItem.Checked = true;
                GammaSpectrDiagram.EnableAxisYZooming = true;
                YAxisZoomingMenuItem.Image = bremsstrahlung.Properties.Resources.ZoomIn_16x;
            }
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
            if (!GammaSpectrChart.IsPrintingAvailable)
            {
                MessageBox.Show("Библиотека \"DevExpress.XtraPrinting.v7.2.dll\" не обнаружена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GammaSpectrChart.Print();
        }

        private void PrintPreviewMenuItem_Click(object sender, EventArgs e)
        {
            if (!GammaSpectrChart.IsPrintingAvailable)
            {
                MessageBox.Show("Библиотека \"DevExpress.XtraPrinting.v7.2.dll\" не обнаружена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GammaSpectrChart.ShowPrintPreview();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationEfficiencySettingsMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationEfficiencySettings registrationEfficiencySettings = new RegistrationEfficiencySettings();
            registrationEfficiencySettings.Owner = this;
            registrationEfficiencySettings.Show();
        }
    }
}
