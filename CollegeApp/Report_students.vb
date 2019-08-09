Imports System.Data.OleDb
Public Class Report_students
    Private Sub Report_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim statuses = {"FRE", "SOP", "JUN", "SNR"}
        statusCombo.DataSource = statuses

    End Sub

    Private Sub applyFilters_Click(sender As Object, e As EventArgs) Handles applyFilters.Click
        If nameCheck.Checked And statusCheck.Checked Then
            Me.applyBothFilters()
        End If
        If nameCheck.Checked And Not statusCheck.Checked Then
            Me.applyNameFilter()
        End If
        If Not nameCheck.Checked And statusCheck.Checked Then
            Me.applyStatusFilter()
        End If
        If Not nameCheck.Checked And Not statusCheck.Checked Then
            load.PerformClick()
        End If
    End Sub

    Private Sub applyStatusFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM STUDENT WHERE st_status='" + statusCombo.SelectedValue.ToString + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        StudentsGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyNameFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM STUDENT WHERE st_name='" + nameBox.Text + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        StudentsGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyBothFilters()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM STUDENT WHERE st_name='" + nameBox.Text + "' AND st_status='" + statusCombo.SelectedValue.ToString + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        StudentsGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM STUDENT"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        StudentsGridView.DataSource = dt
        con1.Close()
    End Sub

End Class