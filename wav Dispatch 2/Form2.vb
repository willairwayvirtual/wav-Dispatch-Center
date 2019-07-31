Public Class Form2
    ' pl1 = panel1 height
    Dim pl1 As Integer = 30

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button72.Click
        Form3.Show()
        Me.Close()


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' 250 = panel height
        If pl1 > 90 Then

            Timer1.Stop()

        Else
            Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl1)
            pl1 += 10
        End If

    End Sub






    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub flightinfo_MouseMove(sender As Object, e As MouseEventArgs) Handles flightinfo.MouseMove
        Timer1.Start()
    End Sub

    Private Sub flightinfo_MouseLeave(sender As Object, e As EventArgs) Handles flightinfo.MouseLeave
        Timer1.Stop()
        pl1 = 30
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class