<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetup
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPrices = New System.Windows.Forms.TextBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(56, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(107, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name of Game:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(56, 76)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 21)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrices.Location = New System.Drawing.Point(56, 153)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(49, 21)
        Me.lblPrices.TabIndex = 2
        Me.lblPrices.Text = "Price:"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.Location = New System.Drawing.Point(56, 113)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(52, 21)
        Me.lblSeats.TabIndex = 3
        Me.lblSeats.Text = "Seats:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Brown
        Me.btnSubmit.Font = New System.Drawing.Font("Gobold Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Snow
        Me.btnSubmit.Location = New System.Drawing.Point(73, 214)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 34)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Gobold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(217, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = ""
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(185, 76)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDate.TabIndex = 7
        Me.dtpDate.Value = New Date(2016, 6, 12, 3, 19, 56, 0)
        '
        'txtPrices
        '
        Me.txtPrices.Location = New System.Drawing.Point(185, 153)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.Size = New System.Drawing.Size(100, 20)
        Me.txtPrices.TabIndex = 8
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(185, 113)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(100, 20)
        Me.txtSeats.TabIndex = 9
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Items.AddRange(New Object() {"Thunder vs Celtics", "Heat vs Bulls", "Lakers vs Raptors", "Warriors vs Cavaliers"})
        Me.cboName.Location = New System.Drawing.Point(185, 39)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(100, 21)
        Me.cboName.TabIndex = 10
        Me.cboName.Text = "Select a Game:"
        '
        'frmSetup
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(344, 263)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.txtPrices)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.lblPrices)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmSetup"
        Me.Text = "Setup Sub System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPrices As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtPrices As TextBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents cboName As ComboBox
End Class
