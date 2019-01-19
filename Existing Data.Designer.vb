<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Existing_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Existing_Data))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.dgvStdDetails = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSubject = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDeleteStdN = New System.Windows.Forms.Button()
        Me.btnDeleteID = New System.Windows.Forms.Button()
        CType(Me.dgvStdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Number"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(120, 76)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'dgvStdDetails
        '
        Me.dgvStdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStdDetails.Location = New System.Drawing.Point(12, 195)
        Me.dgvStdDetails.Name = "dgvStdDetails"
        Me.dgvStdDetails.Size = New System.Drawing.Size(561, 150)
        Me.dgvStdDetails.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Student Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Subject of Student"
        '
        'dgvSubject
        '
        Me.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubject.Location = New System.Drawing.Point(15, 425)
        Me.dgvSubject.Name = "dgvSubject"
        Me.dgvSubject.Size = New System.Drawing.Size(558, 150)
        Me.dgvSubject.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(498, 603)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDeleteStdN
        '
        Me.btnDeleteStdN.Location = New System.Drawing.Point(16, 123)
        Me.btnDeleteStdN.Name = "btnDeleteStdN"
        Me.btnDeleteStdN.Size = New System.Drawing.Size(183, 23)
        Me.btnDeleteStdN.TabIndex = 9
        Me.btnDeleteStdN.Text = "Delete Student By Student Number"
        Me.btnDeleteStdN.UseVisualStyleBackColor = True
        '
        'btnDeleteID
        '
        Me.btnDeleteID.Location = New System.Drawing.Point(205, 123)
        Me.btnDeleteID.Name = "btnDeleteID"
        Me.btnDeleteID.Size = New System.Drawing.Size(143, 23)
        Me.btnDeleteID.TabIndex = 10
        Me.btnDeleteID.Text = "Delete Student By ID Number"
        Me.btnDeleteID.UseVisualStyleBackColor = True
        '
        'Existing_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 638)
        Me.Controls.Add(Me.btnDeleteID)
        Me.Controls.Add(Me.btnDeleteStdN)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvSubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvStdDetails)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Existing_Data"
        Me.Text = "Existing_Data"
        CType(Me.dgvStdDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents dgvStdDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvSubject As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStdN As System.Windows.Forms.Button
    Friend WithEvents btnDeleteID As System.Windows.Forms.Button
End Class
