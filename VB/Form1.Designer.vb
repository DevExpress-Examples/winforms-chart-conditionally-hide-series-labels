<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView
        Dim DataFilter1 As DevExpress.XtraCharts.DataFilter = New DevExpress.XtraCharts.DataFilter("Year", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2003)
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.GspDataSet = New ConditionallyHideSeriesLabels.gspDataSet
        Me.GspDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPTableAdapter = New ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GspDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.GSPTableAdapter
        Me.ChartControl1.DataSource = Me.GspDataSetBindingSource
        XyDiagram1.AxisX.Label.Staggered = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Visible = False
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.Name = "Series 1"
        Series1.View = LineSeriesView1
        Series1.ArgumentDataMember = "Region"
        Series1.ValueDataMembersSerializable = "GSP"
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {DataFilter1})
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(518, 311)
        Me.ChartControl1.TabIndex = 0
        '
        'GspDataSet
        '
        Me.GspDataSet.DataSetName = "gspDataSet"
        Me.GspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GspDataSetBindingSource
        '
        Me.GspDataSetBindingSource.DataMember = "GSP"
        Me.GspDataSetBindingSource.DataSource = Me.GspDataSet
        '
        'GSPTableAdapter
        '
        Me.GSPTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 311)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GspDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GSPTableAdapter As ConditionallyHideSeriesLabels.gspDataSetTableAdapters.GSPTableAdapter
    Friend WithEvents GspDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GspDataSet As ConditionallyHideSeriesLabels.gspDataSet

End Class
