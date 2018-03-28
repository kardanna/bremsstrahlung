namespace bremsstrahlung
{
    partial class BackgroundSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundSettings));
            this.GeometryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExposureTimeLabel = new System.Windows.Forms.Label();
            this.BackgroundChart = new DevExpress.XtraCharts.ChartControl();
            this.ChangeBackgroundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GeometryComboBox
            // 
            this.GeometryComboBox.FormattingEnabled = true;
            this.GeometryComboBox.Items.AddRange(new object[] {
            "Сосуд 0.5 л",
            "Сосуд 0.1 л",
            "Точечная"});
            this.GeometryComboBox.Location = new System.Drawing.Point(10, 10);
            this.GeometryComboBox.Name = "GeometryComboBox";
            this.GeometryComboBox.Size = new System.Drawing.Size(296, 21);
            this.GeometryComboBox.TabIndex = 0;
            this.GeometryComboBox.Text = "Точечная";
            this.GeometryComboBox.SelectedIndexChanged += new System.EventHandler(this.GeometryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время экспозиции:";
            // 
            // ExposureTimeLabel
            // 
            this.ExposureTimeLabel.AutoSize = true;
            this.ExposureTimeLabel.Location = new System.Drawing.Point(518, 15);
            this.ExposureTimeLabel.Name = "ExposureTimeLabel";
            this.ExposureTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.ExposureTimeLabel.TabIndex = 3;
            this.ExposureTimeLabel.Text = "Time";
            // 
            // BackgroundChart
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "1024";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0D;
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "1024";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXZooming = true;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Вторичная ось Y1";
            secondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.BackgroundChart.Diagram = xyDiagram1;
            this.BackgroundChart.Legend.Name = "Default Legend";
            this.BackgroundChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.BackgroundChart.Location = new System.Drawing.Point(10, 37);
            this.BackgroundChart.Name = "BackgroundChart";
            series1.Name = "Фон";
            lineSeriesView1.LineStyle.Thickness = 1;
            series1.View = lineSeriesView1;
            series2.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series2.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Энергия";
            lineSeriesView2.AxisYName = "Вторичная ось Y1";
            lineSeriesView2.Color = System.Drawing.Color.Transparent;
            lineSeriesView2.LineStyle.Thickness = 1;
            series2.View = lineSeriesView2;
            this.BackgroundChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.BackgroundChart.Size = new System.Drawing.Size(798, 483);
            this.BackgroundChart.TabIndex = 4;
            // 
            // ChangeBackgroundButton
            // 
            this.ChangeBackgroundButton.Image = global::bremsstrahlung.Properties.Resources.OpenFile_16x;
            this.ChangeBackgroundButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeBackgroundButton.Location = new System.Drawing.Point(314, 8);
            this.ChangeBackgroundButton.Name = "ChangeBackgroundButton";
            this.ChangeBackgroundButton.Size = new System.Drawing.Size(86, 25);
            this.ChangeBackgroundButton.TabIndex = 1;
            this.ChangeBackgroundButton.Text = "Заменить";
            this.ChangeBackgroundButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // BackgroundSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 535);
            this.Controls.Add(this.BackgroundChart);
            this.Controls.Add(this.ExposureTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeBackgroundButton);
            this.Controls.Add(this.GeometryComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackgroundSettings";
            this.Text = "Фон";
            this.SizeChanged += new System.EventHandler(this.BackgroundSettings_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GeometryComboBox;
        private System.Windows.Forms.Button ChangeBackgroundButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExposureTimeLabel;
        private DevExpress.XtraCharts.ChartControl BackgroundChart;
    }
}