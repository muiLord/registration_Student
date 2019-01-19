Public Class Search
    Dim result As String
    Dim ds As New DataSet
    Dim BClass As New BusinessClass

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = BClass.getConnection()
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ds = BClass.getStudentNos()
        For i = 0 To ds.Tables("stud").Rows.Count - 1
            cboDisplay.Items.Add(ds.Tables("stud").Rows(i)!Student_No)
        Next
    End Sub
    Private Sub cboDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDisplay.SelectedIndexChanged
        ds = BClass.getAllStudentDetailsByStdNo(cboDisplay.SelectedItem)
        If ds.Tables("AllStdDetailsByStdNo").Rows.Count < 1 Then
            MsgBox("The Student Number does not Exist")
            Exit Sub
        End If
        dgvDisplay.DataSource = ds.Tables("AllStdDetailsByStdNo")
    End Sub

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    result = BClass.getConnection
    '    If result = "true" Then
    '        ds = BClass.getDetailsBySearch(txtSurn.Text, txtidNo.Text, txtStud.Text, txtDepart.Text, txtyear.Text)
    '        dgvDisplay.DataSource = ds.Tables("details")
    '    End If
    '    Dim x, y, z As String
    '    For i As Integer = 0 To ds.Tables("details").Rows.Count - 1
    '        x = ds.Tables("details").Rows(i)!surname
    '        y = ds.Tables("details").Rows(i)!Student_No
    '        z = ds.Tables("details").Rows(i)!ID_Number
    '        cboDisplay.Items.Add(x & ":" & y & ":" & z)
    '    Next












    'End Sub



    'Private Sub btnSearchby_Click(sender As Object, e As EventArgs)
    '    If radSurn.Checked = True Then
    '        txtSurn.Enabled = True
    '        txtDepart.Enabled = False
    '        txtyear.Enabled = False
    '        txtStud.Enabled = False
    '        txtidNo.Enabled = False
    '    End If
    '    If radStud.Checked = True Then
    '        txtStud.Enabled = True
    '        txtDepart.Enabled = False
    '        txtyear.Enabled = False
    '        txtSurn.Enabled = False
    '        txtidNo.Enabled = False
    '    End If
    '    If radID.Checked = True Then
    '        txtidNo.Enabled = True
    '        txtDepart.Enabled = False
    '        txtyear.Enabled = False
    '        txtStud.Enabled = False
    '        txtSurn.Enabled = False
    '    End If
    '    If radDep.Checked = True Then
    '        txtDepart.Enabled = True
    '        txtSurn.Enabled = False
    '        txtyear.Enabled = False
    '        txtStud.Enabled = False
    '        txtidNo.Enabled = False
    '    End If
    '    If radYear.Checked = True Then
    '        txtyear.Enabled = True
    '        txtDepart.Enabled = False
    '        txtSurn.Enabled = False
    '        txtStud.Enabled = False
    '        txtidNo.Enabled = False
    '    End If
    'End Sub

End Class