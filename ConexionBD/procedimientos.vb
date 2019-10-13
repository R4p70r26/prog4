Module procedimientos
    'DECLARA VAR GLOBAL
    Public db As New OleDb.OleDbConnection
    'esta variable sera la encargada de conectarnos con la base de datos creada

    'este procedimiento nos conectara con la base de datos usando el archivo udl
    Friend Sub conectar()
        Dim ruta As String ' esta variable guarda la ruta de la bd, es una var local al salir del proceso desaparece

        ruta = "File Name= " & Application.StartupPath & "\conexion.udl"
        db.ConnectionString = ruta

        db.Open() 'abre la conexion

        Exit Sub
    End Sub 'sub es procedimiento

    Function ConexStrOle()
        Dim ruta As String ' esta variable guarda la ruta de la bd, es una var local al salir del proceso desaparece

        ruta = "File Name= " & Application.StartupPath & "\conexion.udl"

        Return ruta
    End Function

    Friend Sub desconectar()
        db.Close() ' cierra bd
    End Sub

    ' este procedimiento carga los datos del a tabla de la base de datos en la memoria de la pc
    Friend Sub cargar_tabla(ByRef tabla_temporal As DataSet, ByVal sql As String)
        conectar()
        'se usa para los select
        Dim consulta As New OleDb.OleDbDataAdapter(sql, db) 'adapta ls datos parametros hacer sql en db

        consulta.Fill(tabla_temporal) 'llene la tabla temporal

        desconectar()
    End Sub

    Friend Sub ejecutar(ByVal sql As String)
        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db) 'declara el comando insertar borrar actualizar como parametro
        comando.ExecuteNonQuery() 'ejecuta el comando
        desconectar()

    End Sub

    Friend Function ejecutarScalar(ByVal sql As String) As Integer
        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db)
        Dim valor = comando.ExecuteScalar()
        desconectar()
        Return valor
    End Function

    Friend Function LeeValorPregunta(ByVal sql As String) As String()
        Dim arr(4) As String

        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db)
        Dim lector As OleDb.OleDbDataReader

        lector = comando.ExecuteReader()
        If lector.Read Then

            arr(0) = lector(0) 'id de pregunta
            arr(1) = lector(2) 'texto de la pregunta
            arr(2) = lector(3) 'tiempo

        End If
        desconectar()

        Return arr
    End Function

    Friend Function LeeValorRespuestas(ByVal sql As String) As String()
        Dim respuesta(5) As String
        Dim tabla As New DataSet()

        Try
            conectar()
            Dim adaptador As New OleDb.OleDbDataAdapter(sql, db)

            adaptador.Fill(tabla)

            respuesta(0) = tabla.Tables(0).Rows(0).Item(0)
            respuesta(1) = tabla.Tables(0).Rows(1).Item(0)
            respuesta(2) = tabla.Tables(0).Rows(2).Item(0)
            respuesta(3) = tabla.Tables(0).Rows(3).Item(0)

            desconectar()


        Catch ex As Exception
            MsgBox("Error al extraer las respuestas")
            desconectar()

        End Try

        Return respuesta

    End Function


End Module
