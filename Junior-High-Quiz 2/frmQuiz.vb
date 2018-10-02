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

        LoadQuiz()
    End Sub

    Public Sub LoadQuiz()
        Dim x As String = quizIndex()
        While DataGridView1.Rows(x).Cells(7).Value = True

            x = quizIndex()

        End While

        txtQuestion.Text = DataGridView1.Rows(x).Cells(1).Value
        btnA.Text = DataGridView1.Rows(x).Cells(2).Value
        btnB.Text = DataGridView1.Rows(x).Cells(3).Value
        btnC.Text = DataGridView1.Rows(x).Cells(4).Value
        btnD.Text = DataGridView1.Rows(x).Cells(5).Value
        notes = DataGridView1.Rows(x).Cells(6).Value
        correctAns = DataGridView1.Rows(x).Cells(8).Value
        DataGridView1.Rows(x).Cells(7).Value = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadQuiz()
    End Sub

    Function quizIndex()
        Dim i As Integer = Format((Rnd() * DataGridView1.RowCount - 1), "0")
        While i <= 0
            i = Format((Rnd() * DataGridView1.RowCount - 1), "0")
        End While

        Return i
    End Function
End Class