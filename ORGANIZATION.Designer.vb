<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ORGANIZATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ORGANIZATION))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.orgPanel = New System.Windows.Forms.Panel()
        Me.miniParishBTN = New System.Windows.Forms.Button()
        Me.ministriesBTN = New System.Windows.Forms.Button()
        Me.ppcBTN = New System.Windows.Forms.Button()
        Me.organizationBTN = New System.Windows.Forms.Button()
        Me.logoutBTN = New System.Windows.Forms.Button()
        Me.dashboardBTN = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.printBTN = New System.Windows.Forms.Button()
        Me.titleTXT = New System.Windows.Forms.Label()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.editBTN = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.orgPanel.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
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
        Me.Panel1.TabIndex = 1
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
        Me.orgPanel.Controls.Add(Me.ministriesBTN)
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
        'ministriesBTN
        '
        Me.ministriesBTN.AccessibleName = ""
        Me.ministriesBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ministriesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ministriesBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.ministriesBTN.FlatAppearance.BorderSize = 0
        Me.ministriesBTN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ministriesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ministriesBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ministriesBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ministriesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ministriesBTN.Location = New System.Drawing.Point(0, 101)
        Me.ministriesBTN.Name = "ministriesBTN"
        Me.ministriesBTN.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ministriesBTN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ministriesBTN.Size = New System.Drawing.Size(204, 47)
        Me.ministriesBTN.TabIndex = 7
        Me.ministriesBTN.Text = "Parish Ministries"
        Me.ministriesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ministriesBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ministriesBTN.UseVisualStyleBackColor = False
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
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel3)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Location = New System.Drawing.Point(209, 10)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(803, 614)
        Me.panelMain.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.printBTN)
        Me.Panel3.Controls.Add(Me.titleTXT)
        Me.Panel3.Controls.Add(Me.addBTN)
        Me.Panel3.Controls.Add(Me.editBTN)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 133)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 481)
        Me.Panel3.TabIndex = 1
        '
        'printBTN
        '
        Me.printBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.printBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.printBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.printBTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBTN.Location = New System.Drawing.Point(705, 12)
        Me.printBTN.Name = "printBTN"
        Me.printBTN.Size = New System.Drawing.Size(91, 30)
        Me.printBTN.TabIndex = 15
        Me.printBTN.Text = "Print"
        Me.printBTN.UseVisualStyleBackColor = False
        '
        'titleTXT
        '
        Me.titleTXT.AutoSize = True
        Me.titleTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleTXT.Location = New System.Drawing.Point(2, 16)
        Me.titleTXT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titleTXT.Name = "titleTXT"
        Me.titleTXT.Size = New System.Drawing.Size(57, 20)
        Me.titleTXT.TabIndex = 14
        Me.titleTXT.Text = "Label2"
        '
        'addBTN
        '
        Me.addBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.addBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.addBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.Location = New System.Drawing.Point(511, 12)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(91, 30)
        Me.addBTN.TabIndex = 12
        Me.addBTN.Text = "Add"
        Me.addBTN.UseVisualStyleBackColor = False
        '
        'editBTN
        '
        Me.editBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.editBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.editBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBTN.Location = New System.Drawing.Point(608, 12)
        Me.editBTN.Name = "editBTN"
        Me.editBTN.Size = New System.Drawing.Size(91, 30)
        Me.editBTN.TabIndex = 11
        Me.editBTN.Text = "Edit"
        Me.editBTN.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 49)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(803, 432)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 128)
        Me.Panel2.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.AccessibleName = ""
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button5.Location = New System.Drawing.Point(534, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(269, 54)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Maintenance"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AccessibleName = ""
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button4.Location = New System.Drawing.Point(268, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(266, 54)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Maintenance"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleName = ""
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.Location = New System.Drawing.Point(1, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(267, 54)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Maintenance"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Parish Ministries"
        '
        'ORGANIZATION
        '
        Me.AccessibleName = "PPC"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1017, 634)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ORGANIZATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PPC"
        Me.Panel1.ResumeLayout(False)
        Me.orgPanel.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents orgPanel As Panel
    Friend WithEvents miniParishBTN As Button
    Friend WithEvents ministriesBTN As Button
    Friend WithEvents ppcBTN As Button
    Friend WithEvents organizationBTN As Button
    Friend WithEvents logoutBTN As Button
    Friend WithEvents dashboardBTN As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titleTXT As Label
    Friend WithEvents addBTN As Button
    Friend WithEvents editBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents printBTN As Button
End Class
