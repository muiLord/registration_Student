'Public Class ADDdeptTOFAC
'    Dim bclass As New BusinessClass
'    Dim result As String
'    Dim ds As New DataSet
'    'Private Sub ADDdeptTOFAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    '    Dim dsF As New DataSet
'    '    Dim dsD As New DataSet
'    '    result = bclass.getConnection()
'    '    If result = "true" Then


'    '        dsF = bclass.getFac_id()
'    '        dsD = bclass.getDept_Id()
'    '        For i As Integer = 0 To dsF.Tables("fac").Rows.Count - 1
'    '            cboFac.Items.Add(dsF.Tables("fac").Rows(i)!ID)
'    '        Next
'    '        For i As Integer = 0 To dsD.Tables("dept").Rows.Count - 1
'    '            cboDep.Items.Add(dsD.Tables("dept").Rows(i)!ID)
'    '        Next
'    '    Else
'    '        MessageBox.Show(result, "error has occured in connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    '        Return
'    '    End If
'    'End Sub

'    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
'        Dim RESULT As String
'        RESULT = bclass.Adding(cboFac.SelectedItem, cboDep.SelectedItem)
'        If RESULT = "true" Then
'            MessageBox.Show("saved successfully", "details has been updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        Else
'            MessageBox.Show(RESULT, "error occured when adding details", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End If
'    End Sub
'End Class