<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblOT = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblAllowance1 = New System.Windows.Forms.Label()
        Me.lblAllowance2 = New System.Windows.Forms.Label()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.txtOTHours = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtOTRate = New System.Windows.Forms.TextBox()
        Me.txtAllowance1 = New System.Windows.Forms.TextBox()
        Me.txtAllowance2 = New System.Windows.Forms.TextBox()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.btnCalculater = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBasicSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasicSalary.Location = New System.Drawing.Point(26, 24)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(122, 20)
        Me.lblBasicSalary.TabIndex = 0
        Me.lblBasicSalary.Text = "Basic Salary:"
        '
        'lblOT
        '
        Me.lblOT.AutoSize = True
        Me.lblOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOT.Location = New System.Drawing.Point(32, 74)
        Me.lblOT.Name = "lblOT"
        Me.lblOT.Size = New System.Drawing.Size(97, 20)
        Me.lblOT.TabIndex = 1
        Me.lblOT.Text = "OT Hours:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(32, 121)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(92, 20)
        Me.lblSex.TabIndex = 2
        Me.lblSex.Text = "Sex(M/F):"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOR.Location = New System.Drawing.Point(32, 180)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(85, 20)
        Me.lblOR.TabIndex = 3
        Me.lblOR.Text = "OT Rate:"
        '
        'lblAllowance1
        '
        Me.lblAllowance1.AutoSize = True
        Me.lblAllowance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAllowance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllowance1.Location = New System.Drawing.Point(32, 237)
        Me.lblAllowance1.Name = "lblAllowance1"
        Me.lblAllowance1.Size = New System.Drawing.Size(116, 20)
        Me.lblAllowance1.TabIndex = 4
        Me.lblAllowance1.Text = "Allowence 1:"
        '
        'lblAllowance2
        '
        Me.lblAllowance2.AutoSize = True
        Me.lblAllowance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAllowance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllowance2.Location = New System.Drawing.Point(32, 295)
        Me.lblAllowance2.Name = "lblAllowance2"
        Me.lblAllowance2.Size = New System.Drawing.Size(116, 20)
        Me.lblAllowance2.TabIndex = 5
        Me.lblAllowance2.Text = "Allowance 2:"
        '
        'lblNetSalary
        '
        Me.lblNetSalary.AutoSize = True
        Me.lblNetSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetSalary.Location = New System.Drawing.Point(32, 343)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(103, 20)
        Me.lblNetSalary.TabIndex = 6
        Me.lblNetSalary.Text = "Net Salary:"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBasicSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasicSalary.Location = New System.Drawing.Point(154, 24)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(316, 27)
        Me.txtBasicSalary.TabIndex = 7
        '
        'txtOTHours
        '
        Me.txtOTHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOTHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTHours.Location = New System.Drawing.Point(154, 74)
        Me.txtOTHours.Name = "txtOTHours"
        Me.txtOTHours.Size = New System.Drawing.Size(316, 27)
        Me.txtOTHours.TabIndex = 8
        '
        'txtSex
        '
        Me.txtSex.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(154, 121)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(316, 27)
        Me.txtSex.TabIndex = 9
        '
        'txtOTRate
        '
        Me.txtOTRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOTRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTRate.Location = New System.Drawing.Point(154, 180)
        Me.txtOTRate.Name = "txtOTRate"
        Me.txtOTRate.Size = New System.Drawing.Size(316, 27)
        Me.txtOTRate.TabIndex = 10
        '
        'txtAllowance1
        '
        Me.txtAllowance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAllowance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllowance1.Location = New System.Drawing.Point(154, 237)
        Me.txtAllowance1.Name = "txtAllowance1"
        Me.txtAllowance1.Size = New System.Drawing.Size(316, 27)
        Me.txtAllowance1.TabIndex = 11
        '
        'txtAllowance2
        '
        Me.txtAllowance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAllowance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllowance2.Location = New System.Drawing.Point(154, 289)
        Me.txtAllowance2.Name = "txtAllowance2"
        Me.txtAllowance2.Size = New System.Drawing.Size(316, 27)
        Me.txtAllowance2.TabIndex = 12
        '
        'txtNetSalary
        '
        Me.txtNetSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSalary.Location = New System.Drawing.Point(154, 343)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.Size = New System.Drawing.Size(316, 27)
        Me.txtNetSalary.TabIndex = 13
        '
        'btnCalculater
        '
        Me.btnCalculater.BackColor = System.Drawing.Color.Cyan
        Me.btnCalculater.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculater.Location = New System.Drawing.Point(179, 410)
        Me.btnCalculater.Name = "btnCalculater"
        Me.btnCalculater.Size = New System.Drawing.Size(245, 130)
        Me.btnCalculater.TabIndex = 14
        Me.btnCalculater.Text = "Calculate"
        Me.btnCalculater.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(137, 560)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 39)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(326, 560)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 39)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 632)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculater)
        Me.Controls.Add(Me.txtNetSalary)
        Me.Controls.Add(Me.txtAllowance2)
        Me.Controls.Add(Me.txtAllowance1)
        Me.Controls.Add(Me.txtOTRate)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtOTHours)
        Me.Controls.Add(Me.txtBasicSalary)
        Me.Controls.Add(Me.lblNetSalary)
        Me.Controls.Add(Me.lblAllowance2)
        Me.Controls.Add(Me.lblAllowance1)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblOT)
        Me.Controls.Add(Me.lblBasicSalary)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblOT As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblOR As Label
    Friend WithEvents lblAllowance1 As Label
    Friend WithEvents lblAllowance2 As Label
    Friend WithEvents lblNetSalary As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtOTHours As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtOTRate As TextBox
    Friend WithEvents txtAllowance1 As TextBox
    Friend WithEvents txtAllowance2 As TextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents btnCalculater As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
