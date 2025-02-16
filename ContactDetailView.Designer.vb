<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactDetailView
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
        Me.LabelX = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CreatedAtLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UpdatedAtLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BackToContactBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Detail Kontak"
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX.Location = New System.Drawing.Point(8, 65)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(132, 28)
        Me.LabelX.TabIndex = 3
        Me.LabelX.Text = "Nama Depan"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(189, 65)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(27, 28)
        Me.FirstNameLabel.TabIndex = 4
        Me.FirstNameLabel.Text = "..."
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(189, 108)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(27, 28)
        Me.LastNameLabel.TabIndex = 6
        Me.LastNameLabel.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Belakang"
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberLabel.Location = New System.Drawing.Point(189, 156)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(27, 28)
        Me.NumberLabel.TabIndex = 8
        Me.NumberLabel.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nomor"
        '
        'CreatedAtLabel
        '
        Me.CreatedAtLabel.AutoSize = True
        Me.CreatedAtLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatedAtLabel.Location = New System.Drawing.Point(189, 254)
        Me.CreatedAtLabel.Name = "CreatedAtLabel"
        Me.CreatedAtLabel.Size = New System.Drawing.Size(27, 28)
        Me.CreatedAtLabel.TabIndex = 12
        Me.CreatedAtLabel.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 28)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Created At"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(189, 206)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(27, 28)
        Me.EmailLabel.TabIndex = 10
        Me.EmailLabel.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Grup"
        '
        'UpdatedAtLabel
        '
        Me.UpdatedAtLabel.AutoSize = True
        Me.UpdatedAtLabel.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatedAtLabel.Location = New System.Drawing.Point(189, 302)
        Me.UpdatedAtLabel.Name = "UpdatedAtLabel"
        Me.UpdatedAtLabel.Size = New System.Drawing.Size(27, 28)
        Me.UpdatedAtLabel.TabIndex = 14
        Me.UpdatedAtLabel.Text = "..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 28)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Updated At"
        '
        'BackToContactBtn
        '
        Me.BackToContactBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BackToContactBtn.FlatAppearance.BorderSize = 0
        Me.BackToContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToContactBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToContactBtn.ForeColor = System.Drawing.Color.White
        Me.BackToContactBtn.Location = New System.Drawing.Point(13, 392)
        Me.BackToContactBtn.Name = "BackToContactBtn"
        Me.BackToContactBtn.Size = New System.Drawing.Size(90, 33)
        Me.BackToContactBtn.TabIndex = 15
        Me.BackToContactBtn.Text = "Kembali"
        Me.BackToContactBtn.UseVisualStyleBackColor = False
        '
        'ContactDetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackToContactBtn)
        Me.Controls.Add(Me.UpdatedAtLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CreatedAtLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContactDetailView"
        Me.Size = New System.Drawing.Size(628, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelX As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumberLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CreatedAtLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents UpdatedAtLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BackToContactBtn As Button
End Class
