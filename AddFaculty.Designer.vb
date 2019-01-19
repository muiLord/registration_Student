<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFaculty
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddFaculty = New System.Windows.Forms.TextBox()
        Me.btnAddFaculty = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add faculty"
        '
        'txtAddFaculty
        '
        Me.txtAddFaculty.Location = New System.Drawing.Point(93, 53)
        Me.txtAddFaculty.Name = "txtAddFaculty"
        Me.txtAddFaculty.Size = New System.Drawing.Size(100, 20)
        Me.txtAddFaculty.TabIndex = 1
        '
        'btnAddFaculty
        '
        Me.btnAddFaculty.Location = New System.Drawing.Point(60, 107)
        Me.btnAddFaculty.Name = "btnAddFaculty"
        Me.btnAddFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFaculty.TabIndex = 2
        Me.btnAddFaculty.Text = "Add Faculty"
        Me.btnAddFaculty.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(161, 107)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AddFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 138)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddFaculty)
        Me.Controls.Add(Me.txtAddFaculty)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddFaculty"
        Me.Text = "AddFaculty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddFaculty As System.Windows.Forms.TextBox
    Friend WithEvents btnAddFaculty As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
