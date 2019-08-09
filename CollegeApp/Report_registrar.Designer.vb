<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_registrar
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
        Me.RegistrarGridView = New System.Windows.Forms.DataGridView()
        Me.load = New System.Windows.Forms.Button()
        Me.applyFilters = New System.Windows.Forms.Button()
        Me.dateCheck = New System.Windows.Forms.CheckBox()
        Me.studentCheck = New System.Windows.Forms.CheckBox()
        Me.semesterCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sem = New System.Windows.Forms.TextBox()
        Me.year = New System.Windows.Forms.TextBox()
        Me.studentName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.credits = New System.Windows.Forms.Label()
        CType(Me.RegistrarGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrarGridView
        '
        Me.RegistrarGridView.AllowUserToAddRows = False
        Me.RegistrarGridView.AllowUserToDeleteRows = False
        Me.RegistrarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrarGridView.Location = New System.Drawing.Point(29, 107)
        Me.RegistrarGridView.Name = "RegistrarGridView"
        Me.RegistrarGridView.ReadOnly = True
        Me.RegistrarGridView.RowTemplate.Height = 24
        Me.RegistrarGridView.Size = New System.Drawing.Size(1150, 361)
        Me.RegistrarGridView.TabIndex = 3
        '
        'load
        '
        Me.load.Location = New System.Drawing.Point(29, 12)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(180, 38)
        Me.load.TabIndex = 2
        Me.load.Text = "Load the report"
        Me.load.UseVisualStyleBackColor = True
        '
        'applyFilters
        '
        Me.applyFilters.Location = New System.Drawing.Point(29, 52)
        Me.applyFilters.Name = "applyFilters"
        Me.applyFilters.Size = New System.Drawing.Size(180, 38)
        Me.applyFilters.TabIndex = 4
        Me.applyFilters.Text = "Apply filters"
        Me.applyFilters.UseVisualStyleBackColor = True
        '
        'dateCheck
        '
        Me.dateCheck.AutoSize = True
        Me.dateCheck.Location = New System.Drawing.Point(291, 15)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(60, 21)
        Me.dateCheck.TabIndex = 5
        Me.dateCheck.Text = "Date"
        Me.dateCheck.UseVisualStyleBackColor = True
        '
        'studentCheck
        '
        Me.studentCheck.AutoSize = True
        Me.studentCheck.Location = New System.Drawing.Point(291, 42)
        Me.studentCheck.Name = "studentCheck"
        Me.studentCheck.Size = New System.Drawing.Size(79, 21)
        Me.studentCheck.TabIndex = 6
        Me.studentCheck.Text = "Student"
        Me.studentCheck.UseVisualStyleBackColor = True
        '
        'semesterCheck
        '
        Me.semesterCheck.AutoSize = True
        Me.semesterCheck.Location = New System.Drawing.Point(291, 69)
        Me.semesterCheck.Name = "semesterCheck"
        Me.semesterCheck.Size = New System.Drawing.Size(90, 21)
        Me.semesterCheck.TabIndex = 7
        Me.semesterCheck.Text = "Semester"
        Me.semesterCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date range:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(496, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(724, 11)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Student:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Semester:"
        '
        'sem
        '
        Me.sem.Location = New System.Drawing.Point(496, 71)
        Me.sem.Name = "sem"
        Me.sem.Size = New System.Drawing.Size(100, 22)
        Me.sem.TabIndex = 13
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(602, 71)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(100, 22)
        Me.year.TabIndex = 14
        '
        'studentName
        '
        Me.studentName.Location = New System.Drawing.Point(496, 43)
        Me.studentName.Name = "studentName"
        Me.studentName.Size = New System.Drawing.Size(206, 22)
        Me.studentName.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(738, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Credits:"
        '
        'credits
        '
        Me.credits.AutoSize = True
        Me.credits.Location = New System.Drawing.Point(800, 63)
        Me.credits.Name = "credits"
        Me.credits.Size = New System.Drawing.Size(16, 17)
        Me.credits.TabIndex = 17
        Me.credits.Text = "0"
        '
        'Report_registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 494)
        Me.Controls.Add(Me.credits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.studentName)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.sem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.semesterCheck)
        Me.Controls.Add(Me.studentCheck)
        Me.Controls.Add(Me.dateCheck)
        Me.Controls.Add(Me.applyFilters)
        Me.Controls.Add(Me.RegistrarGridView)
        Me.Controls.Add(Me.load)
        Me.Name = "Report_registrar"
        Me.Text = "Report_registrar"
        CType(Me.RegistrarGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegistrarGridView As DataGridView
    Friend WithEvents load As Button
    Friend WithEvents applyFilters As Button
    Friend WithEvents dateCheck As CheckBox
    Friend WithEvents studentCheck As CheckBox
    Friend WithEvents semesterCheck As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sem As TextBox
    Friend WithEvents year As TextBox
    Friend WithEvents studentName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents credits As Label
End Class
