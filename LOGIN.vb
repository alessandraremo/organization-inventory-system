Imports System.Data
Imports System.Data.SqlClient

Public Class LOGIN

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click


        If (usernameTB.Text = "") Then
            MessageBox.Show("Enter Username")
            usernameTB.Focus() '-------focus username textbox---------'
            Exit Sub
        End If
        If (passwordTB.Text = "") Then
            MessageBox.Show("Enter Password")
            passwordTB.Focus() '-------focus password textbox---------'
            Exit Sub
        End If

        'Try
        '    con = New SqlConnection("Data Source=LAPTOP-5AKCDL7S;Initial Catalog=MHNOJP;Integrated Security=True") '-------connection string---------'
        '    con.Open()
        '    cmd = New SqlCommand(" select * from LOGIN where username= @username and password= '" & passwordTB.Text & "' ")
        '    cmd.Connection = con
        '    rdr = cmd.ExecuteReader()
        '    If (rdr.Read()) Then
        '        Me.Hide() '-------hide current form---------
        '        DASHBOARD.Show() '-------show form---------
        '    Else
        '        MessageBox.Show("Invalid username and password")
        '        passwordTB.Text = ""
        '        usernameTB.Text = ""
        '    End If

        'Catch ex As Exception
        'End Try

        Dim SQL As New SQLManager
        Dim query As String = "SELECT * FROM LOGIN WHERE username= @Username AND password= @Password "
        SQL.FlushParams()
        SQL.AddParam("@Username", usernameTB.Text)
        SQL.AddParam("@Password", passwordTB.Text)
        SQL.ReadQuery(query)
        If SQL.SQLDR.Read Then
            Me.Hide() '-------hide current form---------
            DASHBOARD.Show() '-------show form---------
        Else
            MessageBox.Show("Invalid username and password")
            passwordTB.Text = ""
            usernameTB.Text = ""
        End If

    End Sub

    Private Sub exitBTN_Click(sender As Object, e As EventArgs) Handles exitBTN.Click
        Me.Close()
    End Sub

    Private Sub showpassBTN_Click(sender As Object, e As EventArgs) Handles showpassBTN.Click
        passwordTB.UseSystemPasswordChar = False
        hidepassBTN.Show()
        showpassBTN.Hide()
    End Sub

    Private Sub hidepassBTN_Click(sender As Object, e As EventArgs) Handles hidepassBTN.Click
        passwordTB.UseSystemPasswordChar = True
        showpassBTN.Show()
        hidepassBTN.Hide()
    End Sub
End Class
