Public Class Calculator

    Dim number1 As Integer
    Dim number2 As Integer
    Dim opr As Integer
    Dim div As Double

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        number1 = TextBox1.Text
        number2 = TextBox2.Text

        If RadioButton1.Checked = True Then
            opr = number1 + number2
            TextBox3.Text = opr
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            opr = TextBox1.Text - TextBox2.Text
            TextBox3.Text = opr
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            opr = TextBox1.Text * TextBox2.Text
            TextBox3.Text = opr
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            div = TextBox1.Text / TextBox2.Text
            TextBox3.Text = div
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            opr = TextBox1.Text Mod TextBox2.Text
            TextBox3.Text = opr
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
