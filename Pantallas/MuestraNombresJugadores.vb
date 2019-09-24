Public Class MuestraNombresJugadores


    Private Sub MuestraNombresJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Muestra en las etiquetas el nombre de los jugadores ingresados en el formulario anterior
            NombreJugador1.Text = My.Forms.NombreUsuraio.Jugardor1.Text
            NombreJugador2.Text = My.Forms.NombreUsuraio.Jugador2.Text

            'establece cuales personajes ha obtenido el jugador
            'de acuerdo al estado de los personajes (true - false)
            'habilitando los que este halla ganado durante el juego

            'jugador 1
            ' si el estado del personaje representado en la variable global es true
            'habilitamos el boton para ver la imagen del personaje a colores
            BtnArte1.Enabled = PersonajeArte1
            BtnCiencia1.Enabled = PersonajeCiencia1
            BtnDeportes1.Enabled = PersonajeDeportes1
            BtnEntretenimiento1.Enabled = PersonajeEntretenimiento1
            BtnGeografia1.Enabled = PersonajeGeografia1
            BtnHistoria1.Enabled = PersonajeHistoria1


            'jugador 2
            ' si el estado del personaje representado en la variable global es true
            'habilitamos el boton para ver la imagen del personaje a colores
            BtnArte2.Enabled = PersonajeArte2
            BtnCiencia2.Enabled = PersonajeCiencia2
            BtnDeportes2.Enabled = PersonajeDeportes2
            BtnEntretenimiento2.Enabled = PersonajeEntretenimiento2
            BtnGeografia2.Enabled = PersonajeGeografia2
            BtnHistoria2.Enabled = PersonajeHistoria2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EmpezarButton1_Click(sender As Object, e As EventArgs) Handles empezarButton1.Click


    End Sub

End Class