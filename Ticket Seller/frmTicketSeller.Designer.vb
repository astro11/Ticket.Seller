<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketSeller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWeekly = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.picTickets = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Snow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTickets, Me.mnuReports})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetup, Me.mnuSell, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(80, 20)
        Me.mnuFile.Text = "&Main Menu"
        '
        'mnuSetup
        '
        Me.mnuSetup.BackColor = System.Drawing.Color.Snow
        Me.mnuSetup.Name = "mnuSetup"
        Me.mnuSetup.Size = New System.Drawing.Size(138, 22)
        Me.mnuSetup.Text = "&Setup Game"
        '
        'mnuSell
        '
        Me.mnuSell.Name = "mnuSell"
        Me.mnuSell.Size = New System.Drawing.Size(138, 22)
        Me.mnuSell.Text = "Sell Tickets"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(138, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuTickets
        '
        Me.mnuTickets.Name = "mnuTickets"
        Me.mnuTickets.Size = New System.Drawing.Size(56, 20)
        Me.mnuTickets.Text = "&Tickets"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDaily, Me.mnuWeekly})
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(59, 20)
        Me.mnuReports.Text = "&Reports"
        '
        'mnuDaily
        '
        Me.mnuDaily.Name = "mnuDaily"
        Me.mnuDaily.Size = New System.Drawing.Size(150, 22)
        Me.mnuDaily.Text = "&Daily Report"
        '
        'mnuWeekly
        '
        Me.mnuWeekly.Name = "mnuWeekly"
        Me.mnuWeekly.Size = New System.Drawing.Size(150, 22)
        Me.mnuWeekly.Text = "&Weekly Report"
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.Color.Brown
        Me.btnSetup.Font = New System.Drawing.Font("Gobold Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.Snow
        Me.btnSetup.Location = New System.Drawing.Point(180, 304)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(157, 48)
        Me.btnSetup.TabIndex = 4
        Me.btnSetup.Text = "Setup Game"
        Me.btnSetup.UseVisualStyleBackColor = False
        '
        'btnSell
        '
        Me.btnSell.BackColor = System.Drawing.Color.Brown
        Me.btnSell.Font = New System.Drawing.Font("Gobold Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.ForeColor = System.Drawing.Color.Snow
        Me.btnSell.Location = New System.Drawing.Point(180, 358)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(157, 48)
        Me.btnSell.TabIndex = 5
        Me.btnSell.Text = "Sell Tickets"
        Me.btnSell.UseVisualStyleBackColor = False
        '
        'picTickets
        '
        Me.picTickets.Image = Global.Ticket_Seller.My.Resources.Resources.tickets
        Me.picTickets.Location = New System.Drawing.Point(150, 84)
        Me.picTickets.Name = "picTickets"
        Me.picTickets.Size = New System.Drawing.Size(215, 214)
        Me.picTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTickets.TabIndex = 2
        Me.picTickets.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gobold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(156, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 41)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Ticket Seller"
        '
        'frmTicketSeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(513, 428)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.picTickets)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTicketSeller"
        Me.Text = "Ticket Seller"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuTickets As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents btnSetup As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents mnuWeekly As ToolStripMenuItem
    Friend WithEvents mnuDaily As ToolStripMenuItem
    Friend WithEvents mnuSetup As ToolStripMenuItem
    Friend WithEvents mnuSell As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picTickets As PictureBox
    Friend WithEvents lblTitle As Label
End Class
