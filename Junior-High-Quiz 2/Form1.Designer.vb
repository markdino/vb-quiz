<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAP = New System.Windows.Forms.Button()
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
        Me.QuizDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New Junior_High_Quiz_2.quizDataSet()
        Me.btnComp = New System.Windows.Forms.Button()
        Me.btnEng = New System.Windows.Forms.Button()
        Me.btnFil = New System.Windows.Forms.Button()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnSci = New System.Windows.Forms.Button()
        Me.btnTLE = New System.Windows.Forms.Button()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.btnVal = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.APTableAdapter()
        Me.ComputerTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ComputerTableAdapter()
        Me.EnglishTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.EnglishTableAdapter()
        Me.FilipinoTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.FilipinoTableAdapter()
        Me.MapehTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.MapehTableAdapter()
        Me.MathTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.MathTableAdapter()
        Me.ScienceTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ScienceTableAdapter()
        Me.TLETableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.TLETableAdapter()
        Me.ValuesTableAdapter = New Junior_High_Quiz_2.quizDataSetTableAdapters.ValuesTableAdapter()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Label()
        Me.btnMax = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.AxWMP = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        CType(Me.AxWMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAP
        '
        Me.btnAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAP.ForeColor = System.Drawing.Color.Black
        Me.btnAP.Location = New System.Drawing.Point(28, 119)
        Me.btnAP.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAP.Name = "btnAP"
        Me.btnAP.Size = New System.Drawing.Size(268, 66)
        Me.btnAP.TabIndex = 0
        Me.btnAP.Text = "AP"
        Me.btnAP.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.QuizDataGridViewTextBoxColumn, Me.ADataGridViewTextBoxColumn, Me.BDataGridViewTextBoxColumn, Me.CDataGridViewTextBoxColumn, Me.DDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.TakeDataGridViewCheckBoxColumn, Me.CorrectDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuizDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1077, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(535, 176)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
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
        'QuizDataSetBindingSource
        '
        Me.QuizDataSetBindingSource.DataMember = "Values"
        Me.QuizDataSetBindingSource.DataSource = Me.QuizDataSet
        '
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "quizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnComp
        '
        Me.btnComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnComp.ForeColor = System.Drawing.Color.Black
        Me.btnComp.Location = New System.Drawing.Point(497, 119)
        Me.btnComp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(268, 66)
        Me.btnComp.TabIndex = 0
        Me.btnComp.Text = "Computer"
        Me.btnComp.UseVisualStyleBackColor = False
        '
        'btnEng
        '
        Me.btnEng.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEng.ForeColor = System.Drawing.Color.Black
        Me.btnEng.Location = New System.Drawing.Point(28, 212)
        Me.btnEng.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEng.Name = "btnEng"
        Me.btnEng.Size = New System.Drawing.Size(268, 66)
        Me.btnEng.TabIndex = 0
        Me.btnEng.Text = "English"
        Me.btnEng.UseVisualStyleBackColor = False
        '
        'btnFil
        '
        Me.btnFil.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFil.ForeColor = System.Drawing.Color.Black
        Me.btnFil.Location = New System.Drawing.Point(497, 212)
        Me.btnFil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFil.Name = "btnFil"
        Me.btnFil.Size = New System.Drawing.Size(268, 66)
        Me.btnFil.TabIndex = 0
        Me.btnFil.Text = "Filipino"
        Me.btnFil.UseVisualStyleBackColor = False
        '
        'btnMath
        '
        Me.btnMath.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMath.ForeColor = System.Drawing.Color.Black
        Me.btnMath.Location = New System.Drawing.Point(28, 305)
        Me.btnMath.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(268, 66)
        Me.btnMath.TabIndex = 0
        Me.btnMath.Text = "Math"
        Me.btnMath.UseVisualStyleBackColor = False
        '
        'btnSci
        '
        Me.btnSci.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSci.ForeColor = System.Drawing.Color.Black
        Me.btnSci.Location = New System.Drawing.Point(497, 305)
        Me.btnSci.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSci.Name = "btnSci"
        Me.btnSci.Size = New System.Drawing.Size(268, 66)
        Me.btnSci.TabIndex = 0
        Me.btnSci.Text = "Science"
        Me.btnSci.UseVisualStyleBackColor = False
        '
        'btnTLE
        '
        Me.btnTLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTLE.ForeColor = System.Drawing.Color.Black
        Me.btnTLE.Location = New System.Drawing.Point(28, 398)
        Me.btnTLE.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTLE.Name = "btnTLE"
        Me.btnTLE.Size = New System.Drawing.Size(268, 66)
        Me.btnTLE.TabIndex = 0
        Me.btnTLE.Text = "TLE"
        Me.btnTLE.UseVisualStyleBackColor = False
        '
        'btnMap
        '
        Me.btnMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMap.ForeColor = System.Drawing.Color.Black
        Me.btnMap.Location = New System.Drawing.Point(497, 398)
        Me.btnMap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(268, 66)
        Me.btnMap.TabIndex = 0
        Me.btnMap.Text = "Mapeh"
        Me.btnMap.UseVisualStyleBackColor = False
        '
        'btnVal
        '
        Me.btnVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVal.ForeColor = System.Drawing.Color.Black
        Me.btnVal.Location = New System.Drawing.Point(259, 491)
        Me.btnVal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVal.Name = "btnVal"
        Me.btnVal.Size = New System.Drawing.Size(268, 66)
        Me.btnVal.TabIndex = 0
        Me.btnVal.Text = "Values"
        Me.btnVal.UseVisualStyleBackColor = False
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Transparent
        Me.mainPanel.BackgroundImage = Global.Junior_High_Quiz_2.My.Resources.Resources.lightblue90
        Me.mainPanel.Controls.Add(Me.Label1)
        Me.mainPanel.Controls.Add(Me.btnVal)
        Me.mainPanel.Controls.Add(Me.btnMap)
        Me.mainPanel.Controls.Add(Me.btnTLE)
        Me.mainPanel.Controls.Add(Me.btnSci)
        Me.mainPanel.Controls.Add(Me.btnMath)
        Me.mainPanel.Controls.Add(Me.btnFil)
        Me.mainPanel.Controls.Add(Me.btnEng)
        Me.mainPanel.Controls.Add(Me.btnComp)
        Me.mainPanel.Controls.Add(Me.btnAP)
        Me.mainPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainPanel.Location = New System.Drawing.Point(17, 43)
        Me.mainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(801, 599)
        Me.mainPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(924, 11)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 20)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "User:"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(985, 11)
        Me.lblLogout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(60, 20)
        Me.lblLogout.TabIndex = 3
        Me.lblLogout.Text = "Logout"
        '
        'btnMin
        '
        Me.btnMin.AutoSize = True
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Font = New System.Drawing.Font("Bauhaus 93", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.Black
        Me.btnMin.Location = New System.Drawing.Point(55, 2)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.btnMin.Size = New System.Drawing.Size(22, 20)
        Me.btnMin.TabIndex = 11
        Me.btnMin.Text = "-"
        '
        'btnMax
        '
        Me.btnMax.AutoSize = True
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.ForeColor = System.Drawing.Color.Black
        Me.btnMax.Location = New System.Drawing.Point(28, 2)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMax.Size = New System.Drawing.Size(23, 21)
        Me.btnMax.TabIndex = 12
        Me.btnMax.Text = "+"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(3, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Size = New System.Drawing.Size(21, 21)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "x"
        '
        'AxWMP
        '
        Me.AxWMP.Enabled = True
        Me.AxWMP.Location = New System.Drawing.Point(1027, 654)
        Me.AxWMP.Name = "AxWMP"
        Me.AxWMP.OcxState = CType(resources.GetObject("AxWMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWMP.Size = New System.Drawing.Size(39, 33)
        Me.AxWMP.TabIndex = 14
        Me.AxWMP.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.Junior_High_Quiz_2.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.AxWMP)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1082, 694)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        CType(Me.AxWMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAP As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QuizDataSetBindingSource As BindingSource
    Friend WithEvents QuizDataSet As quizDataSet
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuizDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TakeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CorrectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APTableAdapter As quizDataSetTableAdapters.APTableAdapter
    Friend WithEvents ComputerTableAdapter As quizDataSetTableAdapters.ComputerTableAdapter
    Friend WithEvents EnglishTableAdapter As quizDataSetTableAdapters.EnglishTableAdapter
    Friend WithEvents FilipinoTableAdapter As quizDataSetTableAdapters.FilipinoTableAdapter
    Friend WithEvents MapehTableAdapter As quizDataSetTableAdapters.MapehTableAdapter
    Friend WithEvents MathTableAdapter As quizDataSetTableAdapters.MathTableAdapter
    Friend WithEvents ScienceTableAdapter As quizDataSetTableAdapters.ScienceTableAdapter
    Friend WithEvents TLETableAdapter As quizDataSetTableAdapters.TLETableAdapter
    Friend WithEvents ValuesTableAdapter As quizDataSetTableAdapters.ValuesTableAdapter
    Friend WithEvents btnComp As Button
    Friend WithEvents btnEng As Button
    Friend WithEvents btnFil As Button
    Friend WithEvents btnMath As Button
    Friend WithEvents btnSci As Button
    Friend WithEvents btnTLE As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnMin As Label
    Friend WithEvents btnMax As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents AxWMP As AxWMPLib.AxWindowsMediaPlayer
End Class
