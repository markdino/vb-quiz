Public Class frmAddQuiz
    Private Sub frmAddQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'TODO: This line of code loads data into the 'QuizDataSet.Copy_Of_Math' table. You can move, or remove it, as needed.
        Me.Copy_Of_MathTableAdapter.Fill(Me.QuizDataSet.Copy_Of_Math)
        'TODO: This line of code loads data into the 'QuizDataSet.Computer' table. You can move, or remove it, as needed.
        Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        'TODO: This line of code loads data into the 'QuizDataSet.AP' table. You can move, or remove it, as needed.
        Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

    End Sub

    Private Sub cboSubj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubj.SelectedIndexChanged
        BSquiz.DataMember = cboSubj.Text
    End Sub
End Class