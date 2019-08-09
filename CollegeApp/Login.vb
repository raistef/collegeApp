Public Class Login
    Private actual_username, faculty_type, actual_password As String
    Private trials_left = 3
    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        Dim user_found = False
        Dim user_home = False

        For Each myrow As DataRow In School_db_dataDataSet.Tables("FACULTY").Rows
            actual_username = myrow("fa_account")
            actual_password = myrow("fa_pin")
            faculty_type = myrow("fa_status")

            If username.Text = actual_username And password.Text = actual_password And faculty_type = "HOME" Then
                user_found = True
                user_home = True
            ElseIf username.Text = actual_username And password.Text = actual_password Then
                user_found = True
            End If
        Next
        If trials_left > 0 Then
            Try
                If username.Text = "" And password.Text = "" Then
                    trials_left = trials_left - 1
                    MessageBox.Show("You did not input your credentials! You have " + trials_left.ToString + " trials left.")
                ElseIf username.Text = "" Then
                    trials_left = trials_left - 1
                    MessageBox.Show("You did not input your username! You have " + trials_left.ToString + " trials left.")
                ElseIf password.Text = "" Then
                    trials_left = trials_left - 1
                    MessageBox.Show("You did not input your password! You have " + trials_left.ToString + " trials left.")
                ElseIf user_found = True And user_home = False Then
                    trials_left = trials_left - 1
                    MessageBox.Show("You are not allowed to enter the system with these credentials. You have " + trials_left.ToString + " trials left.")
                ElseIf user_found = False Then
                    trials_left = trials_left - 1
                    MessageBox.Show("Your credentials are not valid. You have " + trials_left.ToString + " trials left.")
                ElseIf user_found = True And user_home = True Then
                    Main.Show()
                    Me.Hide()
                End If
                If trials_left < 1 Then
                    MessageBox.Show("Sorry, you have no more trials left. The application will close.")
                    Me.Close()
                End If
                message.Text = "You have " + trials_left.ToString + " trials left."
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If



    End Sub

    Private Sub FacultyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacultyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.School_db_dataDataSet)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_db_dataDataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.School_db_dataDataSet.Faculty)

    End Sub
End Class
