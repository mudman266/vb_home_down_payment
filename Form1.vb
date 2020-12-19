Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate input
        If Not IsNumeric(txtDownPayment.Text) Or Not IsNumeric(txtInt.Text) Or Not IsNumeric(txtYears.Text) Then
            MsgBox("You entered an invalid value. Try again.")
            Exit Sub
        End If
        If txtDownPayment.Text < 0 Or txtInt.Text < 0 Or txtYears.Text < 0 Then
            MsgBox("You entered a negative value. Try again.")
            Exit Sub
        End If
        Dim decDownPayment As Decimal = txtDownPayment.Text
        Dim intYears As Integer = txtYears.Text
        Dim decInterestRate As Decimal = txtInt.Text
        Dim decTotalAmount As Decimal = decDownPayment
        Dim i As Integer
        For i = 1 To intYears
            decTotalAmount = decTotalAmount * (1 + decInterestRate)
            lstAmounts.Items.Add(i.ToString() & " " & decTotalAmount.ToString("C2"))
        Next
    End Sub
End Class
