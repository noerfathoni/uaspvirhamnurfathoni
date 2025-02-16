

Imports System.Diagnostics.Eventing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ExportImportView
    Private db As Db

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New Db()
    End Sub
    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Try
            Dim filePath As String
            Dim saveFileDialog As New SaveFileDialog()

            saveFileDialog.Filter = "TSV Files (*.tsv)|*.tsv|All Files (*.*)|*.*"
            saveFileDialog.FileName = "contacts"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                filePath = saveFileDialog.FileName

                Dim dataReader As MySqlDataReader = db.LoadContacts()

                Using writer As New StreamWriter(filePath)

                    ' Write the header (column names) to the TSV file
                    Dim columnCount As Integer = dataReader.FieldCount
                    For i As Integer = 0 To columnCount - 1
                        writer.Write(dataReader.GetName(i))
                        If i < columnCount - 1 Then
                            writer.Write(vbTab) ' Tab separator
                        End If
                    Next
                    writer.WriteLine() ' Newline after header

                    ' Write the data rows to the TSV file
                    While dataReader.Read()
                        For i As Integer = 0 To columnCount - 1
                            writer.Write(dataReader.GetValue(i).ToString())
                            If i < columnCount - 1 Then
                                writer.Write(vbTab) ' Tab separator
                            End If
                        Next
                        writer.WriteLine() ' Newline after each row
                    End While
                End Using
                MessageBox.Show("Data exported successfully to the following location:" & vbCrLf & filePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "TSV Files (*.tsv)|*.tsv"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim conn As MySqlConnection = db.getConnection()
            Try
                ' Open the file using StreamReader
                Using reader As New StreamReader(filePath)
                    reader.ReadLine()
                    Using transaction As MySqlTransaction = conn.BeginTransaction()
                        ' Loop through each line in the TSV file
                        While Not reader.EndOfStream
                            Dim line As String = reader.ReadLine()

                            Dim values As String() = line.Split(vbTab)
                            Console.WriteLine(line)

                            Dim currentDateTime As DateTime = DateTime.Now
                            Dim formattedDateTime As String = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss")

                            Dim query As String = "INSERT INTO contacts (firstname, lastname, contact, id_category, created_at) VALUES (@firstname, @lastname, @contact, @idCategory, @createdAt)"
                            Using cmd As New MySqlCommand(query, conn, transaction)
                                cmd.Parameters.AddWithValue("firstname", values(1))
                                cmd.Parameters.AddWithValue("lastName", values(2))
                                cmd.Parameters.AddWithValue("contact", values(3))
                                cmd.Parameters.AddWithValue("idCategory", values(4))
                                cmd.Parameters.AddWithValue("createdAt", formattedDateTime)
                                cmd.ExecuteNonQuery()
                            End Using
                        End While

                        transaction.Commit()
                    End Using
                End Using
                MessageBox.Show("Data imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
End Class
