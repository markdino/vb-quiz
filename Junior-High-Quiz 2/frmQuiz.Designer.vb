<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BSquiz = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New Junior_High_Quiz_2.quizDataSet()
        Me.APTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.APTableAdapter()
        Me.ComputerTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ComputerTableAdapter()
        Me.EnglishTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.EnglishTableAdapter()
        Me.FilipinoTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.FilipinoTableAdapter()
        Me.MapehTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.MapehTableAdapter()
        Me.MathTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.MathTableAdapter()
        Me.ScienceTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ScienceTableAdapter()
        Me.TLETableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.TLETableAdapter()
        Me.ValuesTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ValuesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuizDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CorrectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.BSquiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSquiz
        '
        Me.BSquiz.DataMember = "Values"
        Me.BSquiz.DataSource = Me.QuizDataSet
        '
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "quizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APTableAdapter
        '
        Me.APTableAdapter.ClearBeforeFill = True
        '
        'ComputerTableAdapter
        '
        Me.ComputerTableAdapter.ClearBeforeFill = True
        '
        'EnglishTableAdapter
        '
        Me.EnglishTableAdapter.ClearBeforeFill = True
        '
        'FilipinoTableAdapter
        '
        Me.FilipinoTableAdapter.ClearBeforeFill = True
        '
        'MapehTableAdapter
        '
        Me.MapehTableAdapter.ClearBeforeFill = True
        '
        'MathTableAdapter
        '
        Me.MathTableAdapter.ClearBeforeFill = True
        '
        'ScienceTableAdapter
        '
        Me.ScienceTableAdapter.ClearBeforeFill = True
        '
        'TLETableAdapter
        '
        Me.TLETableAdapter.ClearBeforeFill = True
        '
        'ValuesTableAdapter
        '
        Me.ValuesTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.QuizDataGridViewTextBoxColumn, Me.ADataGridViewTextBoxColumn, Me.BDataGridViewTextBoxColumn, Me.CDataGridViewTextBoxColumn, Me.DDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.TakeDataGridViewCheckBoxColumn, Me.CorrectDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BSquiz
        Me.DataGridView1.Location = New System.Drawing.Point(810, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(198, 97)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuizDataGridViewTextBoxColumn
        '
        Me.QuizDataGridViewTextBoxColumn.DataPropertyName = "Quiz"
        Me.QuizDataGridViewTextBoxColumn.HeaderText = "Quiz"
        Me.QuizDataGridViewTextBoxColumn.Name = "QuizDataGridViewTextBoxColumn"
        Me.QuizDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADataGridViewTextBoxColumn
        '
        Me.ADataGridViewTextBoxColumn.DataPropertyName = "A"
        Me.ADataGridViewTextBoxColumn.HeaderText = "A"
        Me.ADataGridViewTextBoxColumn.Name = "ADataGridViewTextBoxColumn"
        Me.ADataGridViewTextBoxColumn.ReadOnly = True
        '
        'BDataGridViewTextBoxColumn
        '
        Me.BDataGridViewTextBoxColumn.DataPropertyName = "B"
        Me.BDataGridViewTextBoxColumn.HeaderText = "B"
        Me.BDataGridViewTextBoxColumn.Name = "BDataGridViewTextBoxColumn"
        Me.BDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CDataGridViewTextBoxColumn
        '
        Me.CDataGridViewTextBoxColumn.DataPropertyName = "C"
        Me.CDataGridViewTextBoxColumn.HeaderText = "C"
        Me.CDataGridViewTextBoxColumn.Name = "CDataGridViewTextBoxColumn"
        Me.CDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DDataGridViewTextBoxColumn
        '
        Me.DDataGridViewTextBoxColumn.DataPropertyName = "D"
        Me.DDataGridViewTextBoxColumn.HeaderText = "D"
        Me.DDataGridViewTextBoxColumn.Name = "DDataGridViewTextBoxColumn"
        Me.DDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TakeDataGridViewCheckBoxColumn
        '
        Me.TakeDataGridViewCheckBoxColumn.DataPropertyName = "take"
        Me.TakeDataGridViewCheckBoxColumn.HeaderText = "take"
        Me.TakeDataGridViewCheckBoxColumn.Name = "TakeDataGridViewCheckBoxColumn"
        Me.TakeDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CorrectDataGridViewTextBoxColumn
        '
        Me.CorrectDataGridViewTextBoxColumn.DataPropertyName = "Correct"
        Me.CorrectDataGridViewTextBoxColumn.HeaderText = "Correct"
        Me.CorrectDataGridViewTextBoxColumn.Name = "CorrectDataGridViewTextBoxColumn"
        Me.CorrectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnA
        '
        Me.btnA.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnA.Location = New System.Drawing.Point(176, 299)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(172, 47)
        Me.btnA.TabIndex = 2
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnB.Location = New System.Drawing.Point(176, 371)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(172, 47)
        Me.btnB.TabIndex = 2
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnC.Location = New System.Drawing.Point(444, 299)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(172, 47)
        Me.btnC.TabIndex = 2
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnD.Location = New System.Drawing.Point(444, 371)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(172, 47)
        Me.btnD.TabIndex = 2
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuestion.Location = New System.Drawing.Point(15, 66)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuestion.Size = New System.Drawing.Size(773, 216)
        Me.txtQuestion.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(12, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 43)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Label1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmQuiz"
        Me.Text = "frmQuiz"
        CType(Me.BSquiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BSquiz As BindingSource
    Friend WithEvents QuizDataSet As quizDataSet
    Friend WithEvents APTableAdapter As quizDataSetTableAdapters.APTableAdapter
    Friend WithEvents ComputerTableAdapter As quizDataSetTableAdapters.ComputerTableAdapter
    Friend WithEvents EnglishTableAdapter As quizDataSetTableAdapters.EnglishTableAdapter
    Friend WithEvents FilipinoTableAdapter As quizDataSetTableAdapters.FilipinoTableAdapter
    Friend WithEvents MapehTableAdapter As quizDataSetTableAdapters.MapehTableAdapter
    Friend WithEvents MathTableAdapter As quizDataSetTableAdapters.MathTableAdapter
    Friend WithEvents ScienceTableAdapter As quizDataSetTableAdapters.ScienceTableAdapter
    Friend WithEvents TLETableAdapter As quizDataSetTableAdapters.TLETableAdapter
    Friend WithEvents ValuesTableAdapter As quizDataSetTableAdapters.ValuesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuizDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TakeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CorrectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents lblTitle As Label
End Class
