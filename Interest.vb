Public Class Interest

    Dim SI As Double
    Dim Amount As Double
    Dim CI As Double


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            SI = TextBox1.Text * TextBox2.Text * TextBox3.Text / 100
            TextBox4.Text = SI
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Amount = TextBox1.Text * (1 + TextBox3.Text / 100) ^ TextBox2.Text
            CI = Amount - TextBox1.Text
            TextBox4.Text = CI
        End If

    End Sub
End Class
