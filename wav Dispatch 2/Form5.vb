Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "/CrystalReport3.rpt"
        CrystalReportViewer1.SelectionFormula = "{WavVirtDispatch.flight}= '" & TextBoxkeyword.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()







    End Sub
End Class