Public Class VentanaIncorrecta
    Private Sub Pregunta_TextChanged(sender As Object, e As EventArgs) Handles Pregunta.TextChanged

    End Sub



    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        My.Forms.MuestraNombresJugadores.Show()
        Me.Close()
    End Sub

    Private Sub VentanaIncorrecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pregunta.Text = Me.Tag.ToString
    End Sub
End Class