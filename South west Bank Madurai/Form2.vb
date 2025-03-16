Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form3.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim z, y As String
        z = "Santhosh Kumar"
        y = "1508"
        If TextBox1.Text = z And TextBox2.Text = y Then
            MsgBox("Successfully SignIn", MsgBoxStyle.OkOnly, "SignIn")
            Form4.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Account Number or PIN Number", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x, y As String
        x = "Santhosh Kumar"
        y = "1508"
        If TextBox1.Text = x And TextBox2.Text = y Then
            MsgBox("Successfully SignIn", MsgBoxStyle.OkOnly, "SignIn")
            Form4.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Account Number or PIN Number", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class