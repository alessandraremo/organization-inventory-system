Imports System.IO
Imports System.Data.SqlClient

Public Class INPUT
    Dim SQL As New SQLManager()
    Dim OpenFileDialog1 As OpenFileDialog ' Declare OpenFileDialog1

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            SQL.BeginTransaction()

            Dim Query As String = "INSERT INTO FORM (firstName, lastName, age, gender, birthday, pic) " &
                                  "VALUES (@firstName, @lastName, @age, @gender, @birthday, @pic)"

            SQL.FlushParams()
            SQL.AddParam("@firstName", txtFirstname.Text)
            SQL.AddParam("@lastName", txtLastname.Text)


            ' Convert image to byte array if PictureBox has an image
            If PictureBox1.Image IsNot Nothing Then
                Dim ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                SQL.AddParam("@pic", ms.ToArray(), SqlDbType.Image)
                ms.Close()
            Else
                SQL.AddParam("@pic", DBNull.Value, SqlDbType.Image)
            End If

            ' Convert age to integer before adding as parameter
            Dim age As Integer
            If Integer.TryParse(txtAge.Text, age) Then
                SQL.AddParam("@age", age)
            Else
                MessageBox.Show("Invalid age. Please enter a valid number.")
                Return
            End If

            ' Add gender parameter from ComboBox
            If cbGender.SelectedIndex <> -1 Then
                SQL.AddParam("@gender", cbGender.SelectedItem.ToString())
            Else
                MessageBox.Show("Please select a gender.")
                Return
            End If

            ' Add birthDate parameter from DateTimePicker
            SQL.AddParam("@birthday", dtpBirthday.Value)


            SQL.ExecNonQuery(Query)
            SQL.Commit()
            MessageBox.Show("Successfully Added!")
        Catch ex As Exception
            SQL.Rollback()
            MessageBox.Show(ex.Message)
        Finally
            SQL.CloseCon()
        End Try
    End Sub

    Private Sub INPUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbGender.Items.AddRange({"Priestly Ministry", "Prophetic Ministry", "Kingly Ministry"})
        OpenFileDialog1 = New OpenFileDialog()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files|*.png;*.jpeg;*.jpg;"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName) ' Corrected property name
        End If
    End Sub

End Class
