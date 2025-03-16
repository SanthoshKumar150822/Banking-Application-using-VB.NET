Public Class Form8
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim total As String = 1000
        TextBox2.Text = "$" + total
        MsgBox("Balance Amount " + TextBox2.Text + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "BALANCE ENQUERY")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim total As String = 1000
        TextBox2.Text = "$" + total
        MsgBox("Balance Amount " + TextBox2.Text + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "BALANCE ENQUERY")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class