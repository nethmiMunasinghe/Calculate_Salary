Public Class Form1
    Dim BS, OH, OtR, Al1, Al2, Net, OTAmnt As Double
    Dim Sex As String

    Private Sub btnCalculater_Click(sender As Object, e As EventArgs) Handles btnCalculater.Click
        BS = Convert.ToDouble(txtBasicSalary.Text)
        OH = Convert.ToDouble(txtOTHours.Text)
        Sex = (txtSex.Text)
        OtR = BS / 240

        If BS > 40000 Then
            Al1 = BS * (10 / 100)
        ElseIf BS > 25000 Then
            Al1 = BS * (5 / 100)

        Else
            Al1 = 500
        End If

        If Sex = "M" Then
            Al2 = 2000
        Else
            Al2 = 1000
        End If

        OTAmnt = OH * OtR

        txtOTRate.Text = OtR
        txtAllowance1.Text = Al1
        txtAllowance2.Text = Al2
        Net = BS + OTAmnt + Al1 + Al2
        txtNetSalary.Text = Net
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBasicSalary.Text = ""
        txtOTHours.Text = ""
        txtSex.Text = ""
        txtOTRate.Text = ""
        txtAllowance1.Text = ""
        txtAllowance2.Text = ""
        txtNetSalary.Text = ""

    End Sub
End Class


'awdafsfe' 'sdfsdfsf'

'sfjdhs'