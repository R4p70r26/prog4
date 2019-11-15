Public Class VentanaRespuesta
    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        My.Forms.MuestraNombresJugadores.Show()
        Me.Close()
    End Sub

    Private Sub VentanaRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextoPregunta.Text = Me.Tag.ToString
    End Sub
End Class