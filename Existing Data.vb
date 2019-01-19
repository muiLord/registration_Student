Public Class Existing_Data
    Dim result As String
    Dim ds As New DataSet
    Dim BClass As New BusinessClass

    Private Sub Existing_Data_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AddForm.Show()
        Me.Dispose()
    End Sub
    Private Sub Existing_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = BClass.getConnection()
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        displayCombos()
        
        ds = BClass.getAllStudentDetails()
        dgvStdDetails.DataSource = ds.Tables("AllStdDetails")

        ds = BClass.getAllSubjectDetails()
        dgvSubject.DataSource = ds.Tables("AllSubjDetail")
    End Sub
    Sub displayCombos()
        ds = BClass.getIdNumberandStdNo()
        For i = 0 To ds.Tables("id").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("id").Rows(i)!Student_No)
            ComboBox2.Items.Add(ds.Tables("id").Rows(i)!ID_number)
        Next
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AddForm.Show()
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds = BClass.getAllStudentDetailsByStdNo(ComboBox1.SelectedItem)
        dgvStdDetails.DataSource = ds.Tables("AllStdDetailsByStdNo")

        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex

        ds = BClass.getAllSubjectDetailsByStdNo(ComboBox1.SelectedItem)

        dgvSubject.DataSource = ds.Tables("AllSubjDetails")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ds = BClass.getAllStudentDetailsByStdNo(ComboBox2.SelectedItem)
        dgvStdDetails.DataSource = ds.Tables("AllStdDetailsByStdNo")

        ComboBox1.SelectedIndex = ComboBox2.SelectedIndex

        ds = BClass.getAllSubjectDetailsByStdNo(ComboBox1.SelectedItem)

        dgvSubject.DataSource = ds.Tables("AllSubjDetails")
    End Sub

    Private Sub btnDeleteStdN_Click(sender As Object, e As EventArgs) Handles btnDeleteStdN.Click
        Dim result As String = BClass.Delete_Std_DetByID_OR_Std(ComboBox1.SelectedItem)
        ds = BClass.getAllStudentDetails()
        dgvStdDetails.DataSource = ds.Tables("AllStdDetails")

        result = BClass.Delete_Subj_ByStd(ComboBox1.SelectedItem)
        ds = BClass.getAllSubjectDetails()
        dgvSubject.DataSource = ds.Tables("AllSubjDetail")
    End Sub

    Private Sub btnDeleteID_Click(sender As Object, e As EventArgs) Handles btnDeleteID.Click
        Dim result As String = BClass.Delete_Std_DetByID_OR_Std(ComboBox2.SelectedItem)
        ds = BClass.getAllStudentDetails()
        dgvStdDetails.DataSource = ds.Tables("AllStdDetails")

        result = BClass.Delete_Subj_ByStd(ComboBox1.SelectedItem)
        ds = BClass.getAllSubjectDetails()
        dgvSubject.DataSource = ds.Tables("AllSubjDetail")
    End Sub
End Class