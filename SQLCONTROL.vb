Imports System.Data
Imports System.Data.SqlClient
Public Class SQLCONTROL

    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source=LAPTOP-5AKCDL7S;Initial Catalog=MHNOJP;Integrated Security=True"}
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Public Function Hasconnection() As Boolean
        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()

            Dim R As SqlDataReader = cmd.ExecuteReader

            While R.Read
                MsgBox(R.GetName(0) & ": " & R(1))
            End While

            SQLCon.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
