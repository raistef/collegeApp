<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.login_button = New System.Windows.Forms.Button()
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.School_db_dataDataSet = New CollegeApp.School_db_dataDataSet()
        Me.FacultyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacultyTableAdapter = New CollegeApp.School_db_dataDataSetTableAdapters.FacultyTableAdapter()
        Me.TableAdapterManager = New CollegeApp.School_db_dataDataSetTableAdapters.TableAdapterManager()
        Me.message = New System.Windows.Forms.Label()
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_button
        '
        Me.login_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.login_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login_button.Location = New System.Drawing.Point(212, 153)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(75, 29)
        Me.login_button.TabIndex = 0
        Me.login_button.Text = "Log in"
        Me.login_button.UseVisualStyleBackColor = False
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Location = New System.Drawing.Point(67, 72)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(73, 17)
        Me.username_label.TabIndex = 1
        Me.username_label.Text = "Username"
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Location = New System.Drawing.Point(67, 106)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(69, 17)
        Me.password_label.TabIndex = 2
        Me.password_label.Text = "Password"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(187, 72)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 22)
        Me.username.TabIndex = 3
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(187, 106)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(100, 22)
        Me.password.TabIndex = 4
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
        'message
        '
        Me.message.AutoSize = True
        Me.message.ForeColor = System.Drawing.Color.Red
        Me.message.Location = New System.Drawing.Point(70, 36)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(0, 17)
        Me.message.TabIndex = 5
        '
        'Login
        '
        Me.AcceptButton = Me.login_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 246)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.login_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login Form"
        CType(Me.School_db_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_button As Button
    Friend WithEvents username_label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents School_db_dataDataSet As School_db_dataDataSet
    Friend WithEvents FacultyBindingSource As BindingSource
    Friend WithEvents FacultyTableAdapter As School_db_dataDataSetTableAdapters.FacultyTableAdapter
    Friend WithEvents TableAdapterManager As School_db_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents message As Label
End Class
