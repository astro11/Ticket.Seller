<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblSellDate = New System.Windows.Forms.Label()
        Me.lblSellTickets = New System.Windows.Forms.Label()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSellTickets = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailable.Location = New System.Drawing.Point(26, 23)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(132, 21)
        Me.lblAvailable.TabIndex = 0
        Me.lblAvailable.Text = "Available Tickets:"
        '
        'lblSellDate
        '
        Me.lblSellDate.AutoSize = True
        Me.lblSellDate.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellDate.Location = New System.Drawing.Point(26, 58)
        Me.lblSellDate.Name = "lblSellDate"
        Me.lblSellDate.Size = New System.Drawing.Size(44, 21)
        Me.lblSellDate.TabIndex = 1
        Me.lblSellDate.Text = "Date:"
        '
        'lblSellTickets
        '
        Me.lblSellTickets.AutoSize = True
        Me.lblSellTickets.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellTickets.Location = New System.Drawing.Point(26, 93)
        Me.lblSellTickets.Name = "lblSellTickets"
        Me.lblSellTickets.Size = New System.Drawing.Size(96, 21)
        Me.lblSellTickets.TabIndex = 2
        Me.lblSellTickets.Text = "Sell Tickets:"
        '
        'lblSale
        '
        Me.lblSale.AutoSize = True
        Me.lblSale.Font = New System.Drawing.Font("Gobold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Location = New System.Drawing.Point(26, 130)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(84, 20)
        Me.lblSale.TabIndex = 4
        Me.lblSale.Text = "Total Sale:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(26, 163)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(158, 21)
        Me.lblDiscount.TabIndex = 5
        Me.lblDiscount.Text = "Group Discount (10%):"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Brown
        Me.btnSubmit.Font = New System.Drawing.Font("Gobold Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Snow
        Me.btnSubmit.Location = New System.Drawing.Point(78, 248)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(90, 41)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(199, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 41)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAvailable
        '
        Me.txtAvailable.Location = New System.Drawing.Point(208, 24)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(100, 20)
        Me.txtAvailable.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = ""
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(208, 58)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDate.TabIndex = 9
        '
        'txtSellTickets
        '
        Me.txtSellTickets.Location = New System.Drawing.Point(208, 93)
        Me.txtSellTickets.Name = "txtSellTickets"
        Me.txtSellTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtSellTickets.TabIndex = 10
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(208, 130)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(100, 20)
        Me.txtSale.TabIndex = 12
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(208, 163)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 13
        '
        'frmSell
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(360, 301)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSellTickets)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.lblSellTickets)
        Me.Controls.Add(Me.lblSellDate)
        Me.Controls.Add(Me.lblAvailable)
        Me.Name = "frmSell"
        Me.Text = "Sell Sub System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAvailable As Label
    Friend WithEvents lblSellDate As Label
    Friend WithEvents lblSellTickets As Label
    Friend WithEvents lblSale As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtSellTickets As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents txtDiscount As TextBox
End Class
