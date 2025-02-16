

Public Class MainApp
    Dim db As Db

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If MessageBox.Show("Ingin menutup aplikasi ?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ContactBtn_Click(sender As Object, e As EventArgs) Handles ContactBtn.Click
        ContactsView1.BringToFront()
        ContactsView1.LoadContactDataTable()
    End Sub

    Private Sub GroupBtn_Click(sender As Object, e As EventArgs) Handles GroupBtn.Click
        GroupsView1.BringToFront()
    End Sub

    Private Sub ExportImportBtn_Click(sender As Object, e As EventArgs) Handles ExportImportBtn.Click
        ExportImportView1.BringToFront()
    End Sub
    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles AboutBtn.Click
        AboutView1.BringToFront()
    End Sub
End Class
