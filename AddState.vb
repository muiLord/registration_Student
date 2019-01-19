'Public Class AddState
'    Dim result As String
'    Dim ds As New DataSet
'    Dim BClass As New BusinessClass

'    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
'        Me.Close()
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnState.Click

'        result = BClass.getConnection
'        If result <> "true" Then
'            MessageBox.Show(result, "Connection to database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End If
'        result = BClass.addState(txtAddState.Text)
'        If result <> "true" Then
'            MessageBox.Show(result, "Error occured when adding department to database", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Else
'            MessageBox.Show("Saved successfully", "The new department has been succefully added", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        End If
'    End Sub

'End Class