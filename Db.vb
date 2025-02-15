Imports MySql.Data.MySqlClient

Public Class Db
    Private ReadOnly connectionString As String = "Server=localhost;Database=mycontacts;Uid=root;Pwd=;"

    Function LoadContacts(Optional searchText As String = "%%") As MySqlDataReader
        Dim conn As New MySqlConnection(connectionString)
        Dim reader As MySqlDataReader = Nothing

        Try
            conn.Open()
            Dim query As String = "
                SELECT 
                    firstname, lastname, contact, id_category, created_at, updated_at 
                FROM contacts
                WHERE firstname LIKE @search
                OR contact LIKE @search 
                OR lastname LIKE @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", searchText)
            reader = cmd.ExecuteReader()

            Return reader
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return reader
    End Function

    Function CreateContacts(firstname As String, lastName As String, contact As String, idCategory As Integer) As MySqlDataReader
        Dim conn As New MySqlConnection(connectionString)
        Dim reader As MySqlDataReader = Nothing

        Try
            conn.Open()
            Dim query As String = "INSERT INTO contacts VALUES (@firstname, @lastname, @contact, @idCategory)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("firstname", firstname)
                cmd.Parameters.AddWithValue("lastName", lastName)
                cmd.Parameters.AddWithValue("contact", contact)
                cmd.Parameters.AddWithValue("idCategory", idCategory)
                cmd.ExecuteNonQuery()
            End Using

            Return reader
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return reader
    End Function

    Function LoadCategories() As MySqlDataReader
        Dim conn As New MySqlConnection(connectionString)
        Dim reader As MySqlDataReader = Nothing

        Try
            conn.Open()
            Dim query As String = "SELECT category, created_at, updated_at FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            Return reader
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return reader
    End Function

End Class
