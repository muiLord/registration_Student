<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Me.btnState = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.btnDepart = New System.Windows.Forms.Button()
        Me.btnTO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnState
        '
        Me.btnState.Location = New System.Drawing.Point(88, 62)
        Me.btnState.Name = "btnState"
        Me.btnState.Size = New System.Drawing.Size(75, 23)
        Me.btnState.TabIndex = 0
        Me.btnState.Text = "Add state"
        Me.btnState.UseVisualStyleBackColor = True
        '
        'btnFaculty
        '
        Me.btnFaculty.Location = New System.Drawing.Point(88, 111)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnFaculty.TabIndex = 1
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.UseVisualStyleBackColor = True
        '
        'btnDepart
        '
        Me.btnDepart.Location = New System.Drawing.Point(88, 155)
        Me.btnDepart.Name = "btnDepart"
        Me.btnDepart.Size = New System.Drawing.Size(75, 23)
        Me.btnDepart.TabIndex = 2
        Me.btnDepart.Text = "Department"
        Me.btnDepart.UseVisualStyleBackColor = True
        '
        'btnTO
        '
        Me.btnTO.Location = New System.Drawing.Point(60, 22)
        Me.btnTO.Name = "btnTO"
        Me.btnTO.Size = New System.Drawing.Size(131, 23)
        Me.btnTO.TabIndex = 3
        Me.btnTO.Text = "TO FACULTY"
        Me.btnTO.UseVisualStyleBackColor = True
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 195)
        Me.Controls.Add(Me.btnTO)
        Me.Controls.Add(Me.btnDepart)
        Me.Controls.Add(Me.btnFaculty)
        Me.Controls.Add(Me.btnState)
        Me.Name = "ADMIN"
        Me.Text = "ADMIN"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnState As System.Windows.Forms.Button
    Friend WithEvents btnFaculty As System.Windows.Forms.Button
    Friend WithEvents btnDepart As System.Windows.Forms.Button
    Friend WithEvents btnTO As System.Windows.Forms.Button
End Class
