Option Strict On
Public Class MortgageCalculatorFRM
    Dim fiveDip As String
    Dim tenDip As String
    Dim twentyFDip As String
    Dim fiftyDip As String
    Dim topBar As String = "Term" & vbTab & "Payments".ToString

    Private Sub interestTBX_TextChanged(sender As Object, e As EventArgs) Handles interestTB.TextChanged
        ResultTB.Text = topBar
    End Sub

    Private Sub amountTB_TextChanged(sender As Object, e As EventArgs) Handles amountTB.TextChanged
        ResultTB.Text = topBar


    End Sub

    Private Sub CalcBTN_Click(sender As Object, e As EventArgs) Handles CalcBTN.Click
        ResultTB.Text = topBar
        If (amountTB.Text = ("") Or interestTB.Text = ("")) Then


            MessageBox.Show(" Enter an amount and an interest rate", "invalid data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            If (FiveYrCB.Checked = True) Then
                Dim fiveyr As String
                Dim fiveTime As Integer
                fiveTime = 12 * 5
                fiveyr = Math.Round((((Val(amountTB.Text)) * (Val(interestTB.Text))) / fiveTime), 2).ToString
                fiveDip = "5 Years" & vbTab & "$" & fiveyr
                ResultTB.Text += vbNewLine & fiveDip
            End If

            If (TenYrCB.Checked = True) Then
                Dim tenyr As String
                Dim tenTime As Integer
                tenTime = 12 * 10
                tenyr = Math.Round((((Val(amountTB.Text)) * (Val(interestTB.Text))) / tenTime), 2).ToString
                tenDip = "10 Years" & vbTab & "$" & tenyr
                ResultTB.Text += vbNewLine & tenDip
            End If

            If (twentyfYrCB.Checked = True) Then
                Dim twentyFyr As String
                Dim twentyFTime As Integer
                twentyFTime = 12 * 25
                twentyFyr = Math.Round((((Val(amountTB.Text)) * (Val(interestTB.Text))) / twentyFTime), 2).ToString
                twentyFDip = "20 Years" & vbTab & "$" & twentyFyr
                ResultTB.Text += vbNewLine & twentyFDip
            End If

            If (fiftyYrCB.Checked = True) Then
                Dim fiftyyr As String
                Dim fiftyTime As Integer
                fiftyTime = 12 * 50
                fiftyyr = Math.Round((((Val(amountTB.Text)) * (Val(interestTB.Text))) / fiftyTime), 2).ToString
                fiftyDip = "50 Years" & vbTab & "$" & fiftyyr
                ResultTB.Text += vbNewLine & fiftyDip
            End If
        End If
    End Sub
End Class