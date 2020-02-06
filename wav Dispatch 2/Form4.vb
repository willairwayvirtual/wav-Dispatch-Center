Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WillairwayvirtualDbv1DataSet.repfltdeck' table. You can move, or remove it, as needed.
        Me.RepfltdeckTableAdapter.Fill(Me.WillairwayvirtualDbv1DataSet.repfltdeck)

    End Sub
End Class