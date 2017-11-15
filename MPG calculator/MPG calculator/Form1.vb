Public Class Form1

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim dblMPG As Double
        dblMPG = CDbl(txtMileage.text) / CDbl(txtGallons.text)
        lblResult.Text = dblMPG
    End Sub
End Class
