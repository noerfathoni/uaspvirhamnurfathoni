<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupNameForm = New System.Windows.Forms.RichTextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.BackToContactBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tambah Grup Kontak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Grup:"
        '
        'GroupNameForm
        '
        Me.GroupNameForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GroupNameForm.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNameForm.Location = New System.Drawing.Point(13, 101)
        Me.GroupNameForm.Multiline = False
        Me.GroupNameForm.Name = "GroupNameForm"
        Me.GroupNameForm.Size = New System.Drawing.Size(598, 38)
        Me.GroupNameForm.TabIndex = 19
        Me.GroupNameForm.Text = ""
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
        Me.SaveBtn.TabIndex = 22
        Me.SaveBtn.Text = "Simpan"
        Me.SaveBtn.UseVisualStyleBackColor = False
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
        Me.BackToContactBtn.TabIndex = 21
        Me.BackToContactBtn.Text = "Kembali"
        Me.BackToContactBtn.UseVisualStyleBackColor = False
        '
        'GroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.BackToContactBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupNameForm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GroupForm"
        Me.Size = New System.Drawing.Size(628, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupNameForm As RichTextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents BackToContactBtn As Button
End Class
