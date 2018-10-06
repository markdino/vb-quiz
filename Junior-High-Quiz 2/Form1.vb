Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnAP.Click, btnVal.Click, btnMap.Click, btnTLE.Click, btnSci.Click, btnMath.Click, btnFil.Click, btnEng.Click, btnComp.Click
        frmQuiz.Show()
    End Sub
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnAP.MouseEnter, btnVal.MouseEnter, btnMap.MouseEnter, btnTLE.MouseEnter, btnSci.MouseEnter, btnMath.MouseEnter, btnFil.MouseEnter, btnEng.MouseEnter, btnComp.MouseEnter
        sender.forecolor = Color.White
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnAP.MouseLeave, btnVal.MouseLeave, btnMap.MouseLeave, btnTLE.MouseLeave, btnSci.MouseLeave, btnMath.MouseLeave, btnFil.MouseLeave, btnEng.MouseLeave, btnComp.MouseLeave
        sender.forecolor = Color.Black
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        centerPanel()

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        centerPanel()
    End Sub
    Private Sub centerPanel()
        Dim myWidth As Integer = mainPanel.Width
        Dim myHeight As Integer = mainPanel.Height

        mainPanel.Left = (Width - myWidth) / 2
        mainPanel.Top = (Height - myHeight) / 2
    End Sub


End Class
