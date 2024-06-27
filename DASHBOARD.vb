Public Class DASHBOARD
    Dim isCollapsed As Boolean = True

    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orgPanel.Size = orgPanel.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then

            orgPanel.Height += 10
            If orgPanel.Height >= orgPanel.MaximumSize.Height Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            orgPanel.Height -= 10
            If orgPanel.Height <= orgPanel.MinimumSize.Height Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub organizationBTN_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub logoutBTN_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LOGIN.Show()
    End Sub

    Private Sub minitriesBTN_Click(sender As Object, e As EventArgs) Handles minitriesBTN.Click
        ORGANIZATION.Show()
        Me.Hide()
    End Sub

    Private Sub organizationBTN_Click_1(sender As Object, e As EventArgs) Handles organizationBTN.Click
        Timer1.Start()
    End Sub
End Class