Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m, n As String
        m = TextBox1.Text
        n = TextBox2.Text
        MsgBox(n + " Sucessfully deposited to " + m + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "DEPOSIT")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim m, n As String
        m = TextBox1.Text
        n = TextBox2.Text
        MsgBox(n + " Sucessfully deposited to " + m + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "DEPOSIT")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class