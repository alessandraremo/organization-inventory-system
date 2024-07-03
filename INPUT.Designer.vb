<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INPUT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim Birthday As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INPUT))
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Birthday = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Birthday
        '
        Birthday.AutoSize = True
        Birthday.Location = New System.Drawing.Point(20, 210)
        Birthday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Birthday.Name = "Birthday"
        Birthday.Size = New System.Drawing.Size(45, 13)
        Birthday.TabIndex = 11
        Birthday.Text = "Birthday"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(16, 35)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(236, 20)
        Me.txtFirstname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LastName"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(173, 263)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(79, 20)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(16, 84)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(236, 20)
        Me.txtLastname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(18, 131)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAge.MaxLength = 12
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(69, 20)
        Me.txtAge.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender"
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(20, 177)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(92, 21)
        Me.cbGender.TabIndex = 9
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(22, 231)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(151, 20)
        Me.dtpBirthday.TabIndex = 12
        '
        'addBTN
        '
        Me.addBTN.BackColor = System.Drawing.Color.SteelBlue
        Me.addBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.addBTN.FlatAppearance.BorderSize = 0
        Me.addBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.ForeColor = System.Drawing.Color.White
        Me.addBTN.Image = CType(resources.GetObject("addBTN.Image"), System.Drawing.Image)
        Me.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addBTN.Location = New System.Drawing.Point(284, 158)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.addBTN.Size = New System.Drawing.Size(132, 28)
        Me.addBTN.TabIndex = 100
        Me.addBTN.Text = " Upload"
        Me.addBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addBTN.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.MHNOJP_MEMBER_PROFILE.My.Resources.Resources.blankphoto
        Me.PictureBox1.Location = New System.Drawing.Point(285, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'INPUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(435, 309)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Birthday)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "INPUT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents addBTN As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
