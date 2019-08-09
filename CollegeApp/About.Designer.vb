<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.insert = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Label()
        Me.filter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instructions"
        '
        'insert
        '
        Me.insert.AutoSize = True
        Me.insert.Location = New System.Drawing.Point(18, 70)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(20, 17)
        Me.insert.TabIndex = 1
        Me.insert.Text = "1."
        '
        'delete
        '
        Me.delete.AutoSize = True
        Me.delete.Location = New System.Drawing.Point(18, 107)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(20, 17)
        Me.delete.TabIndex = 2
        Me.delete.Text = "2."
        '
        'update
        '
        Me.update.AutoSize = True
        Me.update.Location = New System.Drawing.Point(18, 142)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(20, 17)
        Me.update.TabIndex = 3
        Me.update.Text = "3."
        '
        'filter
        '
        Me.filter.AutoSize = True
        Me.filter.Location = New System.Drawing.Point(18, 176)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(20, 17)
        Me.filter.TabIndex = 4
        Me.filter.Text = "4."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(15, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contact Us"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 266)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(542, 130)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.Label1)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents insert As Label
    Friend WithEvents delete As Label
    Friend WithEvents update As Label
    Friend WithEvents filter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
