Public Class frmQuiz
    Dim correctAns, notes As String
    Dim userLife As Integer = 5
    Dim userScore As Integer = 0
    Dim topscore As Integer = 26

    Private Sub frmQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        BSquiz.DataMember = lblTitle.Text

        btnResponsive()
        quizFilter()
        checkQuizCount()
        Update_State()
    End Sub

    Private Sub txtQuestion_Resize(sender As Object, e As EventArgs) Handles txtQuestion.Resize
        btnResponsive()
    End Sub

    Private Sub checkQuizCount()
        Dim rowCountCheck As Integer = DataGridView1.RowCount
        If rowCountCheck > 2 Then
            LoadQuiz()
        Else
            MsgBox("Not enough quiz to load." & vbCrLf & "Please contact administrator to fix and load more quiz.", vbExclamation, "Warning")
            Close()
        End If
    End Sub
    Public Sub LoadQuiz()
        txtQuestion.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        btnA.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        btnB.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        btnC.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        btnD.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        notes = DataGridView1.CurrentRow.Cells(6).Value.ToString
        correctAns = DataGridView1.CurrentRow.Cells(8).Value.ToString
    End Sub

    Private Sub quizFilter()
        BSquiz.Filter = "take = " & False
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If menuPanel.Left >= 0 Then
            menuPanel.Left -= menuPanel.Width
            txtQuestion.Left -= menuPanel.Width
            txtQuestion.Width += menuPanel.Width
            btnMenu.Text = "|||"
            btnMenu.Width = 37
        ElseIf menuPanel.Left < 0 Then
            menuPanel.Left = 0
            txtQuestion.Left += menuPanel.Width
            txtQuestion.Width -= menuPanel.Width
            btnMenu.Text = "Menu"
            btnMenu.Width = 63
        End If
    End Sub
    Private Sub SaveTake()
        Validate()
        BSquiz.EndEdit()
        UpdateData()
    End Sub
    Private Sub UpdateData()
        If lblTitle.Text = "Math" Then
            MathTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "Science" Then
            ScienceTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "AP" Then
            APTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "Computer" Then
            ComputerTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "English" Then
            EnglishTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "Filipino" Then
            FilipinoTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "Mapeh" Then
            MapehTableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "TLE" Then
            TLETableAdapter.Update(QuizDataSet)
        ElseIf lblTitle.Text = "Values" Then
            ValuesTableAdapter.Update(QuizDataSet)
        End If
    End Sub
    Private Sub reloadTable()
        If lblTitle.Text = "Math" Then
            Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        ElseIf lblTitle.Text = "Science" Then
            ScienceTableAdapter.Fill(QuizDataSet.Science)
        ElseIf lblTitle.Text = "AP" Then
            APTableAdapter.Fill(QuizDataSet.AP)
        ElseIf lblTitle.Text = "Computer" Then
            ComputerTableAdapter.Fill(QuizDataSet.Computer)
        ElseIf lblTitle.Text = "English" Then
            EnglishTableAdapter.Fill(QuizDataSet.English)
        ElseIf lblTitle.Text = "Filipino" Then
            FilipinoTableAdapter.Fill(QuizDataSet.Filipino)
        ElseIf lblTitle.Text = "Mapeh" Then
            MapehTableAdapter.Fill(QuizDataSet.Mapeh)
        ElseIf lblTitle.Text = "TLE" Then
            TLETableAdapter.Fill(QuizDataSet.TLE)
        ElseIf lblTitle.Text = "Values" Then
            ValuesTableAdapter.Fill(QuizDataSet.Values)
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(1).Value = DataGridView1.CurrentRow.Cells(1).Value.ToString Then
            BSquiz.MoveFirst()

        Else
            BSquiz.MoveNext()
        End If

        quizFilter()
        checkQuizCount()
        Enable_Buttons()
        Reset_Timer()
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim rowIndex As Integer = DataGridView1.CurrentRow.Index.ToString()
        If rowIndex > 0 Then
            BSquiz.MovePrevious()
            LoadQuiz()
            Enable_Buttons()
        End If
        Reset_Timer()
    End Sub

    Private Sub AnswerButton_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click
        Timer1.Enabled = False
        If correctAns = sender.text Then
            userScore += 1
            DataGridView1.CurrentRow.Cells(7).Value = True
            MsgBox("You got the correct answer!", MsgBoxStyle.Information, "Correct")
            SaveTake()
            btnNext_Click(sender, e)
        Else
            userLife -= 1
            If userLife > 0 Then

                If MsgBox("Sorry, you got the wrong Answer" & vbCrLf & "Do you want to try again?" & vbCrLf & "Click ''YES'' to try again or click ''NO'' to proceed to another question.", MsgBoxStyle.RetryCancel + MsgBoxStyle.Critical, "Incorrect") = MsgBoxResult.Cancel Then
                    btnNext_Click(sender, e)
                Else
                    sender.Enabled = False
                    Reset_Timer()
                End If

            Else
                MsgBox("Game over!" & "Try again next time.", MsgBoxStyle.Exclamation, "Game over")
                BackToMain_Click(sender, e)
            End If

        End If
        Update_State()
    End Sub
    Private Sub BackToMain_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reset_Quiz()
        SaveTake()
        Close()
    End Sub
#Region "Subs for UI"
    Private Sub Enable_Buttons()
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
    End Sub

    Private Sub Restore_Life()
        heart5.Visible = True
        heart4.Visible = True
        heart3.Visible = True
        heart2.Visible = True
        heart1.Visible = True
    End Sub

    Private Sub Reset_Quiz()
        Enable_Buttons()
        Restore_Life()
        userScore = 0
        userLife = 5
        Hide()
    End Sub

    Private Sub Update_State()
        lblTopScore.Text = "Top Score: " & topscore
        lblMyScore.Text = Form1.lblUser.Text & ": " & userScore

        lblTopScore.Left = (txtQuestion.Left + txtQuestion.Width) - lblTopScore.Width
        lblMyScore.Left = (txtQuestion.Left + txtQuestion.Width) - lblMyScore.Width

        If lblMyScore.Width > lblTopScore.Width Then
            lblTime.Left = lblMyScore.Left - lblTime.Width
        Else
            lblTime.Left = lblTopScore.Left - lblTime.Width
        End If

        If userLife < 1 Then
            heart1.Visible = False
        ElseIf userLife < 2 Then
            heart2.Visible = False
        ElseIf userLife < 3 Then
            heart3.Visible = False
        ElseIf userLife < 4 Then
            heart4.Visible = False
        ElseIf userLife < 5 Then
            heart5.Visible = False
        End If

    End Sub
    Private Sub btnResponsive()
        PanelButton.Left = ((txtQuestion.Width - PanelButton.Width) / 2) + txtQuestion.Left
        PanelButton.Top = (Height - PanelButton.Height) - 40
    End Sub
#End Region

#Region "controlBox"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Reset_Quiz()
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
        cring()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text -= 1
        If lblTime.Text > 3 Then
            lblTime.ForeColor = Color.Yellow
        Else
            lblTime.ForeColor = Color.Red
        End If

        If lblTime.Text <= 0 Then
            Timer1.Enabled = False
            userLife -= 1
            MsgBox("Time's up!" & vbCrLf & "You need to answer before the countdown ends.", MsgBoxStyle.Critical, "Timer")
            btnNext_Click(sender, e)
            If userLife <= 0 Then
                MsgBox("Game over!" & "Try again next time.", MsgBoxStyle.Exclamation, "Game over")
                BackToMain_Click(sender, e)
            End If
            UpdateData()
        End If
    End Sub
    Private Sub Reset_Timer()
        Timer1.Enabled = True
        lblTime.Text = 10
        lblTime.ForeColor = Color.Yellow
    End Sub

    Private Sub ControlBOx_Leave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave, btnMax.MouseLeave, btnMin.MouseLeave
        sender.ForeColor = Color.Black
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnD_MouseEnter(sender As Object, e As EventArgs) Handles btnD.MouseEnter, btnC.MouseEnter, btnB.MouseEnter, btnA.MouseEnter
        hover()
    End Sub
#End Region

End Class