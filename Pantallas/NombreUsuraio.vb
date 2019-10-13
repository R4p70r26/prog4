Public Class NombreUsuraio

    Private Sub NombreUsuraio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub JugarAhoraButton1_Click(sender As Object, e As EventArgs) Handles JugarAhoraButton1.Click
        Try

            'Validamos si los campos de texto estan vacios
            If Jugardor1.Text = "" Or Jugador2.Text = "" Then
                MessageBox.Show("Debe Ingresar el nombre de los jugadores", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)  'muestra una ventana de alerta
            Else
                'Reproduce el audio al dar click en el boton EMPEZAR - no continua con la siguiente linea hasta reproducirlo por completo ( AudioPlayMode.WaitToComplete )
                NombreJugador1Global = Jugardor1.Text
                NombreJugador2Global = Jugador2.Text
                My.Computer.Audio.Play(My.Resources.Random_Oponent, AudioPlayMode.WaitToComplete)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub



End Class