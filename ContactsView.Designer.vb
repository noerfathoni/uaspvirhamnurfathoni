<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactsView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DetailContactBtn = New System.Windows.Forms.Button()
        Me.SearchForm = New System.Windows.Forms.RichTextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CreateBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 138)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(608, 405)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kontak"
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.DarkOrange
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(106, 49)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(90, 33)
        Me.EditBtn.TabIndex = 3
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Firebrick
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(202, 49)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(90, 33)
        Me.DeleteBtn.TabIndex = 4
        Me.DeleteBtn.Text = "Hapus"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'DetailContactBtn
        '
        Me.DetailContactBtn.BackColor = System.Drawing.Color.DarkViolet
        Me.DetailContactBtn.FlatAppearance.BorderSize = 0
        Me.DetailContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailContactBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailContactBtn.ForeColor = System.Drawing.Color.White
        Me.DetailContactBtn.Location = New System.Drawing.Point(298, 49)
        Me.DetailContactBtn.Name = "DetailContactBtn"
        Me.DetailContactBtn.Size = New System.Drawing.Size(90, 33)
        Me.DetailContactBtn.TabIndex = 5
        Me.DetailContactBtn.Text = "Detail"
        Me.DetailContactBtn.UseVisualStyleBackColor = False
        '
        'SearchForm
        '
        Me.SearchForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchForm.Location = New System.Drawing.Point(10, 96)
        Me.SearchForm.Name = "SearchForm"
        Me.SearchForm.Size = New System.Drawing.Size(515, 33)
        Me.SearchForm.TabIndex = 6
        Me.SearchForm.Text = ""
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(528, 96)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(90, 33)
        Me.SearchBtn.TabIndex = 7
        Me.SearchBtn.Text = "Cari"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'CreateBtn
        '
        Me.CreateBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateBtn.FlatAppearance.BorderSize = 0
        Me.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBtn.ForeColor = System.Drawing.Color.White
        Me.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CreateBtn.Location = New System.Drawing.Point(10, 49)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(90, 33)
        Me.CreateBtn.TabIndex = 2
        Me.CreateBtn.Text = "Tambah"
        Me.CreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateBtn.UseVisualStyleBackColor = False
        '
        'ContactsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.SearchForm)
        Me.Controls.Add(Me.DetailContactBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ContactsView"
        Me.Size = New System.Drawing.Size(628, 553)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents DetailContactBtn As Button
    Friend WithEvents SearchForm As RichTextBox
    Friend WithEvents SearchBtn As Button
End Class
