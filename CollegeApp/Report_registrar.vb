Imports System.Data.OleDb
Public Class Report_registrar
    Private Sub Report_registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sem.Text = "Fall/Spring"
        year.Text = "Year"
    End Sub
    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Try
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1    'Object To Use As SQL Query
            MyQuery = "SELECT * FROM Registrar ORDER BY reg_date"
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               "
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub applyFilters_Click(sender As Object, e As EventArgs) Handles applyFilters.Click
        If studentCheck.Checked And dateCheck.Checked And semesterCheck.Checked Then
            Me.applyAllFilters()
        ElseIf studentCheck.Checked And dateCheck.Checked And Not semesterCheck.Checked Then
            Me.applyStudenDateFilter()
        ElseIf studentCheck.Checked And Not dateCheck.Checked And semesterCheck.Checked Then
            Me.applyStudentSemesterFilter()
        ElseIf Not studentCheck.Checked And dateCheck.Checked And semesterCheck.Checked Then
            Me.applyDateSemesterFilter()
        ElseIf studentCheck.Checked And Not dateCheck.Checked And Not semesterCheck.Checked Then
            Me.applyStudentFilter()
        ElseIf Not studentCheck.Checked And Not dateCheck.Checked And semesterCheck.Checked Then
            Me.applySemesterFilter()
        End If
        If Not studentCheck.Checked And dateCheck.Checked And Not semesterCheck.Checked Then
            Me.applyDateFilter()
        End If
        If Not studentCheck.Checked And Not dateCheck.Checked And Not semesterCheck.Checked Then
            load.PerformClick()
        End If
    End Sub

    Private Sub applyDateFilter()

        Dim dt_start = DateTimePicker1.Value.ToShortDateString()
        Dim dt_end = DateTimePicker2.Value.ToShortDateString()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * from Registrar WHERE reg_date Between #" + dt_start + "# and #" + dt_end + "# ORDER BY reg_date"
        Try
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND reg_date Between #" + dt_start + "# and #" + dt_end + "#
                               "
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub applySemesterFilter()

        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1 'Object To Use As SQL Query
        MyQuery = "SELECT * FROM Registrar WHERE reg_semester='" + sem.Text + "' 
                   AND reg_year='" + year.Text + "' ORDER BY reg_date"
        Try
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND reg_semester='" + sem.Text + "' AND reg_year='" + year.Text + "'
                               "
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub applyStudentFilter()
        Try
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1                                              'Object To Use As SQL Query
            MyQuery = "SELECT * FROM Registrar WHERE st_id_fk=
                       (SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "') ORDER BY reg_date"
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND st_id_fk=(SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "')"
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub applyDateSemesterFilter()

        Dim dt_start = DateTimePicker1.Value.ToShortDateString()
        Dim dt_end = DateTimePicker2.Value.ToShortDateString()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1
        MyQuery = "SELECT * FROM Registrar WHERE reg_semester='" + sem.Text + "' AND reg_year='" + year.Text + "' 
                   AND reg_date Between #" + dt_start + "# and #" + dt_end + "# ORDER BY reg_date"
        Try
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND reg_semester='" + sem.Text + "' 
                               AND reg_year='" + year.Text + "'
                               AND reg_date Between #" + dt_start + "# and #" + dt_end + "#"
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub applyStudentSemesterFilter()

        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        MyQuery = "SELECT * FROM Registrar WHERE reg_semester='" + sem.Text + "' 
                   AND reg_year='" + year.Text + "' AND st_id_fk=(Select st_id FROM Student WHERE st_name='" + studentName.Text + "') ORDER BY reg_date"
        Try
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND reg_semester='" + sem.Text + "' AND reg_year='" + year.Text + "' 
                               AND st_id_fk=(Select st_id FROM Student WHERE st_name='" + studentName.Text + "') "
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            Dim count = Convert.ToInt32(scalarReader)
            credits.Text = count.ToString
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub applyStudenDateFilter()
        Try
            Dim dt_start = DateTimePicker1.Value.ToShortDateString()
            Dim dt_end = DateTimePicker2.Value.ToShortDateString()
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1                                              'Object To Use As SQL Query
            MyQuery = "SELECT * from Registrar WHERE st_id_fk=(SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "') AND reg_date Between #" + dt_start + "# and #" + dt_end + "# ORDER BY reg_date"
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND st_id_fk=(SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "') 
                               AND reg_date Between #" + dt_start + "# and #" + dt_end + "#"
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub applyAllFilters()
        Dim dt_start = DateTimePicker1.Value.ToShortDateString()
        Dim dt_end = DateTimePicker2.Value.ToShortDateString()
        Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1
        MyQuery = "SELECT * FROM Registrar WHERE reg_semester='" + sem.Text + "' AND reg_year='" + year.Text + "' AND st_id_fk=(SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "') AND reg_date Between #" + dt_start + "# and #" + dt_end + "# ORDER BY reg_date"
        Try
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            Dim dt = New DataTable
            dt.Load(MyReader)
            RegistrarGridView.DataSource = dt
            MyReader.Close()
            Dim creditsQuery = "SELECT SUM(crs_credits)
                               FROM Course, Registrar
                               WHERE crs_id = crs_id_fk 
                               AND reg_semester='" + sem.Text + "' AND reg_year='" + year.Text + "' 
                               AND st_id_fk=(SELECT st_id FROM Student WHERE st_name='" + studentName.Text + "') 
                               AND reg_date Between #" + dt_start + "# and #" + dt_end + "#"
            Dim Command As New OleDbCommand(creditsQuery, con1)
            Dim scalarReader = Command.ExecuteScalar()
            If Not (scalarReader Is DBNull.Value) Then
                Dim count = Convert.ToInt32(scalarReader)
                credits.Text = count.ToString
            End If
            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class