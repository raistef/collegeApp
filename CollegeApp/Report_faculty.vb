Imports System.Data.OleDb
Public Class Report_faculty
    Private Sub Report_Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim types = {"ADJUNCT", "FULL-TIME", "HOME", "NOT_ACTIVE"}
        typeCombo.DataSource = types

    End Sub

    Private Sub applyFilters_Click(sender As Object, e As EventArgs) Handles applyFilters.Click
        If nameCheck.Checked And typeCheck.Checked Then
            Me.applyBothFilters()
        End If
        If nameCheck.Checked And Not typeCheck.Checked Then
            Me.applyNameFilter()
        End If
        If Not nameCheck.Checked And typeCheck.Checked Then
            Me.applytypeFilter()
        End If
        If Not nameCheck.Checked And Not typeCheck.Checked Then
            load.PerformClick()
        End If
    End Sub

    Private Sub applyTypeFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM FACULTY WHERE fa_status='" + typeCombo.SelectedValue.ToString + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        FacultyGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyNameFilter()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM FACULTY WHERE fa_name='" + nameBox.Text + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        FacultyGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub applyBothFilters()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM FACULTY WHERE fa_name='" + nameBox.Text + "' AND fa_status='" + typeCombo.SelectedValue.ToString + "'"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        FacultyGridView.DataSource = dt
        con1.Close()
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM FACULTY"
        con1.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        Dim dt = New DataTable
        dt.Load(MyReader)
        FacultyGridView.DataSource = dt
        con1.Close()
    End Sub
End Class