Imports System.Data.OleDb
Public Class Report_course
    Private Sub Report_Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim departments = {"CS", "MATH", "BUS", "ECO"}
        deptCombo.DataSource = departments

    End Sub

    Private Sub applyFilters_Click(sender As Object, e As EventArgs) Handles applyFilters.Click
        If facultyCheck.Checked And departmentCheck.Checked Then
            Me.applyBothFilters()
        End If
        If facultyCheck.Checked And Not departmentCheck.Checked Then
            Me.applyFacultyFilter()
        End If
        If Not facultyCheck.Checked And departmentCheck.Checked Then
            Me.applyDepartmentFilter()
        End If
        If Not facultyCheck.Checked And Not departmentCheck.Checked Then
            load.PerformClick()
        End If
    End Sub

    Private Sub applyDepartmentFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM COURSE WHERE crs_dept='" + deptCombo.SelectedValue.ToString + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        CourseGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyFacultyFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM COURSE WHERE fa_id_fk=(SELECT fa_id FROM faculty WHERE fa_name='" + facultyBox.Text + "')"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        CourseGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyBothFilters()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM COURSE WHERE crs_dept='" + deptCombo.SelectedValue.ToString + "' AND fa_id_fk= (SELECT fa_id FROM faculty WHERE fa_name='" + facultyBox.Text + "')"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        CourseGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM COURSE"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        CourseGridView.DataSource = dt
        con1.Close()
    End Sub
End Class