<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.cmbStdNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNameSur = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkJune = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbStdNo
        '
        Me.cmbStdNo.FormattingEnabled = True
        Me.cmbStdNo.Location = New System.Drawing.Point(174, 12)
        Me.cmbStdNo.Name = "cmbStdNo"
        Me.cmbStdNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbStdNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Numer"
        '
        'cmbNameSur
        '
        Me.cmbNameSur.FormattingEnabled = True
        Me.cmbNameSur.Location = New System.Drawing.Point(174, 50)
        Me.cmbNameSur.Name = "cmbNameSur"
        Me.cmbNameSur.Size = New System.Drawing.Size(121, 21)
        Me.cmbNameSur.TabIndex = 4
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(174, 92)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 5
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(220, 175)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Payed"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Months"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Student Name and Surname"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(174, 132)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(121, 20)
        Me.txtMoney.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Money"
        '
        'chkJune
        '
        Me.chkJune.AutoSize = True
        Me.chkJune.Location = New System.Drawing.Point(23, 166)
        Me.chkJune.Name = "chkJune"
        Me.chkJune.Size = New System.Drawing.Size(78, 17)
        Me.chkJune.TabIndex = 11
        Me.chkJune.Text = "June Exam"
        Me.chkJune.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 210)
        Me.Controls.Add(Me.chkJune)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbNameSur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStdNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStdNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNameSur As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkJune As System.Windows.Forms.CheckBox
End Class
