<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDIT
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
        Me.State = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboLoad = New System.Windows.Forms.ComboBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadNo = New System.Windows.Forms.RadioButton()
        Me.RadYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(22, 19)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(32, 13)
        Me.State.TabIndex = 0
        Me.State.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(114, 12)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(48, 53)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboLoad
        '
        Me.cboLoad.FormattingEnabled = True
        Me.cboLoad.Location = New System.Drawing.Point(93, 82)
        Me.cboLoad.Name = "cboLoad"
        Me.cboLoad.Size = New System.Drawing.Size(121, 21)
        Me.cboLoad.TabIndex = 3
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(129, 53)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(118, 23)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change state"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadYes)
        Me.GroupBox1.Controls.Add(Me.RadNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 87)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "APPEAL"
        '
        'RadNo
        '
        Me.RadNo.AutoSize = True
        Me.RadNo.Location = New System.Drawing.Point(3, 16)
        Me.RadNo.Name = "RadNo"
        Me.RadNo.Size = New System.Drawing.Size(39, 17)
        Me.RadNo.TabIndex = 2
        Me.RadNo.TabStop = True
        Me.RadNo.Text = "No"
        Me.RadNo.UseVisualStyleBackColor = True
        '
        'RadYes
        '
        Me.RadYes.AutoSize = True
        Me.RadYes.Location = New System.Drawing.Point(3, 49)
        Me.RadYes.Name = "RadYes"
        Me.RadYes.Size = New System.Drawing.Size(43, 17)
        Me.RadYes.TabIndex = 3
        Me.RadYes.TabStop = True
        Me.RadYes.Text = "Yes"
        Me.RadYes.UseVisualStyleBackColor = True
        '
        'EDIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 222)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.cboLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.State)
        Me.Name = "EDIT"
        Me.Text = "EDIT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents State As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cboLoad As System.Windows.Forms.ComboBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadYes As System.Windows.Forms.RadioButton
    Friend WithEvents RadNo As System.Windows.Forms.RadioButton
End Class
