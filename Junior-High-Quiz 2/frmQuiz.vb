Public Class frmQuiz
    Dim correctAns, notes As String
    Dim globalIndex, topScore As Integer
    Dim userLife As Integer = 5
    Dim userScore As Integer = 0

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
        Dim x As String = quizIndex()
        While DataGridView1.Rows(x).Cells(7).Value = True

            x = quizIndex()

        End While

        txtQuestion.Text = DataGridView1.Rows(x).Cells(1).Value.ToString
        btnA.Text = DataGridView1.Rows(x).Cells(2).Value.ToString
        btnB.Text = DataGridView1.Rows(x).Cells(3).Value.ToString
        btnC.Text = DataGridView1.Rows(x).Cells(4).Value.ToString
        btnD.Text = DataGridView1.Rows(x).Cells(5).Value.ToString
        notes = DataGridView1.Rows(x).Cells(6).Value.ToString
        correctAns = DataGridView1.Rows(x).Cells(8).Value.ToString
        DataGridView1.Rows(x).Cells(7).Value = True

        globalIndex = x
    End Sub


    Function quizIndex()
        Dim i As Integer = Format((Rnd() * DataGridView1.RowCount - 1), "0")
        While i <= 0
            i = Format((Rnd() * DataGridView1.RowCount - 1), "0")
        End While

        Return i
    End Function
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
        'DataGridView1.Rows(globalIndex).Cells(7).Value = False
        reloadTable()
        quizFilter()
        checkQuizCount()
        'frmQuiz_Load(sender, e)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click

    End Sub

    Private Sub btnResponsive()
        Dim col6 As Integer = txtQuestion.Width / 6
        Dim btnWidth As Integer = col6 * 2 - 10
        Dim spanLeft As Integer = txtQuestion.Left
        btnA.Left = col6 + spanLeft
        btnB.Left = col6 + spanLeft
        btnC.Left = col6 * 3 + 10 + spanLeft
        btnD.Left = col6 * 3 + 10 + spanLeft

        btnA.Width = btnWidth
        btnB.Width = btnWidth
        btnC.Width = btnWidth
        btnD.Width = btnWidth

        lblTitle.Width = col6 * 2
        lblTitle.Left = col6 * 2 + spanLeft

        lifePanel.Left = spanLeft
    End Sub


End Class