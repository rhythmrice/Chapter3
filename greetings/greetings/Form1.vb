Public Class Form1

    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        Dim strName As String

        strName = txtUserName.Text

        lblGreeting.Text = "Hi " + strName
    End Sub

    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Me.Close()
    End Sub
End Class
