Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

' ...
Namespace ConditionallyHideSeriesLabels

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'gspDataSet.GSP' table.
            ' You can move, or remove it, as needed.
            gSPTableAdapter.Fill(gspDataSet.GSP)
        End Sub

        Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            ' If the value is less than 1, hide the point's label.
            If e.SeriesPoint(0) < 1 Then
                e.LabelText = ""
            End If
        End Sub
    End Class
End Namespace
