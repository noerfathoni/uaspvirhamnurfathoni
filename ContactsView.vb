Imports Org.BouncyCastle.Crypto

Public Class ContactsView
    Private db As Db

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub
    Private Sub LoadContactDataTable()
        Dim contactTable As New DataTable
        contactTable.Load(db.LoadContacts)
        DataGridView1.DataSource = contactTable
    End Sub

    Private Sub ContactsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContactDataTable()
    End Sub

    Private Sub DetailContactBtn_Click(sender As Object, e As EventArgs) Handles DetailContactBtn.Click
        If MainApp.ContactsView1.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data dahulu")
        Else
            MainApp.ContactDetailView1.BringToFront()
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer

        With DataGridView1
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                MainApp.ContactDetailView1.FirstNameLabel.Text = .Rows(i).Cells(0).Value.ToString()
                MainApp.ContactDetailView1.LastNameLabel.Text = .Rows(i).Cells(1).Value.ToString()
                MainApp.ContactDetailView1.NumberLabel.Text = .Rows(i).Cells(2).Value.ToString()
                MainApp.ContactDetailView1.EmailLabel.Text = .Rows(i).Cells(3).Value.ToString()
                MainApp.ContactDetailView1.CreatedAtLabel.Text = .Rows(i).Cells(4).Value.ToString()
                MainApp.ContactDetailView1.UpdatedAtLabel.Text = .Rows(i).Cells(5).Value.ToString()
            End If
        End With
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        MainApp.ContactCreate1.BringToFront()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim searchText As String = "%" & SearchForm.Text & "%"
        Dim contactTable As New DataTable
        contactTable.Load(db.LoadContacts(searchText))
        DataGridView1.DataSource = contactTable
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MainApp.ContactsView1.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data dahulu")
        Else
            Try
                If MessageBox.Show("Ingin hapus kontak ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    MsgBox("Berhasil Menghapus kontak")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If MainApp.ContactsView1.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data dahulu")
        Else

        End If
    End Sub
End Class
