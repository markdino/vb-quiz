<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BSquiz = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New Junior_High_Quiz_2.quizDataSet()
        Me.APTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.APTableAdapter()
        Me.ComputerTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ComputerTableAdapter()
        Me.Copy_Of_MathTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.Copy_Of_MathTableAdapter()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboSubj = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BSquiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSquiz
        '
        Me.BSquiz.DataMember = "Math"
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
        'Copy_Of_MathTableAdapter
        '
        Me.Copy_Of_MathTableAdapter.ClearBeforeFill = True
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
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.QuizDataGridViewTextBoxColumn, Me.ADataGridViewTextBoxColumn, Me.BDataGridViewTextBoxColumn, Me.CDataGridViewTextBoxColumn, Me.DDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.TakeDataGridViewCheckBoxColumn, Me.CorrectDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BSquiz
        Me.DataGridView1.Location = New System.Drawing.Point(18, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(745, 243)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 303)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No."
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(63, 300)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(66, 26)
        Me.txtID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 339)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Question:"
        '
        'txtQ
        '
        Me.txtQ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "Quiz", True))
        Me.txtQ.Location = New System.Drawing.Point(26, 364)
        Me.txtQ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQ.Multiline = True
        Me.txtQ.Name = "txtQ"
        Me.txtQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQ.Size = New System.Drawing.Size(422, 198)
        Me.txtQ.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(459, 303)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Answers:"
        '
        'txtA
        '
        Me.txtA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "A", True))
        Me.txtA.Location = New System.Drawing.Point(463, 328)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(146, 26)
        Me.txtA.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "C", True))
        Me.txtC.Location = New System.Drawing.Point(617, 328)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(146, 26)
        Me.txtC.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "B", True))
        Me.txtB.Location = New System.Drawing.Point(463, 364)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(146, 26)
        Me.txtB.TabIndex = 2
        '
        'txtD
        '
        Me.txtD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "D", True))
        Me.txtD.Location = New System.Drawing.Point(617, 364)
        Me.txtD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(146, 26)
        Me.txtD.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(459, 404)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Correct answers:"
        '
        'txtCorrect
        '
        Me.txtCorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorrect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "Correct", True))
        Me.txtCorrect.Location = New System.Drawing.Point(463, 429)
        Me.txtCorrect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.Size = New System.Drawing.Size(146, 26)
        Me.txtCorrect.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(459, 467)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSquiz, "Notes", True))
        Me.txtNotes.Location = New System.Drawing.Point(463, 492)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(310, 70)
        Me.txtNotes.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(330, 567)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 39)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(436, 567)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(567, 567)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 39)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(673, 567)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 39)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboSubj
        '
        Me.cboSubj.FormattingEnabled = True
        Me.cboSubj.Items.AddRange(New Object() {"AP", "Computer", "Math", "English", "Filipino", "Mapeh", "Science", "TLE", "Values"})
        Me.cboSubj.Location = New System.Drawing.Point(18, 14)
        Me.cboSubj.Name = "cboSubj"
        Me.cboSubj.Size = New System.Drawing.Size(253, 28)
        Me.cboSubj.TabIndex = 4
        Me.cboSubj.Text = "Select Subject Here . . ."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAddQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboSubj)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCorrect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(802, 665)
        Me.Name = "frmAddQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Quiz"
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
    Friend WithEvents Copy_Of_MathTableAdapter As quizDataSetTableAdapters.Copy_Of_MathTableAdapter
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboSubj As ComboBox
    Friend WithEvents Button1 As Button
End Class
