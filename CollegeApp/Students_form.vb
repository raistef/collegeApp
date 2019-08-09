Imports System.Data.OleDb

Public Class Students_form

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.StudentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
            StudentTableAdapter.Fill(School_db_dataDataSet.Student)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Students_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'School_db_dataDataSet.Student' table.
        Me.StudentTableAdapter.Fill(Me.School_db_dataDataSet.Student)

    End Sub

    Private Sub add_student_Click(sender As Object, e As EventArgs) Handles add_student.Click
        Try
            StudentTableAdapter.Insert(s_name.Text, s_number.Text, s_telephone.Text, s_address.Text, s_age.Text, s_date.Text,
                                       s_enabled.Text, s_credits.Text, s_status.Text, s_comment.Text)
            ' Update the DataGridView:
            StudentTableAdapter.Fill(School_db_dataDataSet.Student)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click

        Dim i As Integer
        For Each row As DataGridViewRow In StudentDataGridView.SelectedRows
            Try
                row.Cells(7).Value = "y"
                i = i + 1
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next

        Try
            Me.Validate()
            Me.StudentBindingSource.EndEdit()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Displays number of rows updated.
        MessageBox.Show("Number of rows updated: " & i)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click, Del_Rows.Click
        Dim unable_to_delete = 0 'rows that cannot be deleted
        'check if the rows selected are eligible for deletion
        For Each row As DataGridViewRow In StudentDataGridView.SelectedRows
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1                                              'Object To Use As SQL Query
            Dim student_id As Int16
            student_id = row.Cells(0).Value

            MyQuery = "SELECT COUNT(*) FROM STUDENT, REGISTRAR WHERE st_id=st_id_fk AND st_id=" + Convert.ToString(student_id)
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            MyReader.Read()
            If MyReader.GetValue(0) > 0 Then
                MsgBox("The student with ID " + Convert.ToString(student_id) + " has " + Convert.ToString(MyReader.GetValue(0)) + " registrations assigned!")
            End If
            If MyReader.GetValue(0) > 0 Then
                unable_to_delete = unable_to_delete + 1
            End If

        Next

        If unable_to_delete = 0 Then
            For Each row As DataGridViewRow In StudentDataGridView.SelectedRows
                StudentDataGridView.Rows.RemoveAt(row.Index)
            Next
            Try
                Me.Validate()
                Me.StudentBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
                StudentTableAdapter.Fill(School_db_dataDataSet.Student)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("You cannot delete students that have active registrations.")
        End If
    End Sub



    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        StudentTableAdapter.Fill(School_db_dataDataSet.Student)

    End Sub
End Class