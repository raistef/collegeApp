<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_form))
        Me.RegistrarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistrarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School_db_dataDataSet = New CollegeApp.School_db_dataDataSet()
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
        Me.RegistrarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistrarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add_registrar = New System.Windows.Forms.Button()
        Me.r_year = New System.Windows.Forms.TextBox()
        Me.r_semester = New System.Windows.Forms.TextBox()
        Me.r_date = New System.Windows.Forms.TextBox()
        Me.r_grade = New System.Windows.Forms.TextBox()
        Me.r_status = New System.Windows.Forms.TextBox()
        Me.r_course_id_fk = New System.Windows.Forms.TextBox()
        Me.r_student_id_fk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegistrarTableAdapter = New CollegeApp.School_db_dataDataSetTableAdapters.RegistrarTableAdapter()
        Me.TableAdapterManager = New CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager()
        Me.Del_Rows = New System.Windows.Forms.Button()
        Me.DelUnpaid = New System.Windows.Forms.Button()
        Me.update_course = New System.Windows.Forms.Button()
        Me.course_id_box = New System.Windows.Forms.RichTextBox()
        CType(Me.RegistrarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrarBindingNavigator.SuspendLayout()
        CType(Me.RegistrarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrarBindingNavigator
        '
        Me.RegistrarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistrarBindingNavigator.BindingSource = Me.RegistrarBindingSource
        Me.RegistrarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistrarBindingNavigator.DeleteItem = Nothing
        Me.RegistrarBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RegistrarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistrarBindingNavigatorSaveItem})
        Me.RegistrarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistrarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistrarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistrarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistrarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistrarBindingNavigator.Name = "RegistrarBindingNavigator"
        Me.RegistrarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistrarBindingNavigator.Size = New System.Drawing.Size(1193, 27)
        Me.RegistrarBindingNavigator.TabIndex = 0
        Me.RegistrarBindingNavigator.Text = "BindingNavigator1"
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
        'RegistrarBindingSource
        '
        Me.RegistrarBindingSource.DataMember = "Registrar"
        Me.RegistrarBindingSource.DataSource = Me.School_db_dataDataSet
        '
        'School_db_dataDataSet
        '
        Me.School_db_dataDataSet.DataSetName = "School_db_dataDataSet"
        Me.School_db_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RegistrarBindingNavigatorSaveItem
        '
        Me.RegistrarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistrarBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistrarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistrarBindingNavigatorSaveItem.Name = "RegistrarBindingNavigatorSaveItem"
        Me.RegistrarBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.RegistrarBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RegistrarDataGridView
        '
        Me.RegistrarDataGridView.AutoGenerateColumns = False
        Me.RegistrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.RegistrarDataGridView.DataSource = Me.RegistrarBindingSource
        Me.RegistrarDataGridView.Location = New System.Drawing.Point(12, 32)
        Me.RegistrarDataGridView.Name = "RegistrarDataGridView"
        Me.RegistrarDataGridView.ReadOnly = True
        Me.RegistrarDataGridView.RowTemplate.Height = 24
        Me.RegistrarDataGridView.Size = New System.Drawing.Size(1172, 319)
        Me.RegistrarDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "reg_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "reg_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "st_id_fk"
        Me.DataGridViewTextBoxColumn2.HeaderText = "st_id_fk"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "crs_id_fk"
        Me.DataGridViewTextBoxColumn3.HeaderText = "crs_id_fk"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "reg_grade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "reg_grade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "reg_status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "reg_status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "reg_semester"
        Me.DataGridViewTextBoxColumn6.HeaderText = "reg_semester"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "reg_year"
        Me.DataGridViewTextBoxColumn7.HeaderText = "reg_year"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "reg_date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "reg_date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'add_registrar
        '
        Me.add_registrar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.add_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.add_registrar.Location = New System.Drawing.Point(15, 549)
        Me.add_registrar.Name = "add_registrar"
        Me.add_registrar.Size = New System.Drawing.Size(459, 32)
        Me.add_registrar.TabIndex = 62
        Me.add_registrar.Text = "Insert Registrar details"
        Me.add_registrar.UseVisualStyleBackColor = False
        '
        'r_year
        '
        Me.r_year.Location = New System.Drawing.Point(374, 425)
        Me.r_year.Name = "r_year"
        Me.r_year.Size = New System.Drawing.Size(100, 22)
        Me.r_year.TabIndex = 61
        '
        'r_semester
        '
        Me.r_semester.Location = New System.Drawing.Point(374, 385)
        Me.r_semester.Name = "r_semester"
        Me.r_semester.Size = New System.Drawing.Size(100, 22)
        Me.r_semester.TabIndex = 58
        '
        'r_date
        '
        Me.r_date.Location = New System.Drawing.Point(374, 468)
        Me.r_date.Name = "r_date"
        Me.r_date.Size = New System.Drawing.Size(100, 22)
        Me.r_date.TabIndex = 57
        '
        'r_grade
        '
        Me.r_grade.Location = New System.Drawing.Point(135, 468)
        Me.r_grade.Name = "r_grade"
        Me.r_grade.Size = New System.Drawing.Size(100, 22)
        Me.r_grade.TabIndex = 56
        '
        'r_status
        '
        Me.r_status.Location = New System.Drawing.Point(135, 505)
        Me.r_status.Name = "r_status"
        Me.r_status.Size = New System.Drawing.Size(100, 22)
        Me.r_status.TabIndex = 55
        '
        'r_course_id_fk
        '
        Me.r_course_id_fk.Location = New System.Drawing.Point(135, 428)
        Me.r_course_id_fk.Name = "r_course_id_fk"
        Me.r_course_id_fk.Size = New System.Drawing.Size(100, 22)
        Me.r_course_id_fk.TabIndex = 54
        '
        'r_student_id_fk
        '
        Me.r_student_id_fk.Location = New System.Drawing.Point(135, 385)
        Me.r_student_id_fk.Name = "r_student_id_fk"
        Me.r_student_id_fk.Size = New System.Drawing.Size(100, 22)
        Me.r_student_id_fk.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 471)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Date entered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Course Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Student Id"
        '
        'RegistrarTableAdapter
        '
        Me.RegistrarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CourseTableAdapter = Nothing
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.RegistrarTableAdapter = Me.RegistrarTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Del_Rows
        '
        Me.Del_Rows.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Del_Rows.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Del_Rows.Location = New System.Drawing.Point(725, 453)
        Me.Del_Rows.Name = "Del_Rows"
        Me.Del_Rows.Size = New System.Drawing.Size(459, 32)
        Me.Del_Rows.TabIndex = 63
        Me.Del_Rows.Text = "Delete selected rows"
        Me.Del_Rows.UseVisualStyleBackColor = False
        '
        'DelUnpaid
        '
        Me.DelUnpaid.BackColor = System.Drawing.SystemColors.HotTrack
        Me.DelUnpaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DelUnpaid.Location = New System.Drawing.Point(725, 491)
        Me.DelUnpaid.Name = "DelUnpaid"
        Me.DelUnpaid.Size = New System.Drawing.Size(459, 32)
        Me.DelUnpaid.TabIndex = 64
        Me.DelUnpaid.Text = "Delete unpaid enrollments"
        Me.DelUnpaid.UseVisualStyleBackColor = False
        '
        'update_course
        '
        Me.update_course.BackColor = System.Drawing.SystemColors.HotTrack
        Me.update_course.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.update_course.Location = New System.Drawing.Point(725, 538)
        Me.update_course.Name = "update_course"
        Me.update_course.Size = New System.Drawing.Size(327, 32)
        Me.update_course.TabIndex = 65
        Me.update_course.Text = "Update course id to:"
        Me.update_course.UseVisualStyleBackColor = False
        '
        'course_id_box
        '
        Me.course_id_box.Location = New System.Drawing.Point(1071, 538)
        Me.course_id_box.Name = "course_id_box"
        Me.course_id_box.Size = New System.Drawing.Size(113, 32)
        Me.course_id_box.TabIndex = 66
        Me.course_id_box.Text = ""
        '
        'Registrar_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 604)
        Me.Controls.Add(Me.course_id_box)
        Me.Controls.Add(Me.update_course)
        Me.Controls.Add(Me.DelUnpaid)
        Me.Controls.Add(Me.Del_Rows)
        Me.Controls.Add(Me.add_registrar)
        Me.Controls.Add(Me.r_year)
        Me.Controls.Add(Me.r_semester)
        Me.Controls.Add(Me.r_date)
        Me.Controls.Add(Me.r_grade)
        Me.Controls.Add(Me.r_status)
        Me.Controls.Add(Me.r_course_id_fk)
        Me.Controls.Add(Me.r_student_id_fk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RegistrarDataGridView)
        Me.Controls.Add(Me.RegistrarBindingNavigator)
        Me.Name = "Registrar_form"
        Me.Text = "Registrar_form"
        CType(Me.RegistrarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrarBindingNavigator.ResumeLayout(False)
        Me.RegistrarBindingNavigator.PerformLayout()
        CType(Me.RegistrarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents School_db_dataDataSet As School_db_dataDataSet
    Friend WithEvents RegistrarBindingSource As BindingSource
    Friend WithEvents RegistrarTableAdapter As School_db_dataDataSetTableAdapters.RegistrarTableAdapter
    Friend WithEvents TableAdapterManager As School_db_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrarBindingNavigator As BindingNavigator
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
    Friend WithEvents RegistrarBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RegistrarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents add_registrar As Button
    Friend WithEvents r_year As TextBox
    Friend WithEvents r_semester As TextBox
    Friend WithEvents r_date As TextBox
    Friend WithEvents r_grade As TextBox
    Friend WithEvents r_status As TextBox
    Friend WithEvents r_course_id_fk As TextBox
    Friend WithEvents r_student_id_fk As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Del_Rows As Button
    Friend WithEvents DelUnpaid As Button
    Friend WithEvents update_course As Button
    Friend WithEvents course_id_box As RichTextBox
End Class
