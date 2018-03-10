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
    public partial class SpectrometryHandler : Form
    {
        public SpectrometryHandler()
        {
            InitializeComponent();
        }

        private void StartHanler_Click(object sender, EventArgs e)
        {

            Form1 mainForm = this.Owner as Form1;

            int SmoothingWindowWidth = 1,
                FirstDerivativeWindowWidth = 1,
                SecondDerivativeWindowWidth = 1,
                SmoothingPolynomialType = 1,
                FirstDerivativePolynomialType = 1,
                SecondDerivativePolynomialType = 1;
            double  SmoothingNormalisation = 1,
                    FirstDerivativeNormalisation = 1,
                    SecondDerivativeNormalisation = 1;
            double[,] SavitzkyGolaySmoothing = new double[,] {          { 0, 0, -3, 12, 17, 12, -3, 0, 0 },
                                                                        { 0, -2, 3, 6, 7, 6, 3, -2, 0 },
                                                                        { -21, 14, 39, 54, 59, 54, 39, 14, -21 },
                                                                        { 0, 5, -30, 75, 131, 75, -30, 5, 0 },
                                                                        { 15, -55, 30, 135, 179, 135, 30, -55, 15 } };
            double[,] SavitzkyGolayFirstDerivative = new double[,] {    { 0, 0, 0, -1, 0, 1, 0, 0, 0 },
                                                                        { 0, 0, -2, -1, 0, 1, 2, 0, 0 },
                                                                        { 0, -3, -2, -1, 0, 1, 2, 3, 0 },
                                                                        { -4, -3, -2, -1, 0, 1, 2, 3, 4 },
                                                                        { 0, 0, 1, -8, 0, 8, -1, 0, 0 },
                                                                        { 0, 22, -67, -58, 0, 58, 67, -22, 0 },
                                                                        { 86, -142, -193, -126, 0, 126, 193, 142, -86 } };
            double[,] SavitzkyGolaySecondDerivative = new double[,] {   { 0, 0, 2, -1, -2, -1, 2, 0, 0 },
                                                                        { 0, 5, 0, -3, -4, -3, 0, 5, 0 },
                                                                        { 28, 7, -8, -17, -20, -17, -8, 7, 28 },
                                                                        { 0, 0, -1, 16, -30, 16, -1, 0, 0 },
                                                                        { 0, -13, 67, -19, -70, -19, 67, -13, 0 },
                                                                        { -126, 371, 151, -211, -370, -211, 151, 371, -126 } };

            if (radioButton1.Checked == true) { SmoothingWindowWidth = 5; SmoothingNormalisation = 35; SmoothingPolynomialType = 0; }
            if (radioButton2.Checked == true) { SmoothingWindowWidth = 7; SmoothingNormalisation = 21; SmoothingPolynomialType = 1; }
            if (radioButton3.Checked == true) { SmoothingWindowWidth = 9; SmoothingNormalisation = 231; SmoothingPolynomialType = 2; }
            if (radioButton4.Checked == true) { SmoothingWindowWidth = 7; SmoothingNormalisation = 231; SmoothingPolynomialType = 3; }
            if (radioButton5.Checked == true) { SmoothingWindowWidth = 9; SmoothingNormalisation = 429; SmoothingPolynomialType = 4; }

            if (radioButton6.Checked == true) { FirstDerivativeWindowWidth = 3; FirstDerivativeNormalisation = 2; FirstDerivativePolynomialType = 0; }
            if (radioButton7.Checked == true) { FirstDerivativeWindowWidth = 5; FirstDerivativeNormalisation = 10; FirstDerivativePolynomialType = 1; }
            if (radioButton8.Checked == true) { FirstDerivativeWindowWidth = 7; FirstDerivativeNormalisation = 28; FirstDerivativePolynomialType = 2; }
            if (radioButton9.Checked == true) { FirstDerivativeWindowWidth = 9; FirstDerivativeNormalisation = 60; FirstDerivativePolynomialType = 3; }
            if (radioButton10.Checked == true) { FirstDerivativeWindowWidth = 5; FirstDerivativeNormalisation = 12; FirstDerivativePolynomialType = 4; }
            if (radioButton11.Checked == true) { FirstDerivativeWindowWidth = 7; FirstDerivativeNormalisation = 252; FirstDerivativePolynomialType = 5; }
            if (radioButton12.Checked == true) { FirstDerivativeWindowWidth = 9; FirstDerivativeNormalisation = 1188; FirstDerivativePolynomialType = 6; }

            if (radioButton13.Checked == true) { SecondDerivativeWindowWidth = 5; SecondDerivativeNormalisation = 7; SecondDerivativePolynomialType = 0; }
            if (radioButton14.Checked == true) { SecondDerivativeWindowWidth = 7; SecondDerivativeNormalisation = 42; SecondDerivativePolynomialType = 1; }
            if (radioButton15.Checked == true) { SecondDerivativeWindowWidth = 9; SecondDerivativeNormalisation = 462; SecondDerivativePolynomialType = 2; }
            if (radioButton16.Checked == true) { SecondDerivativeWindowWidth = 5; SecondDerivativeNormalisation = 12; SecondDerivativePolynomialType = 3; }
            if (radioButton17.Checked == true) { SecondDerivativeWindowWidth = 7; SecondDerivativeNormalisation = 132; SecondDerivativePolynomialType = 4; }
            if (radioButton18.Checked == true) { SecondDerivativeWindowWidth = 9; SecondDerivativeNormalisation = 1716; SecondDerivativePolynomialType = 5; }

            double[] SavitzkyGolaySmoothingSeries = new double[1024];
            double[] SavitzkyGolayFirstDerivativeSeries = new double[1024];
            double[] SavitzkyGolaySecondDerivativeSeries = new double[1024];
            double[] SourceData = new double[1024];
            double[] RWC = new double[1024];
            double[] SD = new double[1024];

            //Сглаживание
            for (int counterI = 0; counterI < (SmoothingWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySmoothingSeries[counterI] = mainForm.WorkingSpectr.GammaSpectr[counterI];
                SavitzkyGolaySmoothingSeries[counterI + 1024 - (SmoothingWindowWidth - 1) / 2] = mainForm.WorkingSpectr.GammaSpectr[counterI + 1024 - (SmoothingWindowWidth - 1) / 2];
            }
            for (int counterI = (SmoothingWindowWidth - 1) / 2; counterI < 1024 - (SmoothingWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySmoothingSeries[counterI] = 0;
                for (int counterJ = counterI - (SmoothingWindowWidth - 1) / 2; counterJ <= counterI + (SmoothingWindowWidth - 1) / 2; counterJ++)
                {
                    SavitzkyGolaySmoothingSeries[counterI] += (mainForm.WorkingSpectr.GammaSpectr[counterJ] * SavitzkyGolaySmoothing[SmoothingPolynomialType, 4 + counterJ - counterI]) / SmoothingNormalisation;
                }
            }
            
            //Использовать ли сглаженные данные для нахождения первой и второй производной
            if (UseSmoothedData.Checked == true)
            {
                SourceData = SavitzkyGolaySmoothingSeries;
            }
            else
            {
                SourceData = mainForm.WorkingSpectr.GammaSpectr;
            }

            //Первая производная
            for (int counterI = 0; counterI < (FirstDerivativeWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolayFirstDerivativeSeries[counterI] = SourceData[counterI];
                SavitzkyGolayFirstDerivativeSeries[counterI + 1024 - (FirstDerivativeWindowWidth - 1) / 2] = SourceData[counterI + 1024 - (FirstDerivativeWindowWidth - 1) / 2];
            }
            for (int counterI = (FirstDerivativeWindowWidth - 1) / 2; counterI < 1024 - (FirstDerivativeWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolayFirstDerivativeSeries[counterI] = 0;
                for (int counterJ = counterI - (FirstDerivativeWindowWidth - 1) / 2; counterJ <= counterI + (FirstDerivativeWindowWidth - 1) / 2; counterJ++)
                {
                    SavitzkyGolayFirstDerivativeSeries[counterI] += (SourceData[counterJ] * SavitzkyGolayFirstDerivative[FirstDerivativePolynomialType, 4 + counterJ - counterI]) / FirstDerivativeNormalisation;
                }
            }

            //Вторая производная
            for (int counterI = 0; counterI < (SecondDerivativeWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySecondDerivativeSeries[counterI] = SourceData[counterI];
                SavitzkyGolaySecondDerivativeSeries[counterI + 1024 - (SecondDerivativeWindowWidth - 1) / 2] = SourceData[counterI + 1024 - (SecondDerivativeWindowWidth - 1) / 2];
            }
            for (int counterI = (SecondDerivativeWindowWidth - 1) / 2; counterI < 1024 - (SecondDerivativeWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySecondDerivativeSeries[counterI] = 0;
                for (int counterJ = counterI - (SecondDerivativeWindowWidth - 1) / 2; counterJ <= counterI + (SecondDerivativeWindowWidth - 1) / 2; counterJ++)
                {
                    SavitzkyGolaySecondDerivativeSeries[counterI] += (SourceData[counterJ] * SavitzkyGolaySecondDerivative[SecondDerivativePolynomialType, 4 + counterJ - counterI]) / SecondDerivativeNormalisation;
                }
            }

            //Поиск пиков
            XYDiagram GammaSpectrDiagram = (XYDiagram)mainForm.GammaSpectrChart.Diagram;
            GammaSpectrDiagram.AxisX.ConstantLines.Clear();
            mainForm.GammaSpectrChart.Series["Пики"].Points.Clear();
            for (int counterI = 2; counterI < 950; counterI++)
            {
                if (SavitzkyGolayFirstDerivativeSeries[counterI - 2] > 0 && SavitzkyGolayFirstDerivativeSeries[counterI - 1] > 0 && SavitzkyGolayFirstDerivativeSeries[counterI] > 0 &&
                    SavitzkyGolayFirstDerivativeSeries[counterI + 1] < 0 && SavitzkyGolayFirstDerivativeSeries[counterI + 2] < 0 && SavitzkyGolayFirstDerivativeSeries[counterI + 3] < 0 &&
                    SourceData[counterI] > double.Parse(LowerDetectionThresholdTextBox.Text))
                {
                    int Range = (int)Math.Round(mainForm.WorkingSpectr.Resolution[counterI] + mainForm.WorkingSpectr.Resolution[counterI]);
                    if (Range % 2 == 0) Range++;
                    RWC[counterI] = 0;
                    SD[counterI] = 0;
                    for (int counterJ = counterI - Range; counterJ < counterI; counterJ++)
                    {
                        RWC[counterI] -= SourceData[counterJ];
                        SD[counterI] += SourceData[counterJ];
                    }
                    for (int counterJ = counterI; counterJ < counterI + Range; counterJ++)
                    {
                        RWC[counterI] += 2 * SourceData[counterJ];
                        SD[counterI] += 4 * SourceData[counterJ];
                    }
                    for (int counterJ = counterI + Range; counterJ < counterI + 2 * Range; counterJ++)
                    {
                        RWC[counterI] -= SourceData[counterJ];
                        SD[counterI] += SourceData[counterJ];
                    }
                    RWC[counterI + 1] = 0;
                    SD[counterI + 1] = 0;
                    for (int counterJ = counterI + 1 - Range; counterJ < counterI + 1; counterJ++)
                    {
                        RWC[counterI + 1] -= SourceData[counterJ];
                        SD[counterI + 1] += SourceData[counterJ];
                    }
                    for (int counterJ = counterI + 1; counterJ < counterI + 1 + Range; counterJ++)
                    {
                        RWC[counterI + 1] += 2 * SourceData[counterJ];
                        SD[counterI + 1] += 4 * SourceData[counterJ];
                    }
                    for (int counterJ = counterI + 1 + Range; counterJ < counterI + 1 + 2 * Range; counterJ++)
                    {
                        RWC[counterI + 1] -= SourceData[counterJ];
                        SD[counterI + 1] += SourceData[counterJ];
                    }
                    if (RWC[counterI]/Math.Sqrt(SD[counterI]) > RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) && RWC[counterI] / Math.Sqrt(SD[counterI]) > double.Parse(Sensetivity.Text.Replace('.',',')))
                    {
                        ConstantLine constantLine = new ConstantLine(Math.Round(mainForm.WorkingSpectr.Energy[counterI],1).ToString() + " кэВ");
                        GammaSpectrDiagram.AxisX.ConstantLines.Add(constantLine);
                        constantLine.AxisValue = counterI + 1;
                        constantLine.Title.Alignment = ConstantLineTitleAlignment.Far;

                    }
                    if (RWC[counterI] / Math.Sqrt(SD[counterI]) < RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) && RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) > double.Parse(Sensetivity.Text.Replace('.', ',')))
                    {
                        ConstantLine constantLine = new ConstantLine(Math.Round(mainForm.WorkingSpectr.Energy[counterI],1).ToString() + " кэВ");
                        GammaSpectrDiagram.AxisX.ConstantLines.Add(constantLine);
                        constantLine.AxisValue = counterI + 2;
                        constantLine.Title.Alignment = ConstantLineTitleAlignment.Far;
                    }
                }
            }

            //Отрисовка
            mainForm.DrawFromHandlerProcedure(SavitzkyGolaySmoothingSeries);
        }
    }
}
