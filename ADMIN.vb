Public Class ADMIN

    Private Sub btnState_Click(sender As Object, e As EventArgs) Handles btnState.Click
        Me.Hide()
        AddState.Show()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Me.Hide()
        AddFaculty.Show()
    End Sub

    Private Sub btnDepart_Click(sender As Object, e As EventArgs) Handles btnDepart.Click
        Me.Hide()
        AddDepartment.Show()
    End Sub

    Private Sub btnTO_Click(sender As Object, e As EventArgs) Handles btnTO.Click
        Me.Show()
        ADDdeptTOFAC.Show()
    End Sub
End Class