namespace bremsstrahlung
{
    partial class RegistrationEfficiencySettings
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationEfficiencySettings));
            this.GeometryComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrationEfficiencyChart = new DevExpress.XtraCharts.ChartControl();
            this.RegistrationEfficiencyKnotsGrid = new System.Windows.Forms.DataGridView();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeRegistrationEfficiencyFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationEfficiencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationEfficiencyKnotsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GeometryComboBox
            // 
            this.GeometryComboBox.FormattingEnabled = true;
            this.GeometryComboBox.ItemHeight = 13;
            this.GeometryComboBox.Items.AddRange(new object[] {
            "Сосуд 0.5 л",
            "Сосуд 0.1 л",
            "Точечная"});
            this.GeometryComboBox.Location = new System.Drawing.Point(10, 10);
            this.GeometryComboBox.Name = "GeometryComboBox";
            this.GeometryComboBox.Size = new System.Drawing.Size(220, 21);
            this.GeometryComboBox.TabIndex = 0;
            this.GeometryComboBox.Text = "Точечная";
            this.GeometryComboBox.SelectedIndexChanged += new System.EventHandler(this.GeometryComboBox_SelectedIndexChanged);
            // 
            // RegistrationEfficiencyChart
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.VisualRange.Auto = false;
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "1024";
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "1";
            xyDiagram2.AxisX.WholeRange.Auto = false;
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram2.AxisX.WholeRange.MaxValueSerializable = "1024";
            xyDiagram2.AxisX.WholeRange.MinValueSerializable = "1";
            xyDiagram2.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.EnableAxisXZooming = true;
            secondaryAxisY2.AxisID = 0;
            secondaryAxisY2.Name = "Вторичная ось Y1";
            secondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.False;
            secondaryAxisY2.VisibleInPanesSerializable = "-1";
            xyDiagram2.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY2});
            this.RegistrationEfficiencyChart.Diagram = xyDiagram2;
            this.RegistrationEfficiencyChart.Legend.Name = "Default Legend";
            this.RegistrationEfficiencyChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.RegistrationEfficiencyChart.Location = new System.Drawing.Point(236, 37);
            this.RegistrationEfficiencyChart.Name = "RegistrationEfficiencyChart";
            series4.Name = "Эффективность";
            lineSeriesView3.LineStyle.Thickness = 1;
            series4.View = lineSeriesView3;
            series5.Name = "Узлы";
            series5.View = pointSeriesView2;
            series6.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.False;
            series6.Name = "Энергия";
            lineSeriesView4.AxisYName = "Вторичная ось Y1";
            lineSeriesView4.Color = System.Drawing.Color.Transparent;
            series6.View = lineSeriesView4;
            this.RegistrationEfficiencyChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.RegistrationEfficiencyChart.Size = new System.Drawing.Size(451, 406);
            this.RegistrationEfficiencyChart.TabIndex = 3;
            // 
            // RegistrationEfficiencyKnotsGrid
            // 
            this.RegistrationEfficiencyKnotsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RegistrationEfficiencyKnotsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrationEfficiencyKnotsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Energy,
            this.Efficiency});
            this.RegistrationEfficiencyKnotsGrid.Location = new System.Drawing.Point(10, 37);
            this.RegistrationEfficiencyKnotsGrid.Name = "RegistrationEfficiencyKnotsGrid";
            this.RegistrationEfficiencyKnotsGrid.RowHeadersVisible = false;
            this.RegistrationEfficiencyKnotsGrid.Size = new System.Drawing.Size(220, 407);
            this.RegistrationEfficiencyKnotsGrid.TabIndex = 4;
            // 
            // Energy
            // 
            this.Energy.HeaderText = "Энергия, кэВ";
            this.Energy.Name = "Energy";
            this.Energy.ReadOnly = true;
            this.Energy.Width = 109;
            // 
            // Efficiency
            // 
            this.Efficiency.HeaderText = "Эффективность";
            this.Efficiency.Name = "Efficiency";
            this.Efficiency.ReadOnly = true;
            this.Efficiency.Width = 108;
            // 
            // ChangeRegistrationEfficiencyFileButton
            // 
            this.ChangeRegistrationEfficiencyFileButton.Image = global::bremsstrahlung.Properties.Resources.OpenFile_16x;
            this.ChangeRegistrationEfficiencyFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeRegistrationEfficiencyFileButton.Location = new System.Drawing.Point(236, 8);
            this.ChangeRegistrationEfficiencyFileButton.Name = "ChangeRegistrationEfficiencyFileButton";
            this.ChangeRegistrationEfficiencyFileButton.Size = new System.Drawing.Size(111, 25);
            this.ChangeRegistrationEfficiencyFileButton.TabIndex = 2;
            this.ChangeRegistrationEfficiencyFileButton.Text = "Заменить файл";
            this.ChangeRegistrationEfficiencyFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeRegistrationEfficiencyFileButton.UseVisualStyleBackColor = true;
            this.ChangeRegistrationEfficiencyFileButton.Click += new System.EventHandler(this.ChangeRegistrationEfficiencyFileButton_Click);
            // 
            // RegistrationEfficiencySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 464);
            this.Controls.Add(this.RegistrationEfficiencyKnotsGrid);
            this.Controls.Add(this.RegistrationEfficiencyChart);
            this.Controls.Add(this.ChangeRegistrationEfficiencyFileButton);
            this.Controls.Add(this.GeometryComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationEfficiencySettings";
            this.Text = "Эффективность регистрации";
            this.SizeChanged += new System.EventHandler(this.RegistrationEfficiencySettings_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationEfficiencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationEfficiencyKnotsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GeometryComboBox;
        private System.Windows.Forms.Button ChangeRegistrationEfficiencyFileButton;
        private DevExpress.XtraCharts.ChartControl RegistrationEfficiencyChart;
        private System.Windows.Forms.DataGridView RegistrationEfficiencyKnotsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efficiency;
    }
}