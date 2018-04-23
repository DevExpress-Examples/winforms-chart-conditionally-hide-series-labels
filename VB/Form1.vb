Imports DevExpress.XtraCharts
' ...

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        Me.GSPTableAdapter.Fill(Me.GspDataSet.GSP)

    End Sub

    Private Sub ChartControl1_CustomDrawSeriesPoint(ByVal sender As System.Object, _
    ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControl1.CustomDrawSeriesPoint
        ' If the value is less than 1, hide the point's label.
        If e.SeriesPoint(0) < 1 Then
            e.LabelText = ""
        End If
    End Sub
End Class
