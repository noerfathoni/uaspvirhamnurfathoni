Public Class ContactCreate
    Private Sub BackToContactBtn_Click(sender As Object, e As EventArgs) Handles BackToContactBtn.Click
        MainApp.ContactsView1.BringToFront()
    End Sub
End Class
