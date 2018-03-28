namespace bremsstrahlung
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.RangeControlRange rangeControlRange2 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series11 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series12 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView8 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series13 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView9 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series14 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView3 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series15 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView4 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series16 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView10 = new DevExpress.XtraCharts.LineSeriesView();
            this.GammaSpectrRangeControl = new DevExpress.XtraEditors.RangeControl();
            this.GammaSpectrChart = new DevExpress.XtraCharts.ChartControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спектрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenSpectrMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpectrometryHandlerMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSubstraction = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSettingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationEfficiencySettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XAxisZoomingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YAxisZoomingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrRangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GammaSpectrRangeControl
            // 
            this.GammaSpectrRangeControl.Client = this.GammaSpectrChart;
            this.GammaSpectrRangeControl.Location = new System.Drawing.Point(10, 503);
            this.GammaSpectrRangeControl.Name = "GammaSpectrRangeControl";
            rangeControlRange2.Maximum = 1024.6D;
            rangeControlRange2.Minimum = 0.4D;
            rangeControlRange2.Owner = this.GammaSpectrRangeControl;
            this.GammaSpectrRangeControl.SelectedRange = rangeControlRange2;
            this.GammaSpectrRangeControl.Size = new System.Drawing.Size(826, 90);
            this.GammaSpectrRangeControl.TabIndex = 1;
            this.GammaSpectrRangeControl.Text = "rangeControl1";
            // 
            // GammaSpectrChart
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.VisualRange.Auto = false;
            xyDiagram2.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "1024";
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "1";
            xyDiagram2.AxisX.VisualRange.SideMarginsValue = 0.6D;
            xyDiagram2.AxisX.WholeRange.Auto = false;
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram2.AxisX.WholeRange.MaxValueSerializable = "1024";
            xyDiagram2.AxisX.WholeRange.MinValueSerializable = "1";
            xyDiagram2.AxisX.WholeRange.SideMarginsValue = 0.6D;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.EnableAxisXZooming = true;
            xyDiagram2.RangeControlNumericGridOptions.GridMode = DevExpress.XtraCharts.ChartRangeControlClientGridMode.Manual;
            xyDiagram2.RangeControlNumericGridOptions.GridSpacing = 100D;
            xyDiagram2.RangeControlNumericGridOptions.SnapMode = DevExpress.XtraCharts.ChartRangeControlClientSnapMode.Manual;
            secondaryAxisY2.AxisID = 0;
            secondaryAxisY2.Name = "Вторичная ось Y1";
            secondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.False;
            secondaryAxisY2.VisibleInPanesSerializable = "-1";
            xyDiagram2.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY2});
            this.GammaSpectrChart.Diagram = xyDiagram2;
            this.GammaSpectrChart.Legend.Name = "Default Legend";
            this.GammaSpectrChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.GammaSpectrChart.Location = new System.Drawing.Point(11, 33);
            this.GammaSpectrChart.Name = "GammaSpectrChart";
            this.GammaSpectrChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
            series9.Name = "Спектр";
            lineSeriesView6.LineStyle.Thickness = 1;
            lineSeriesView6.RangeControlOptions.ViewType = DevExpress.XtraCharts.RangeControlViewType.Area;
            series9.View = lineSeriesView6;
            series10.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series10.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series10.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series10.Name = "Энергия";
            lineSeriesView7.AxisYName = "Вторичная ось Y1";
            lineSeriesView7.Color = System.Drawing.Color.Transparent;
            lineSeriesView7.LineMarkerOptions.Color = System.Drawing.Color.Transparent;
            lineSeriesView7.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            lineSeriesView7.RangeControlOptions.Visible = false;
            series10.View = lineSeriesView7;
            series11.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series11.Name = "Сглаживание";
            splineSeriesView2.Color = System.Drawing.Color.Crimson;
            splineSeriesView2.LineStyle.Thickness = 1;
            splineSeriesView2.RangeControlOptions.Visible = false;
            series11.View = splineSeriesView2;
            series12.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series12.Name = "Пр1";
            series12.View = lineSeriesView8;
            series12.Visible = false;
            series13.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series13.Name = "Пр2";
            series13.View = lineSeriesView9;
            series13.Visible = false;
            series14.Name = "edges";
            series14.View = pointSeriesView3;
            series14.Visible = false;
            series15.Name = "edges2";
            series15.View = pointSeriesView4;
            series15.Visible = false;
            series16.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series16.Name = "baseline";
            lineSeriesView10.LineStyle.Thickness = 1;
            series16.View = lineSeriesView10;
            this.GammaSpectrChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9,
        series10,
        series11,
        series12,
        series13,
        series14,
        series15,
        series16};
            this.GammaSpectrChart.Size = new System.Drawing.Size(826, 463);
            this.GammaSpectrChart.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спектрToolStripMenuItem,
            this.обработкаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спектрToolStripMenuItem
            // 
            this.спектрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSpectrMenuButton,
            this.toolStripSeparator2,
            this.PrintMenuItem,
            this.PrintPreviewMenuItem,
            this.toolStripSeparator3,
            this.CloseMenuItem});
            this.спектрToolStripMenuItem.Name = "спектрToolStripMenuItem";
            this.спектрToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.спектрToolStripMenuItem.Text = "Файл";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpectrometryHandlerMenuButton,
            this.BackgroundSubstraction});
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroundSettingsMenuButton,
            this.RegistrationEfficiencySettingsMenuItem,
            this.toolStripSeparator1,
            this.XAxisZoomingMenuItem,
            this.YAxisZoomingMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // OpenSpectrMenuButton
            // 
            this.OpenSpectrMenuButton.Image = global::bremsstrahlung.Properties.Resources.OpenFolder_16x;
            this.OpenSpectrMenuButton.Name = "OpenSpectrMenuButton";
            this.OpenSpectrMenuButton.Size = new System.Drawing.Size(198, 22);
            this.OpenSpectrMenuButton.Text = "Открыть...";
            this.OpenSpectrMenuButton.Click += new System.EventHandler(this.OpenSpectrMenuButton_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Image = global::bremsstrahlung.Properties.Resources.Print_16x;
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.Size = new System.Drawing.Size(198, 22);
            this.PrintMenuItem.Text = "Печать";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // PrintPreviewMenuItem
            // 
            this.PrintPreviewMenuItem.Image = global::bremsstrahlung.Properties.Resources.PrintPreview_16x;
            this.PrintPreviewMenuItem.Name = "PrintPreviewMenuItem";
            this.PrintPreviewMenuItem.Size = new System.Drawing.Size(198, 22);
            this.PrintPreviewMenuItem.Text = "Предпросмотр печати";
            this.PrintPreviewMenuItem.Click += new System.EventHandler(this.PrintPreviewMenuItem_Click);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Image = global::bremsstrahlung.Properties.Resources.CloseSolution_16x;
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(198, 22);
            this.CloseMenuItem.Text = "Выход";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // SpectrometryHandlerMenuButton
            // 
            this.SpectrometryHandlerMenuButton.Image = global::bremsstrahlung.Properties.Resources.GenericChart_16x;
            this.SpectrometryHandlerMenuButton.Name = "SpectrometryHandlerMenuButton";
            this.SpectrometryHandlerMenuButton.Size = new System.Drawing.Size(252, 22);
            this.SpectrometryHandlerMenuButton.Text = "Спектрометрическая обработка";
            this.SpectrometryHandlerMenuButton.Click += new System.EventHandler(this.SpectrometryHandlerMenuButton_Click);
            // 
            // BackgroundSubstraction
            // 
            this.BackgroundSubstraction.Checked = true;
            this.BackgroundSubstraction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackgroundSubstraction.Image = global::bremsstrahlung.Properties.Resources.SubReport_16x;
            this.BackgroundSubstraction.Name = "BackgroundSubstraction";
            this.BackgroundSubstraction.Size = new System.Drawing.Size(252, 22);
            this.BackgroundSubstraction.Text = "Фон вычтен";
            this.BackgroundSubstraction.Click += new System.EventHandler(this.BackgroundSunstraction_Click);
            // 
            // BackgroundSettingsMenuButton
            // 
            this.BackgroundSettingsMenuButton.Image = global::bremsstrahlung.Properties.Resources.SettingsFile_16x;
            this.BackgroundSettingsMenuButton.Name = "BackgroundSettingsMenuButton";
            this.BackgroundSettingsMenuButton.Size = new System.Drawing.Size(233, 22);
            this.BackgroundSettingsMenuButton.Text = "Фон";
            this.BackgroundSettingsMenuButton.Click += new System.EventHandler(this.BackgroundSettingsMenuButton_Click);
            // 
            // RegistrationEfficiencySettingsMenuItem
            // 
            this.RegistrationEfficiencySettingsMenuItem.Image = global::bremsstrahlung.Properties.Resources.AlphaTest_16x;
            this.RegistrationEfficiencySettingsMenuItem.Name = "RegistrationEfficiencySettingsMenuItem";
            this.RegistrationEfficiencySettingsMenuItem.Size = new System.Drawing.Size(233, 22);
            this.RegistrationEfficiencySettingsMenuItem.Text = "Эффективность регистрации";
            this.RegistrationEfficiencySettingsMenuItem.Click += new System.EventHandler(this.RegistrationEfficiencySettingsMenuItem_Click);
            // 
            // XAxisZoomingMenuItem
            // 
            this.XAxisZoomingMenuItem.Checked = true;
            this.XAxisZoomingMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XAxisZoomingMenuItem.Image = global::bremsstrahlung.Properties.Resources.ZoomIn_16x;
            this.XAxisZoomingMenuItem.Name = "XAxisZoomingMenuItem";
            this.XAxisZoomingMenuItem.Size = new System.Drawing.Size(233, 22);
            this.XAxisZoomingMenuItem.Text = "Масшабирование по оси X";
            this.XAxisZoomingMenuItem.Click += new System.EventHandler(this.XAxisZoomingMenuItem_Click);
            // 
            // YAxisZoomingMenuItem
            // 
            this.YAxisZoomingMenuItem.Image = global::bremsstrahlung.Properties.Resources.Zoom_16x;
            this.YAxisZoomingMenuItem.Name = "YAxisZoomingMenuItem";
            this.YAxisZoomingMenuItem.Size = new System.Drawing.Size(233, 22);
            this.YAxisZoomingMenuItem.Text = "Масшабирование по оси Y";
            this.YAxisZoomingMenuItem.Click += new System.EventHandler(this.YAxisZoomingMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 601);
            this.Controls.Add(this.GammaSpectrRangeControl);
            this.Controls.Add(this.GammaSpectrChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Bremsstrahlung";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrRangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.RangeControl GammaSpectrRangeControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спектрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSpectrMenuButton;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackgroundSettingsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SpectrometryHandlerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem BackgroundSubstraction;
        public DevExpress.XtraCharts.ChartControl GammaSpectrChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem XAxisZoomingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YAxisZoomingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PrintPreviewMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrationEfficiencySettingsMenuItem;
    }
}

