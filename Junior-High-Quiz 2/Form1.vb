Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizDataSet.Values' table. You can move, or remove it, as needed.
        Me.ValuesTableAdapter.Fill(Me.QuizDataSet.Values)
        Me.TLETableAdapter.Fill(Me.QuizDataSet.TLE)
        Me.ScienceTableAdapter.Fill(Me.QuizDataSet.Science)
        Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        Me.MapehTableAdapter.Fill(Me.QuizDataSet.Mapeh)
        Me.FilipinoTableAdapter.Fill(Me.QuizDataSet.Filipino)
        Me.EnglishTableAdapter.Fill(Me.QuizDataSet.English)
        Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

        centerPanel()
        respondUserUI()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        centerPanel()
        respondUserUI()
    End Sub
    Private Sub centerPanel()
        Dim myWidth As Integer = mainPanel.Width
        Dim myHeight As Integer = mainPanel.Height

        mainPanel.Left = (Width - myWidth) / 2
        mainPanel.Top = (Height - myHeight) / 2
    End Sub

    Private Sub respondUserUI()
        lblLogout.Left = (Width - lblLogout.Width) - 30
        lblUser.Left = (lblLogout.Left - lblUser.Width) - 5
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnAP.Click, btnVal.Click, btnMap.Click, btnTLE.Click, btnSci.Click, btnMath.Click, btnFil.Click, btnEng.Click, btnComp.Click
        frmQuiz.lblTitle.Text = sender.Text
        frmQuiz.Show()
        frmQuiz.WindowState = WindowState
    End Sub
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnAP.MouseEnter, btnVal.MouseEnter, btnMap.MouseEnter, btnTLE.MouseEnter, btnSci.MouseEnter, btnMath.MouseEnter, btnFil.MouseEnter, btnEng.MouseEnter, btnComp.MouseEnter
        sender.forecolor = Color.White
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnAP.MouseLeave, btnVal.MouseLeave, btnMap.MouseLeave, btnTLE.MouseLeave, btnSci.MouseLeave, btnMath.MouseLeave, btnFil.MouseLeave, btnEng.MouseLeave, btnComp.MouseLeave
        sender.forecolor = Color.Black
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        frmUser.Show()
        Close()

    End Sub

    Private Sub lblLogout_MouseHover(sender As Object, e As EventArgs) Handles lblLogout.MouseHover
        lblLogout.ForeColor = Color.Red

    End Sub

    Private Sub lblLogout_MouseLeave(sender As Object, e As EventArgs) Handles lblLogout.MouseLeave
        lblLogout.ForeColor = Color.Black
        lblLogout.Font = New Font(lblLogout.Font, FontStyle.Regular)

    End Sub

    Private Sub lblLogout_MouseEnter(sender As Object, e As EventArgs) Handles lblLogout.MouseEnter
        lblLogout.Font = New Font(lblLogout.Font, FontStyle.Bold)

    End Sub
End Class
