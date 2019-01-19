<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartment
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
        Me.btnAddDepart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddDepartment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAddDepart
        '
        Me.btnAddDepart.Location = New System.Drawing.Point(28, 104)
        Me.btnAddDepart.Name = "btnAddDepart"
        Me.btnAddDepart.Size = New System.Drawing.Size(98, 23)
        Me.btnAddDepart.TabIndex = 0
        Me.btnAddDepart.Text = "Add Department"
        Me.btnAddDepart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add department"
        '
        'txtAddDepartment
        '
        Me.txtAddDepartment.Location = New System.Drawing.Point(139, 43)
        Me.txtAddDepartment.Name = "txtAddDepartment"
        Me.txtAddDepartment.Size = New System.Drawing.Size(100, 20)
        Me.txtAddDepartment.TabIndex = 3
        '
        'AddDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 141)
        Me.Controls.Add(Me.txtAddDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddDepart)
        Me.Name = "AddDepartment"
        Me.Text = "AddDepartment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddDepart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddDepartment As System.Windows.Forms.TextBox
End Class
