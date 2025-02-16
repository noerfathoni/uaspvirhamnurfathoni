<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportImportView
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
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ekspor / Impor"
        '
        'ExportBtn
        '
        Me.ExportBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ExportBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExportBtn.FlatAppearance.BorderSize = 0
        Me.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn.ForeColor = System.Drawing.Color.White
        Me.ExportBtn.Location = New System.Drawing.Point(220, 193)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(194, 54)
        Me.ExportBtn.TabIndex = 7
        Me.ExportBtn.Text = "Ekspor Kontak"
        Me.ExportBtn.UseVisualStyleBackColor = False
        '
        'ImportBtn
        '
        Me.ImportBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ImportBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImportBtn.FlatAppearance.BorderSize = 0
        Me.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImportBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportBtn.ForeColor = System.Drawing.Color.White
        Me.ImportBtn.Location = New System.Drawing.Point(220, 267)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(194, 54)
        Me.ImportBtn.TabIndex = 8
        Me.ImportBtn.Text = "Impor Kontak"
        Me.ImportBtn.UseVisualStyleBackColor = False
        '
        'ExportImportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ImportBtn)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ExportImportView"
        Me.Size = New System.Drawing.Size(628, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ExportBtn As Button
    Friend WithEvents ImportBtn As Button
End Class
