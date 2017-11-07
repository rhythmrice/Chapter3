Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim dblResult As Double

        lblOperation.Text = "+"

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub


    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblResult As Double

        lblOperation.Text = "-"

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub
 
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim dblResult As Double

        lblOperation.Text = "x"

        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim dblResult As Double

        lblOperation.Text = "/"

        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        Dim dblResult As Double

        lblOperation.Text = "^"

        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblResult As Integer

        lblOperation.Text = "MOD"

        dblResult = CDbl(txtNumber1.Text) Mod CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblResult.Clear()
    End Sub
End Class
