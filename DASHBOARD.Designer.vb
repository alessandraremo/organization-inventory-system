<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DASHBOARD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DASHBOARD))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.orgPanel = New System.Windows.Forms.Panel()
        Me.miniParishBTN = New System.Windows.Forms.Button()
        Me.minitriesBTN = New System.Windows.Forms.Button()
        Me.ppcBTN = New System.Windows.Forms.Button()
        Me.organizationBTN = New System.Windows.Forms.Button()
        Me.logoutBTN = New System.Windows.Forms.Button()
        Me.dashboardBTN = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.orgPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASHBOARD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.orgPanel)
        Me.Panel1.Controls.Add(Me.logoutBTN)
        Me.Panel1.Controls.Add(Me.dashboardBTN)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 634)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.AccessibleName = ""
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(204, 54)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = " Maintenance"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'orgPanel
        '
        Me.orgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.orgPanel.Controls.Add(Me.miniParishBTN)
        Me.orgPanel.Controls.Add(Me.minitriesBTN)
        Me.orgPanel.Controls.Add(Me.ppcBTN)
        Me.orgPanel.Controls.Add(Me.organizationBTN)
        Me.orgPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.orgPanel.Location = New System.Drawing.Point(0, 192)
        Me.orgPanel.MaximumSize = New System.Drawing.Size(204, 193)
        Me.orgPanel.MinimumSize = New System.Drawing.Size(204, 54)
        Me.orgPanel.Name = "orgPanel"
        Me.orgPanel.Size = New System.Drawing.Size(204, 193)
        Me.orgPanel.TabIndex = 1
        '
        'miniParishBTN
        '
        Me.miniParishBTN.AccessibleName = ""
        Me.miniParishBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.miniParishBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.miniParishBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.miniParishBTN.FlatAppearance.BorderSize = 0
        Me.miniParishBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.miniParishBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.miniParishBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miniParishBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.miniParishBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.miniParishBTN.Location = New System.Drawing.Point(0, 148)
        Me.miniParishBTN.Name = "miniParishBTN"
        Me.miniParishBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.miniParishBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.miniParishBTN.Size = New System.Drawing.Size(204, 47)
        Me.miniParishBTN.TabIndex = 10
        Me.miniParishBTN.Text = "Mini Parish Pastoral Council"
        Me.miniParishBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.miniParishBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.miniParishBTN.UseVisualStyleBackColor = False
        '
        'minitriesBTN
        '
        Me.minitriesBTN.AccessibleName = ""
        Me.minitriesBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.minitriesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.minitriesBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.minitriesBTN.FlatAppearance.BorderSize = 0
        Me.minitriesBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.minitriesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minitriesBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minitriesBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.minitriesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.minitriesBTN.Location = New System.Drawing.Point(0, 101)
        Me.minitriesBTN.Name = "minitriesBTN"
        Me.minitriesBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.minitriesBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minitriesBTN.Size = New System.Drawing.Size(204, 47)
        Me.minitriesBTN.TabIndex = 7
        Me.minitriesBTN.Text = "Parish Ministries"
        Me.minitriesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.minitriesBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.minitriesBTN.UseVisualStyleBackColor = False
        '
        'ppcBTN
        '
        Me.ppcBTN.AccessibleName = ""
        Me.ppcBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ppcBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ppcBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.ppcBTN.FlatAppearance.BorderSize = 0
        Me.ppcBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ppcBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ppcBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppcBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ppcBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ppcBTN.Location = New System.Drawing.Point(0, 54)
        Me.ppcBTN.Name = "ppcBTN"
        Me.ppcBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ppcBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ppcBTN.Size = New System.Drawing.Size(204, 47)
        Me.ppcBTN.TabIndex = 6
        Me.ppcBTN.Text = "Parish Pastoral Council"
        Me.ppcBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ppcBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ppcBTN.UseVisualStyleBackColor = False
        '
        'organizationBTN
        '
        Me.organizationBTN.AccessibleName = "organizationBTN"
        Me.organizationBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.organizationBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.organizationBTN.FlatAppearance.BorderSize = 0
        Me.organizationBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.organizationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.organizationBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.organizationBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.organizationBTN.Image = CType(resources.GetObject("organizationBTN.Image"), System.Drawing.Image)
        Me.organizationBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.organizationBTN.Location = New System.Drawing.Point(0, 0)
        Me.organizationBTN.Name = "organizationBTN"
        Me.organizationBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.organizationBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.organizationBTN.Size = New System.Drawing.Size(204, 54)
        Me.organizationBTN.TabIndex = 5
        Me.organizationBTN.Text = " Organization"
        Me.organizationBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.organizationBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.organizationBTN.UseVisualStyleBackColor = True
        '
        'logoutBTN
        '
        Me.logoutBTN.AccessibleName = "logoutBTN"
        Me.logoutBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logoutBTN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutBTN.FlatAppearance.BorderSize = 0
        Me.logoutBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.logoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logoutBTN.Image = CType(resources.GetObject("logoutBTN.Image"), System.Drawing.Image)
        Me.logoutBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutBTN.Location = New System.Drawing.Point(0, 580)
        Me.logoutBTN.Name = "logoutBTN"
        Me.logoutBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.logoutBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logoutBTN.Size = New System.Drawing.Size(204, 54)
        Me.logoutBTN.TabIndex = 7
        Me.logoutBTN.Text = " Logout"
        Me.logoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutBTN.UseVisualStyleBackColor = True
        '
        'dashboardBTN
        '
        Me.dashboardBTN.AccessibleName = "dashboardBTN"
        Me.dashboardBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.dashboardBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardBTN.FlatAppearance.BorderSize = 0
        Me.dashboardBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dashboardBTN.Image = CType(resources.GetObject("dashboardBTN.Image"), System.Drawing.Image)
        Me.dashboardBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBTN.Location = New System.Drawing.Point(0, 138)
        Me.dashboardBTN.Name = "dashboardBTN"
        Me.dashboardBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.dashboardBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dashboardBTN.Size = New System.Drawing.Size(204, 54)
        Me.dashboardBTN.TabIndex = 3
        Me.dashboardBTN.Text = " Dashboard"
        Me.dashboardBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboardBTN.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(204, 138)
        Me.Panel4.TabIndex = 2
        '
        'DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 634)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DASHBOARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DASHBOARD"
        Me.Panel1.ResumeLayout(False)
        Me.orgPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents orgPanel As Panel
    Friend WithEvents miniParishBTN As Button
    Friend WithEvents minitriesBTN As Button
    Friend WithEvents ppcBTN As Button
    Friend WithEvents organizationBTN As Button
    Friend WithEvents logoutBTN As Button
    Friend WithEvents dashboardBTN As Button
    Friend WithEvents Panel4 As Panel
End Class
