<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.loginBTN = New System.Windows.Forms.Button()
        Me.passwordLBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitBTN = New System.Windows.Forms.Button()
        Me.showpassBTN = New System.Windows.Forms.PictureBox()
        Me.hidepassBTN = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showpassBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidepassBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginBTN
        '
        Me.loginBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.loginBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.loginBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.loginBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBTN.Location = New System.Drawing.Point(149, 384)
        Me.loginBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loginBTN.Name = "loginBTN"
        Me.loginBTN.Size = New System.Drawing.Size(121, 37)
        Me.loginBTN.TabIndex = 2
        Me.loginBTN.Text = "Login"
        Me.loginBTN.UseVisualStyleBackColor = False
        '
        'passwordLBL
        '
        Me.passwordLBL.AutoSize = True
        Me.passwordLBL.BackColor = System.Drawing.Color.Transparent
        Me.passwordLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLBL.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.passwordLBL.Location = New System.Drawing.Point(149, 300)
        Me.passwordLBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passwordLBL.Name = "passwordLBL"
        Me.passwordLBL.Size = New System.Drawing.Size(83, 18)
        Me.passwordLBL.TabIndex = 5
        Me.passwordLBL.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(149, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'passwordTB
        '
        Me.passwordTB.AccessibleName = "passwordTB"
        Me.passwordTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.passwordTB.Location = New System.Drawing.Point(153, 324)
        Me.passwordTB.Margin = New System.Windows.Forms.Padding(13, 12, 4, 12)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.Size = New System.Drawing.Size(267, 24)
        Me.passwordTB.TabIndex = 3
        Me.passwordTB.UseSystemPasswordChar = True
        '
        'usernameTB
        '
        Me.usernameTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.usernameTB.Location = New System.Drawing.Point(153, 260)
        Me.usernameTB.Margin = New System.Windows.Forms.Padding(13, 12, 4, 12)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(267, 24)
        Me.usernameTB.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(191, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 155)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'exitBTN
        '
        Me.exitBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.exitBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exitBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBTN.Location = New System.Drawing.Point(279, 384)
        Me.exitBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exitBTN.Name = "exitBTN"
        Me.exitBTN.Size = New System.Drawing.Size(121, 37)
        Me.exitBTN.TabIndex = 10
        Me.exitBTN.Text = "Exit"
        Me.exitBTN.UseVisualStyleBackColor = False
        '
        'showpassBTN
        '
        Me.showpassBTN.Image = CType(resources.GetObject("showpassBTN.Image"), System.Drawing.Image)
        Me.showpassBTN.Location = New System.Drawing.Point(431, 324)
        Me.showpassBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.showpassBTN.Name = "showpassBTN"
        Me.showpassBTN.Size = New System.Drawing.Size(27, 26)
        Me.showpassBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.showpassBTN.TabIndex = 11
        Me.showpassBTN.TabStop = False
        '
        'hidepassBTN
        '
        Me.hidepassBTN.BackColor = System.Drawing.Color.DarkRed
        Me.hidepassBTN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hidepassBTN.Image = CType(resources.GetObject("hidepassBTN.Image"), System.Drawing.Image)
        Me.hidepassBTN.Location = New System.Drawing.Point(431, 324)
        Me.hidepassBTN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hidepassBTN.Name = "hidepassBTN"
        Me.hidepassBTN.Size = New System.Drawing.Size(25, 25)
        Me.hidepassBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.hidepassBTN.TabIndex = 12
        Me.hidepassBTN.TabStop = False
        Me.hidepassBTN.Visible = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1051, 551)
        Me.Controls.Add(Me.hidepassBTN)
        Me.Controls.Add(Me.showpassBTN)
        Me.Controls.Add(Me.exitBTN)
        Me.Controls.Add(Me.usernameTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordLBL)
        Me.Controls.Add(Me.passwordTB)
        Me.Controls.Add(Me.loginBTN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showpassBTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidepassBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginBTN As Button
    Friend WithEvents passwordLBL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents usernameTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitBTN As Button
    Friend WithEvents showpassBTN As PictureBox
    Friend WithEvents hidepassBTN As PictureBox
End Class
