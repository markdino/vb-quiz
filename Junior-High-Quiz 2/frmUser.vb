Public Class frmUser
    Dim newUser As Boolean = False
    Dim userFile As String = Application.StartupPath & "\user.txt"
    Dim userList As String
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreader As New System.IO.StreamReader(userFile)
        userList = objreader.ReadToEnd
        cboUser.Items.AddRange(IO.File.ReadAllLines(userFile))
        objreader.Close()
    End Sub
    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged
        If cboUser.Items.Contains(cboUser.Text) Then
            btnLogin.Enabled = True
            newUser = False
        End If

        If cboUser.Text = "<Add new user>" Then
            newUser = True
            cboUser.Text = ""
            btnExit.Text = "true"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userReady As Boolean = False
        If cboUser.Text = "Admin" Then
            frmAddQuiz.Show()
            frmAddQuiz.WindowState = FormWindowState.Maximized
            Form1.lblUser.Text = cboUser.Text
            Close()
        ElseIf cboUser.Text.Length > 1 Then
            userReady = True
            If newUser = True Then
                If cboUser.Items.Contains(cboUser.Text) Then
                    MsgBox("Username already taken!", MsgBoxStyle.Exclamation, "User")
                    userReady = False
                Else
                    cboUser.Items.Add(cboUser.Text)

                    Dim objWriter As New System.IO.StreamWriter(userFile)
                    objWriter.Write(cboUser.Text & vbCrLf & userList)
                    objWriter.Close()
                    MsgBox(cboUser.Text & vbCrLf & userList)

                    userReady = True
                End If

            End If
            If userReady = True Then
                Form1.lblUser.Text = cboUser.Text
                Form1.Show()
                Close()
            End If

        Else
            MsgBox("Invalid Username, Please use another username.", vbExclamation, "Invalid")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frmAddQuiz.Hide()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If

    End Sub
    Private Sub ControlBOx_Enter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter, btnMax.MouseEnter, btnMin.MouseEnter
        sender.ForeColor = Color.White
        sender.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub ControlBOx_Leave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave, btnMax.MouseLeave, btnMin.MouseLeave
        sender.ForeColor = Color.Black
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private Sub cboUser_KeyDown(sender As Object, e As KeyEventArgs) Handles cboUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not cboUser.Text = "Select User Here . . ." Then
                btnLogin_Click(sender, e)
            End If
        End If
    End Sub
End Class