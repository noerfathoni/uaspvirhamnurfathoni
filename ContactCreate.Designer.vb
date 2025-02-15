<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactCreate
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BackToContactBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
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
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 101)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(598, 38)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(13, 184)
        Me.RichTextBox2.Multiline = False
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(598, 38)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(13, 277)
        Me.RichTextBox3.Multiline = False
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(598, 38)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 28
        Me.ComboBox1.Location = New System.Drawing.Point(13, 360)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(598, 36)
        Me.ComboBox1.TabIndex = 7
        '
        'BackToContactBtn
        '
        Me.BackToContactBtn.BackColor = System.Drawing.Color.White
        Me.BackToContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToContactBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToContactBtn.Location = New System.Drawing.Point(118, 438)
        Me.BackToContactBtn.Name = "BackToContactBtn"
        Me.BackToContactBtn.Size = New System.Drawing.Size(90, 33)
        Me.BackToContactBtn.TabIndex = 16
        Me.BackToContactBtn.Text = "Kembali"
        Me.BackToContactBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.White
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(13, 438)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(90, 33)
        Me.SaveBtn.TabIndex = 17
        Me.SaveBtn.Text = "Simpan"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ContactCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.BackToContactBtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContactCreate"
        Me.Size = New System.Drawing.Size(628, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BackToContactBtn As Button
    Friend WithEvents SaveBtn As Button
End Class
