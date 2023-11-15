Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = "" Then
            MessageBox.Show("Username is missing!")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Password is missing!")
        ElseIf txtuser.Text = "admin" And txtpass.Text = "admin" Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit the Application?", "Exit",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()

        End If
    End Sub
End Class
