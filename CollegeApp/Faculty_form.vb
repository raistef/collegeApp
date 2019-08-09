Imports System.Data.OleDb

Public Class Faculty_form
    Private Sub FacultyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacultyBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.FacultyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
            FacultyTableAdapter.Fill(School_db_dataDataSet.Faculty)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Faculty_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_db_dataDataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.School_db_dataDataSet.Faculty)

    End Sub

    Private Sub add_faculty_Click(sender As Object, e As EventArgs) Handles add_faculty.Click
        Try
            FacultyTableAdapter.Insert(f_name.Text, f_age.Text, f_date.Text, f_address.Text, f_telephone.Text, f_account.Text,
                                       f_pin.Text, f_status.Text, f_comment.Text)
            ' Update the DataGridView:
            FacultyTableAdapter.Fill(School_db_dataDataSet.Faculty)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click, Del_Rows.Click
        Dim unable_to_delete = 0 'rows that cannot be deleted
        'check if the rows selected are eligible for deletion
        For Each row As DataGridViewRow In FacultyDataGridView.SelectedRows
            Dim con1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
            Dim MyQuery As String = 1                                              'Object To Use As SQL Query
            Dim faculty_id As Int16
            faculty_id = row.Cells(0).Value

            MyQuery = "SELECT COUNT(*) FROM FACULTY, COURSE WHERE fa_id=fa_id_fk AND fa_id=" + Convert.ToString(faculty_id)
            con1.Open()
            Dim oleAccCommand As New OleDbCommand(MyQuery, con1)
            Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
            MyReader.Read()
            If MyReader.GetValue(0) > 0 Then
                MsgBox("The faculty with ID " + Convert.ToString(faculty_id) + " has " + Convert.ToString(MyReader.GetValue(0)) + " course(s) assigned!")
            End If
            If MyReader.GetValue(0) > 0 Then
                unable_to_delete = unable_to_delete + 1
            End If

        Next
        'if all rows are eligible for deletion
        If unable_to_delete = 0 Then
            For Each row As DataGridViewRow In FacultyDataGridView.SelectedRows
                FacultyDataGridView.Rows.RemoveAt(row.Index)
            Next
            Try
                Me.Validate()
                Me.FacultyBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
                FacultyTableAdapter.Fill(School_db_dataDataSet.Faculty)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("You cannot delete faculty that have active course assignments. You have to delete the course assignments first.")
        End If
    End Sub
End Class