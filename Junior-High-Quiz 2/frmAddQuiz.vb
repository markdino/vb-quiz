Public Class frmAddQuiz
    Private Sub frmAddQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableEdit()
        btnAdd.Enabled = False
        'Me.Hide()
        'Form1.Show()

        frmUser.Show()
        frmUser.Focus()

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
        txtQ.Focus()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtQ.TextLength > 0 And txtA.TextLength > 0 And txtB.TextLength > 0 And txtC.TextLength > 0 And txtD.TextLength > 0 And txtCorrect.TextLength > 0 Then
            Validate()
            BSquiz.EndEdit()
            UpdateData()
            MsgBox("Successfully saved and updated!", MsgBoxStyle.Information, "Saved")
        Else
            MsgBox("Some text field are empty. Please fill up the requied fields.", MsgBoxStyle.Exclamation, "Incomplete")
        End If

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to permanently delete this item?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            BSquiz.RemoveCurrent()
            MsgBox("Item deleted", MsgBoxStyle.Information, "Deleted")
        End If

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
        Form1.Show()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        restrictRow1()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnExit_Click(sender, e)
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
End Class