Public Class Form4
    Public Property stringtext1 As String
    Private Sub Form4Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WillairwayvirtualDbv1DataSet.repfltdeck' table. You can move, or remove it, as needed.
        Me.RepfltdeckTableAdapter.Fill(Me.WillairwayvirtualDbv1DataSet.repfltdeck)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = stringtext1
    End Sub
    
End Class