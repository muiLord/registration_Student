Imports Excel = Microsoft.Office.Interop.Excel
Public Class BusinessClass
    Dim con As New OleDb.OleDbConnection
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Public Function getConnection() As String
        Dim result As String = "true"
        Try
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\BLACKTOTI\registration.mdb"
            con.Open()
            con.Close()
        Catch ex As Exception
            result = ex.Message.ToString
        End Try
        Return result
    End Function

    Public Function Save(ByVal idNo As String, ByVal age As String, ByVal g As String, ByVal dob As String, ByVal citizen As String, ByVal first As String, ByVal middle As String, ByVal last As String, ByVal stud As String, ByVal dat As String, ByVal parentName As String, ByVal parentId As String, ByVal parentNo As String) As String
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String
        Dim result As String = ""
        Try
            sql = "INSERT INTO Student_Details (ID_number,age,gender,date_of_birth,citizenship,first_name,middle_name,surname,Student_No,date_of_registration,Parent_Name,Parent_ID,Parent_Phone) VALUES ('" + idNo + "','" + age + "','" + g + "','" + dob + "','" + citizen + "','" + first + "','" + middle + "','" + last + "','" + stud + "','" + dat + "','" + parentName + "','" + parentId + "','" + parentNo + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function Checkbox(ByVal chk1 As String, ByVal stdNo As String) As String
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String
        Dim result As String = ""
        Try
            sql = "INSERT INTO Subjects (Subject_Name,Student_No) VALUES ('" & chk1 & "','" & stdNo & "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function

    Public Function Delete_Std_DetByID_OR_Std(ByVal stdNo As String) As String
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String
        Dim result As String = ""
        Try
            If stdNo.Length = 9 Then
                sql = "Delete From Student_Details Where Student_No='" & stdNo & "'"
            ElseIf stdNo.Length = 13 Then
                sql = "Delete From Student_Details Where ID_number='" & stdNo & "'"

            End If
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function Delete_Subj_ByStd(ByVal stdNo As String) As String
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String
        Dim result As String = ""
        Try
            sql = "Delete From Subjects Where Student_No='" & stdNo & "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function getIdNumberandStdNo() As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select ID_number,Student_No from Student_Details Order By ID_number"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "id")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function Update(ByVal fNm As String, ByVal lstNm As String, ByVal mddNm As String, ByVal parentId As String, ByVal parentNm As String, ByVal parentNo As String, ByVal stud As String) As String
        Dim cmd As OleDb.OleDbCommand
        Dim sql, result As String
        Try
            sql = " UPDATE Student_Details SET first_name = '" + fNm + "', middle_name = '" + mddNm +
                "', surname = '" + lstNm + "', Parent_Name = '" + parentNm + "', Parent_ID = '" + parentId +
                "', Parent_Phone = '" + parentNo + "' WHERE Student_No = '" + stud + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function

    Public Function getAllStudentDetails() As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select * from Student_Details Order By ID_number"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AllStdDetails")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function
    Public Function getAllStudentDetailsByStdNo(ByVal std As String) As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If std.Length = 9 Then
            sql = "Select * from Student_Details Where Student_No ='" & std & "' Order By Student_No"
        ElseIf std.Length = 13 Then
            sql = "Select * from Student_Details Where ID_number ='" & std & "' Order By ID_number"
        End If

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AllStdDetailsByStdNo")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function
    Public Function getAllSubjectDetailsByStdNo(ByVal std As String) As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sql = "Select Subject_Name from Subjects Where Student_No ='" & std & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AllSubjDetails")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function getAllSubjectDetails() As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select * from Subjects"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AllSubjDetail")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function getAllStudentNo() As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select Student_No from Student_Details Order By Student_No"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "student_No")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function
    Public Function GenerateStudentNumber(ByVal dat As String) As String

        Dim ds As New DataSet
        Dim lasNo, hold, zero As String
        Dim fieldNo As Integer
        ds = getAllStudentNo()
        fieldNo = ds.Tables("student_No").Rows.Count ' check if the are records
        Dim start As String = dat.Substring(0, 1) & dat.Substring(2, 2) ' its the start of the Student Number eg 218(2018)
        If fieldNo = 0 Then
            hold = start & "000000"
            Return hold
        End If
        lasNo = ds.Tables("student_No").Rows(ds.Tables("student_No").Rows.Count - 1)!Student_No
        'MsgBox("Last Student No " & lasNo)
        zero = zeros(lasNo.Substring(3, 6))
        hold = start & zero

        'lastNoS = CStr(lasNo)
        'lasNo = CInt(lasNo.Substring(5, 4))
        'lasNo = (lasNo) + 1
        'hold = dat.Substring(0, 1)
        'hold = hold & dat.Substring(2, 2) & "29"

        'If lasNo < 10 Then
        '    hold = hold & "000" & lasNo
        'ElseIf lasNo < 100 Then
        '    hold = hold & "00" & lasNo
        'ElseIf lasNo < 1000 Then
        '    hold = hold & "0" & lasNo
        'Else
        '    hold = hold & lasNo
        'End If

        Return hold

    End Function
    Public Function zeros(ByVal lastS As String) As String
        Dim zerosNum As String
        Dim lock As String = ""
        Dim zeroStr As String

        zerosNum = CStr(CInt(lastS) + 1)

        For index = 1 To lastS.Length - zerosNum.Length
            lock = "0" & lock
        Next
        zeroStr = lock & zerosNum
        Return zeroStr
    End Function


    Public Function getDetailsBySearch(ByVal surn As String, ByVal id As String, ByVal stud As String, ByVal year As String) As DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "select * from Student_Details where surname='" + surn + "' or  ID_number='" + id + "' or Student_No='" + stud + "' or Date_of_registration='" + year + "' Order By ID_number"
        '
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "details")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function getStudentNos() As DataSet

        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select * from Student_Details Order By ID_number"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "stud")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function num() As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim ds As New DataSet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "Select Count (*) As row_count from Student_Details "
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "num")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    

    Public Function insertStdExcel(ByVal fullNm As String, ByVal midddleNm As String, ByVal surname As String) As String
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open("C:\BLACKTOTI\Admin_Pay4.xlsx")           ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = xlWorkBook.Worksheets("Payments")

        Try
            For row As Integer = 2 To xlWorkSheet.Rows.Count
                If Trim(xlWorkSheet.Cells(row, 1).value) = "" Then
                    'Check the middle name if its empty then dont insert it else take first letter
                    If midddleNm <> "" Then
                        xlWorkSheet.Cells(row, 1).value = fullNm & " " & midddleNm.Substring(0, 1) & " " & surname
                        xlWorkSheet.Cells(row, 2).value = 300
                    Else
                        xlWorkSheet.Cells(row, 1).value = fullNm & " " & surname
                        xlWorkSheet.Cells(row, 2).value = 300
                    End If
                    Exit For
                End If
            Next
            xlWorkBook.Save()
            xlWorkBook.Close() : xlApp.Quit()

            ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
            'Return true when student is inserted to the excel spreadsheet last row in column 1
            Return "true"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
