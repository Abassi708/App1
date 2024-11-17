Public Class Form1
    Private Sub lsttaille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsttaille.SelectedIndexChanged

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = lsttaille.SelectedItem.ToString()
        Dim ingredient As String = ""
        If rb1.Checked Then
            ingredient = "croute fine"
        ElseIf rb2.Checked Then
            ingredient = " croute classique"
        ElseIf rb3.Checked Then
            ingredient = "croute épaisse"
        End If
        Dim ingrsupp As String = ""
        If CheckBox1.Checked Then
            ingrsupp = "champinions"
        ElseIf CheckBox2.Checked Then
            ingrsupp = "olives"
        ElseIf CheckBox3.Checked Then
            ingrsupp = "poivrons"
        ElseIf CheckBox4.Checked Then
            ingrsupp = "frommage supplémentaire"
        End If
        Dim msg As String = "taille:  " + taille + "  " + "type de croute :  " + ingredient + "   " + "ingredients supplémentaire:  " + ingrsupp
        MessageBox.Show(msg)
    End Sub
End Class
