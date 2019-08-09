Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        insert.Text = "Insert data - To insert a new course, student, course or registration complete the form below the grid and press the Insert button"
        delete.Text = "Delete data - To delete a course or a student, make sure that they are not part of any active registrations. If they are, make sure to delete the registrations before attempting to delete a student or a course."
        update.Text = "Update data - You can update a field directly in the grid and make sure to save your changes."
        filter.Text = "Reports - To see reports and filter the data available go to the reports section of the menu and choose the desired information. make sure you check any filters you want to be considered."
        RichTextBox1.Text = "For any issues you encounter, contact 20150046@student.act.edu or leave a message here."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for your message")
    End Sub
End Class