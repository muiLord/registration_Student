Public Class Display
    Dim ds As New DataSet
    Dim result As String
    Dim BClass As New BusinessClass


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtMiddle.TextChanged

    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contain As String
        Dim hold As String
        contain = Search.cboDisplay.Text
        hold = contain.Substring(contain.Length - 15, 9)
        result = BClass.getConnection
        If result = "true" Then
            ' ds = BClass.getAllDetails()


            txtid.Enabled = False
            txtName.Enabled = False
            txtMiddle.Enabled = False
            txtSurname.Enabled = False
            txtReg.Enabled = False
            txtState.Enabled = False
            txtDep.Enabled = False
            txtGender.Enabled = False
            txtAge.Enabled = False
            txtCitizen.Enabled = False
            txtdob.Enabled = False
            txtStud.Enabled = False
            txtFaculty.Enabled = False
            Dim i As Integer

            txtid.Text = CStr(ds.Tables("AllDetails").Rows(0)!ID_number)
            txtName.Text = CStr(ds.Tables("AllDetails").Rows(i)!first_name)
            txtMiddle.Text = CStr(ds.Tables("AllDetails").Rows(i)!middle_name)
            txtSurname.Text = CStr(ds.Tables("AllDetails").Rows(i)!surname)
            txtReg.Text = CStr(ds.Tables("AllDetails").Rows(i)!date_of_registration)
            txtState.Text = CStr(ds.Tables("AllDetails").Rows(i)!state_id)
            txtDep.Text = CStr(ds.Tables("AllDetails").Rows(i)!Department_id)
            txtGender.Text = CStr(ds.Tables("AllDetails").Rows(i)!gender)
            txtAge.Text = CStr(ds.Tables("AllDetails").Rows(i)!age)
            txtCitizen.Text = CStr(ds.Tables("AllDetails").Rows(i)!citizenship)
            txtdob.Text = CStr(ds.Tables("AllDetails").Rows(i)!date_of_birth)
            txtStud.Text = CStr(ds.Tables("AllDetails").Rows(i)!Student_No)
            txtFaculty.Text = CStr(ds.Tables("AllDetails").Rows(i)!faculty_id)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        AddForm.Show()
        'txtid.Clear()
        'txtName.Clear()
        'txtMiddle.Clear()
        'txtSurname.Clear()
        'txtReg.Clear()
        'txtState.Clear()
        'txtDep.Clear()
        'txtGender.Clear()
        'txtAge.Clear()
        'txtCitizen.Clear()
        'txtdob.Clear()
        'txtStud.Clear()
        'txtFaculty.Clear()
    End Sub
End Class