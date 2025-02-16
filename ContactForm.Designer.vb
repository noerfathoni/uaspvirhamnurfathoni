<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameForm = New System.Windows.Forms.RichTextBox()
        Me.LastNameForm = New System.Windows.Forms.RichTextBox()
        Me.NumberForm = New System.Windows.Forms.RichTextBox()
        Me.GroupCb = New System.Windows.Forms.ComboBox()
        Me.BackToContactBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tambah Kontak"
        '
        'FirstNameForm
        '
        Me.FirstNameForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameForm.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameForm.Location = New System.Drawing.Point(13, 101)
        Me.FirstNameForm.Multiline = False
        Me.FirstNameForm.Name = "FirstNameForm"
        Me.FirstNameForm.Size = New System.Drawing.Size(598, 38)
        Me.FirstNameForm.TabIndex = 4
        Me.FirstNameForm.Text = ""
        '
        'LastNameForm
        '
        Me.LastNameForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastNameForm.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameForm.Location = New System.Drawing.Point(13, 184)
        Me.LastNameForm.Multiline = False
        Me.LastNameForm.Name = "LastNameForm"
        Me.LastNameForm.Size = New System.Drawing.Size(598, 38)
        Me.LastNameForm.TabIndex = 5
        Me.LastNameForm.Text = ""
        '
        'NumberForm
        '
        Me.NumberForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumberForm.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberForm.Location = New System.Drawing.Point(13, 277)
        Me.NumberForm.MaxLength = 20
        Me.NumberForm.Multiline = False
        Me.NumberForm.Name = "NumberForm"
        Me.NumberForm.Size = New System.Drawing.Size(598, 38)
        Me.NumberForm.TabIndex = 6
        Me.NumberForm.Text = ""
        '
        'GroupCb
        '
        Me.GroupCb.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCb.FormattingEnabled = True
        Me.GroupCb.IntegralHeight = False
        Me.GroupCb.ItemHeight = 28
        Me.GroupCb.Location = New System.Drawing.Point(13, 360)
        Me.GroupCb.Name = "GroupCb"
        Me.GroupCb.Size = New System.Drawing.Size(598, 36)
        Me.GroupCb.TabIndex = 7
        '
        'BackToContactBtn
        '
        Me.BackToContactBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BackToContactBtn.FlatAppearance.BorderSize = 0
        Me.BackToContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToContactBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToContactBtn.ForeColor = System.Drawing.Color.White
        Me.BackToContactBtn.Location = New System.Drawing.Point(118, 438)
        Me.BackToContactBtn.Name = "BackToContactBtn"
        Me.BackToContactBtn.Size = New System.Drawing.Size(90, 33)
        Me.BackToContactBtn.TabIndex = 16
        Me.BackToContactBtn.Text = "Kembali"
        Me.BackToContactBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(13, 438)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(90, 33)
        Me.SaveBtn.TabIndex = 17
        Me.SaveBtn.Text = "Simpan"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Depan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama Belakang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nomor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Grup Kontak:"
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.BackToContactBtn)
        Me.Controls.Add(Me.GroupCb)
        Me.Controls.Add(Me.NumberForm)
        Me.Controls.Add(Me.LastNameForm)
        Me.Controls.Add(Me.FirstNameForm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContactForm"
        Me.Size = New System.Drawing.Size(628, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FirstNameForm As RichTextBox
    Friend WithEvents LastNameForm As RichTextBox
    Friend WithEvents NumberForm As RichTextBox
    Friend WithEvents GroupCb As ComboBox
    Friend WithEvents BackToContactBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
