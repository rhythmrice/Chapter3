Public Class Form1

 lblDateToday.Text = Not.ToString("D")

 lblTimeToday.Text = Not.ToString("T")


    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Close()
    End Sub

    Private Sub ButtCalculate_Click(sender As Object, e As EventArgs) Handles ButtCalculate.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        lblStatus.Text = String.Empty
        Try
            decRoomCharges = CDec(txtNights.Text)
            CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text)
            CDec(txtTelephone.Text)
            CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTotal.ToString("c")

            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")
        Catch

            MessageBox.Show("All input here must be valid numeric values.")
        End Try
    End Sub

    Private Sub ButtClear_Click(sender As Object, e As EventArgs) Handles ButtClear.Click
        txtNights.Clear()
        txtNightlyCharge.Clear()

        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        lblDateToday.Text = Now.ToString("D")

        lblTimeToday.Text = Now.ToString("T")

        txtNights.Focus()
    End Sub
End Class
