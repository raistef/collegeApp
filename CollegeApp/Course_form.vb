Imports System.Data.OleDb

Public Class Course_form
    Private Sub CourseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CourseBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CourseBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Course_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_db_dataDataSet.Course' table. 
        Me.CourseTableAdapter.Fill(Me.School_db_dataDataSet.Course)

    End Sub

    Private Sub add_course_Click(sender As Object, e As EventArgs) Handles add_course.Click

        Dim eligible_faculty = False
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
        Dim MyQuery As String = 1                                              'Object To Use As SQL Query
        Dim fa_id As Int16
        fa_id = Convert.ToInt16(c_faculty_fk.Text)
        'check the status of the respective faculty
        MyQuery = "SELECT fa_status FROM FACULTY WHERE fa_id=" + Convert.ToString(fa_id)
        con.Open()
        Dim oleAccCommand As New OleDbCommand(MyQuery, con)
        Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
        MyReader.Read()
        'check if courses can be assigned to the respective faculty
        Try
            If MyReader.GetValue(0) = "HOME" Or MyReader.GetValue(0) = "NOT_ACTIVE" Then
                eligible_faculty = False
                MsgBox("Classes cannot be assigned to the faculty with ID " + Convert.ToString(fa_id) + " because its status is " + Convert.ToString(MyReader.GetValue(0)) + ".")
            Else
                eligible_faculty = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If eligible_faculty Then
            Try
                CourseTableAdapter.Insert(c_name.Text, c_number.Text, c_department.Text, c_credits.Text, c_faculty_fk.Text)
                CourseTableAdapter.Fill(School_db_dataDataSet.Course)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Del_fs_id_Click_1(sender As Object, e As EventArgs) Handles Del_fa_id.Click
        Try
            CourseTableAdapter.DeleteFaId(faculty_id.Text)
            ' Update the DataGridView:
            CourseTableAdapter.Fill(School_db_dataDataSet.Course)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'The subroutine below handles two buttons, the red x and the custom button
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click, Del_Rows.Click
        Dim unable_to_delete = 0 'rows that cannot be deleted
        'check if the rows selected are eligible for deletion
        For Each row As DataGridViewRow In CourseDataGridView.SelectedRows
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1                                              'Object To Use As SQL Query
            Dim course_id As Int16
            course_id = row.Cells(0).Value

            MyQuery = "SELECT COUNT(*) FROM COURSE, REGISTRAR WHERE crs_id=crs_id_fk AND crs_id=" + Convert.ToString(course_id)
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            MyReader.Read()
            If MyReader.GetValue(0) > 0 Then
                MsgBox("The course with ID " + Convert.ToString(course_id) + " has " + Convert.ToString(MyReader.GetValue(0)) + " registrations assigned!")
            End If
            If MyReader.GetValue(0) > 0 Then
                unable_to_delete = unable_to_delete + 1
            End If

        Next
        'if at least one has active registrations
        If unable_to_delete = 0 Then
            For Each row As DataGridViewRow In CourseDataGridView.SelectedRows
                CourseDataGridView.Rows.RemoveAt(row.Index)
            Next
            Try
                Me.Validate()
                Me.CourseBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
                CourseTableAdapter.Fill(School_db_dataDataSet.Course)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("You cannot delete courses that are currently assigned.")
        End If


    End Sub


End Class