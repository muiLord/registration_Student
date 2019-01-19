<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VERIFY
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnVeri = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStud = New System.Windows.Forms.ComboBox()
        Me.txtSt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 172)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnVeri
        '
        Me.btnVeri.Location = New System.Drawing.Point(113, 172)
        Me.btnVeri.Name = "btnVeri"
        Me.btnVeri.Size = New System.Drawing.Size(75, 23)
        Me.btnVeri.TabIndex = 1
        Me.btnVeri.Text = "VERIFY"
        Me.btnVeri.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(248, 172)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(55, 77)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(240, 74)
        Me.dgvDisplay.TabIndex = 3
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(113, 32)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "State"
        '
        'cboStud
        '
        Me.cboStud.FormattingEnabled = True
        Me.cboStud.Location = New System.Drawing.Point(260, 29)
        Me.cboStud.Name = "cboStud"
        Me.cboStud.Size = New System.Drawing.Size(121, 21)
        Me.cboStud.TabIndex = 6
        '
        'txtSt
        '
        Me.txtSt.Location = New System.Drawing.Point(318, 131)
        Me.txtSt.Name = "txtSt"
        Me.txtSt.Size = New System.Drawing.Size(100, 20)
        Me.txtSt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'VERIFY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSt)
        Me.Controls.Add(Me.cboStud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnVeri)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "VERIFY"
        Me.Text = "VERIFY"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnVeri As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStud As System.Windows.Forms.ComboBox
    Friend WithEvents txtSt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
