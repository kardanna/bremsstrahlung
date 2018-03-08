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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.GammaSpectrRangeControl = new DevExpress.XtraEditors.RangeControl();
            this.GammaSpectrChart = new DevExpress.XtraCharts.ChartControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спектрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSpectrMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpectrometryHandlerMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSunstraction = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundSettingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrRangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
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
            xyDiagram1.RangeControlNumericGridOptions.GridMode = DevExpress.XtraCharts.ChartRangeControlClientGridMode.Manual;
            xyDiagram1.RangeControlNumericGridOptions.GridSpacing = 100D;
            xyDiagram1.RangeControlNumericGridOptions.SnapMode = DevExpress.XtraCharts.ChartRangeControlClientSnapMode.Manual;
            this.GammaSpectrChart.Diagram = xyDiagram1;
            this.GammaSpectrChart.Legend.Name = "Default Legend";
            this.GammaSpectrChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.GammaSpectrChart.Location = new System.Drawing.Point(10, 34);
            this.GammaSpectrChart.Name = "GammaSpectrChart";
            series1.Name = "Спектр";
            series1.View = lineSeriesView1;
            series2.Name = "Энергия";
            series2.View = lineSeriesView2;
            this.GammaSpectrChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
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
            this.OpenSpectrMenuButton});
            this.спектрToolStripMenuItem.Name = "спектрToolStripMenuItem";
            this.спектрToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.спектрToolStripMenuItem.Text = "Файл";
            // 
            // OpenSpectrMenuButton
            // 
            this.OpenSpectrMenuButton.Name = "OpenSpectrMenuButton";
            this.OpenSpectrMenuButton.Size = new System.Drawing.Size(130, 22);
            this.OpenSpectrMenuButton.Text = "Открыть...";
            this.OpenSpectrMenuButton.Click += new System.EventHandler(this.OpenSpectrMenuButton_Click);
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
            this.BackgroundSettingsMenuButton});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // BackgroundSettingsMenuButton
            // 
            this.BackgroundSettingsMenuButton.Name = "BackgroundSettingsMenuButton";
            this.BackgroundSettingsMenuButton.Size = new System.Drawing.Size(97, 22);
            this.BackgroundSettingsMenuButton.Text = "Фон";
            this.BackgroundSettingsMenuButton.Click += new System.EventHandler(this.BackgroundSettingsMenuButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSpectrChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl GammaSpectrChart;
        private DevExpress.XtraEditors.RangeControl GammaSpectrRangeControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спектрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSpectrMenuButton;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackgroundSettingsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SpectrometryHandlerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem BackgroundSunstraction;
    }
}

