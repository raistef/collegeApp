<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_faculty
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
        Me.FacultyGridView = New System.Windows.Forms.DataGridView()
        Me.load = New System.Windows.Forms.Button()
        Me.applyFilters = New System.Windows.Forms.Button()
        Me.typeCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.typeCheck = New System.Windows.Forms.CheckBox()
        Me.nameCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FacultyGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacultyGridView
        '
        Me.FacultyGridView.AllowUserToAddRows = False
        Me.FacultyGridView.AllowUserToDeleteRows = False
        Me.FacultyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacultyGridView.Location = New System.Drawing.Point(12, 77)
        Me.FacultyGridView.Name = "FacultyGridView"
        Me.FacultyGridView.ReadOnly = True
        Me.FacultyGridView.RowTemplate.Height = 24
        Me.FacultyGridView.Size = New System.Drawing.Size(962, 361)
        Me.FacultyGridView.TabIndex = 3
        '
        'load
        '
        Me.load.Location = New System.Drawing.Point(12, 12)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(180, 38)
        Me.load.TabIndex = 2
        Me.load.Text = "Load the report"
        Me.load.UseVisualStyleBackColor = True
        '
        'applyFilters
        '
        Me.applyFilters.Location = New System.Drawing.Point(211, 12)
        Me.applyFilters.Name = "applyFilters"
        Me.applyFilters.Size = New System.Drawing.Size(180, 38)
        Me.applyFilters.TabIndex = 17
        Me.applyFilters.Text = "Apply filters"
        Me.applyFilters.UseVisualStyleBackColor = True
        '
        'typeCombo
        '
        Me.typeCombo.FormattingEnabled = True
        Me.typeCombo.Location = New System.Drawing.Point(853, 25)
        Me.typeCombo.Name = "typeCombo"
        Me.typeCombo.Size = New System.Drawing.Size(121, 24)
        Me.typeCombo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(850, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(664, 28)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(151, 22)
        Me.nameBox.TabIndex = 13
        '
        'typeCheck
        '
        Me.typeCheck.AutoSize = True
        Me.typeCheck.Location = New System.Drawing.Point(571, 28)
        Me.typeCheck.Name = "typeCheck"
        Me.typeCheck.Size = New System.Drawing.Size(62, 21)
        Me.typeCheck.TabIndex = 12
        Me.typeCheck.Text = "Type"
        Me.typeCheck.UseVisualStyleBackColor = True
        '
        'nameCheck
        '
        Me.nameCheck.AutoSize = True
        Me.nameCheck.Location = New System.Drawing.Point(498, 28)
        Me.nameCheck.Name = "nameCheck"
        Me.nameCheck.Size = New System.Drawing.Size(67, 21)
        Me.nameCheck.TabIndex = 11
        Me.nameCheck.Text = "Name"
        Me.nameCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(429, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filter by:"
        '
        'Report_faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 450)
        Me.Controls.Add(Me.applyFilters)
        Me.Controls.Add(Me.typeCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.typeCheck)
        Me.Controls.Add(Me.nameCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FacultyGridView)
        Me.Controls.Add(Me.load)
        Me.Name = "Report_faculty"
        Me.Text = "Report_faculty"
        CType(Me.FacultyGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacultyGridView As DataGridView
    Friend WithEvents load As Button
    Friend WithEvents applyFilters As Button
    Friend WithEvents typeCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents typeCheck As CheckBox
    Friend WithEvents nameCheck As CheckBox
    Friend WithEvents Label1 As Label
End Class
