Public Class Form1
    Private Sub btnAceptar1_Click(sender As Object, e As EventArgs) Handles btnAceptar1.Click
        If txtNombre.Text <> "" And (radHombre.Checked = True Or radMujer.Checked = True) Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Error, debe ingresar los datos para continuar")
            txtNombre.Focus()
        End If
    End Sub

End Class
