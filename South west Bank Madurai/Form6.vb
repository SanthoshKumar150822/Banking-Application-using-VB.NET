Public Class Form6
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As String
        b = TextBox2.Text
        MsgBox(b + " Sucessfully withdrawn" + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "WITHDRAWN")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim b As String
        b = TextBox2.Text
        MsgBox(b + " Sucessfully withdrawn" + vbCrLf + "Don't forget to collect your card!!!", MsgBoxStyle.OkOnly, "WITHDRAWN")
    End Sub
End Class