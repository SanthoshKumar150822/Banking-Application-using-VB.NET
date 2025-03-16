Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = TextBox1.Text
        b = TextBox2.Text
        MsgBox(b + " is sucessfully transfered to " + a + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "DEPOSIT")
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a, b As String
        a = TextBox1.Text
        b = TextBox2.Text
        MsgBox(b + " is sucessfully transfered to " + a + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "TRANSFER")
    End Sub
End Class