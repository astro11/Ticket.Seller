Public Class frmSetup


    Private Sub cboName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboName.SelectedIndexChanged, cboName.SelectedIndexChanged


    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' This Sub procedure opens the original menu on the Ticket Seller form
        Dim frmFirst As New frmTicketSeller

        Hide()
        frmFirst.ShowDialog()
    End Sub

    Private Function ValidateTourSelection(ByRef blnGame As Boolean, ByRef strGame As String) As Integer
        ' This function ensures the user selected a tour
        Dim intGameChoice As Integer

        Try
            intGameChoice = Convert.ToInt32(cboName.SelectedIndex)
            strGame = cboName.SelectedItem.ToString()
            blnGame = True
        Catch Exception As SystemException
            ' Detects if a tour is selected
            MsgBox("Please Select a Game First!", , "Error")
            blnGame = False

        End Try
        Return intGameChoice

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        ' Declaration section

        Dim decGameOne As Decimal = 35.99D
        Dim decGameTwo As Decimal = 45.99D
        Dim decGameThree As Decimal = 65.99D
        Dim decGameFour As Decimal = 85.99D
        Dim intSeats As Integer

        Dim strGameChoice As String
        Dim blnGameIsSelected As Boolean = False
        Dim strSelectedGame As String = ""


        ' Calculate and display the cost estimate

        strGameChoice = cboName.SelectedIndex
        Select Case strGameChoice
            Case 0
                txtPrices.Text = Val(txtSeats.Text) * decGameOne
            Case 1
                txtPrices.Text = Val(txtSeats.Text) * decGameTwo
            Case 2
                txtPrices.Text = Val(txtSeats.Text) * decGameThree
            Case 3
                txtPrices.Text = Val(txtSeats.Text) * decGameFour
        End Select



        ' Call a function to ensure a tour was selected
        strGameChoice = ValidateTourSelection(blnGameIsSelected, strSelectedGame)

    End Sub

End Class