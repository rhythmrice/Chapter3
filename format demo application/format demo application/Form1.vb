Public Class Form1

    Private Sub ButtNumber_Click(sender As Object, e As EventArgs) Handles ButtNumber.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(TextBoxEntersumthin.Text)

        strResult = dblAnswer.ToString("n")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtFixed_Click(sender As Object, e As EventArgs) Handles ButtFixed.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(TextBoxEntersumthin.Text)

        strResult = dblAnswer.ToString("f")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtExponetial_Click(sender As Object, e As EventArgs) Handles ButtExponetial.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(TextBoxEntersumthin.Text)

        strResult = dblAnswer.ToString("e")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtCurrency_Click(sender As Object, e As EventArgs) Handles ButtCurrency.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(TextBoxEntersumthin.Text)

        strResult = dblAnswer.ToString("c")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtPercent_Click(sender As Object, e As EventArgs) Handles ButtPercent.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(TextBoxEntersumthin.Text)

        strResult = dblAnswer.ToString("p")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtShortdate_Click(sender As Object, e As EventArgs) Handles ButtShortdate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(TextBoxEntersumthin.Text)

        strResult = Answer.ToString("d")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtLongdate_Click(sender As Object, e As EventArgs) Handles ButtLongdate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(TextBoxEntersumthin.Text)

        strResult = Answer.ToString("D")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtShorttime_Click(sender As Object, e As EventArgs) Handles ButtShorttime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(TextBoxEntersumthin.Text)

        strResult = Answer.ToString("t")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtLongtime_Click(sender As Object, e As EventArgs) Handles ButtLongtime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(TextBoxEntersumthin.Text)

        strResult = Answer.ToString("T")
        LabelFormatted.Text = strResult
    End Sub

    Private Sub ButtFulldatetime_Click(sender As Object, e As EventArgs) Handles ButtFulldatetime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(TextBoxEntersumthin.Text)

        strResult = Answer.ToString("F")
        LabelFormatted.Text = strResult
    End Sub
End Class
