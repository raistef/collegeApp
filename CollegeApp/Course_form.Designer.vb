<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Course_form))
        Me.School_db_dataDataSet = New CollegeApp.School_db_dataDataSet()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New CollegeApp.School_db_dataDataSetTableAdapters.CourseTableAdapter()
        Me.TableAdapterManager = New CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager()
        Me.CourseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CourseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CourseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add_course = New System.Windows.Forms.Button()
        Me.c_department = New System.Windows.Forms.TextBox()
        Me.c_faculty_fk = New System.Windows.Forms.TextBox()
        Me.c_credits = New System.Windows.Forms.TextBox()
        Me.c_number = New System.Windows.Forms.TextBox()
        Me.c_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Del_Rows = New System.Windows.Forms.Button()
        Me.Del_fa_id = New System.Windows.Forms.Button()
        Me.faculty_id = New System.Windows.Forms.RichTextBox()
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CourseBindingNavigator.SuspendLayout()
        CType(Me.CourseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'School_db_dataDataSet
        '
        Me.School_db_dataDataSet.DataSetName = "School_db_dataDataSet"
        Me.School_db_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.School_db_dataDataSet
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CourseTableAdapter = Me.CourseTableAdapter
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.RegistrarTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CourseBindingNavigator
        '
        Me.CourseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CourseBindingNavigator.BindingSource = Me.CourseBindingSource
        Me.CourseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CourseBindingNavigator.DeleteItem = Nothing
        Me.CourseBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CourseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CourseBindingNavigatorSaveItem})
        Me.CourseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CourseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CourseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CourseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CourseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CourseBindingNavigator.Name = "CourseBindingNavigator"
        Me.CourseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CourseBindingNavigator.Size = New System.Drawing.Size(985, 27)
        Me.CourseBindingNavigator.TabIndex = 0
        Me.CourseBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CourseBindingNavigatorSaveItem
        '
        Me.CourseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CourseBindingNavigatorSaveItem.Image = CType(resources.GetObject("CourseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CourseBindingNavigatorSaveItem.Name = "CourseBindingNavigatorSaveItem"
        Me.CourseBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CourseBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CourseDataGridView
        '
        Me.CourseDataGridView.AllowUserToAddRows = False
        Me.CourseDataGridView.AutoGenerateColumns = False
        Me.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CourseDataGridView.DataSource = Me.CourseBindingSource
        Me.CourseDataGridView.Location = New System.Drawing.Point(27, 30)
        Me.CourseDataGridView.Name = "CourseDataGridView"
        Me.CourseDataGridView.RowTemplate.Height = 24
        Me.CourseDataGridView.Size = New System.Drawing.Size(938, 317)
        Me.CourseDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "crs_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "crs_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "crs_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "crs_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "crs_number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "crs_number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "crs_dept"
        Me.DataGridViewTextBoxColumn4.HeaderText = "crs_dept"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "crs_credits"
        Me.DataGridViewTextBoxColumn5.HeaderText = "crs_credits"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fa_id_fk"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fa_id_fk"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'add_course
        '
        Me.add_course.BackColor = System.Drawing.SystemColors.HotTrack
        Me.add_course.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.add_course.Location = New System.Drawing.Point(24, 531)
        Me.add_course.Name = "add_course"
        Me.add_course.Size = New System.Drawing.Size(459, 37)
        Me.add_course.TabIndex = 43
        Me.add_course.Text = "Insert course details"
        Me.add_course.UseVisualStyleBackColor = False
        '
        'c_department
        '
        Me.c_department.Location = New System.Drawing.Point(125, 478)
        Me.c_department.Name = "c_department"
        Me.c_department.Size = New System.Drawing.Size(100, 22)
        Me.c_department.TabIndex = 37
        '
        'c_faculty_fk
        '
        Me.c_faculty_fk.Location = New System.Drawing.Point(370, 397)
        Me.c_faculty_fk.Name = "c_faculty_fk"
        Me.c_faculty_fk.Size = New System.Drawing.Size(100, 22)
        Me.c_faculty_fk.TabIndex = 36
        '
        'c_credits
        '
        Me.c_credits.Location = New System.Drawing.Point(370, 435)
        Me.c_credits.Name = "c_credits"
        Me.c_credits.Size = New System.Drawing.Size(100, 22)
        Me.c_credits.TabIndex = 35
        '
        'c_number
        '
        Me.c_number.Location = New System.Drawing.Point(125, 439)
        Me.c_number.Name = "c_number"
        Me.c_number.Size = New System.Drawing.Size(100, 22)
        Me.c_number.TabIndex = 34
        '
        'c_name
        '
        Me.c_name.Location = New System.Drawing.Point(125, 400)
        Me.c_name.Name = "c_name"
        Me.c_name.Size = New System.Drawing.Size(100, 22)
        Me.c_name.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(277, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Credits"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Faculty Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 483)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'Del_Rows
        '
        Me.Del_Rows.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Del_Rows.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Del_Rows.Location = New System.Drawing.Point(506, 473)
        Me.Del_Rows.Name = "Del_Rows"
        Me.Del_Rows.Size = New System.Drawing.Size(459, 37)
        Me.Del_Rows.TabIndex = 44
        Me.Del_Rows.Text = "Delete selected rows"
        Me.Del_Rows.UseCompatibleTextRendering = True
        Me.Del_Rows.UseVisualStyleBackColor = False
        '
        'Del_fa_id
        '
        Me.Del_fa_id.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Del_fa_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Del_fa_id.Location = New System.Drawing.Point(506, 531)
        Me.Del_fa_id.Name = "Del_fa_id"
        Me.Del_fa_id.Size = New System.Drawing.Size(331, 37)
        Me.Del_fa_id.TabIndex = 45
        Me.Del_fa_id.Text = "Delete courses with this faculty ID"
        Me.Del_fa_id.UseVisualStyleBackColor = False
        '
        'faculty_id
        '
        Me.faculty_id.Location = New System.Drawing.Point(867, 531)
        Me.faculty_id.Name = "faculty_id"
        Me.faculty_id.Size = New System.Drawing.Size(98, 37)
        Me.faculty_id.TabIndex = 46
        Me.faculty_id.Text = ""
        '
        'Course_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 580)
        Me.Controls.Add(Me.faculty_id)
        Me.Controls.Add(Me.Del_fa_id)
        Me.Controls.Add(Me.Del_Rows)
        Me.Controls.Add(Me.add_course)
        Me.Controls.Add(Me.c_department)
        Me.Controls.Add(Me.c_faculty_fk)
        Me.Controls.Add(Me.c_credits)
        Me.Controls.Add(Me.c_number)
        Me.Controls.Add(Me.c_name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CourseDataGridView)
        Me.Controls.Add(Me.CourseBindingNavigator)
        Me.Name = "Course_form"
        Me.Text = "Course_form"
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CourseBindingNavigator.ResumeLayout(False)
        Me.CourseBindingNavigator.PerformLayout()
        CType(Me.CourseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents School_db_dataDataSet As School_db_dataDataSet
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As School_db_dataDataSetTableAdapters.CourseTableAdapter
    Friend WithEvents TableAdapterManager As School_db_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CourseBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CourseBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CourseDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents add_course As Button
    Friend WithEvents c_department As TextBox
    Friend WithEvents c_faculty_fk As TextBox
    Friend WithEvents c_credits As TextBox
    Friend WithEvents c_number As TextBox
    Friend WithEvents c_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Del_Rows As Button
    Friend WithEvents Del_fa_id As Button
    Friend WithEvents faculty_id As RichTextBox
End Class
