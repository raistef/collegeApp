Public Class Main

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'display message if the user tries to close the form
        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to close this application? Make sure you saved your changes!", "Close Application?", MessageBoxButtons.YesNo)

        'cancel if user clicked no
        If Result = System.Windows.Forms.DialogResult.Yes Then
            'close the main form and the login form running in thw background
            Login.Close()
        End If
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Students_form.Show()
        Students_form.MdiParent = Me
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Faculty_form.Show()
        Faculty_form.MdiParent = Me
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        Course_form.Show()
        Course_form.MdiParent = Me
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registrar_form.Show()
        Registrar_form.MdiParent = Me
    End Sub
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'display message if the user tries to close the form
        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure you want to close this application? Make sure you saved your changes!", "Close Application?", MessageBoxButtons.YesNo)

        'cancel if user clicked no
        If Result = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            'close the main form and the login form running in thw background
            Login.Close()
        End If

    End Sub

    Private Sub StudentsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem1.Click
        Report_students.Show()
        Report_students.MdiParent = Me
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem1.Click
        Report_faculty.Show()
        Report_faculty.MdiParent = Me
    End Sub

    Private Sub CourseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem1.Click
        Report_course.Show()
        Report_course.MdiParent = Me
    End Sub

    Private Sub RegisrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrarToolStripMenuItem.Click
        Report_registrar.Show()
        Report_registrar.MdiParent = Me
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        About.MdiParent = Me
    End Sub
End Class