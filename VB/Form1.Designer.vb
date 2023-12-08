Namespace ConditionallyHideSeriesLabels

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim dataFilter1 As DevExpress.XtraCharts.DataFilter = New DevExpress.XtraCharts.DataFilter("Year", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2003)
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gspDataSet = New ConditionallyHideSeriesLabels.gspDataSet()
            Me.gspDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gSPTableAdapter = New ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gspDataSetBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataAdapter = Me.gSPTableAdapter
            Me.chartControl1.DataSource = Me.gspDataSetBindingSource
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.Name = "Series 1"
            series1.View = lineSeriesView1
            series1.ArgumentDataMember = "Region"
            series1.ValueDataMembersSerializable = "GSP"
            series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {dataFilter1})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.Size = New System.Drawing.Size(474, 325)
            Me.chartControl1.TabIndex = 0
            AddHandler Me.chartControl1.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.chartControl1_CustomDrawSeriesPoint)
            ' 
            ' gspDataSet
            ' 
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gspDataSetBindingSource
            ' 
            Me.gspDataSetBindingSource.DataMember = "GSP"
            Me.gspDataSetBindingSource.DataSource = Me.gspDataSet
            ' 
            ' gSPTableAdapter
            ' 
            Me.gSPTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(474, 325)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gspDataSetBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private gSPTableAdapter As ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter

        Private gspDataSetBindingSource As System.Windows.Forms.BindingSource

        Private gspDataSet As ConditionallyHideSeriesLabels.gspDataSet
    End Class
End Namespace
