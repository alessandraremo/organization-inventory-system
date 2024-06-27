Imports System.IO
Imports System.Data.SqlClient

Public Class ADD

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim OpenFileDialog1 As OpenFileDialog ' Declare OpenFileDialog1


    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' Check for null or empty values before attempting to insert into the database
        If String.IsNullOrWhiteSpace(fnameTB.Text) OrElse String.IsNullOrWhiteSpace(mNameTB.Text) OrElse
           String.IsNullOrWhiteSpace(lNameTB.Text) OrElse String.IsNullOrWhiteSpace(birthPlaceTB.Text) OrElse
           String.IsNullOrWhiteSpace(ageTB.Text) OrElse String.IsNullOrWhiteSpace(addressTB.Text) OrElse
           String.IsNullOrWhiteSpace(memContactNoTB.Text) OrElse String.IsNullOrWhiteSpace(fbNameTB.Text) OrElse
           String.IsNullOrWhiteSpace(emailTB.Text) OrElse String.IsNullOrWhiteSpace(baptisimMinisterTB.Text) OrElse
           String.IsNullOrWhiteSpace(baptisimParishTB.Text) OrElse String.IsNullOrWhiteSpace(fhcMinisterTB.Text) OrElse
           String.IsNullOrWhiteSpace(fhcParishTB.Text) OrElse String.IsNullOrWhiteSpace(confirmationMinisterTB.Text) OrElse
           String.IsNullOrWhiteSpace(confirmationParishTB.Text) OrElse String.IsNullOrWhiteSpace(fullNameTB.Text) OrElse
           String.IsNullOrWhiteSpace(relationshipTB.Text) OrElse ministryCB.SelectedIndex = -1 OrElse
           organizationCB.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(skillsTB.Text) OrElse
           String.IsNullOrWhiteSpace(otherOrgTB.Text) Then

            MessageBox.Show("Please fill in all fields before adding the member.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Highlight and set focus on the first empty field
            If String.IsNullOrWhiteSpace(fnameTB.Text) Then
                fnameTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(mNameTB.Text) Then
                mNameTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(lNameTB.Text) Then
                lNameTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(birthPlaceTB.Text) Then
                birthPlaceTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(ageTB.Text) Then
                ageTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(addressTB.Text) Then
                addressTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(memContactNoTB.Text) Then
                memContactNoTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(fbNameTB.Text) Then
                fbNameTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(emailTB.Text) Then
                emailTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(baptisimMinisterTB.Text) Then
                baptisimMinisterTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(baptisimParishTB.Text) Then
                baptisimParishTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(fhcMinisterTB.Text) Then
                fhcMinisterTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(fhcParishTB.Text) Then
                fhcParishTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(confirmationMinisterTB.Text) Then
                confirmationMinisterTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(confirmationParishTB.Text) Then
                confirmationParishTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(fullNameTB.Text) Then
                fullNameTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(relationshipTB.Text) Then
                relationshipTB.Focus()
            ElseIf ministryCB.SelectedIndex = -1 Then
                ministryCB.Focus()
            ElseIf organizationCB.SelectedIndex = -1 Then
                organizationCB.Focus()
            ElseIf String.IsNullOrWhiteSpace(skillsTB.Text) Then
                skillsTB.Focus()
            ElseIf String.IsNullOrWhiteSpace(otherOrgTB.Text) Then
                otherOrgTB.Focus()
            End If

            Return
        End If

        Try
            con = New SqlConnection("Data Source=LAPTOP-5AKCDL7S;Initial Catalog=MHNOJP;Integrated Security=True") '-------connection string---------'
            con.Open()
            Dim Query As String
            Query = "INSERT INTO MEMBERS (firstName, middleName, lastName, birthday, birthplace, age, Address, ContactNumber, " &
                    "fbname, email, baptismMinister, baptismDate, baptismParish, CommunionMinister, CommunionDate, CommunionParish, " &
                    "confirmationMinister, confirmationDate, confirmationParish, ContactPerson, memContactNo, relationship, " &
                    "ministry, organization, skills, otherOrg, image) " &
                    "VALUES (@firstName, @middleName, @lastName, @birthday, @birthplace, @age, @Address, @ContactNumber, " &
                    "@fbname, @email, @baptismMinister, @baptismDate, @baptismParish, @CommunionMinister, @CommunionDate, @CommunionParish, " &
                    "@confirmationMinister, @confirmationDate, @confirmationParish, @ContactPerson, @memContactNo, @relationship, " &
                    "@ministry, @organization, @skills, @otherOrg, @image)"
            cmd = New SqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@firstName", fnameTB.Text)
            cmd.Parameters.AddWithValue("@middleName", mNameTB.Text)
            cmd.Parameters.AddWithValue("@lastName", lNameTB.Text)
            cmd.Parameters.AddWithValue("@birthday", birthdayDTP.Text)
            cmd.Parameters.AddWithValue("@birthplace", birthPlaceTB.Text)
            cmd.Parameters.AddWithValue("@age", ageTB.Text)
            cmd.Parameters.AddWithValue("@Address", addressTB.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", memContactNoTB.Text)
            cmd.Parameters.AddWithValue("@fbname", fbNameTB.Text)
            cmd.Parameters.AddWithValue("@email", emailTB.Text)
            cmd.Parameters.AddWithValue("@baptismMinister", baptisimMinisterTB.Text)
            cmd.Parameters.AddWithValue("@baptismDate", baptismDateDTP.Text)
            cmd.Parameters.AddWithValue("@baptismParish", baptisimParishTB.Text)
            cmd.Parameters.AddWithValue("@CommunionMinister", fhcMinisterTB.Text)
            cmd.Parameters.AddWithValue("@CommunionDate", fhcDateDTP.Text)
            cmd.Parameters.AddWithValue("@CommunionParish", fhcParishTB.Text)
            cmd.Parameters.AddWithValue("@confirmationMinister", confirmationMinisterTB.Text)
            cmd.Parameters.AddWithValue("@confirmationDate", confirmationDateDTP.Text)
            cmd.Parameters.AddWithValue("@confirmationParish", confirmationParishTB.Text)
            cmd.Parameters.AddWithValue("@ContactPerson", fullNameTB.Text)
            cmd.Parameters.AddWithValue("@memContactNo", memContactNoTB.Text)
            cmd.Parameters.AddWithValue("@relationship", relationshipTB.Text)
            cmd.Parameters.AddWithValue("@ministry", ministryCB.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@organization", organizationCB.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@skills", skillsTB.Text)
            cmd.Parameters.AddWithValue("@otherOrg", otherOrgTB.Text)
            ' Convert image to byte array if PictureBox has an image
            If PictureBox1.Image IsNot Nothing Then
                Dim ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                cmd.Parameters.AddWithValue("@Image", ms.GetBuffer())
                ms.Close()
            Else
                cmd.Parameters.AddWithValue("@Image", DBNull.Value)
            End If

            cmd.ExecuteNonQuery()

            MessageBox.Show("Successfully Added!")

            ' Clear all input fields after successful insertion
            For Each tb As TextBox In New TextBox() {fnameTB, mNameTB, lNameTB, birthPlaceTB, ageTB, addressTB, memContactNoTB, fbNameTB, emailTB, baptisimMinisterTB, baptisimParishTB, fhcMinisterTB, fhcParishTB, confirmationMinisterTB, confirmationParishTB, fullNameTB, relationshipTB, skillsTB, otherOrgTB}
                tb.Clear()
            Next

            For Each dtp As DateTimePicker In New DateTimePicker() {birthdayDTP, baptismDateDTP, fhcDateDTP, confirmationDateDTP}
                dtp.Value = DateTime.Now ' Reset to current date
            Next

            ministryCB.SelectedIndex = -1 ' Reset ComboBox selection
            organizationCB.Items.Clear() ' Clear items in organizationCB
            PictureBox1.Image = Nothing ' Clear PictureBox

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub ADD_Load(sender As Object, e As EventArgs) Handles Me.Load
        ministryCB.Items.AddRange({"Priestly Ministry", "Prophetic Ministry", "Kingly Ministry"})

        OpenFileDialog1 = New OpenFileDialog()

    End Sub

    Private Sub ministryCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ministryCB.SelectedIndexChanged
        organizationCB.Items.Clear()

        Select Case ministryCB.SelectedItem.ToString()
            Case "Priestly Ministry"
                organizationCB.Items.AddRange({"Lectors and Commentator Ministry", "Lingkod ng Dambana", "Extraordinary Ministers of the Holy Communion", "Paris Liturgical Music Ministry", "Mother Butler Guild", "Usher and Collector Guild", "Apostolado ng Panalangin", "Adoracion Nocturna Filipina", "Order of Franciscan Secular", "Holy Face of Jesus", "Little Brethren of Mary"})
            Case "Prophetic Ministry"
                organizationCB.Items.AddRange({"Catechist", "El Shaddai", "Parish Bible Ministry", "Parish Youth Ministry", "Sheperd of the Lord’s Sheep", "Couples for Christ", "Charismatic Movement", "Family and Life Ministry", "Dalaw Patron sa Kapitbahayang Katoliko"})
            Case "Kingly Ministry"
                organizationCB.Items.AddRange({"Health Ministry", "Ecology Ministry", "Temporalities", "PPCRV/Public Affairs", "Vocation Ministry", "Knights of Columbus", "Migrant Ministry", "Social Action Ministry", "Social Communication Ministry", "Human Resource"})
            Case Else
                organizationCB.Items.AddRange({"No Ministry Chosen"})
        End Select
    End Sub


    Private Sub resetBTN_Click(sender As Object, e As EventArgs) Handles resetBTN.Click

        ' Clear all input fields after successful insertion
        For Each tb As TextBox In New TextBox() {fnameTB, mNameTB, lNameTB, birthPlaceTB, ageTB, addressTB, memContactNoTB, fbNameTB, emailTB, baptisimMinisterTB, baptisimParishTB, fhcMinisterTB, fhcParishTB, confirmationMinisterTB, confirmationParishTB, fullNameTB, relationshipTB, skillsTB, otherOrgTB}
            tb.Clear()
        Next

        For Each dtp As DateTimePicker In New DateTimePicker() {birthdayDTP, baptismDateDTP, fhcDateDTP, confirmationDateDTP}
            dtp.Value = DateTime.Now ' Reset to current date
        Next

        ministryCB.SelectedIndex = -1 ' Reset ComboBox selection
        organizationCB.Items.Clear() ' Clear items in organizationCB

    End Sub

    Private Sub closeBTN_Click(sender As Object, e As EventArgs) Handles closeBTN.Click
        Me.Hide()
        ORGANIZATION.Show()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files|*.png;*.jpeg;*.jpg;"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName) ' Corrected property name

        End If
    End Sub

End Class