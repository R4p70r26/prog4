Public Class VentEntretenimiento
    Private tiempo As Integer
    Private id_pregunta As Integer
    Private Sub BtnOpcion4_Click(sender As Object, e As EventArgs) Handles BtnOpcion4.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion4.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                BtnOpcion4.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion3_Click(sender As Object, e As EventArgs) Handles BtnOpcion3.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion3.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                BtnOpcion3.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion2_Click(sender As Object, e As EventArgs) Handles BtnOpcion2.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion2.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                BtnOpcion2.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion1_Click(sender As Object, e As EventArgs) Handles BtnOpcion1.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion1.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                BtnOpcion1.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextoPregunta_TextChanged(sender As Object, e As EventArgs) Handles TextoPregunta.TextChanged

    End Sub

    Private Sub conexion()


        Dim sql = "SELECT TOP 1 * FROM PRENGUNTAS where id_tema = 4 ORDER BY NEWID()"      'trae un pregunta al azar(TEMA 4 = entretenimiento)
        Dim arrPregu = LeeValorPregunta(sql)

        id_pregunta = arrPregu(0)
        TextoPregunta.Text = arrPregu(1)
        tiempo = arrPregu(2)


        Dim sqlResp = "select opcion from Respuesta where id_pregunta = " & id_pregunta
        Dim arrRespu = LeeValorRespuestas(sqlResp)

        BtnOpcion1.Text = arrRespu(0)
        BtnOpcion2.Text = arrRespu(1)
        BtnOpcion3.Text = arrRespu(2)
        BtnOpcion4.Text = arrRespu(3)

    End Sub

    Private Sub VentEntretenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Timer1.Enabled = True
        pictiempofuera.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo > 0 Then
            tiempo = tiempo - 1
            Ltiempo.Text = tiempo
        Else
            Timer1.Enabled = False
        End If
        TiempoPregunta()
    End Sub

    Private Sub TiempoPregunta()

        If tiempo = 0 Then
            If Persona1EstaJugando Then
                Persona1EstaJugando = False
                Persona2EstaJugando = True
            ElseIf Persona2EstaJugando Then
                Persona1EstaJugando = True
                Persona2EstaJugando = False

            End If

            BtnOpcion1.Enabled = False
            BtnOpcion2.Enabled = False
            BtnOpcion3.Enabled = False
            BtnOpcion4.Enabled = False

            pictiempofuera.Visible = True

        End If

    End Sub


End Class