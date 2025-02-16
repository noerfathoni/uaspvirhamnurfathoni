Imports MySql.Data.MySqlClient

Public Class Db
    Private ReadOnly connectionString As String = "Server=localhost;Database=mycontacts;Uid=root;Pwd=;"

    Public Function getConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function

    Function LoadContacts(Optional searchText As String = "%%") As MySqlDataReader
        Dim conn As New MySqlConnection(connectionString)
        Dim reader As MySqlDataReader = Nothing

        Try
            conn.Open()
            Dim query As String = "
                SELECT 
                    contacts.id, firstname, lastname, contact, id_category, 
                    category, contacts.created_at, contacts.updated_at 
                FROM contacts
                LEFT JOIN categories ON contacts.id_category = categories.id
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

    Sub CreateContacts(firstname As String, lastName As String, contact As String, idCategory As String)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim currentDateTime As DateTime = DateTime.Now
            Dim formattedDateTime As String = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")

            Dim query As String = "INSERT INTO contacts (firstname, lastname, contact, id_category, created_at) 
                VALUES (@firstname, @lastname, @contact, @idCategory, @createdAt)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("firstname", firstname)
                cmd.Parameters.AddWithValue("lastName", lastName)
                cmd.Parameters.AddWithValue("contact", contact)
                cmd.Parameters.AddWithValue("idCategory", idCategory)
                cmd.Parameters.AddWithValue("createdAt", formattedDateTime)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub UpdateContacts(id As String, firstname As String, lastName As String, contact As String, idCategory As Integer)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim currentDateTime As DateTime = DateTime.Now
            Dim formattedDateTime As String = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")
            Dim query As String = "UPDATE contacts SET 
                    firstname = @firstname, 
                    lastname = @lastname, 
                    contact = @contact, 
                    id_category = @idCategory
                    WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("id", id)
                cmd.Parameters.AddWithValue("firstname", firstname)
                cmd.Parameters.AddWithValue("lastName", lastName)
                cmd.Parameters.AddWithValue("contact", contact)
                cmd.Parameters.AddWithValue("idCategory", idCategory)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub DeleteContacts(Id As Integer)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim query As String = "DELETE FROM contacts WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("id", Id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ''' Categories Module
    Function LoadCategories(Optional searchText As String = "%%") As MySqlDataReader
        Dim conn As New MySqlConnection(connectionString)
        Dim reader As MySqlDataReader = Nothing

        Try
            conn.Open()
            Dim query As String = "SELECT id, category, created_at, updated_at FROM categories WHERE category LIKE @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("search", searchText)
            reader = cmd.ExecuteReader()

            Return reader
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return reader
    End Function

    Sub CreateCategory(category As String)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim currentDateTime As DateTime = DateTime.Now
            Dim formattedDateTime As String = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")

            Dim query As String = "INSERT INTO categories (category, created_at) VALUES (@category, @createdAt)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("category", category)
                cmd.Parameters.AddWithValue("createdAt", formattedDateTime)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub UpdateCategory(id As String, category As String)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim currentDateTime As DateTime = DateTime.Now
            Dim formattedDateTime As String = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")
            Dim query As String = "UPDATE categories SET 
                    category = @category
                    WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("id", id)
                cmd.Parameters.AddWithValue("category", category)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub DeleteCategory(Id As Integer)
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim query As String = "DELETE FROM categories WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("id", Id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
