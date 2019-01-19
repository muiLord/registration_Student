Public Class AddForm
    Dim result As String
    Dim ds As New DataSet
    Dim BClass As New BusinessClass
    Dim numMaxSubj As Integer = 0
    Dim subj(3) As String
    Public std As String

    Private Sub AddForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub



    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = BClass.getConnection()
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        enableButton(False)
        ds = BClass.getAllStudentDetails()
        Dim nm As String = ds.Tables("AllStdDetails").Rows(0)!first_name
        Dim insert As String
        insert = BClass.insertStdExcel(txtFname.Text, txtMname.Text, txtLname.Text)
        If insert <> "true" Then
            MessageBox.Show(result, "Error occured when adding to student to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Sub enableButton(ByVal most As Boolean)
        txtAge.Enabled = most
        txtDOB.Enabled = most
        txtGender.Enabled = most
        txtFname.Enabled = most
        txtLname.Enabled = most
        txtMname.Enabled = most
        txtCitizenship.Enabled = most
        txtStudNo.Enabled = most
        txtRegDate.Enabled = most
        txtParentId.Enabled = most
        txtPName.Enabled = most
        txtPhone.Enabled = most
        ComboBox1.Enabled = most
        GroupBox1.Enabled = most
    End Sub
    Public Function UniqueID(ByVal id As String) As Boolean

        result = BClass.getConnection
        id = Trim(txtIdNumber.Text)
        If result = "true" Then
            ds = BClass.getIdNumberandStdNo()
            For i As Integer = 0 To ds.Tables("id").Rows.Count - 1
                If id = ds.Tables("id").Rows(i)!ID_number Then
                    Return False
                End If
            Next

        End If
        Return True
    End Function

    Public Function IsValidID(ByVal idNo As String) As Boolean


        Dim odd As Integer = 0
        For i As Integer = 0 To 5
            odd += CInt(idNo.Substring(i * 2, 1))
        Next

        Dim evenInt As Integer = 0
        For i As Integer = 0 To 5
            evenInt = evenInt * 10 + CInt(idNo.Substring(2 * i + 1, 1))
        Next
        evenInt *= 2
        Dim c As Integer = 0
        Do
            c += evenInt Mod 10
            evenInt = Int(evenInt / 10)
        Loop Until evenInt <= 0
        c += odd
        Dim d As Integer = 0
        d = 10 - (c Mod 10)
        If (d = 10) Then d = 0

        If d = CInt(idNo.Substring(12, 1)) Then
            Return True
        Else
            Return False
        End If

        Return False

    End Function


    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click

        Dim idNo, month, day, year As String
        Dim gender, current As Integer
        If txtIdNumber.Text = "" Then
            MsgBox("Enter id number")
        End If
        idNo = txtIdNumber.Text

        If UniqueID(txtIdNumber.Text) = False Then
            MessageBox.Show("DUPLIACATION IS NOT ALLOWED")
            Exit Sub
        End If
        'check if id is valid
        If IsValidID(idNo) = True Then
            'txtIdNumber.ReadOnly() = True
            Dim dat As String
            txtRegDate.Text = CStr(Date.Today)

            'spliting age ,gender,DOB into seperate textboxes
            gender = CInt(idNo.Substring(6, 4))
            If gender >= 5000 Then
                txtGender.Text = "Male"
            Else
                txtGender.Text = "Female"
            End If
            year = idNo.Substring(0, 2)
            current = CInt(year)

            If current > 18 Then
                year = "19" & CStr(current)
            Else
                If CStr(current).Length = 1 Then
                    year = "20" & "0" & CStr(current)
                Else
                    year = "20" & CStr(current)
                End If
            End If
            month = idNo.Substring(2, 2)
            day = idNo.Substring(4, 2)
            txtDOB.Text = year & "/" & month & "/" & day
            txtAge.Text = 2018 - CInt(year)
            'citizenship
            If idNo.Substring(10, 1) <> "0" Then
                txtCitizenship.Text = "Not South African"
            Else
                txtCitizenship.Text = "South African"
            End If

        Else
            ' error message if not valid id
            MsgBox("Invalid South African ID number")
            Exit Sub
        End If

       
        'enabling textboxes and comboboxes 
        txtFname.Enabled = True
        txtLname.Enabled = True
        txtMname.Enabled = True
        txtStudNo.Enabled = False
        txtParentId.Enabled = True
        txtPName.Enabled = True
        txtPhone.Enabled = True
        GroupBox1.Enabled = True

        result = BClass.GenerateStudentNumber(txtRegDate.Text)
        std = result
        txtStudNo.Text = result
        btnValidate.Enabled = False

    End Sub
    Sub subjectClicked()
        If CheckBox1.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox1.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox1.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox2.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox2.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox2.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox3.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox3.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox3.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox4.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox4.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox4.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox5.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox5.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox5.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox6.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox6.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox6.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox7.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox7.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox7.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox8.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox8.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox8.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox9.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox9.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox9.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox10.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox10.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox10.Text
                numMaxSubj += 1
            End If
        End If
        If CheckBox11.Checked = True Then

            If numMaxSubj > subj.Length - 1 Then
                CheckBox11.Checked = False
                MsgBox("ERROR")
                Exit Sub
            Else
                subj(numMaxSubj) = CheckBox11.Text
                numMaxSubj += 1
            End If
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'save student details 
        result = BClass.getConnection()
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'If BClass.getAllDetails().Tables("AllDetails").Rows.Count >= 3 Then
        '    MessageBox.Show("full")
        'End If
        'result = BClass.state()
        'txtState.Text = result

        subjectClicked()
       

        For i = 0 To numMaxSubj - 1
            result = BClass.Checkbox(subj(i), txtStudNo.Text)
            If result <> "true" Then
                MessageBox.Show(result, "Error occured when adding to subject", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next


        result = BClass.Save(txtIdNumber.Text, txtAge.Text, txtGender.Text, txtDOB.Text, txtCitizenship.Text, txtFname.Text, txtMname.Text, txtLname.Text, txtStudNo.Text, txtRegDate.Text, txtPName.Text, txtParentId.Text, txtPhone.Text)


        If result <> "true" Then
            MessageBox.Show(result, "Error occured when adding to student details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show("Saved succefully", "The new student has been succefully added", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Insert new Student in Excel Spreadsheet
            Dim insert As String
            insert = BClass.insertStdExcel(txtFname.Text, txtMname.Text, txtLname.Text)
            If insert <> "true" Then
                MessageBox.Show(result, "Error occured when adding to student to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("Saved succefully", "The new student has been succefully added to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            txtIdNumber.Text = ""
            txtIdNumber.Enabled = True
            Me.txtAge.Text = ""
            Me.txtGender.Text = ""
            Me.txtDOB.Text = ""
            Me.txtFname.Text = ""
            Me.txtMname.Text = ""
            Me.txtLname.Text = ""
            Me.txtCitizenship.Text = ""
            Me.txtRegDate.Text = ""
            Me.txtPhone.Text = ""
            Me.txtPName.Text = ""
            Me.txtParentId.Text = ""
            txtStudNo.Text = ""
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            btnValidate.Enabled = True
            Button2.Enabled = True

        End If


        numMaxSubj = 0

        'Me.Hide()
        'Edit1.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Search.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        enableButton(False)
        ds = BClass.getStudentNos()
        For i = 0 To ds.Tables("stud").Rows.Count - 1
            If ComboBox1.Items.Contains(ds.Tables("stud").Rows(i)!Student_No) = False Then
                ComboBox1.Items.Add(ds.Tables("stud").Rows(i)!Student_No)
            End If
        Next
        ComboBox1.Enabled = True
        GroupBox1.Enabled = True
        Button2.Enabled = False


        'result = BClass.getConnection()
        'If result <> "true" Then
        '    MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If



        ''Me.Hide()
        ''EDIT.Show()
        ''If IsValidID(txtIdNumber.Text) = True Then
        ''    Dim gdate, newState As String
        ''    Dim diff As Integer
        ''    gdate = Today
        ''    diff = CInt(gdate.Substring(4, 4)) - CInt(txtRegDate.Text)
        ''    'completionDate=

        ''    If diff = 0 Then
        ''        newState = "finished"
        ''    End If
        ''End If

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        result = BClass.Update(txtFname.Text, txtLname.Text, txtMname.Text, txtParentId.Text, txtPName.Text, txtPhone.Text, ComboBox1.SelectedItem)
        If result <> "true" Then
            MessageBox.Show(result, "Update incorrectyl", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show("Succefully updated fields", "Updated fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdNumber.Text = ""
            txtIdNumber.Enabled = True
            Me.txtAge.Text = ""
            Me.txtGender.Text = ""
            Me.txtDOB.Text = ""
            Me.txtFname.Text = ""
            Me.txtMname.Text = ""
            Me.txtLname.Text = ""
            Me.txtCitizenship.Text = ""
            Me.txtRegDate.Text = ""
            Me.txtPhone.Text = ""
            Me.txtPName.Text = ""
            Me.txtParentId.Text = ""
            txtStudNo.Text = ""
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            btnValidate.Enabled = True
            Button2.Enabled = True
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ADMIN.Show()
    End Sub

    Private Sub btnVeri_Click(sender As Object, e As EventArgs)
        Me.Hide()
        VERIFY.Show()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        enableButton(False)

        txtFname.Enabled = True
        txtMname.Enabled = True
        txtLname.Enabled = True
        txtParentId.Enabled = True
        txtPhone.Enabled = True
        txtPName.Enabled = True

        ds = BClass.getAllSubjectDetailsByStdNo(ComboBox1.SelectedItem)
        For i = 0 To ds.Tables("AllSubjDetails").Rows.Count - 1
            If ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox1.Text Then
                CheckBox1.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox2.Text Then
                CheckBox2.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox3.Text Then
                CheckBox3.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox4.Text Then
                CheckBox4.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox5.Text Then
                CheckBox5.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox6.Text Then
                CheckBox6.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox7.Text Then
                CheckBox7.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox8.Text Then
                CheckBox8.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox9.Text Then
                CheckBox9.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox10.Text Then
                CheckBox10.Checked = True
            ElseIf ds.Tables("AllSubjDetails").Rows(i)!Subject_Name = CheckBox11.Text Then
                CheckBox11.Checked = True
            End If
        Next

        ds = BClass.getAllStudentDetailsByStdNo(ComboBox1.SelectedItem)
        txtIdNumber.Enabled = False
        txtIdNumber.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!ID_number
        txtFname.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!first_name
        txtMname.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!middle_name
        txtLname.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!surname
        txtRegDate.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!date_of_registration
        txtGender.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!gender
        txtAge.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!age
        txtCitizenship.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!citizenship
        txtDOB.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!date_of_birth
        txtStudNo.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!Student_No
        txtPName.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!Parent_Name
        txtParentId.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!Parent_ID
        txtPhone.Text = ds.Tables("AllStdDetailsByStdNo").Rows(0)!Parent_Phone
    End Sub

    Private Sub btnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        Me.Hide()
        Existing_Data.Show()
    End Sub

    Private Sub btnArrears_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPaymentToolStripMenuItem.Click
        Me.Hide()
        Payment.Show()
    End Sub
End Class
