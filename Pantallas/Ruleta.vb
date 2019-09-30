Public Class Ruleta

    Private picnum As Integer = 0
    Private randomNum As Integer
    Private randomObject As New Random()

    Private Sub RuletaPictureBox1_Click(sender As Object, e As EventArgs) Handles RuletaPictureBox1.Click
        VueltasTimer1.Enabled = Not (VueltasTimer1.Enabled)
    End Sub

    Private Sub VueltasTimer1_Tick(sender As Object, e As EventArgs) Handles VueltasTimer1.Tick
        Select Case picnum'select case que cambia las imagenes como si rotara
            Case 1
                'RuletaPictureBox1.Image = My.Resources.arte1
            Case 2
                'RuletaPictureBox1.Image = My.Resources.entreten1
            Case 3
                'RuletaPictureBox1.Image = My.Resources.corona1
            Case 4
                'RuletaPictureBox1.Image = My.Resources.geogra1
            Case 5
                'RuletaPictureBox1.Image = My.Resources.ciencia1
            Case 6
                'RuletaPictureBox1.Image = My.Resources.historia1
            Case 7
                'RuletaPictureBox1.Image = My.Resources.deporte1
                VueltasTimer1.Interval += 1 'aumenta el intervalo del tiempo
            Case Else
                picnum = 0 'resetea el valor para que vuelva a la imagen original
        End Select
        picnum += 1 'aumenta para cambiar la imagen

        If VueltasTimer1.Interval >= 10 Then 'si el contador del tiempo llega a 10 detiene la rotacion de imagenes
            VueltasTimer1.Enabled = Not (VueltasTimer1.Enabled)
            VueltasTimer1.Interval = 1 'vuelve a poner el intervalo en 1 para siguiente turno

            'Randomize()
            'randomNum = Int((8 * Rnd() + 1)) 'una forma de usar el random
            randomNum = randomObject.Next(1, 8) 'otra forma con random para que me de una numero entre 1 y 7
            Select Case randomNum 'cambia la imagen segun el numero dado 
                Case 1
                    'RuletaPictureBox1.Image = My.Resources.arte1

                    VentanaInicioArte.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana

                Case 2
                    'RuletaPictureBox1.Image = My.Resources.entreten1

                    VentanaInicioEntretenimiento.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana

                Case 3
                    'RuletaPictureBox1.Image = My.Resources.corona1

                    VentCorona.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 4
                    'RuletaPictureBox1.Image = My.Resources.geogra1

                    VentanaInicioGeografia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 5
                    'RuletaPictureBox1.Image = My.Resources.ciencia1

                    VentanaInicionCiencia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 6
                    'RuletaPictureBox1.Image = My.Resources.historia1

                    VentanaInicioHistoria.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 7
                    'RuletaPictureBox1.Image = My.Resources.deporte1

                    VentanaInicioDeportes.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


                Case Else

            End Select

        End If
    End Sub
End Class