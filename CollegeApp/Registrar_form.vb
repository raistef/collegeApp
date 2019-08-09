Imports System.Data.OleDb

Public Class Registrar_form

    Private Sub RegistrarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistrarBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.RegistrarBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Registrar_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_db_dataDataSet.Registrar' table. You can move, or remove it, as needed.
        Me.RegistrarTableAdapter.Fill(Me.School_db_dataDataSet.Registrar)

    End Sub

    Private Sub add_registrar_Click(sender As Object, e As EventArgs) Handles add_registrar.Click
        Dim credits = 0
        Try
            'I forgot to make the registrar id an autoNumber and even if I updated the ACCESS table, it still asks for an id, so I increment the id here instead of asking the user
            Dim r As Random = New Random
            RegistrarTableAdapter.Insert(r.Next(1000, 9999) + 1, r_student_id_fk.Text, r_course_id_fk.Text, r_grade.Text, r_status.Text, r_semester.Text, r_year.Text,
                                       r_date.Text)
            ' Update the DataGridView:
            RegistrarTableAdapter.Fill(School_db_dataDataSet.Registrar)
            Try
                Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                Dim course_id As Int16
                course_id = Convert.ToInt16(r_course_id_fk.Text)

                MyQuery = "SELECT crs_credits FROM course WHERE crs_id=" + Convert.ToString(course_id)
                con.Open()
                Dim oleAccCommand As New OleDbCommand(MyQuery, con)
                Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
                MyReader.Read()
                Try
                    If MyReader.GetValue(0) > 0 Then
                        credits = MyReader.GetValue(0)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If credits > 0 Then
                Try

                    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                    Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                    Dim student_id As Int16
                    student_id = Convert.ToInt16(r_student_id_fk.Text)
                    MyQuery = "UPDATE student SET st_credits = st_credits +" + Convert.ToString(credits) + " WHERE st_id=" + Convert.ToString(student_id)
                    con.Open()
                    Dim oleAccCommand As New OleDbCommand(MyQuery, con)
                    Dim rowsAffected As Integer = oleAccCommand.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("The number of credits for the student with id:" + Convert.ToString(student_id) + " was updated")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Del_Rows_Click(sender As Object, e As EventArgs) Handles Del_Rows.Click, BindingNavigatorDeleteItem.Click
        Dim student_id
        Dim credits = 0
        For Each row As DataGridViewRow In RegistrarDataGridView.SelectedRows
            student_id = row.Cells(1).Value
            Try
                Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                Dim course_id As Int16
                course_id = row.Cells(2).Value

                MyQuery = "SELECT crs_credits FROM course WHERE crs_id=" + Convert.ToString(course_id)
                con.Open()
                Dim oleAccCommand As New OleDbCommand(MyQuery, con)
                Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
                MyReader.Read()
                Try
                    If MyReader.GetValue(0) > 0 Then
                        credits = MyReader.GetValue(0)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If credits > 0 Then
                Try
                    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                    Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                    MyQuery = "UPDATE student SET st_credits = st_credits -" + Convert.ToString(credits) + " WHERE st_id=" + Convert.ToString(student_id)
                    con.Open()
                    Dim oleAccCommand As New OleDbCommand(MyQuery, con)
                    Dim rowsAffected As Integer = oleAccCommand.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("The number of credits for the student with id:" + Convert.ToString(student_id) + " was updated")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            Try
                RegistrarDataGridView.Rows.RemoveAt(row.Index)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Next
        Try
            Me.Validate()
            Me.RegistrarBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)
            RegistrarTableAdapter.Fill(School_db_dataDataSet.Registrar)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DelUnpaid_Click(sender As Object, e As EventArgs) Handles DelUnpaid.Click
        Try
            RegistrarTableAdapter.DeleteUnpaid()
            ' Update the DataGridView:
            RegistrarTableAdapter.Fill(School_db_dataDataSet.Registrar)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub update_course_Click(sender As Object, e As EventArgs) Handles update_course.Click
        Dim student_id
        Dim prev_credits = 0
        Dim future_credits = 0
        If IsNumeric(course_id_box.Text) Then
            For Each row As DataGridViewRow In RegistrarDataGridView.SelectedRows
                student_id = row.Cells(1).Value
                Try
                    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                    Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                    Dim course_id As Int16
                    course_id = row.Cells(2).Value
                    MyQuery = "SELECT crs_credits FROM course WHERE crs_id=" + course_id_box.Text
                    con.Open()
                    Dim oleAccCommand As New OleDbCommand(MyQuery, con)
                    Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
                    MyReader.Read()
                    Try
                        future_credits = MyReader.GetValue(0)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    Dim con2 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                    Dim MyQuery As String = 1                                              'Object To Use As SQL Query
                    MyQuery = "SELECT crs_credits FROM course WHERE crs_id=" + Convert.ToString(row.Cells(2).Value)
                    con2.Open()
                    Dim oleAccCommand As New OleDbCommand(MyQuery, con2)
                    Dim MyReader As OleDbDataReader = oleAccCommand.ExecuteReader()
                    MyReader.Read()
                    prev_credits = MyReader.GetValue(0)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    Dim con3 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                    Dim CourseQuery As String = 1   'Object To Use As SQL Query
                    CourseQuery = "UPDATE registrar SET crs_id_fk= " + course_id_box.Text + " WHERE reg_id=" + Convert.ToString(row.Cells(0).Value)
                    con3.Open()
                    Dim oleAccCommand As New OleDbCommand(CourseQuery, con3)
                    Dim rowsAffected As Integer = oleAccCommand.ExecuteNonQuery()


                    'Check If rows affected
                    If rowsAffected > 0 Then
                        MsgBox("The course for the student with id:" + Convert.ToString(student_id) + " was updated")
                    End If
                    RegistrarTableAdapter.Fill(School_db_dataDataSet.Registrar)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                If Not prev_credits = future_credits Then
                    Try
                        Dim con4 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=School_db_with_data.accdb; Persist Security Info=False;")
                        Dim CreditsQuery As String = 1   'Object To Use As SQL Query
                        CreditsQuery = "UPDATE student SET st_credits = st_credits -" + Convert.ToString(prev_credits) + "+" + Convert.ToString(future_credits) + " WHERE st_id=" + Convert.ToString(student_id)
                        con4.Open()
                        Dim oleAccCommand2 As New OleDbCommand(CreditsQuery, con4)
                        Dim rowsAffected2 As Integer = oleAccCommand2.ExecuteNonQuery()
                        'Check if rows affected
                        'If rowsAffected2 > 0 Then
                        '    MsgBox("The number of credits for the student with id:" + Convert.ToString(student_id) + " was updated")
                        'End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next
        Else
            MessageBox.Show("The numebr of credits is not valid.")
        End If


    End Sub
End Class