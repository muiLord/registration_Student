Public Class VERIFY
    Dim bclass As New BusinessClass
    Dim result As String
    Dim ds As New DataSet

    Private Sub VERIFY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = bclass.getConnection()
        If result = "true" Then
            'ds = bclass.getAllDetails()
            For i As Integer = 0 To ds.Tables("AllDetails").Rows.Count - 1
                cboStud.Items.Add(ds.Tables("AllDetails").Rows(i)!Student_No)
            Next
        End If
    End Sub

    'Private Sub btnVeri_Click(sender As Object, e As EventArgs) Handles btnVeri.Click
    '    Dim ds As New DataSet
    '    Dim gdate As String
    '    Dim dsS As New DataSet
    '    dsS = bclass.getSearchD(txtSt.Text)
    '    dgvDisplay.DataSource = ds.Tables("st")
    '    ds = bclass.getAllDetails()
    '    Dim hold, hold1 As Integer
    '    Dim diff As Integer
    '    gdate = Today
    '    hold = cboStud.SelectedItem.Substring(1, 2)
    '    hold1 = gdate.Substring(2, 2)
    '    diff = hold1 - hold

    '    If diff > 4 Then
    '        txtState.Text = "3"
    '    End If
    '    result = bclass.getConnection()
    '    If result = "true" Then


    '        'Else
    '        '    MessageBox.Show(result, "ERROR HAS OCCURED IN connection PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If


    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' result = bclass.Update(txtState.Text, cboStud.Text)
        If result = "true" Then
            MessageBox.Show("successfully saved", "STATE HAS BEEN UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(result, "ERROR HAS OCCURED IN UPDATE PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtState.Text = result

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim DC As New DataSet
        result = bclass.getConnection()
        If result = "true" Then
            'DC = bclass.getSearchD(txtSt.Text)
            dgvDisplay.DataSource = DC.Tables("st")
        End If
    End Sub
End Class