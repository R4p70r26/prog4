Public Class VentHistoria
    Private tiempo As Integer
    Private id_pregunta As Integer
    Private Sub TextoPregunta_TextChanged(sender As Object, e As EventArgs) Handles TextoPregunta.TextChanged

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

    Private Sub conexion()
        Dim oleconex As String = "File Name=" & Application.StartupPath & "Conexion.udl"
        Dim sqlquery As String
        Dim sqlQRespuesta As String

        oleconex = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=preguntadosDB;Data Source=DESKTOP-UQHUGC6\RAPTRSQLEXPRESS"

        Using conexOle As New OleDb.OleDbConnection(oleconex)
            conexOle.Open()
            sqlquery = "SELECT TOP 1 * FROM PRENGUNTAS where id_tema = 6 ORDER BY NEWID()"      'trae un pregunta al azar(TEMA 6 = historia)




            Using cmd As New OleDb.OleDbCommand(sqlquery, conexOle)

                Using read As OleDb.OleDbDataReader = cmd.ExecuteReader
                    If read.Read Then
                        id_pregunta = read(0)
                        TextoPregunta.Text = read(2)
                        tiempo = read(3)
                    End If
                End Using
            End Using


            sqlQRespuesta = "select opcion from Respuesta where id_pregunta = " & id_pregunta


            Using consul As New OleDb.OleDbDataAdapter(sqlQRespuesta, conexOle)
                Try
                    Dim TABLA_TEMPORAL = New DataSet()
                    consul.Fill(TABLA_TEMPORAL)

                    BtnOpcion1.Text = TABLA_TEMPORAL.Tables(0).Rows(0).Item(0)
                    BtnOpcion2.Text = TABLA_TEMPORAL.Tables(0).Rows(1).Item(0)
                    BtnOpcion3.Text = TABLA_TEMPORAL.Tables(0).Rows(2).Item(0)
                    BtnOpcion4.Text = TABLA_TEMPORAL.Tables(0).Rows(3).Item(0)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            End Using

        End Using

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo > 0 Then
            tiempo = tiempo - 1
            LTiempo.Text = tiempo
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub VentHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Timer1.Enabled = True
    End Sub
End Class