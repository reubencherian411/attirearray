Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty

        TextBox4.Text = String.Empty

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class