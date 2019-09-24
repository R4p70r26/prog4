Public Class VentCiencia
    Private Sub BtnOpcion1_Click(sender As Object, e As EventArgs) Handles BtnOpcion1.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion1.BackColor = Color.GreenYellow
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtnOpcion1.BackColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion3_Click(sender As Object, e As EventArgs) Handles BtnOpcion3.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion3.BackColor = Color.GreenYellow
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtnOpcion3.BackColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion2_Click(sender As Object, e As EventArgs) Handles BtnOpcion2.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion2.BackColor = Color.GreenYellow
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtnOpcion2.BackColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion4_Click(sender As Object, e As EventArgs) Handles BtnOpcion4.Click
        Try
            'falta validar si la respuesta seleccionada es la corecta
            If True Then
                BtnOpcion4.BackColor = Color.GreenYellow
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MuestraNombresJugadores.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtnOpcion4.BackColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextoPregunta_TextChanged(sender As Object, e As EventArgs) Handles TextoPregunta.TextChanged

    End Sub
End Class