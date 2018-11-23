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
        Me.lifePanel = New System.Windows.Forms.Panel()
        Me.heart3 = New System.Windows.Forms.PictureBox()
        Me.heart2 = New System.Windows.Forms.PictureBox()
        Me.heart1 = New System.Windows.Forms.PictureBox()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.heart4 = New System.Windows.Forms.PictureBox()
        Me.heart5 = New System.Windows.Forms.PictureBox()
        CType(Me.BSquiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lifePanel.SuspendLayout()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuPanel.SuspendLayout()
        CType(Me.heart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(934, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(848, 154)
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
        Me.btnA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.Location = New System.Drawing.Point(334, 301)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(201, 47)
        Me.btnA.TabIndex = 2
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(334, 373)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(201, 47)
        Me.btnB.TabIndex = 2
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(647, 301)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(201, 47)
        Me.btnC.TabIndex = 2
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.Location = New System.Drawing.Point(647, 373)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(201, 47)
        Me.btnD.TabIndex = 2
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'txtQuestion
        '
        Me.txtQuestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(234, 66)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuestion.Size = New System.Drawing.Size(684, 216)
        Me.txtQuestion.TabIndex = 3
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(412, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(342, 43)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Label1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lifePanel
        '
        Me.lifePanel.Controls.Add(Me.heart5)
        Me.lifePanel.Controls.Add(Me.heart4)
        Me.lifePanel.Controls.Add(Me.heart3)
        Me.lifePanel.Controls.Add(Me.heart2)
        Me.lifePanel.Controls.Add(Me.heart1)
        Me.lifePanel.Location = New System.Drawing.Point(234, 25)
        Me.lifePanel.Name = "lifePanel"
        Me.lifePanel.Size = New System.Drawing.Size(172, 40)
        Me.lifePanel.TabIndex = 5
        '
        'heart3
        '
        Me.heart3.Image = Global.Junior_High_Quiz_2.My.Resources.Resources.heart
        Me.heart3.Location = New System.Drawing.Point(71, 5)
        Me.heart3.Name = "heart3"
        Me.heart3.Size = New System.Drawing.Size(30, 30)
        Me.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart3.TabIndex = 0
        Me.heart3.TabStop = False
        '
        'heart2
        '
        Me.heart2.Image = Global.Junior_High_Quiz_2.My.Resources.Resources.heart
        Me.heart2.Location = New System.Drawing.Point(37, 5)
        Me.heart2.Name = "heart2"
        Me.heart2.Size = New System.Drawing.Size(30, 30)
        Me.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart2.TabIndex = 0
        Me.heart2.TabStop = False
        '
        'heart1
        '
        Me.heart1.Image = Global.Junior_High_Quiz_2.My.Resources.Resources.heart
        Me.heart1.Location = New System.Drawing.Point(3, 5)
        Me.heart1.Name = "heart1"
        Me.heart1.Size = New System.Drawing.Size(30, 30)
        Me.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart1.TabIndex = 0
        Me.heart1.TabStop = False
        '
        'menuPanel
        '
        Me.menuPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.menuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuPanel.Controls.Add(Me.Button3)
        Me.menuPanel.Controls.Add(Me.btnNext)
        Me.menuPanel.Controls.Add(Me.Button1)
        Me.menuPanel.Location = New System.Drawing.Point(0, 66)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(200, 382)
        Me.menuPanel.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(11, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(11, 84)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(171, 47)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Retry"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.AutoSize = True
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(-1, 25)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(63, 42)
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'heart4
        '
        Me.heart4.Image = Global.Junior_High_Quiz_2.My.Resources.Resources.heart
        Me.heart4.Location = New System.Drawing.Point(105, 5)
        Me.heart4.Name = "heart4"
        Me.heart4.Size = New System.Drawing.Size(30, 30)
        Me.heart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart4.TabIndex = 0
        Me.heart4.TabStop = False
        '
        'heart5
        '
        Me.heart5.Image = Global.Junior_High_Quiz_2.My.Resources.Resources.heart
        Me.heart5.Location = New System.Drawing.Point(139, 4)
        Me.heart5.Name = "heart5"
        Me.heart5.Size = New System.Drawing.Size(30, 30)
        Me.heart5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart5.TabIndex = 0
        Me.heart5.TabStop = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.menuPanel)
        Me.Controls.Add(Me.lifePanel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(949, 489)
        Me.Name = "frmQuiz"
        Me.Text = "frmQuiz"
        CType(Me.BSquiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lifePanel.ResumeLayout(False)
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuPanel.ResumeLayout(False)
        CType(Me.heart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lifePanel As Panel
    Friend WithEvents heart1 As PictureBox
    Friend WithEvents heart3 As PictureBox
    Friend WithEvents heart2 As PictureBox
    Friend WithEvents menuPanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents heart5 As PictureBox
    Friend WithEvents heart4 As PictureBox
End Class
