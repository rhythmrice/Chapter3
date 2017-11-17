Public Class Form1

    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Close()
    End Sub

    Private Sub ButtCalculate_Click(sender As Object, e As EventArgs) Handles ButtCalculate.Click
        Dim dblMPG As Double
        dblMPG = CDbl(txtMileage.Text) / CDbl(txtGallons.Text)
        lblResult = dblMPG
    End Sub
End Class
