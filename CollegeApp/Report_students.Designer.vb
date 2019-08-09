<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_students
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
        Me.load = New System.Windows.Forms.Button()
        Me.StudentsGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameCheck = New System.Windows.Forms.CheckBox()
        Me.statusCheck = New System.Windows.Forms.CheckBox()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.statusCombo = New System.Windows.Forms.ComboBox()
        Me.applyFilters = New System.Windows.Forms.Button()
        CType(Me.StudentsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'load
        '
        Me.load.Location = New System.Drawing.Point(33, 21)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(180, 38)
        Me.load.TabIndex = 0
        Me.load.Text = "Load the report"
        Me.load.UseVisualStyleBackColor = True
        '
        'StudentsGridView
        '
        Me.StudentsGridView.AllowUserToAddRows = False
        Me.StudentsGridView.AllowUserToDeleteRows = False
        Me.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsGridView.Location = New System.Drawing.Point(33, 77)
        Me.StudentsGridView.Name = "StudentsGridView"
        Me.StudentsGridView.ReadOnly = True
        Me.StudentsGridView.RowTemplate.Height = 24
        Me.StudentsGridView.Size = New System.Drawing.Size(966, 361)
        Me.StudentsGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter by:"
        '
        'nameCheck
        '
        Me.nameCheck.AutoSize = True
        Me.nameCheck.Location = New System.Drawing.Point(523, 37)
        Me.nameCheck.Name = "nameCheck"
        Me.nameCheck.Size = New System.Drawing.Size(67, 21)
        Me.nameCheck.TabIndex = 3
        Me.nameCheck.Text = "Name"
        Me.nameCheck.UseVisualStyleBackColor = True
        '
        'statusCheck
        '
        Me.statusCheck.AutoSize = True
        Me.statusCheck.Location = New System.Drawing.Point(596, 37)
        Me.statusCheck.Name = "statusCheck"
        Me.statusCheck.Size = New System.Drawing.Size(70, 21)
        Me.statusCheck.TabIndex = 4
        Me.statusCheck.Text = "Status"
        Me.statusCheck.UseVisualStyleBackColor = True
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(689, 37)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(151, 22)
        Me.nameBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(686, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(875, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Status"
        '
        'statusCombo
        '
        Me.statusCombo.FormattingEnabled = True
        Me.statusCombo.Location = New System.Drawing.Point(878, 34)
        Me.statusCombo.Name = "statusCombo"
        Me.statusCombo.Size = New System.Drawing.Size(121, 24)
        Me.statusCombo.TabIndex = 8
        '
        'applyFilters
        '
        Me.applyFilters.Location = New System.Drawing.Point(236, 21)
        Me.applyFilters.Name = "applyFilters"
        Me.applyFilters.Size = New System.Drawing.Size(180, 38)
        Me.applyFilters.TabIndex = 9
        Me.applyFilters.Text = "Apply filters"
        Me.applyFilters.UseVisualStyleBackColor = True
        '
        'Report_students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 505)
        Me.Controls.Add(Me.applyFilters)
        Me.Controls.Add(Me.statusCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.statusCheck)
        Me.Controls.Add(Me.nameCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StudentsGridView)
        Me.Controls.Add(Me.load)
        Me.Name = "Report_students"
        Me.Text = "Report_students"
        CType(Me.StudentsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents load As Button
    Friend WithEvents StudentsGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents nameCheck As CheckBox
    Friend WithEvents statusCheck As CheckBox
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents statusCombo As ComboBox
    Friend WithEvents applyFilters As Button
End Class
