<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_course
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
        Me.CourseGridView = New System.Windows.Forms.DataGridView()
        Me.load = New System.Windows.Forms.Button()
        Me.applyFilters = New System.Windows.Forms.Button()
        Me.deptCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.facultyBox = New System.Windows.Forms.TextBox()
        Me.departmentCheck = New System.Windows.Forms.CheckBox()
        Me.facultyCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.CourseGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseGridView
        '
        Me.CourseGridView.AllowUserToAddRows = False
        Me.CourseGridView.AllowUserToDeleteRows = False
        Me.CourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseGridView.Location = New System.Drawing.Point(29, 77)
        Me.CourseGridView.Name = "CourseGridView"
        Me.CourseGridView.ReadOnly = True
        Me.CourseGridView.RowTemplate.Height = 24
        Me.CourseGridView.Size = New System.Drawing.Size(975, 361)
        Me.CourseGridView.TabIndex = 3
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
        Me.applyFilters.Location = New System.Drawing.Point(224, 12)
        Me.applyFilters.Name = "applyFilters"
        Me.applyFilters.Size = New System.Drawing.Size(180, 38)
        Me.applyFilters.TabIndex = 25
        Me.applyFilters.Text = "Apply filters"
        Me.applyFilters.UseVisualStyleBackColor = True
        '
        'deptCombo
        '
        Me.deptCombo.FormattingEnabled = True
        Me.deptCombo.Location = New System.Drawing.Point(883, 27)
        Me.deptCombo.Name = "deptCombo"
        Me.deptCombo.Size = New System.Drawing.Size(121, 24)
        Me.deptCombo.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(880, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Department:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(691, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Faculty:"
        '
        'facultyBox
        '
        Me.facultyBox.Location = New System.Drawing.Point(694, 30)
        Me.facultyBox.Name = "facultyBox"
        Me.facultyBox.Size = New System.Drawing.Size(151, 22)
        Me.facultyBox.TabIndex = 21
        '
        'departmentCheck
        '
        Me.departmentCheck.AutoSize = True
        Me.departmentCheck.Location = New System.Drawing.Point(584, 28)
        Me.departmentCheck.Name = "departmentCheck"
        Me.departmentCheck.Size = New System.Drawing.Size(104, 21)
        Me.departmentCheck.TabIndex = 20
        Me.departmentCheck.Text = "Department"
        Me.departmentCheck.UseVisualStyleBackColor = True
        '
        'facultyCheck
        '
        Me.facultyCheck.AutoSize = True
        Me.facultyCheck.Location = New System.Drawing.Point(511, 28)
        Me.facultyCheck.Name = "facultyCheck"
        Me.facultyCheck.Size = New System.Drawing.Size(75, 21)
        Me.facultyCheck.TabIndex = 19
        Me.facultyCheck.Text = "Faculty"
        Me.facultyCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Filter by:"
        '
        'Report_course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 450)
        Me.Controls.Add(Me.applyFilters)
        Me.Controls.Add(Me.deptCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.facultyBox)
        Me.Controls.Add(Me.departmentCheck)
        Me.Controls.Add(Me.facultyCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CourseGridView)
        Me.Controls.Add(Me.load)
        Me.Name = "Report_course"
        Me.Text = "Report_course"
        CType(Me.CourseGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CourseGridView As DataGridView
    Friend WithEvents load As Button
    Friend WithEvents applyFilters As Button
    Friend WithEvents deptCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents facultyBox As TextBox
    Friend WithEvents departmentCheck As CheckBox
    Friend WithEvents facultyCheck As CheckBox
    Friend WithEvents Label1 As Label
End Class
