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
using MathNet.Numerics;

namespace bremsstrahlung
{
    public partial class SpectrometryHandler : Form
    {
        public SpectrometryHandler()
        {
            InitializeComponent();
        }
        
        public void ClearAllSeries()
        {
            Form1 mainForm = this.Owner as Form1;
            XYDiagram GammaSpectrDiagram = (XYDiagram)mainForm.GammaSpectrChart.Diagram;
            mainForm.GammaSpectrChart.Series["Пр1"].Points.Clear();
            mainForm.GammaSpectrChart.Series["Пр2"].Points.Clear();
            mainForm.GammaSpectrChart.Series["baseline"].Points.Clear();
            mainForm.GammaSpectrChart.Series["edges"].Points.Clear();
            mainForm.GammaSpectrChart.Series["edges2"].Points.Clear();
            GammaSpectrDiagram.AxisX.ConstantLines.Clear();
            dataGridView1.Rows.Clear();
        }

        private void StartHanler_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;
            XYDiagram GammaSpectrDiagram = (XYDiagram)mainForm.GammaSpectrChart.Diagram;

            //Очистка графика
            ClearAllSeries();

            int SmoothingWindowWidth = 1,
                FirstDerivativeWindowWidth = 1,
                SecondDerivativeWindowWidth = 1,
                SmoothingPolynomialType = 1,
                FirstDerivativePolynomialType = 1,
                SecondDerivativePolynomialType = 1;
            double SmoothingNormalisation = 1,
                    FirstDerivativeNormalisation = 1,
                    SecondDerivativeNormalisation = 1;
            double[,] SavitzkyGolaySmoothing = new double[,] {          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -3, 12, 17, 12, -3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, 0, 0, 0, 0, -2, 3, 6, 7, 6, 3, -2, 0 , 0, 0, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, 0, 0, 0, -21, 14, 39, 54, 59, 54, 39, 14, -21, 0, 0, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, -30, 75, 131, 75, -30, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, 0, 0, 0, 15, -55, 30, 135, 179, 135, 30, -55, 15, 0, 0, 0, 0, 0, 0, 0, 0 },
                                                                /**/    { 0, 0, 0, 0, 0, 0, 0, -36, 9, 44, 69, 84, 89, 84, 67, 44, 9, -36, 0, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, 0, -11, 0, 9, 16, 21, 24, 25, 24, 21, 16, 9 , 0, -11, 0, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, 0, -78, -13, 42, 87, 122, 147, 162, 167, 162, 147, 122, 87, 42, -13, -78, 0, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, 0, -21, -6, 7, 18, 27, 32, 39, 42, 43, 42, 39, 34, 27, 18, 7, -6, -21, 0, 0, 0, 0 },
                                                                        { 0, 0, 0, -136, -51, 24, 89, 144, 189, 224, 249, 264, 269, 264, 249, 224, 189, 144, 89, 24, -51, -136, 0, 0, 0 },
                                                                        { 0, 0, -171, -76, 9, 84, 149, 204, 249, 284, 309, 324, 329, 324, 309, 284, 249, 204, 149, 84, 9, -76, -171, 0, 0 },
                                                                        { 0, -42, -21, -2, 15, 30, 43, 54, 63, 70, 75, 78, 79, 78, 75, 70, 63, 54, 43, 30, 15, -2, -21, -42, 0 },
                                                                        { -253, -138, -33, 62, 147, 222, 287, 343, 387, 422, 447, 462, 467, 462, 447, 422, 387, 343, 287, 222, 147, 62, -33, -138, -253 }};
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
            if (radioButton19.Checked == true) { SmoothingWindowWidth = 11; SmoothingNormalisation = 429; SmoothingPolynomialType = 5; }
            if (radioButton20.Checked == true) { SmoothingWindowWidth = 13; SmoothingNormalisation = 143; SmoothingPolynomialType = 6; }
            if (radioButton21.Checked == true) { SmoothingWindowWidth = 15; SmoothingNormalisation = 1105; SmoothingPolynomialType = 7; }
            if (radioButton22.Checked == true) { SmoothingWindowWidth = 17; SmoothingNormalisation = 323; SmoothingPolynomialType = 8; }
            if (radioButton23.Checked == true) { SmoothingWindowWidth = 19; SmoothingNormalisation = 2261; SmoothingPolynomialType = 9; }
            if (radioButton24.Checked == true) { SmoothingWindowWidth = 21; SmoothingNormalisation = 3059; SmoothingPolynomialType = 10; }
            if (radioButton25.Checked == true) { SmoothingWindowWidth = 23; SmoothingNormalisation = 805; SmoothingPolynomialType = 11; }
            if (radioButton26.Checked == true) { SmoothingWindowWidth = 25; SmoothingNormalisation = 5175; SmoothingPolynomialType = 12; }

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
            double[] SavitzkyGolaySmoothingBaseline = new double[1024];
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
                    SavitzkyGolaySmoothingSeries[counterI] += (mainForm.WorkingSpectr.GammaSpectr[counterJ] * SavitzkyGolaySmoothing[SmoothingPolynomialType, 12 + counterJ - counterI]) / SmoothingNormalisation;
                }
            }

            if (radioButton39.Checked == true) { SmoothingWindowWidth = 5; SmoothingNormalisation = 35; SmoothingPolynomialType = 0; }
            if (radioButton38.Checked == true) { SmoothingWindowWidth = 7; SmoothingNormalisation = 21; SmoothingPolynomialType = 1; }
            if (radioButton37.Checked == true) { SmoothingWindowWidth = 9; SmoothingNormalisation = 231; SmoothingPolynomialType = 2; }
            if (radioButton36.Checked == true) { SmoothingWindowWidth = 7; SmoothingNormalisation = 231; SmoothingPolynomialType = 3; }
            if (radioButton35.Checked == true) { SmoothingWindowWidth = 9; SmoothingNormalisation = 429; SmoothingPolynomialType = 4; }
            if (radioButton34.Checked == true) { SmoothingWindowWidth = 11; SmoothingNormalisation = 429; SmoothingPolynomialType = 5; }
            if (radioButton33.Checked == true) { SmoothingWindowWidth = 13; SmoothingNormalisation = 143; SmoothingPolynomialType = 6; }
            if (radioButton32.Checked == true) { SmoothingWindowWidth = 15; SmoothingNormalisation = 1105; SmoothingPolynomialType = 7; }
            if (radioButton31.Checked == true) { SmoothingWindowWidth = 17; SmoothingNormalisation = 323; SmoothingPolynomialType = 8; }
            if (radioButton30.Checked == true) { SmoothingWindowWidth = 19; SmoothingNormalisation = 2261; SmoothingPolynomialType = 9; }
            if (radioButton29.Checked == true) { SmoothingWindowWidth = 21; SmoothingNormalisation = 3059; SmoothingPolynomialType = 10; }
            if (radioButton28.Checked == true) { SmoothingWindowWidth = 23; SmoothingNormalisation = 805; SmoothingPolynomialType = 11; }
            if (radioButton27.Checked == true) { SmoothingWindowWidth = 25; SmoothingNormalisation = 5175; SmoothingPolynomialType = 12; }

            for (int counterI = 0; counterI < (SmoothingWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySmoothingBaseline[counterI] = mainForm.WorkingSpectr.GammaSpectr[counterI];
                SavitzkyGolaySmoothingBaseline[counterI + 1024 - (SmoothingWindowWidth - 1) / 2] = mainForm.WorkingSpectr.GammaSpectr[counterI + 1024 - (SmoothingWindowWidth - 1) / 2];
            }
            for (int counterI = (SmoothingWindowWidth - 1) / 2; counterI < 1024 - (SmoothingWindowWidth - 1) / 2; counterI++)
            {
                SavitzkyGolaySmoothingBaseline[counterI] = 0;
                for (int counterJ = counterI - (SmoothingWindowWidth - 1) / 2; counterJ <= counterI + (SmoothingWindowWidth - 1) / 2; counterJ++)
                {
                    SavitzkyGolaySmoothingBaseline[counterI] += (mainForm.WorkingSpectr.GammaSpectr[counterJ] * SavitzkyGolaySmoothing[SmoothingPolynomialType, 12 + counterJ - counterI]) / SmoothingNormalisation;
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
            //Номер обрабатываемого пика
            int Peak = 1;            

            //Массивы для поиска границ пиков
            int[] EdgesNumbers = new int[1024];
            EdgesNumbers[0] = 0;
            int NumberOfEdges = 1;

            //Цикл поиска пиков. Верхняя граница ограничена значением 1,5*ПШПВ из-за возможности
            //выхода за границу массива при нахождении RWC. ПОИСК ПИКОВ ВОСЛЕ 950 КАНАЛА НЕ ПРОИЗВОДИТСЯ
            for (int counterI = 2; counterI < 950; counterI++)
            {
                //Проверка смены знака производной в районе 6 каналов и наличия необходимого
                //числа счетов в канале, большего чем нижний порог обнаружения 
                if (SavitzkyGolayFirstDerivativeSeries[counterI - 2] > 0 && SavitzkyGolayFirstDerivativeSeries[counterI - 1] > 0 && SavitzkyGolayFirstDerivativeSeries[counterI] > 0 &&
                    SavitzkyGolayFirstDerivativeSeries[counterI + 1] < 0 && SavitzkyGolayFirstDerivativeSeries[counterI + 2] < 0 && SavitzkyGolayFirstDerivativeSeries[counterI + 3] < 0 &&
                    SourceData[counterI] > double.Parse(LowerDetectionThresholdTextBox.Text))
                {
                    //Получение полной ширины на полувысоте из калибровки спектра
                    //В случае необходимости полученное значение увеличивается до нечетного
                    int Range = (int)Math.Round(mainForm.WorkingSpectr.Resolution[counterI] + mainForm.WorkingSpectr.Resolution[counterI]);
                    if (Range % 2 == 0) Range++;

                    //Объявление массивов RWC и его ошибки. Вычисление RWC для двух точек
                    //претендующих на вершину пика
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

                    //Объявление и инициализация логических переменных
                    //проверяющих соответсвие претендующих каналов заданным статистическим критериям истинного пика
                    bool LeftPeakIsTrue = RWC[counterI] / Math.Sqrt(SD[counterI]) > RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) && RWC[counterI] / Math.Sqrt(SD[counterI]) > double.Parse(Sensetivity.Text.Replace('.', ','));
                    bool RightPeakIsTrue = RWC[counterI] / Math.Sqrt(SD[counterI]) < RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) && RWC[counterI + 1] / Math.Sqrt(SD[counterI + 1]) > double.Parse(Sensetivity.Text.Replace('.', ','));

                    //Выбор истинного пика
                    if (LeftPeakIsTrue)
                    {
                        Peak = counterI;
                    }
                    if (RightPeakIsTrue)
                    {
                        Peak = counterI + 1;
                    }

                    //В случае, если пик является истинным, фиксируется и определяются его границы.
                    if (LeftPeakIsTrue || RightPeakIsTrue)
                    {
                        //Добавление линии на график
                        ConstantLine constantLine = new ConstantLine(Math.Round(mainForm.WorkingSpectr.Energy[Peak], 1).ToString() + " кэВ");
                        GammaSpectrDiagram.AxisX.ConstantLines.Add(constantLine);
                        constantLine.AxisValue = Peak + 1;
                        constantLine.Title.Alignment = ConstantLineTitleAlignment.Far;

                        //Добавление строки в сводную таблицу
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[1].Value = Math.Round(mainForm.WorkingSpectr.Energy[Peak], 1);
                        row.Cells[2].Value = Peak + 1;
                        dataGridView1.Rows.Add(row);

                        //Определение левой границы пика как точки в которой производная сменяет знак 
                        for (int counterJ = Peak; SavitzkyGolayFirstDerivativeSeries[counterJ] * SavitzkyGolayFirstDerivativeSeries[counterJ - 1] > 0 && counterJ > 1; counterJ--)
                        {
                            if (SavitzkyGolayFirstDerivativeSeries[counterJ - 1] * SavitzkyGolayFirstDerivativeSeries[counterJ - 2] < 0)
                            {
                                //Проверка не идет ли один пик сразу за другим и их границы соприкасаются. 
                                //Если соприкасаются, правая граница первого пика отодвигается на один канал назад
                                if (EdgesNumbers[NumberOfEdges - 1] != counterJ - 2)
                                {
                                    mainForm.GammaSpectrChart.Series["edges2"].Points.Add(new SeriesPoint(counterJ, mainForm.WorkingSpectr.GammaSpectr[counterJ - 1]));
                                    EdgesNumbers[NumberOfEdges] = counterJ - 1;
                                    NumberOfEdges++;
                                }
                                else
                                {
                                    mainForm.GammaSpectrChart.Series["edges2"].Points.Add(new SeriesPoint(counterJ, mainForm.WorkingSpectr.GammaSpectr[counterJ - 1]));
                                    EdgesNumbers[NumberOfEdges] = counterJ - 1;
                                    EdgesNumbers[NumberOfEdges - 1] = counterJ - 3;
                                    NumberOfEdges++;
                                }
                            }
                        }

                        //Определение правой границы пика как точки в которой производная сменяет знак 
                        for (int counterJ = Peak + 1; SavitzkyGolayFirstDerivativeSeries[counterJ] * SavitzkyGolayFirstDerivativeSeries[counterJ + 1] > 0 && counterJ < 1022; counterJ++)
                        {
                            if (SavitzkyGolayFirstDerivativeSeries[counterJ + 1] * SavitzkyGolayFirstDerivativeSeries[counterJ + 2] < 0)
                            {
                                mainForm.GammaSpectrChart.Series["edges"].Points.Add(new SeriesPoint(counterJ + 2, mainForm.WorkingSpectr.GammaSpectr[counterJ + 1]));
                                EdgesNumbers[NumberOfEdges] = counterJ + 1;
                                NumberOfEdges++;
                            }
                        }                        
                    }                    
                }
            }

            //Добавление крайней правой границы спектра
            EdgesNumbers[NumberOfEdges] = 1023;
            NumberOfEdges++;

            //Массив флагов, где -1 - континуум, +1 - пик
            int[] PeaksFlags = new int[1024];

            //Если число границ четное, значит программа определила, что
            //спектр начинается с континуума, с пика. Установление флагов в соотвествии 
            //с границами пиков
            if (NumberOfEdges % 2 == 0)
            {
                int Flag = -1;
                for (int counterI = 0; counterI < NumberOfEdges - 1; counterI++)
                {                    
                    for (int counterJ = EdgesNumbers[counterI]; counterJ <= EdgesNumbers[counterI + 1]; counterJ++)
                    {
                        PeaksFlags[counterJ] = Flag;
                    }
                    if (EdgesNumbers[counterI] != 0 && Flag == -1) PeaksFlags[EdgesNumbers[counterI]] = 1;
                    Flag *= -1;
                }
            }
            else
            {
                int Flag = 1;
                for (int counterI = 0; counterI < NumberOfEdges - 1; counterI++)
                {
                    for (int counterJ = EdgesNumbers[counterI]; counterJ <= EdgesNumbers[counterI + 1]; counterJ++)
                    {
                        PeaksFlags[counterJ] = Flag;
                    }
                    if (EdgesNumbers[counterI] != 0 && Flag == -1) PeaksFlags[EdgesNumbers[counterI]] = 1;
                    Flag *= -1;
                }
            }


            //Вычисление базовой линии
            double[] Baseline = new double[1024];
            if (checkBox1.Checked)
            {
                //BAD QUINTANA
                //НЕСООТВЕТСВТУЮТ ГРАНИЦЫ ПИКОВ И ЧИСЛО ИМПУЛЬСОВ В НИХ: СТОЯТ ЗАЧЕНИЯ НА ОДИН КАНАЛ ПОСЛЕ                
                double[] cX = new double[NumberOfEdges];
                double[] cY = new double[NumberOfEdges];
                for (int i = 0; i < NumberOfEdges; i++)
                {
                    cX[i] = EdgesNumbers[i];
                    cY[i] = mainForm.WorkingSpectr.GammaSpectr[(int)cX[i]];
                }

                int finish = 0;
                while (finish != 1)
                {
                    finish = 1;
                    mainForm.GammaSpectrChart.Series["baseline"].Points.Clear();
                    for (int i = 0; i < 1024; i++)
                    {
                        Baseline[i] = Interpolate.CubicSplineRobust(cX, cY).Interpolate(i);
                    }                    
                    for (int i = 0; i < NumberOfEdges - 1; i++)
                    {
                        double  R = 0,
                                S = 0;
                        if (PeaksFlags[(int)cX[i] + 1] == 1) continue;
                        for (int j = (int)cX[i] + 1; j < (int)cX[i + 1]; j++)
                        {
                            R += Math.Abs((mainForm.WorkingSpectr.GammaSpectr[j - 1] - Baseline[j - 1]) / Math.Sqrt(Math.Abs(mainForm.WorkingSpectr.GammaSpectr[j - 1])) *
                                (mainForm.WorkingSpectr.GammaSpectr[j] - Baseline[j]) / Math.Sqrt(Math.Abs(mainForm.WorkingSpectr.GammaSpectr[j])));
                            S += Math.Pow(mainForm.WorkingSpectr.GammaSpectr[j] - Baseline[j], 2);
                        }
                        if ((cX[i + 1] - cX[i]) * R / S > double.Parse(textBox1.Text.Replace('.', ',')))
                        {
                            
                            List<double> lst = cX.OfType<double>().ToList();
                            lst.Insert(i + 1, Math.Round((cX[i + 1] + cX[i]) / 2));
                            Array.Resize(ref cX, cX.Length + 1);
                            cX = lst.ToArray();
                            List<double> lst2 = cY.OfType<double>().ToList();
                            lst2.Insert(i + 1, mainForm.WorkingSpectr.GammaSpectr[(int)Math.Round((cX[i + 1] + cX[i]) / 2)]);
                            Array.Resize(ref cY, cY.Length + 1);
                            cY = lst2.ToArray();
                            NumberOfEdges++;
                            finish = 0;
                        }
                    }
                }
                for (int counterI = 0; counterI < 1024; counterI++)
                {
                    if (PeaksFlags[counterI] == 1)
                    {
                        Baseline[counterI] = Interpolate.CubicSplineRobust(cX, cY).Interpolate(counterI);
                    }
                    else
                    {
                        Baseline[counterI] = mainForm.WorkingSpectr.GammaSpectr[counterI];
                    }
                    mainForm.GammaSpectrChart.Series["baseline"].Points.Add(new SeriesPoint(counterI + 1, Baseline[counterI]));
                }
            }
            else
            {     
                //ВЫШЛО ЛУЧШЕ
                double[] ContinuumX = new double[1024];
                double[] ContinuumY = new double[1024];
                double[] PeaksX = new double[1024];
                double[] PeaksY = new double[1024];
                int ContinuumCounter = 0,
                    PeaksCounter = 0;
                PeaksFlags[0] = -1;
                for (int counterI = 0; counterI < 1024; counterI++)
                {
                    if (PeaksFlags[counterI] == -1)
                    {
                        ContinuumX[ContinuumCounter] = counterI;
                        ContinuumY[ContinuumCounter] = SavitzkyGolaySmoothingBaseline[counterI];
                        ContinuumCounter++;
                    }
                else
                    {
                        PeaksX[PeaksCounter] = counterI;
                        PeaksY[PeaksCounter] = mainForm.WorkingSpectr.GammaSpectr[counterI];
                        PeaksCounter++;
                    }
                }                
                double[] cX = new double[ContinuumCounter];
                double[] cY = new double[ContinuumCounter];
                for (int i = 0; i < ContinuumCounter; i++)
                {
                    cX[i] = ContinuumX[i];
                    cY[i] = ContinuumY[i];
                }

                for (int counterI = 0; counterI < 1024; counterI++)
                {
                    if (PeaksFlags[counterI] == 1)
                    {
                        Baseline[counterI] = Interpolate.CubicSplineRobust(cX, cY).Interpolate(counterI);
                    }
                    else
                    {
                        Baseline[counterI] = mainForm.WorkingSpectr.GammaSpectr[counterI];
                    }
                    mainForm.GammaSpectrChart.Series["baseline"].Points.Add(new SeriesPoint(counterI + 1, Baseline[counterI]));
                }                
            }
            
            //Отрисовка сглаженного спектра, певой и второй производной
            mainForm.DrawFromHandlerProcedure(SavitzkyGolaySmoothingSeries);
        }
    }
}
