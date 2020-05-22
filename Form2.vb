Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.radHombre.Checked = True Then
            lblBienvenida.Text = "¡Bienvenido " & Form1.txtNombre.Text & "!"
        ElseIf Form1.radMujer.Checked = True Then
            lblBienvenida.Text = "¡Bienvenida " & Form1.txtNombre.Text & "!"
        End If
    End Sub

    Private Function binario(ByVal año As Integer) As Boolean
        Dim respuesta As Boolean
        If (año Mod 4 = 0 And año Mod 100 <> 0 Or año Mod 400 = 0) Then
            respuesta = True
        Else
            respuesta = False
        End If
        Return respuesta
    End Function

    Private Sub btnAceptar2_Click(sender As Object, e As EventArgs) Handles btnAceptar2.Click
        Dim var As Integer = txtAño.Text
        If binario(var) = True Then
            lblRespuesta.Text = "¡El año ingresado es bisiesto!"
            lblRespuesta.ForeColor = Color.Green
            lblRespuesta.Visible = True
        Else
            lblRespuesta.Text = "¡El año ingresado no es bisiesto!"
            lblRespuesta.ForeColor = Color.Red
            lblRespuesta.Visible = True
        End If
        lblGracias.Visible = True
        lblMiNombre.Visible = True
        lblUtu.Visible = True
    End Sub

    Private Sub txtAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAño.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class