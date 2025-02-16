Public Class GroupsView
    Private db As Db
    Public selectedRowIdx As Integer

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub
    Private Sub GroupsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Sub LoadCategories(Optional search As String = "%%")
        Dim categoriesTable As New DataTable
        categoriesTable.Load(db.LoadCategories(search))
        DataGridView1.DataSource = categoriesTable
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer

        With DataGridView1
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                selectedRowIdx = .Rows(i).Cells(0).Value.ToString()
                MainApp.GroupForm1.GroupNameForm.Text = .Rows(i).Cells(1).Value.ToString()
            End If
        End With
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim searchText As String = "%" & SearchForm.Text & "%"
        LoadCategories(searchText)
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If MainApp.GroupsView1.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If MessageBox.Show("Ingin hapus grup kontak ini ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    db.DeleteCategory(selectedRowIdx)
                    MsgBox("Berhasil Menghapus grup kontak ")
                    LoadCategories()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        MainApp.GroupForm1.GroupNameForm.Text = ""
        MainApp.GroupForm1.SetFormType(1)
        MainApp.GroupForm1.BringToFront()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If MainApp.GroupsView1.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MainApp.GroupForm1.BringToFront()
            MainApp.GroupForm1.SetFormType(0)
            For Each row As DataGridViewRow In MainApp.GroupsView1.DataGridView1.SelectedRows
                MainApp.GroupForm1.SetSelectedId(row.Cells(0).Value)
                MainApp.GroupForm1.GroupNameForm.Text = row.Cells(1).Value.ToString()
            Next
        End If
    End Sub
End Class
