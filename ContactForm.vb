Public Class ContactForm
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
        MainApp.ContactsView1.BringToFront()
    End Sub

    Public Sub SetFormType(type As Integer)
        isCreate = type

        If isCreate = 1 Then
            Label1.Text = "Tambah Kontak"
        Else
            Label1.Text = "Edit Kontak"
        End If
    End Sub

    Public Sub SetSelectedId(id As Integer)
        selectedId = id
    End Sub

    Private Sub ContactForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Sub LoadCategories()
        Dim groupTb As New DataTable

        groupTb.Load(db.LoadCategories)
        GroupCb.DataSource = groupTb
        GroupCb.DisplayMember = "category"
        GroupCb.ValueMember = "id"
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim firstName As String = FirstNameForm.Text
        Dim lastName As String = LastNameForm.Text
        Dim contact As String = NumberForm.Text
        Dim group As String = GroupCb.SelectedValue.ToString()

        If isCreate = 1 Then
            db.CreateContacts(firstName, lastName, contact, group)
            MessageBox.Show("Kontak berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.UpdateContacts(selectedId, firstName, lastName, contact, group)
            MessageBox.Show("Kontak berhasil diedit ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        MainApp.ContactsView1.LoadContactDataTable()
        MainApp.ContactsView1.BringToFront()
    End Sub

    Private Sub NumberForm_TextChanged(sender As Object, e As KeyPressEventArgs) Handles NumberForm.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
