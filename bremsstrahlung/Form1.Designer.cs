namespace bremsstrahlung
{
    partial class Form1
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
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            this.GammaSpectrRangeControl = new DevExpress.XtraEditors.RangeControl();
            this.GammaSpectrChart = new DevExpress.XtraCharts.ChartControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спектрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpectrometryHandlerMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSunstraction = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSpectrMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSettingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.XAxisZoomingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YAxisZoomingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrRangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GammaSpectrRangeControl
            // 
            this.GammaSpectrRangeControl.Client = this.GammaSpectrChart;
            this.GammaSpectrRangeControl.Location = new System.Drawing.Point(10, 503);
            this.GammaSpectrRangeControl.Name = "GammaSpectrRangeControl";
            rangeControlRange1.Maximum = 1024.6D;
            rangeControlRange1.Minimum = 0.4D;
            rangeControlRange1.Owner = this.GammaSpectrRangeControl;
            this.GammaSpectrRangeControl.SelectedRange = rangeControlRange1;
            this.GammaSpectrRangeControl.Size = new System.Drawing.Size(826, 90);
            this.GammaSpectrRangeControl.TabIndex = 1;
            this.GammaSpectrRangeControl.Text = "rangeControl1";
            // 
            // GammaSpectrChart
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "1024";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "1";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0.6D;
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "1024";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "1";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.6D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.RangeControlNumericGridOptions.GridMode = DevExpress.XtraCharts.ChartRangeControlClientGridMode.Manual;
            xyDiagram1.RangeControlNumericGridOptions.GridSpacing = 100D;
            xyDiagram1.RangeControlNumericGridOptions.SnapMode = DevExpress.XtraCharts.ChartRangeControlClientSnapMode.Manual;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Вторичная ось Y1";
            secondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.GammaSpectrChart.Diagram = xyDiagram1;
            this.GammaSpectrChart.Legend.Name = "Default Legend";
            this.GammaSpectrChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.GammaSpectrChart.Location = new System.Drawing.Point(11, 33);
            this.GammaSpectrChart.Name = "GammaSpectrChart";
            this.GammaSpectrChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom;
            series1.Name = "Спектр";
            lineSeriesView1.LineStyle.Thickness = 1;
            lineSeriesView1.RangeControlOptions.ViewType = DevExpress.XtraCharts.RangeControlViewType.Area;
            series1.View = lineSeriesView1;
            series2.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series2.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Энергия";
            lineSeriesView2.AxisYName = "Вторичная ось Y1";
            lineSeriesView2.Color = System.Drawing.Color.Transparent;
            lineSeriesView2.LineMarkerOptions.Color = System.Drawing.Color.Transparent;
            lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            lineSeriesView2.RangeControlOptions.Visible = false;
            series2.View = lineSeriesView2;
            series3.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series3.Name = "Сглаживание";
            splineSeriesView1.Color = System.Drawing.Color.Crimson;
            splineSeriesView1.LineStyle.Thickness = 1;
            splineSeriesView1.RangeControlOptions.Visible = false;
            series3.View = splineSeriesView1;
            series4.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series4.Name = "Пр1";
            series4.View = lineSeriesView3;
            series4.Visible = false;
            series5.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series5.Name = "Пр2";
            series5.View = lineSeriesView4;
            series5.Visible = false;
            series6.Name = "edges";
            series6.View = pointSeriesView1;
            series6.Visible = false;
            series7.Name = "edges2";
            series7.View = pointSeriesView2;
            series7.Visible = false;
            series8.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series8.Name = "baseline";
            lineSeriesView5.LineStyle.Thickness = 1;
            series8.View = lineSeriesView5;
            this.GammaSpectrChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4,
        series5,
        series6,
        series7,
        series8};
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
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpectrometryHandlerMenuButton,
            this.BackgroundSunstraction});
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // SpectrometryHandlerMenuButton
            // 
            this.SpectrometryHandlerMenuButton.Name = "SpectrometryHandlerMenuButton";
            this.SpectrometryHandlerMenuButton.Size = new System.Drawing.Size(252, 22);
            this.SpectrometryHandlerMenuButton.Text = "Спектрометрическая обработка";
            this.SpectrometryHandlerMenuButton.Click += new System.EventHandler(this.SpectrometryHandlerMenuButton_Click);
            // 
            // BackgroundSunstraction
            // 
            this.BackgroundSunstraction.Checked = true;
            this.BackgroundSunstraction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackgroundSunstraction.Name = "BackgroundSunstraction";
            this.BackgroundSunstraction.Size = new System.Drawing.Size(252, 22);
            this.BackgroundSunstraction.Text = "Фон вычтен";
            this.BackgroundSunstraction.Click += new System.EventHandler(this.BackgroundSunstraction_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroundSettingsMenuButton,
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
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
            // CloseMenuItem
            // 
            this.CloseMenuItem.Image = global::bremsstrahlung.Properties.Resources.CloseSolution_16x;
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(198, 22);
            this.CloseMenuItem.Text = "Выход";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
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
            // BackgroundSettingsMenuButton
            // 
            this.BackgroundSettingsMenuButton.Image = global::bremsstrahlung.Properties.Resources.SettingsFile_16x;
            this.BackgroundSettingsMenuButton.Name = "BackgroundSettingsMenuButton";
            this.BackgroundSettingsMenuButton.Size = new System.Drawing.Size(224, 22);
            this.BackgroundSettingsMenuButton.Text = "Фон";
            this.BackgroundSettingsMenuButton.Click += new System.EventHandler(this.BackgroundSettingsMenuButton_Click);
            // 
            // XAxisZoomingMenuItem
            // 
            this.XAxisZoomingMenuItem.Checked = true;
            this.XAxisZoomingMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XAxisZoomingMenuItem.Image = global::bremsstrahlung.Properties.Resources.ZoomIn_16x;
            this.XAxisZoomingMenuItem.Name = "XAxisZoomingMenuItem";
            this.XAxisZoomingMenuItem.Size = new System.Drawing.Size(224, 22);
            this.XAxisZoomingMenuItem.Text = "Масшабирование по оси X";
            this.XAxisZoomingMenuItem.Click += new System.EventHandler(this.XAxisZoomingMenuItem_Click);
            // 
            // YAxisZoomingMenuItem
            // 
            this.YAxisZoomingMenuItem.Image = global::bremsstrahlung.Properties.Resources.Zoom_16x;
            this.YAxisZoomingMenuItem.Name = "YAxisZoomingMenuItem";
            this.YAxisZoomingMenuItem.Size = new System.Drawing.Size(224, 22);
            this.YAxisZoomingMenuItem.Text = "Масшабирование по оси Y";
            this.YAxisZoomingMenuItem.Click += new System.EventHandler(this.YAxisZoomingMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 601);
            this.Controls.Add(this.GammaSpectrRangeControl);
            this.Controls.Add(this.GammaSpectrChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bremsstrahlung";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrRangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem BackgroundSunstraction;
        public DevExpress.XtraCharts.ChartControl GammaSpectrChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem XAxisZoomingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YAxisZoomingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PrintPreviewMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
    }
}

