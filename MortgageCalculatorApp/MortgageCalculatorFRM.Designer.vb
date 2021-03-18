<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MortgageCalculatorFRM
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
        Me.loanDataGBX = New System.Windows.Forms.GroupBox()
        Me.interestTB = New System.Windows.Forms.TextBox()
        Me.amountTB = New System.Windows.Forms.TextBox()
        Me.interestRateLBL = New System.Windows.Forms.Label()
        Me.mortgageAountLBL = New System.Windows.Forms.Label()
        Me.titleLBL = New System.Windows.Forms.Label()
        Me.monthlyPmtsLBL = New System.Windows.Forms.Label()
        Me.TermOptions = New System.Windows.Forms.GroupBox()
        Me.TenYrCB = New System.Windows.Forms.CheckBox()
        Me.FiveYrCB = New System.Windows.Forms.CheckBox()
        Me.fiftyYrCB = New System.Windows.Forms.CheckBox()
        Me.twentyfYrCB = New System.Windows.Forms.CheckBox()
        Me.ResultTB = New System.Windows.Forms.TextBox()
        Me.CalcBTN = New System.Windows.Forms.Button()
        Me.loanDataGBX.SuspendLayout()
        Me.TermOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'loanDataGBX
        '
        Me.loanDataGBX.Controls.Add(Me.interestTB)
        Me.loanDataGBX.Controls.Add(Me.amountTB)
        Me.loanDataGBX.Controls.Add(Me.interestRateLBL)
        Me.loanDataGBX.Controls.Add(Me.mortgageAountLBL)
        Me.loanDataGBX.Location = New System.Drawing.Point(25, 51)
        Me.loanDataGBX.Name = "loanDataGBX"
        Me.loanDataGBX.Size = New System.Drawing.Size(223, 114)
        Me.loanDataGBX.TabIndex = 0
        Me.loanDataGBX.TabStop = False
        Me.loanDataGBX.Text = "Loan Data:"
        '
        'interestTB
        '
        Me.interestTB.Location = New System.Drawing.Point(160, 72)
        Me.interestTB.Name = "interestTB"
        Me.interestTB.Size = New System.Drawing.Size(44, 26)
        Me.interestTB.TabIndex = 3
        Me.interestTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'amountTB
        '
        Me.amountTB.Location = New System.Drawing.Point(119, 34)
        Me.amountTB.Name = "amountTB"
        Me.amountTB.Size = New System.Drawing.Size(85, 26)
        Me.amountTB.TabIndex = 2
        Me.amountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'interestRateLBL
        '
        Me.interestRateLBL.AutoSize = True
        Me.interestRateLBL.Location = New System.Drawing.Point(19, 75)
        Me.interestRateLBL.Name = "interestRateLBL"
        Me.interestRateLBL.Size = New System.Drawing.Size(132, 20)
        Me.interestRateLBL.TabIndex = 1
        Me.interestRateLBL.Text = "Interest rate (%): "
        '
        'mortgageAountLBL
        '
        Me.mortgageAountLBL.AutoSize = True
        Me.mortgageAountLBL.Location = New System.Drawing.Point(19, 37)
        Me.mortgageAountLBL.Name = "mortgageAountLBL"
        Me.mortgageAountLBL.Size = New System.Drawing.Size(69, 20)
        Me.mortgageAountLBL.TabIndex = 0
        Me.mortgageAountLBL.Text = "Amount:"
        '
        'titleLBL
        '
        Me.titleLBL.AutoSize = True
        Me.titleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLBL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.titleLBL.Location = New System.Drawing.Point(127, 13)
        Me.titleLBL.Name = "titleLBL"
        Me.titleLBL.Size = New System.Drawing.Size(230, 29)
        Me.titleLBL.TabIndex = 2
        Me.titleLBL.Text = "Mortgage Calculator"
        '
        'monthlyPmtsLBL
        '
        Me.monthlyPmtsLBL.AutoSize = True
        Me.monthlyPmtsLBL.Location = New System.Drawing.Point(268, 56)
        Me.monthlyPmtsLBL.Name = "monthlyPmtsLBL"
        Me.monthlyPmtsLBL.Size = New System.Drawing.Size(142, 20)
        Me.monthlyPmtsLBL.TabIndex = 4
        Me.monthlyPmtsLBL.Text = "Monthly Payments:"
        '
        'TermOptions
        '
        Me.TermOptions.Controls.Add(Me.TenYrCB)
        Me.TermOptions.Controls.Add(Me.FiveYrCB)
        Me.TermOptions.Controls.Add(Me.fiftyYrCB)
        Me.TermOptions.Controls.Add(Me.twentyfYrCB)
        Me.TermOptions.Location = New System.Drawing.Point(25, 179)
        Me.TermOptions.Name = "TermOptions"
        Me.TermOptions.Size = New System.Drawing.Size(223, 113)
        Me.TermOptions.TabIndex = 5
        Me.TermOptions.TabStop = False
        Me.TermOptions.Text = "Term Options"
        '
        'TenYrCB
        '
        Me.TenYrCB.AutoSize = True
        Me.TenYrCB.Location = New System.Drawing.Point(7, 72)
        Me.TenYrCB.Name = "TenYrCB"
        Me.TenYrCB.Size = New System.Drawing.Size(92, 24)
        Me.TenYrCB.TabIndex = 3
        Me.TenYrCB.Text = "10 Years"
        Me.TenYrCB.UseVisualStyleBackColor = True
        '
        'FiveYrCB
        '
        Me.FiveYrCB.AutoSize = True
        Me.FiveYrCB.Location = New System.Drawing.Point(7, 36)
        Me.FiveYrCB.Name = "FiveYrCB"
        Me.FiveYrCB.Size = New System.Drawing.Size(79, 24)
        Me.FiveYrCB.TabIndex = 2
        Me.FiveYrCB.Text = "5 years"
        Me.FiveYrCB.UseVisualStyleBackColor = True
        '
        'fiftyYrCB
        '
        Me.fiftyYrCB.AutoSize = True
        Me.fiftyYrCB.Location = New System.Drawing.Point(107, 72)
        Me.fiftyYrCB.Name = "fiftyYrCB"
        Me.fiftyYrCB.Size = New System.Drawing.Size(92, 24)
        Me.fiftyYrCB.TabIndex = 1
        Me.fiftyYrCB.Text = "50 Years"
        Me.fiftyYrCB.UseVisualStyleBackColor = True
        '
        'twentyfYrCB
        '
        Me.twentyfYrCB.AutoSize = True
        Me.twentyfYrCB.Location = New System.Drawing.Point(107, 36)
        Me.twentyfYrCB.Name = "twentyfYrCB"
        Me.twentyfYrCB.Size = New System.Drawing.Size(88, 24)
        Me.twentyfYrCB.TabIndex = 0
        Me.twentyfYrCB.Text = "25 years"
        Me.twentyfYrCB.UseVisualStyleBackColor = True
        '
        'ResultTB
        '
        Me.ResultTB.Location = New System.Drawing.Point(272, 85)
        Me.ResultTB.Multiline = True
        Me.ResultTB.Name = "ResultTB"
        Me.ResultTB.ReadOnly = True
        Me.ResultTB.Size = New System.Drawing.Size(200, 154)
        Me.ResultTB.TabIndex = 6
        '
        'CalcBTN
        '
        Me.CalcBTN.Location = New System.Drawing.Point(272, 251)
        Me.CalcBTN.Name = "CalcBTN"
        Me.CalcBTN.Size = New System.Drawing.Size(200, 41)
        Me.CalcBTN.TabIndex = 7
        Me.CalcBTN.Text = "Calculate Payments"
        Me.CalcBTN.UseVisualStyleBackColor = True
        '
        'MortgageCalculatorFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 304)
        Me.Controls.Add(Me.CalcBTN)
        Me.Controls.Add(Me.ResultTB)
        Me.Controls.Add(Me.TermOptions)
        Me.Controls.Add(Me.monthlyPmtsLBL)
        Me.Controls.Add(Me.titleLBL)
        Me.Controls.Add(Me.loanDataGBX)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MortgageCalculatorFRM"
        Me.Text = "Mortgage App"
        Me.loanDataGBX.ResumeLayout(False)
        Me.loanDataGBX.PerformLayout()
        Me.TermOptions.ResumeLayout(False)
        Me.TermOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loanDataGBX As GroupBox
    Friend WithEvents interestRateLBL As Label
    Friend WithEvents mortgageAountLBL As Label
    Friend WithEvents titleLBL As Label
    Friend WithEvents interestTB As TextBox
    Friend WithEvents amountTB As TextBox
    Friend WithEvents monthlyPmtsLBL As Label
    Friend WithEvents TermOptions As GroupBox
    Friend WithEvents fiftyYrCB As CheckBox
    Friend WithEvents twentyfYrCB As CheckBox
    Friend WithEvents TenYrCB As CheckBox
    Friend WithEvents FiveYrCB As CheckBox
    Friend WithEvents ResultTB As TextBox
    Friend WithEvents CalcBTN As Button
End Class
