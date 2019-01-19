Imports Excel = Microsoft.Office.Interop.Excel
Public Class Payment
    Dim BClass As New BusinessClass
    Dim result As String
    Dim ds As New DataSet
    Dim mnth As String() = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November"}
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Private Sub Payment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        AddForm.Show()
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = BClass.getConnection
        If result <> "true" Then
            MessageBox.Show(result, "Connection to the database has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        For Each m As String In mnth
            cmbMonth.Items.Add(m)
        Next

        ds = BClass.getAllStudentDetails()
        For index = 0 To ds.Tables("AllStdDetails").Rows.Count - 1
            Dim nm As String
            If ds.Tables("AllStdDetails").Rows(index)!middle_name <> "" Then
                nm = ds.Tables("AllStdDetails").Rows(index)!first_name &
                " " & ds.Tables("AllStdDetails").Rows(index)!middle_name.ToString.Substring(0, 1) &
                " " & ds.Tables("AllStdDetails").Rows(index)!surname
            Else
                nm = ds.Tables("AllStdDetails").Rows(index)!first_name &
                " " & ds.Tables("AllStdDetails").Rows(index)!surname
            End If

            cmbNameSur.Items.Add(nm)
        Next


        ds = BClass.getStudentNos()
        For index = 0 To ds.Tables("stud").Rows.Count - 1
            cmbStdNo.Items.Add(ds.Tables("stud").Rows(index)!Student_No)
        Next
        'Dim n As Integer = 13
        'If Today.Month <> 6 Then
        '    For Each ctrl As Control In Me.GroupBox1.Controls
        '        If n = 6 Then
        '            Exit For
        '        Else
        '            DirectCast(ctrl, CheckBox).Enabled = False
        '            If DirectCast(ctrl, CheckBox).Text = "June" Then
        '                DirectCast(ctrl, CheckBox).Enabled = True
        '            End If
        '            n -= 1
        '        End If
        '    Next
        'End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs)

        'For Each ctrl As Control In Me.GroupBox1.Controls
        '    If TypeOf ctrl Is CheckBox And DirectCast(ctrl, CheckBox).Enabled = True And DirectCast(ctrl, CheckBox).Checked Then
        '        result = BClass.InsertPay(cmbStdNo.SelectedItem, DirectCast(ctrl, CheckBox).Text, 500)
        '        If result <> "true" Then
        '            MsgBox(result)
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open("C:\BLACKTOTI\Admin_Pay4.xlsx")           ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = xlWorkBook.Worksheets("Payments")    ' THE NAME OF THE WORK SHEET. 

        Dim iRow As Integer = 0
        Dim iCol As Integer = 0
        Dim colY As Integer = 0
        Dim rowX As Integer = 0

        'Look for month in row 1 

        For row As Integer = 1 To 1
            
            For col As Integer = 1 To 10
                If Trim(xlWorkSheet.Cells(1, col).value) = "" Then
                    MsgBox("REACHED THE LAST COLUMN")
                    Exit For    ' BAIL OUT IF REACHED THE LAST COLUMN.
                End If
                If Trim(xlWorkSheet.Cells(row, col).value) = Trim(cmbMonth.SelectedItem) Then
                    MsgBox("Column " & col)
                    colY = col
                    'xlWorkSheet.Cells(iRow, iCol + 1) = Trim(tbMobile.Text)
                    Exit For    ' DONE. GET OUT OF THE LOOP.
                End If
            Next
        Next


        For iRow = 2 To xlWorkSheet.Rows.Count
            If Trim(xlWorkSheet.Cells(iRow, 1).value) = "" Then
                'MsgBox("REACHED THE LAST ROW")
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            End If

            For iCol = 1 To xlWorkSheet.Columns.Count
                If Trim(xlWorkSheet.Cells(1, iCol).value) = "" Then
                    'MsgBox("REACHED THE LAST COLUMN")
                    Exit For    ' BAIL OUT IF REACHED THE LAST COLUMN.
                End If

                ' CHECK IF THE SELECTED EMPLOYEE EXISTS AND CHANGE THE MOBILE NO.
                If Trim(xlWorkSheet.Cells(iRow, iCol).value) = Trim(cmbNameSur.Text) Then
                    'MsgBox("Row " & iRow)
                    xlWorkSheet.Cells(iRow, colY) = Trim(txtMoney.Text)
                    If chkJune.Checked = True And cmbMonth.SelectedIndex <= 5 Then
                        xlWorkSheet.Cells(iRow, colY).Font.Color = 255
                        Exit For    ' DONE. GET OUT OF THE LOOP.
                    End If
                End If
            Next
        Next
        xlWorkBook.Save()
        xlWorkBook.Close() : xlApp.Quit()

        ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing

        MessageBox.Show("Saved succefully", "The new student Excel ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmbStdNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStdNo.SelectedIndexChanged
        cmbNameSur.SelectedIndex = cmbStdNo.SelectedIndex
    End Sub

    Private Sub cmbNameSur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNameSur.SelectedIndexChanged
        cmbStdNo.SelectedIndex = cmbNameSur.SelectedIndex
    End Sub
End Class