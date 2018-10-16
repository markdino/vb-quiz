Public Class frmQuiz
    Dim correctAns, notes As String

    Private Sub frmQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizDataSet.Values' table. You can move, or remove it, as needed.
        Me.ValuesTableAdapter.Fill(Me.QuizDataSet.Values)
        'TODO: This line of code loads data into the 'QuizDataSet.TLE' table. You can move, or remove it, as needed.
        Me.TLETableAdapter.Fill(Me.QuizDataSet.TLE)
        'TODO: This line of code loads data into the 'QuizDataSet.Science' table. You can move, or remove it, as needed.
        Me.ScienceTableAdapter.Fill(Me.QuizDataSet.Science)
        'TODO: This line of code loads data into the 'QuizDataSet.Math' table. You can move, or remove it, as needed.
        Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        'TODO: This line of code loads data into the 'QuizDataSet.Mapeh' table. You can move, or remove it, as needed.
        Me.MapehTableAdapter.Fill(Me.QuizDataSet.Mapeh)
        'TODO: This line of code loads data into the 'QuizDataSet.Filipino' table. You can move, or remove it, as needed.
        Me.FilipinoTableAdapter.Fill(Me.QuizDataSet.Filipino)
        'TODO: This line of code loads data into the 'QuizDataSet.English' table. You can move, or remove it, as needed.
        Me.EnglishTableAdapter.Fill(Me.QuizDataSet.English)
        'TODO: This line of code loads data into the 'QuizDataSet.Computer' table. You can move, or remove it, as needed.
        Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        'TODO: This line of code loads data into the 'QuizDataSet.AP' table. You can move, or remove it, as needed.
        Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

        btnResponsive()
        quizFilter()
        'LoadQuiz()
    End Sub

    Private Sub txtQuestion_Resize(sender As Object, e As EventArgs) Handles txtQuestion.Resize
        btnResponsive()
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