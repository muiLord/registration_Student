<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.cboDisplay = New System.Windows.Forms.ComboBox()
        Me.m = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(12, 107)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(590, 150)
        Me.dgvDisplay.TabIndex = 0
        '
        'cboDisplay
        '
        Me.cboDisplay.FormattingEnabled = True
        Me.cboDisplay.Location = New System.Drawing.Point(199, 46)
        Me.cboDisplay.Name = "cboDisplay"
        Me.cboDisplay.Size = New System.Drawing.Size(184, 21)
        Me.cboDisplay.TabIndex = 2
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Location = New System.Drawing.Point(90, 54)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(89, 13)
        Me.m.TabIndex = 3
        Me.m.Text = "Student Numbers"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 381)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.cboDisplay)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Name = "Search"
        Me.Text = "Search"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents cboDisplay As System.Windows.Forms.ComboBox
    Friend WithEvents m As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
