<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDownPayment = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblNumYears = New System.Windows.Forms.Label()
        Me.lstAmounts = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(1, -3)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(800, 453)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(212, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Home Down Payment"
        '
        'lblDownPayment
        '
        Me.lblDownPayment.AutoSize = True
        Me.lblDownPayment.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownPayment.Location = New System.Drawing.Point(37, 73)
        Me.lblDownPayment.Name = "lblDownPayment"
        Me.lblDownPayment.Size = New System.Drawing.Size(268, 38)
        Me.lblDownPayment.TabIndex = 2
        Me.lblDownPayment.Text = "Down Payment"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(37, 132)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(241, 38)
        Me.lblInterestRate.TabIndex = 3
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblNumYears
        '
        Me.lblNumYears.AutoSize = True
        Me.lblNumYears.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumYears.Location = New System.Drawing.Point(37, 190)
        Me.lblNumYears.Name = "lblNumYears"
        Me.lblNumYears.Size = New System.Drawing.Size(293, 38)
        Me.lblNumYears.TabIndex = 4
        Me.lblNumYears.Text = "Number of Years"
        '
        'lstAmounts
        '
        Me.lstAmounts.FormattingEnabled = True
        Me.lstAmounts.Location = New System.Drawing.Point(607, 75)
        Me.lstAmounts.Name = "lstAmounts"
        Me.lstAmounts.Size = New System.Drawing.Size(158, 251)
        Me.lstAmounts.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(75, 261)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(172, 65)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownPayment.Location = New System.Drawing.Point(336, 79)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(100, 32)
        Me.txtDownPayment.TabIndex = 7
        '
        'txtInt
        '
        Me.txtInt.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInt.Location = New System.Drawing.Point(336, 132)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(100, 32)
        Me.txtInt.TabIndex = 8
        '
        'txtYears
        '
        Me.txtYears.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYears.Location = New System.Drawing.Point(336, 190)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 32)
        Me.txtYears.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.txtDownPayment)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstAmounts)
        Me.Controls.Add(Me.lblNumYears)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblDownPayment)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmMain"
        Me.Text = "Home Down Payment"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDownPayment As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblNumYears As Label
    Friend WithEvents lstAmounts As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents txtInt As TextBox
    Friend WithEvents txtYears As TextBox
End Class
