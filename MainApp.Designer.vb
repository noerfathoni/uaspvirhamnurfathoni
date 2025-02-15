<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ExportImportBtn = New System.Windows.Forms.Button()
        Me.ContactBtn = New System.Windows.Forms.Button()
        Me.GroupBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContactCreate1 = New UASIrhamNoer.ContactCreate()
        Me.DashboardView1 = New UASIrhamNoer.DashboardView()
        Me.ContactsView1 = New UASIrhamNoer.ContactsView()
        Me.ExportImportView1 = New UASIrhamNoer.ExportImportView()
        Me.GroupsView1 = New UASIrhamNoer.GroupsView()
        Me.AboutView1 = New UASIrhamNoer.AboutView()
        Me.ContactDetailView1 = New UASIrhamNoer.ContactDetailView()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.AboutBtn)
        Me.Panel1.Controls.Add(Me.ExitBtn)
        Me.Panel1.Controls.Add(Me.ExportImportBtn)
        Me.Panel1.Controls.Add(Me.ContactBtn)
        Me.Panel1.Controls.Add(Me.GroupBtn)
        Me.Panel1.Controls.Add(Me.DashboardBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 553)
        Me.Panel1.TabIndex = 0
        '
        'AboutBtn
        '
        Me.AboutBtn.FlatAppearance.BorderSize = 0
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutBtn.ForeColor = System.Drawing.Color.White
        Me.AboutBtn.Location = New System.Drawing.Point(0, 339)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(150, 50)
        Me.AboutBtn.TabIndex = 5
        Me.AboutBtn.Text = "Tentang"
        Me.AboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(0, 395)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(150, 50)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "Keluar"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'ExportImportBtn
        '
        Me.ExportImportBtn.FlatAppearance.BorderSize = 0
        Me.ExportImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportImportBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportImportBtn.ForeColor = System.Drawing.Color.White
        Me.ExportImportBtn.Location = New System.Drawing.Point(0, 283)
        Me.ExportImportBtn.Name = "ExportImportBtn"
        Me.ExportImportBtn.Size = New System.Drawing.Size(150, 50)
        Me.ExportImportBtn.TabIndex = 3
        Me.ExportImportBtn.Text = "Ekspor/Impor"
        Me.ExportImportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExportImportBtn.UseVisualStyleBackColor = True
        '
        'ContactBtn
        '
        Me.ContactBtn.FlatAppearance.BorderSize = 0
        Me.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactBtn.ForeColor = System.Drawing.Color.White
        Me.ContactBtn.Location = New System.Drawing.Point(0, 171)
        Me.ContactBtn.Name = "ContactBtn"
        Me.ContactBtn.Size = New System.Drawing.Size(150, 50)
        Me.ContactBtn.TabIndex = 2
        Me.ContactBtn.Text = "Kontakku"
        Me.ContactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContactBtn.UseVisualStyleBackColor = True
        '
        'GroupBtn
        '
        Me.GroupBtn.FlatAppearance.BorderSize = 0
        Me.GroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBtn.ForeColor = System.Drawing.Color.White
        Me.GroupBtn.Location = New System.Drawing.Point(0, 227)
        Me.GroupBtn.Name = "GroupBtn"
        Me.GroupBtn.Size = New System.Drawing.Size(150, 50)
        Me.GroupBtn.TabIndex = 1
        Me.GroupBtn.Text = "Grup"
        Me.GroupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GroupBtn.UseVisualStyleBackColor = True
        '
        'DashboardBtn
        '
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Nunito SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.White
        Me.DashboardBtn.Location = New System.Drawing.Point(0, 115)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(150, 50)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DashboardView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ContactsView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExportImportView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupsView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.AboutView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ContactDetailView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ContactCreate1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(152, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(628, 553)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ContactCreate1
        '
        Me.ContactCreate1.Location = New System.Drawing.Point(3, 3357)
        Me.ContactCreate1.Name = "ContactCreate1"
        Me.ContactCreate1.Size = New System.Drawing.Size(628, 553)
        Me.ContactCreate1.TabIndex = 6
        '
        'DashboardView1
        '
        Me.DashboardView1.Location = New System.Drawing.Point(3, 3)
        Me.DashboardView1.Name = "DashboardView1"
        Me.DashboardView1.Size = New System.Drawing.Size(628, 553)
        Me.DashboardView1.TabIndex = 0
        '
        'ContactsView1
        '
        Me.ContactsView1.Location = New System.Drawing.Point(3, 562)
        Me.ContactsView1.Name = "ContactsView1"
        Me.ContactsView1.Size = New System.Drawing.Size(628, 553)
        Me.ContactsView1.TabIndex = 4
        '
        'ExportImportView1
        '
        Me.ExportImportView1.Location = New System.Drawing.Point(3, 1121)
        Me.ExportImportView1.Name = "ExportImportView1"
        Me.ExportImportView1.Size = New System.Drawing.Size(628, 553)
        Me.ExportImportView1.TabIndex = 3
        '
        'GroupsView1
        '
        Me.GroupsView1.Location = New System.Drawing.Point(3, 1680)
        Me.GroupsView1.Name = "GroupsView1"
        Me.GroupsView1.Size = New System.Drawing.Size(628, 553)
        Me.GroupsView1.TabIndex = 2
        '
        'AboutView1
        '
        Me.AboutView1.Location = New System.Drawing.Point(3, 2239)
        Me.AboutView1.Name = "AboutView1"
        Me.AboutView1.Size = New System.Drawing.Size(628, 553)
        Me.AboutView1.TabIndex = 1
        '
        'ContactDetailView1
        '
        Me.ContactDetailView1.Location = New System.Drawing.Point(3, 2798)
        Me.ContactDetailView1.Name = "ContactDetailView1"
        Me.ContactDetailView1.Size = New System.Drawing.Size(628, 553)
        Me.ContactDetailView1.TabIndex = 5
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyContact"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ExportImportBtn As Button
    Friend WithEvents ContactBtn As Button
    Friend WithEvents GroupBtn As Button
    Friend WithEvents AboutBtn As Button
    Friend WithEvents DashboardView1 As DashboardView
    Friend WithEvents ExportImportView1 As ExportImportView
    Friend WithEvents GroupsView1 As GroupsView
    Friend WithEvents AboutView1 As AboutView
    Friend WithEvents ContactsView1 As ContactsView
    Friend WithEvents ContactDetailView1 As ContactDetailView
    Friend WithEvents ContactCreate1 As ContactCreate
End Class
