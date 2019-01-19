Public Class EDIT
    Dim result As String
    Dim bclass As New BusinessClass
    Dim ds As New DataSet
    Private Sub EDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = bclass.getConnection()
        'ds = bclass.getAllDetails()
        For i As Integer = 0 To ds.Tables("AllDetails").Rows.Count - 1
            cboLoad.Items.Add(ds.Tables("AllDetails").Rows(i)!Student_No)
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Dim gdate As String
        'Dim diff As Integer

        'Dim ds As New DataSet
        'ds = bclass.getAllDetails()
        'Dim hold, hold1 As Integer
        'gdate = Today
        'hold = cboLoad.SelectedItem.Substring(1, 2)
        'hold1 = gdate.Substring(2, 2)
        'diff = hold1 - hold
        'If diff = 4 Then
        '    txtState.Text = "2"
        'End If
        'If diff < 4 Then
        '    txtState.Text = "3"
        'End If
        ' Dim results As String
        result = bclass.getConnection()
        If result <> "true" Then
            MessageBox.Show(result, "Connection to database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'result = bclass.Update(txtState.Text, cboLoad.SelectedItem)
        If result <> "true" Then
            MessageBox.Show(result, "error has occured in update process", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MessageBox.Show("saved successfully", "the details has been updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim gdate As String
        Dim diff As Integer

        Dim ds As New DataSet
        'ds = bclass.getAllDetails()
        Dim hold, hold1 As Integer
        gdate = Today
        hold = cboLoad.SelectedItem.Substring(1, 2)
        hold1 = gdate.Substring(2, 2)
        diff = hold1 - hold
        If diff = 4 Then
            txtState.Text = "2"
        End If
        If diff < 4 Then
            txtState.Text = "3"
        End If
        If diff > 4 Then
            If RadYes.Checked = True Then
                txtState.Text = "4"
            Else
                txtState.Text = "3"
            End If
        End If
    End Sub
End Class