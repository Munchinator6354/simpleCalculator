<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtNumber1Input = New System.Windows.Forms.TextBox()
        Me.txtNumber2Input = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNumber1Text = New System.Windows.Forms.Label()
        Me.lblNumber2Text = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpArithmetic = New System.Windows.Forms.GroupBox()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblEqualsSign = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.grpArithmetic.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(2, 1)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(203, 51)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise #8 - Simple Calculator"
        '
        'txtNumber1Input
        '
        Me.txtNumber1Input.Location = New System.Drawing.Point(75, 177)
        Me.txtNumber1Input.Name = "txtNumber1Input"
        Me.txtNumber1Input.Size = New System.Drawing.Size(92, 22)
        Me.txtNumber1Input.TabIndex = 1
        '
        'txtNumber2Input
        '
        Me.txtNumber2Input.Location = New System.Drawing.Point(221, 177)
        Me.txtNumber2Input.Name = "txtNumber2Input"
        Me.txtNumber2Input.Size = New System.Drawing.Size(92, 22)
        Me.txtNumber2Input.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(61, 357)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(199, 65)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(302, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 65)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(533, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(194, 65)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNumber1Text
        '
        Me.lblNumber1Text.AutoSize = True
        Me.lblNumber1Text.Location = New System.Drawing.Point(84, 142)
        Me.lblNumber1Text.Name = "lblNumber1Text"
        Me.lblNumber1Text.Size = New System.Drawing.Size(70, 17)
        Me.lblNumber1Text.TabIndex = 6
        Me.lblNumber1Text.Text = "Number 1"
        '
        'lblNumber2Text
        '
        Me.lblNumber2Text.AutoSize = True
        Me.lblNumber2Text.Location = New System.Drawing.Point(230, 142)
        Me.lblNumber2Text.Name = "lblNumber2Text"
        Me.lblNumber2Text.Size = New System.Drawing.Size(70, 17)
        Me.lblNumber2Text.TabIndex = 7
        Me.lblNumber2Text.Text = "Number 2"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(69, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(646, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "The Amazing Complex Computation Calculator!!!!!"
        '
        'grpArithmetic
        '
        Me.grpArithmetic.Controls.Add(Me.radDivision)
        Me.grpArithmetic.Controls.Add(Me.radMultiplication)
        Me.grpArithmetic.Controls.Add(Me.radSubtraction)
        Me.grpArithmetic.Controls.Add(Me.radAddition)
        Me.grpArithmetic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpArithmetic.Location = New System.Drawing.Point(533, 131)
        Me.grpArithmetic.Name = "grpArithmetic"
        Me.grpArithmetic.Size = New System.Drawing.Size(139, 186)
        Me.grpArithmetic.TabIndex = 9
        Me.grpArithmetic.TabStop = False
        Me.grpArithmetic.Text = "Arithmetic"
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAddition.Location = New System.Drawing.Point(18, 29)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(80, 21)
        Me.radAddition.TabIndex = 0
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "Addition"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSubtraction.Location = New System.Drawing.Point(18, 65)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(101, 21)
        Me.radSubtraction.TabIndex = 1
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "Subtraction"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMultiplication.Location = New System.Drawing.Point(18, 102)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(110, 21)
        Me.radMultiplication.TabIndex = 2
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "Multiplication"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDivision.Location = New System.Drawing.Point(18, 144)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(78, 21)
        Me.radDivision.TabIndex = 3
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "Division"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(186, 180)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(19, 17)
        Me.lblOperator.TabIndex = 10
        Me.lblOperator.Text = "O"
        '
        'lblEqualsSign
        '
        Me.lblEqualsSign.AutoSize = True
        Me.lblEqualsSign.Location = New System.Drawing.Point(338, 180)
        Me.lblEqualsSign.Name = "lblEqualsSign"
        Me.lblEqualsSign.Size = New System.Drawing.Size(16, 17)
        Me.lblEqualsSign.TabIndex = 11
        Me.lblEqualsSign.Text = "="
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(394, 180)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(54, 17)
        Me.lblAnswer.TabIndex = 12
        Me.lblAnswer.Text = "Answer"
        '
        'frmSimpleCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblEqualsSign)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.grpArithmetic)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblNumber2Text)
        Me.Controls.Add(Me.lblNumber1Text)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumber2Input)
        Me.Controls.Add(Me.txtNumber1Input)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmSimpleCalculator"
        Me.Text = "Simple Calculator"
        Me.grpArithmetic.ResumeLayout(False)
        Me.grpArithmetic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtNumber1Input As TextBox
    Friend WithEvents txtNumber2Input As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNumber1Text As Label
    Friend WithEvents lblNumber2Text As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpArithmetic As GroupBox
    Friend WithEvents radDivision As RadioButton
    Friend WithEvents radMultiplication As RadioButton
    Friend WithEvents radSubtraction As RadioButton
    Friend WithEvents radAddition As RadioButton
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblEqualsSign As Label
    Friend WithEvents lblAnswer As Label
End Class
