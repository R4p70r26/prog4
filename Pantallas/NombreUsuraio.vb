﻿Public Class NombreUsuraio

    Dim arrPregu As DataSet
    Private Sub NombreUsuraio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Jugador2.Enabled = False 'desabilita combo 

        conexion() 'conecta bd

    End Sub

    Private Sub JugarAhoraButton1_Click(sender As Object, e As EventArgs) Handles JugarAhoraButton1.Click
        Try

            'Validamos si los campos de texto estan vacios
            'If Jugador1.Text = "" And Jugador2.Text = "" Then
            'MessageBox.Show("Debe Ingresar el nombre de los jugadores", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)  'muestra una ventana de alerta
            'Else

            If Jugador1.Text <> "" And Jugador2.Text <> "" Then

                'Reproduce el audio al dar click en el boton EMPEZAR - no continua con la siguiente linea hasta reproducirlo por completo ( AudioPlayMode.WaitToComplete )
                NombreJugador1Global = Jugador1.Text 'asigna nombres globales
                NombreJugador2Global = Jugador2.Text
                My.Computer.Audio.Play(My.Resources.Random_Oponent, AudioPlayMode.WaitToComplete)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()

            ElseIf txtJug1.Text <> "" And txtJug2.Text <> "" Then

                'Reproduce el audio al dar click en el boton EMPEZAR - no continua con la siguiente linea hasta reproducirlo por completo ( AudioPlayMode.WaitToComplete )
                NombreJugador1Global = txtJug1.Text 'asigna nombres globales
                NombreJugador2Global = txtJug2.Text
                My.Computer.Audio.Play(My.Resources.Random_Oponent, AudioPlayMode.WaitToComplete)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()

            Else
                MessageBox.Show("Debe Ingresar el nombre de los jugadores", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)  'muestra una ventana de alerta

            End If

            'End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


    Private Sub conexion()

        Try
            Dim sql = "SELECT * FROM Jugador"      'selecciona los jugadores
            arrPregu = LeeJugadores(sql) 'almacena jugadores array

            For index = 0 To arrPregu.Tables(0).Rows.Count - 1
                Jugador1.Items.Insert(index, (arrPregu.Tables(0).Rows(index).Item(1).ToString().Trim())) 'agrega los jugadores al listbox
            Next
        Catch ex As Exception
            MsgBox("Error al conectar a DB", vbCritical, "Error")
        End Try

    End Sub

    Private Sub Jugador1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Jugador1.SelectedIndexChanged 'valida que se selecciones los jugadores
        Jugador2.Enabled = True
        Jugador2.Items.Clear()
        Jugador2.Text = ""
        For index = 0 To arrPregu.Tables(0).Rows.Count - 1
            If Jugador1.SelectedIndex <> index Then
                Dim index2 As Integer = 0

                Jugador2.Items.Insert(index2, (arrPregu.Tables(0).Rows(index).Item(1).ToString().Trim()))
                index2 += 1
            End If

        Next

    End Sub

    Private Sub Jugador2_MouseClick(sender As Object, e As MouseEventArgs) Handles Jugador2.MouseClick
        If Jugador1.SelectedIndex = -1 Then 'valida que se selecciones los jugadores
            MsgBox("Por favor seleccione el jugador 1", MsgBoxStyle.Information, "Seleccion jugador")
        End If
    End Sub
End Class