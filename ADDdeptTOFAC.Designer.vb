<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDdeptTOFAC
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
        Me.cboFac = New System.Windows.Forms.ComboBox()
        Me.cboDep = New System.Windows.Forms.ComboBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboFac
        '
        Me.cboFac.FormattingEnabled = True
        Me.cboFac.Location = New System.Drawing.Point(12, 25)
        Me.cboFac.Name = "cboFac"
        Me.cboFac.Size = New System.Drawing.Size(121, 21)
        Me.cboFac.TabIndex = 0
        '
        'cboDep
        '
        Me.cboDep.FormattingEnabled = True
        Me.cboDep.Location = New System.Drawing.Point(149, 25)
        Me.cboDep.Name = "cboDep"
        Me.cboDep.Size = New System.Drawing.Size(121, 21)
        Me.cboDep.TabIndex = 1
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(99, 72)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(75, 23)
        Me.btnADD.TabIndex = 2
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Faculty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Department"
        '
        'ADDdeptTOFAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 107)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.cboDep)
        Me.Controls.Add(Me.cboFac)
        Me.Name = "ADDdeptTOFAC"
        Me.Text = "ADDdeptTOFAC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFac As System.Windows.Forms.ComboBox
    Friend WithEvents cboDep As System.Windows.Forms.ComboBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
