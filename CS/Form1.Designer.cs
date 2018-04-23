namespace ConditionallyHideSeriesLabels {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.DataFilter dataFilter1 = new DevExpress.XtraCharts.DataFilter("Year", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2003);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gspDataSet = new ConditionallyHideSeriesLabels.gspDataSet();
            this.gspDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSPTableAdapter = new ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.gSPTableAdapter;
            this.chartControl1.DataSource = this.gspDataSetBindingSource;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            series1.ArgumentDataMember = "Region";
            series1.ValueDataMembersSerializable = "GSP";
            series1.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            dataFilter1});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(474, 325);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // gspDataSet
            // 
            this.gspDataSet.DataSetName = "gspDataSet";
            this.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gspDataSetBindingSource
            // 
            this.gspDataSetBindingSource.DataMember = "GSP";
            this.gspDataSetBindingSource.DataSource = this.gspDataSet;
            // 
            // gSPTableAdapter
            // 
            this.gSPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 325);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter gSPTableAdapter;
        private System.Windows.Forms.BindingSource gspDataSetBindingSource;
        private gspDataSet gspDataSet;
    }
}

