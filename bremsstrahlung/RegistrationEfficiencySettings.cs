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
    public partial class RegistrationEfficiencySettings : Form
    {
        public RegistrationEfficiencySettings()
        {
            InitializeComponent();
            SetRegistrationEfficiency();
            //Задание размеров и положений элементов окна
            RegistrationEfficiencyKnotsGrid.Height = this.ClientSize.Height - 47;
            RegistrationEfficiencyChart.Height = this.ClientSize.Height - 47;
            RegistrationEfficiencyChart.Width = this.ClientSize.Width - 246;
            //SpectrometryHandler SpectrHandler = this.Owner as SpectrometryHandler;
        }

        public class RegistrationEfficicency
        {
            public string[] FileLines { get; set; }
            public int GeometryIndex { get; set; }
            public int KnotsStartPosition { get; set; }
            public int PointsStartPosition { get; set; }
            public double[,] Knots = new double[1024, 2];
            public double[] Points = new double[1024];
            public string[] EnergyScaleFileLines { get; set; }
            public double[] EnergyScale = new double[1024];
        }

        RegistrationEfficicency RE = new RegistrationEfficicency();

        public void SetRegistrationEfficiency()
        {
            switch (GeometryComboBox.Text)
            {
                case "Сосуд 0.5 л":
                    RE.GeometryIndex = 0;
                    break;
                case "Сосуд 0.1 л":
                    RE.GeometryIndex = 1;
                    break;
                case "Точечная":
                    RE.GeometryIndex = 2;
                    break;                
            }
            RE.FileLines = System.IO.File.ReadAllLines(Properties.RegistrationEfficiency.Default.Geometries[RE.GeometryIndex]);
            RE.EnergyScaleFileLines = System.IO.File.ReadAllLines("RegistrationEfficiency//EnergyScale.txt");
            for (int counterI = 0; counterI < RE.FileLines.Length; counterI++)
            {
                if (RE.FileLines[counterI].Length >= 6 && RE.FileLines[counterI].Substring(0, 6) == "Points") RE.KnotsStartPosition = counterI + 1;
                if (RE.FileLines[counterI].Length >= 4 && RE.FileLines[counterI].Substring(0, 4) == "Line") RE.PointsStartPosition = counterI + 1;
            }
            for (int counterI = RE.KnotsStartPosition; counterI < RE.PointsStartPosition - 1; counterI++)
            {
                string[] temp = RE.FileLines[counterI].Split('	');
                RE.Knots[counterI, 0] = double.Parse(temp[0].Replace('.', ','));
                RE.Knots[counterI, 1] = double.Parse(temp[1].Replace('.', ','));
            }
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                RE.Points[counterI] = double.Parse(RE.FileLines[counterI + RE.PointsStartPosition].Replace('.', ','));
                RE.EnergyScale[counterI] = double.Parse(RE.EnergyScaleFileLines[counterI].Replace('.', ','));
            }
            DrawRegistrationEfficiencyChartAndGrid();
        }

        void DrawRegistrationEfficiencyChartAndGrid()
        {
            ClearRegistrationEfficiencyChart();
            for (int counterI = RE.KnotsStartPosition; counterI < RE.PointsStartPosition - 1; counterI++)
            {
                DataGridViewRow NewRow = (DataGridViewRow)RegistrationEfficiencyKnotsGrid.Rows[0].Clone();
                NewRow.Cells[0].Value = RE.Knots[counterI, 0];
                NewRow.Cells[1].Value = RE.Knots[counterI, 1];
                RegistrationEfficiencyKnotsGrid.Rows.Add(NewRow);
                //RegistrationEfficiencyChart.Series["Узлы"].Points.Add(new SeriesPoint(RE.Knots[counterI,0], RE.Knots[counterI,1]));
            }
            for (int counterI = 0; counterI < 1024; counterI++)
            {
                RegistrationEfficiencyChart.Series["Эффективность"].Points.Add(new SeriesPoint(counterI + 1, RE.Points[counterI]));
                RegistrationEfficiencyChart.Series["Энергия"].Points.Add(new SeriesPoint(counterI + 1, Math.Round(RE.EnergyScale[counterI],1)));                
            }
        }

        void ClearRegistrationEfficiencyChart()
        {
            RegistrationEfficiencyKnotsGrid.Rows.Clear();
            RegistrationEfficiencyChart.Series["Узлы"].Points.Clear();
            RegistrationEfficiencyChart.Series["Эффективность"].Points.Clear();
            RegistrationEfficiencyChart.Series["Энергия"].Points.Clear();

        }

        private void GeometryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRegistrationEfficiency();
        }

        private void ChangeRegistrationEfficiencyFileButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string GeometryName = "";
                    switch (GeometryComboBox.Text)
                    {
                        case "Сосуд 0.5 л":
                            GeometryName = "V05_Efficiency.txt";
                            break;
                        case "Сосуд 0.1 л":
                            GeometryName = "V01_Efficiency.txt";
                            break;
                        case "Точечная":
                            GeometryName = "P_Efficiency.txt";
                            break;
                    }
                    System.IO.File.Copy(openFileDialog.FileName, @"RegistrationEfficiency\\"+ GeometryName, true);
                    SetRegistrationEfficiency();
                }
            }
        }

        private void RegistrationEfficiencySettings_SizeChanged(object sender, EventArgs e)
        {
            RegistrationEfficiencyKnotsGrid.Height = this.ClientSize.Height - 47;
            RegistrationEfficiencyChart.Height = this.ClientSize.Height - 47;
            RegistrationEfficiencyChart.Width = this.ClientSize.Width - 246;
        }
    }
}
