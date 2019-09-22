' Name:         Jacobson Solution
' Purpose:      Calculate and display the sales tax and total due.
' Programmer:   <your name> on <current date>

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Setting up variables to get values from Main Form
        Dim principalValue As Decimal = Convert.ToDecimal(txtSales.Text)
        Dim taxRate As Decimal = Convert.ToDecimal(lblTax.Text)

        ' Converting the taxRate in order to calculate total cost

        taxRate = taxRate * 0.01

        ' Sets lblTotal to principle + added tax amount from taxRate rounded to dollars and cents

        lblTotal.Text = Math.Round((principalValue + (principalValue * taxRate)), 2)

    End Sub

End Class
