﻿Public Class Splash
    Private Sub Button1cli_Click(sender As Object, e As EventArgs)
        Timer1.Start()
        Enabled = False



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If

        Label1.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
