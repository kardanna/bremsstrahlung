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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace bremsstrahlung
{
    public partial class BackgroundSettings : Form
    {
        public BackgroundSettings()
        {
            InitializeComponent();
            BackgroundChart.Height = this.ClientSize.Height - 47;
            BackgroundChart.Width = this.ClientSize.Width - 20;
            ShowBackground();
        }

        public class BackgroundFile
        {
            public string[] FileLines { get; set; }
            public int Time { get; set; }
            public int Geometry { get; set; }
            public int GammaSpectrStartPosition { get; set; }
            public int EnergyStartPosition { get; set; }
            public double[] GammaSpectr = new double[1024];
            public double[] Energy = new double[1024];
        }

        BackgroundFile Background = new BackgroundFile();

        void ClearChart()
        {
            BackgroundChart.Series["Фон"].Points.Clear();
            BackgroundChart.Series["Энергия"].Points.Clear();
        }

        void ShowBackground()
        {
            ClearChart();
            switch (GeometryComboBox.Text)
            {
                case "Сосуд 0.5 л":
                    Background.Geometry = 0;
                    break;
                case "Сосуд 0.1 л":
                    Background.Geometry = 1;
                    break;
                case "Точечная":
                    Background.Geometry = 2;
                    break;
            }
            Background.FileLines = System.IO.File.ReadAllLines(Properties.BackgroundSettings.Default.Geometries[Background.Geometry]);
            for (int counterI = 0; counterI < Background.FileLines.Length; counterI++)
            {
                if (Background.FileLines[counterI].Substring(0, 4) == "TIME") Background.Time = int.Parse(Background.FileLines[counterI].Substring(7));
                if (Background.FileLines[counterI].Substring(0, 6) == "SPECTR") Background.GammaSpectrStartPosition = counterI + 1;
                if (Background.FileLines[counterI].Length > 12 && Background.FileLines[counterI].Substring(0, 12) == "ECALIBRATION") Background.EnergyStartPosition = counterI + 1;
            }
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                Background.GammaSpectr[counterI] = double.Parse(Background.FileLines[counterI + Background.GammaSpectrStartPosition].Replace('.', ','));
                Background.Energy[counterI] = double.Parse(Background.FileLines[counterI + Background.EnergyStartPosition].Replace('.', ','));
                BackgroundChart.Series["Фон"].Points.Add(new SeriesPoint(counterI + 1, Background.GammaSpectr[counterI]));
                BackgroundChart.Series["Энергия"].Points.Add(new SeriesPoint(counterI + 1, Math.Round(Background.Energy[counterI],1)));
            }
            ExposureTimeLabel.Text = Background.Time + " c";
        }

        private void GeometryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBackground();
        }

        private void BackgroundSettings_SizeChanged(object sender, EventArgs e)
        {
            BackgroundChart.Height = this.ClientSize.Height - 47;
            BackgroundChart.Width = this.ClientSize.Width - 20;
        }
    }
}
