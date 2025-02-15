Public Class GroupsView
    Private db As Db

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub
    Private Sub GroupsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Dim categoriesTable As New DataTable
        categoriesTable.Load(db.LoadCategories)
        DataGridView1.DataSource = categoriesTable
    End Sub
End Class
