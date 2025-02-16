Public Class GroupForm
    Private db As Db
    Public selectedId As Integer
    Public isCreate As Integer
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub

    Private Sub BackToContactBtn_Click(sender As Object, e As EventArgs) Handles BackToContactBtn.Click
        MainApp.GroupsView1.BringToFront()
    End Sub

    Public Sub SetSelectedId(id As Integer)
        selectedId = id
    End Sub

    Public Sub SetFormType(type As Integer)
        isCreate = type

        If isCreate = 1 Then
            Label1.Text = "Tambah Grup Kontak"
        Else
            Label1.Text = "Edit Grup Kontak"
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim groupName As String = GroupNameForm.Text

        If isCreate = 1 Then
            db.CreateCategory(groupName)
            MessageBox.Show("Grup Kontak berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.UpdateCategory(selectedId, groupName)
            MessageBox.Show("Grup Kontak berhasil diedit ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        MainApp.GroupsView1.LoadCategories()
        MainApp.GroupsView1.BringToFront()
    End Sub
End Class
