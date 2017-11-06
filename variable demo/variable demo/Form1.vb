Public Class Form1

    Private Sub Buttonshow_Click(sender As Object, e As EventArgs) Handles Buttonshow.Click
        Dim strFullName As String

        strFullName = txtFirstName.Text & " " & txtLastName.Text

        lblFullName.Text = strFullName
    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty
    End Sub

    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Me.Close()
    End Sub
End Class
