Public Class frmAddQuiz
    Private Sub frmAddQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableEdit()
        btnAdd.Enabled = False
        Me.Hide()
        'Form1.Show()

        frmUser.Show()
    End Sub

    Private Sub cboSubj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubj.SelectedIndexChanged
        'TODO: This line of code loads data into the 'QuizDataSet.Values' table. You can move, or remove it, as needed.
        Me.ValuesTableAdapter.Fill(Me.QuizDataSet.Values)
        Me.TLETableAdapter.Fill(Me.QuizDataSet.TLE)
        Me.ScienceTableAdapter.Fill(Me.QuizDataSet.Science)
        Me.MathTableAdapter.Fill(Me.QuizDataSet.Math)
        Me.MapehTableAdapter.Fill(Me.QuizDataSet.Mapeh)
        Me.FilipinoTableAdapter.Fill(Me.QuizDataSet.Filipino)
        Me.EnglishTableAdapter.Fill(Me.QuizDataSet.English)
        Me.Copy_Of_MathTableAdapter.Fill(Me.QuizDataSet.Copy_Of_Math)
        Me.ComputerTableAdapter.Fill(Me.QuizDataSet.Computer)
        Me.APTableAdapter.Fill(Me.QuizDataSet.AP)

        BSquiz.DataMember = cboSubj.Text
        btnAdd.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BSquiz.AddNew()
        txtID.Text = DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value + 1
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Validate()
        BSquiz.EndEdit()
        UpdateData()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BSquiz.RemoveCurrent()
    End Sub

    Private Sub UpdateData()
        If cboSubj.Text = "Math" Then
            MathTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Science" Then
            ScienceTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "AP" Then
            APTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Computer" Then
            ComputerTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "English" Then
            EnglishTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Filipino" Then
            FilipinoTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Mapeh" Then
            MapehTableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "TLE" Then
            TLETableAdapter.Update(QuizDataSet)
        ElseIf cboSubj.Text = "Values" Then
            ValuesTableAdapter.Update(QuizDataSet)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtQ.Clear()
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtD.Clear()
        txtCorrect.Clear()
        txtNotes.Clear()
    End Sub
    Private Sub restrictRow1()
        If txtID.Text = "1" Then
            disableEdit()
        Else
            enableEdit()
        End If
    End Sub
    Private Sub disableEdit()
        btnClear.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        txtQ.Enabled = False
        txtA.Enabled = False
        txtB.Enabled = False
        txtC.Enabled = False
        txtD.Enabled = False
        txtCorrect.Enabled = False
        txtNotes.Enabled = False
    End Sub
    Private Sub enableEdit()
        btnClear.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
        txtQ.Enabled = True
        txtA.Enabled = True
        txtB.Enabled = True
        txtC.Enabled = True
        txtD.Enabled = True
        txtCorrect.Enabled = True
        txtNotes.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Hide()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        restrictRow1()
    End Sub
End Class