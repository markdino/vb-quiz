Public Class frmSplash
    Dim displayCount As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Opacity < 1 Then
            Opacity += 0.05
        Else
            Timer1.Interval = 1000
            If lblProgress.Text = "Loading . . ." Then
                lblProgress.Text = "Loading ."
            ElseIf lblProgress.Text = "Loading ." Then
                lblProgress.Text = "Loading . ."
            ElseIf lblProgress.Text = "Loading . ." Then
                lblProgress.Text = "Loading . . ."
            End If
            displayCount += 1
            If displayCount = 10 Then
                lblProgress.Text = "Completed"
                BackgroundImage = My.Resources.splash2
            ElseIf displayCount = 11 Then
                frmUser.Show()
                frmUser.Focus()
                Close()

            End If
        End If


    End Sub
End Class