Imports Word = Microsoft.Office.Interop.Word

Public Class frmSell



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' This Sub procedure opens the first form
        Dim frmFirst As New frmTicketSeller

        Hide()
        frmFirst.ShowDialog()
    End Sub



    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        ' This btnSubmit click event provides the user with a itemized list of the form calculations

        ' Declaration section
        Dim decAvailable As Integer
        Dim decDiscount As Decimal = 10%
        Dim decTicketNumber As Decimal = 100


        txtAvailable.Text = decAvailable.ToString("100") - txtSellTickets.Text








    End Sub
End Class