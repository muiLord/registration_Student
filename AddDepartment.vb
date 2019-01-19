'Public Class AddDepartment
'    Dim result As String
'    Dim BClass As New BusinessClass
'    Dim ds As New DataSet


'    Private Sub btnAddDepart_Click(sender As Object, e As EventArgs) Handles btnAddDepart.Click
'        result = BClass.getConnection
'        If result <> "true" Then
'            MessageBox.Show(result, "Connection to database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End If
'        result = BClass.addDept(txtAddDepartment.Text)
'        If result <> "true" Then
'            MessageBox.Show(result, "Error occured when adding department to database", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Else
'            MessageBox.Show("Saved successfully", "The new department has been succefully added", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        End If
'    End Sub
'End Class