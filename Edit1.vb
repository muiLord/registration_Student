Public Class Edit1
    Dim BClass As New BusinessClass
    Dim result As String
    Dim ds As New DataSet
    Dim dt As New DataTable

    Private Sub Edit1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        AddForm.Show()
    End Sub
    Private Sub Edit1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report1 As New CrystalReport1

        result = BClass.getConnection
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ds = BClass.getAllStudentDetailsByStdNo(AddForm.std)
        dt = ds.Tables("AllStdDetailsByStdNo")
        dt.WriteXml("schema.xml")
        report1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


End Class