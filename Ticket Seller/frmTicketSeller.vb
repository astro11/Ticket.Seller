' Program Name: Ticket Seller Application
' Author:       Aquila Strother
' Date:         6/09/2016
' Purpose:      The Ticket Seller application determines the game types available and calculates the total prices.


Public Class frmTicketSeller

    Private Sub frmTicketSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hold the splash screen for 5 seconds
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the application
        Application.Exit()
    End Sub

    Private Sub mnuSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetup.Click
        ' The mnuSetup click event creates an instance of frmSetup
        Dim frmSecond As New frmSetup

        ' Hide this form and show the Setup form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        ' The btnDisplay click event creates an instance of frmSetup
        Dim frmSecond As New frmSetup

        ' Hide this form and show the Setup form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub btnSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSell.Click
        ' The btnSell click event creates an instance of frmSell
        Dim frmSecond As New frmSell

        ' Hide this form and show the Sell form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDaily.Click
        ' This mnuDaily click event provides the user with a daily report

        Dim FILE_NAME As String = "C:\Users\JetStream\Desktop\brandingQuotes.rtf"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub mnuWeekly_Click(sender As Object, e As EventArgs) Handles mnuWeekly.Click
        ' This mnuDaily click event provides the user with a weekly report

        Dim FILE_NAME As String = "C:\Users\JetStream\Desktop\brandingQuotes.rtf"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub mnuTickets_Click(sender As Object, e As EventArgs) Handles mnuTickets.Click
        ' This mnuTickets click event provides the user with the purchased tickets 

        Dim FILE_NAME As String = "C:\Users\JetStream\Desktop\ticketConfirmation.rtf"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("Your Tickets Have Been Confirmed!")
        End If
    End Sub
End Class
