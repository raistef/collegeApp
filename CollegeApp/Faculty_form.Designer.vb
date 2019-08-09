<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_form))
        Me.School_db_dataDataSet = New CollegeApp.School_db_dataDataSet()
        Me.FacultyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacultyTableAdapter = New CollegeApp.School_db_dataDataSetTableAdapters.FacultyTableAdapter()
        Me.TableAdapterManager = New CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager()
        Me.FacultyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacultyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FacultyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add_faculty = New System.Windows.Forms.Button()
        Me.f_pin = New System.Windows.Forms.TextBox()
        Me.f_status = New System.Windows.Forms.TextBox()
        Me.f_comment = New System.Windows.Forms.TextBox()
        Me.f_account = New System.Windows.Forms.TextBox()
        Me.f_date = New System.Windows.Forms.TextBox()
        Me.f_age = New System.Windows.Forms.TextBox()
        Me.f_address = New System.Windows.Forms.TextBox()
        Me.f_telephone = New System.Windows.Forms.TextBox()
        Me.f_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Del_Rows = New System.Windows.Forms.Button()
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacultyBindingNavigator.SuspendLayout()
        CType(Me.FacultyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'School_db_dataDataSet
        '
        Me.School_db_dataDataSet.DataSetName = "School_db_dataDataSet"
        Me.School_db_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacultyBindingSource
        '
        Me.FacultyBindingSource.DataMember = "Faculty"
        Me.FacultyBindingSource.DataSource = Me.School_db_dataDataSet
        '
        'FacultyTableAdapter
        '
        Me.FacultyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CourseTableAdapter = Nothing
        Me.TableAdapterManager.FacultyTableAdapter = Me.FacultyTableAdapter
        Me.TableAdapterManager.RegistrarTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacultyBindingNavigator
        '
        Me.FacultyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacultyBindingNavigator.BindingSource = Me.FacultyBindingSource
        Me.FacultyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacultyBindingNavigator.DeleteItem = Nothing
        Me.FacultyBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FacultyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacultyBindingNavigatorSaveItem})
        Me.FacultyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacultyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacultyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacultyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacultyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacultyBindingNavigator.Name = "FacultyBindingNavigator"
        Me.FacultyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacultyBindingNavigator.Size = New System.Drawing.Size(1338, 27)
        Me.FacultyBindingNavigator.TabIndex = 0
        Me.FacultyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'FacultyBindingNavigatorSaveItem
        '
        Me.FacultyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacultyBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacultyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacultyBindingNavigatorSaveItem.Name = "FacultyBindingNavigatorSaveItem"
        Me.FacultyBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.FacultyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FacultyDataGridView
        '
        Me.FacultyDataGridView.AutoGenerateColumns = False
        Me.FacultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacultyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.FacultyDataGridView.DataSource = Me.FacultyBindingSource
        Me.FacultyDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.FacultyDataGridView.Name = "FacultyDataGridView"
        Me.FacultyDataGridView.RowTemplate.Height = 24
        Me.FacultyDataGridView.Size = New System.Drawing.Size(1326, 301)
        Me.FacultyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fa_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fa_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fa_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fa_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fa_age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fa_age"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fa_date_entered"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fa_date_entered"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fa_address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fa_address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fa_tel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fa_tel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fa_account"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fa_account"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fa_pin"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fa_pin"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fa_status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fa_status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fa_comments"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fa_comments"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'add_faculty
        '
        Me.add_faculty.BackColor = System.Drawing.SystemColors.HotTrack
        Me.add_faculty.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.add_faculty.Location = New System.Drawing.Point(28, 563)
        Me.add_faculty.Name = "add_faculty"
        Me.add_faculty.Size = New System.Drawing.Size(459, 32)
        Me.add_faculty.TabIndex = 43
        Me.add_faculty.Text = "Insert faculty details"
        Me.add_faculty.UseVisualStyleBackColor = False
        '
        'f_pin
        '
        Me.f_pin.Location = New System.Drawing.Point(387, 402)
        Me.f_pin.Name = "f_pin"
        Me.f_pin.Size = New System.Drawing.Size(100, 22)
        Me.f_pin.TabIndex = 42
        '
        'f_status
        '
        Me.f_status.Location = New System.Drawing.Point(387, 439)
        Me.f_status.Name = "f_status"
        Me.f_status.Size = New System.Drawing.Size(100, 22)
        Me.f_status.TabIndex = 41
        '
        'f_comment
        '
        Me.f_comment.Location = New System.Drawing.Point(387, 477)
        Me.f_comment.Name = "f_comment"
        Me.f_comment.Size = New System.Drawing.Size(100, 22)
        Me.f_comment.TabIndex = 40
        '
        'f_account
        '
        Me.f_account.Location = New System.Drawing.Point(387, 362)
        Me.f_account.Name = "f_account"
        Me.f_account.Size = New System.Drawing.Size(100, 22)
        Me.f_account.TabIndex = 39
        '
        'f_date
        '
        Me.f_date.Location = New System.Drawing.Point(148, 522)
        Me.f_date.Name = "f_date"
        Me.f_date.Size = New System.Drawing.Size(100, 22)
        Me.f_date.TabIndex = 38
        '
        'f_age
        '
        Me.f_age.Location = New System.Drawing.Point(148, 445)
        Me.f_age.Name = "f_age"
        Me.f_age.Size = New System.Drawing.Size(100, 22)
        Me.f_age.TabIndex = 37
        '
        'f_address
        '
        Me.f_address.Location = New System.Drawing.Point(148, 482)
        Me.f_address.Name = "f_address"
        Me.f_address.Size = New System.Drawing.Size(100, 22)
        Me.f_address.TabIndex = 36
        '
        'f_telephone
        '
        Me.f_telephone.Location = New System.Drawing.Point(148, 405)
        Me.f_telephone.Name = "f_telephone"
        Me.f_telephone.Size = New System.Drawing.Size(100, 22)
        Me.f_telephone.TabIndex = 34
        '
        'f_name
        '
        Me.f_name.Location = New System.Drawing.Point(148, 362)
        Me.f_name.Name = "f_name"
        Me.f_name.Size = New System.Drawing.Size(100, 22)
        Me.f_name.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Comment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Pin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 522)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Date entered"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Telephone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Del_Rows
        '
        Me.Del_Rows.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Del_Rows.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Del_Rows.Location = New System.Drawing.Point(867, 563)
        Me.Del_Rows.Name = "Del_Rows"
        Me.Del_Rows.Size = New System.Drawing.Size(459, 32)
        Me.Del_Rows.TabIndex = 44
        Me.Del_Rows.Text = "Delete selected rows"
        Me.Del_Rows.UseVisualStyleBackColor = False
        '
        'Faculty_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 606)
        Me.Controls.Add(Me.Del_Rows)
        Me.Controls.Add(Me.add_faculty)
        Me.Controls.Add(Me.f_pin)
        Me.Controls.Add(Me.f_status)
        Me.Controls.Add(Me.f_comment)
        Me.Controls.Add(Me.f_account)
        Me.Controls.Add(Me.f_date)
        Me.Controls.Add(Me.f_age)
        Me.Controls.Add(Me.f_address)
        Me.Controls.Add(Me.f_telephone)
        Me.Controls.Add(Me.f_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FacultyDataGridView)
        Me.Controls.Add(Me.FacultyBindingNavigator)
        Me.Name = "Faculty_form"
        Me.Text = "Faculty_form"
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacultyBindingNavigator.ResumeLayout(False)
        Me.FacultyBindingNavigator.PerformLayout()
        CType(Me.FacultyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents School_db_dataDataSet As School_db_dataDataSet
    Friend WithEvents FacultyBindingSource As BindingSource
    Friend WithEvents FacultyTableAdapter As School_db_dataDataSetTableAdapters.FacultyTableAdapter
    Friend WithEvents TableAdapterManager As School_db_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacultyBindingNavigator As BindingNavigator
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
    Friend WithEvents FacultyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FacultyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents add_faculty As Button
    Friend WithEvents f_pin As TextBox
    Friend WithEvents f_status As TextBox
    Friend WithEvents f_comment As TextBox
    Friend WithEvents f_account As TextBox
    Friend WithEvents f_date As TextBox
    Friend WithEvents f_age As TextBox
    Friend WithEvents f_address As TextBox
    Friend WithEvents f_telephone As TextBox
    Friend WithEvents f_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Del_Rows As Button
End Class
