Imports MySql.Data.MySqlClient
Module BaseDatosDll
    'Variables para la conexión a la base de datos
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=recargasatc; port=3306")
    'Dim conexion As New MySqlConnection("server=187.189.152.4 ; user=xampp; password=marquesada?466; database=recargasatc; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim comando As MySqlCommand
    'Variables publicas
    Public nickname As String
    Public pass As String
    Public Administrador As Integer
    Public Permiso As Integer
    'Método para hacer inserción y actualización en la base de datos
    Public Sub Insertar(sql As String, mensaje As String, salida As Integer, titulo As String)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            If salida = 1 Then
                MsgBox(mensaje, MsgBoxStyle.Information, Title:=titulo)
            End If

        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Title:=titulo)
        End Try
    End Sub
    'Método para comprobar la existencia de un elemento en la base de datos
    Public Function ComprobrarExistencia(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComprobrarExistencia = dt.Rows(0).Item("id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
    'Método para comprobar la existencia de un elemento en la base de datos
    Public Function ObtnenerClave(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtnenerClave = dt.Rows(0).Item("numero")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    Public Function ObtenerMonto(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerMonto = dt.Rows(0).Item("monto")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
    'Método para mostrar los resultados de una consulta en un DataGridView
    Public Sub mostrarDatosDataGridView(sql As String, DGReporte As DataGridView)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DGReporte.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    'Método que muestra un socio en un ComboBox
    Public Sub mostrarMontoCarrier(sql As String, DdMonto As ComboBox)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DdMonto.DataSource = dt
            DdMonto.DisplayMember = "monto"
            DdMonto.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            DdMonto.AutoCompleteSource = AutoCompleteSource.ListItems
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    'Método que muestra un socio en un ComboBox
    Public Sub mostrarEmpresa(sql As String, DdEmpresa As ComboBox)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DdEmpresa.DataSource = dt
            DdEmpresa.DisplayMember = "nombre"
            DdEmpresa.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            DdEmpresa.AutoCompleteSource = AutoCompleteSource.ListItems
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    'Método que muestra un clave de cliente en un ComboBox
    Public Sub mostrarClaveCliente(sql As String, DdClave As ComboBox)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DdClave.DataSource = dt
            DdClave.DisplayMember = "CLAVE"
            DdClave.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            DdClave.AutoCompleteSource = AutoCompleteSource.ListItems
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    'Método que muestra un socio en un ComboBox
    Public Sub mostrarPuntoVenta(sql As String, DdPuntoVenta As ComboBox)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DdPuntoVenta.DataSource = dt
            DdPuntoVenta.DisplayMember = "tipo"
            DdPuntoVenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            DdPuntoVenta.AutoCompleteSource = AutoCompleteSource.ListItems
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Public Function ObtenerAcceso(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            nickname = dt.Rows(0).Item("nickname")
            pass = dt.Rows(0).Item("pass")
            ObtenerAcceso = dt.Rows(0).Item("id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
    Public Sub ObtenerPermiso(sql As String)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            Administrador = dt.Rows(0).Item("administrador_id")
            Permiso = dt.Rows(0).Item("permiso_id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
    Public Sub mostrarPermiso(sql As String, CbPermiso As ComboBox)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            CbPermiso.DataSource = dt
            CbPermiso.DisplayMember = "tipo"
            CbPermiso.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            CbPermiso.AutoCompleteSource = AutoCompleteSource.ListItems
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Public Function ObtneerNombreUsuario(sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtneerNombreUsuario = dt.Rows(0).Item("nombre")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
End Module
