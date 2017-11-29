Public Class EliminarRestaurarCliente
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idCliente As Integer
    Dim idPuntoVenta As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub EliminarRestaurarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT nombre 
                FROM empresa 
                WHERE activo=true
                ORDER BY nombre ASC"
        mostrarEmpresa(sql, CBEmpresa)
        CBEmpresa.Text = Empresa
        If Permiso <> 3 Then
            CBEmpresa.Enabled = False
        End If
        ObtenerIdEmpresa()
        sql = "SELECT tipo
                FROM punto_venta
                WHERE activo=true
                AND empresa_id='" + idEmpresa.ToString + "'
                ORDER BY tipo ASC"
        mostrarPuntoVenta(sql, CBPuntoVenta)
        ObtenerIdPuntoVenta()
        generarReporte()
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
    End Sub
    Private Sub ObtenerIdPuntoVenta()
        sql = "SELECT id
             FROM punto_venta
             WHERE tipo='" + CBPuntoVenta.Text + "'
             AND empresa_id='" + idEmpresa.ToString + "'"
        idPuntoVenta = ComprobrarExistencia(sql)
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    'Método que muestra en un DataGrid el reporte de activos o inactivos segun lo requerido por el usuario 
    Private Sub generarReporte()
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        'Activos
        If TabClientes.SelectedIndex = 0 Then
            sql = "SELECT DISTINCT CONCAT(pv.tipo,'-',cc.numero) AS CLAVE,cli.nombre AS NOMBRE,cli.direccion AS DIRECCIÓN,cli.telefono AS TELÉFONO
                    FROM cliente cli,clave_cliente cc,punto_venta pv
                    WHERE cli.empresa_id='" + idEmpresa.ToString + "'
                    AND cc.cliente_id=cli.id
                    AND cc.puntoventa_id=pv.id
                    AND pv.id='" + idPuntoVenta.ToString + "'
                    AND cli.activo=true
                    ORDER BY CONCAT(pv.tipo,'-',cc.numero) ASC;"
            mostrarDatosDataGridView(sql, DGActivos)
        Else
            'Inactivos
            sql = "SELECT DISTINCT CONCAT(pv.tipo,'-',cc.numero) AS CLAVE,cli.nombre AS NOMBRE,cli.direccion AS DIRECCIÓN,cli.telefono AS TELÉFONO
                    FROM cliente cli,clave_cliente cc,punto_venta pv
                    WHERE cli.empresa_id='" + idEmpresa.ToString + "'
                    AND cc.cliente_id=cli.id
                    AND cc.puntoventa_id=pv.id
                    AND pv.id='" + idPuntoVenta.ToString + "'
                    AND cli.activo=false
                    ORDER BY CONCAT(pv.tipo,'-',cc.numero) ASC;"
            mostrarDatosDataGridView(sql, DGInativos)
        End If
    End Sub
    Private Sub ActualizarEstado()
        If TabClientes.SelectedIndex = 0 Then
            Try
                Dim i As Integer = i = DGActivos.CurrentRow.Index
                i = Me.DGActivos.CurrentCell.RowIndex
                Dim nombre As String = DGActivos.Item(1, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT cli.id
                        FROM cliente cli, clave_cliente cc,punto_venta pv
                        WHERE pv.id='" + idPuntoVenta.ToString + "'
                        AND cli.nombre='" + nombre.ToString + "'
                        AND cc.cliente_id=cli.id
                        AND cc.puntoventa_id=pv.id"
                idCliente = ComprobrarExistencia(sql)
                sql = "UPDATE cliente 
                        SET activo=false 
                        WHERE id='" + idCliente.ToString + "'"
                Insertar(sql, "", 2, "")
                sql = "UPDATE clave_cliente 
                        SET activo=false 
                        WHERE cliente_id='" + idCliente.ToString + "'"
                Insertar(sql, "", 2, "")
                sql = "UPDATE permiso_cliente 
                        SET activo=false 
                        WHERE cliente_id='" + idCliente.ToString + "'"
                Insertar(sql, "Cliente eliminado correctamente", 1, "Clientes")
                generarReporte()
                BtnEliminar.Enabled = True
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, Title:="Clientes")
            End Try
        Else
            Try
                Dim i As Integer = i = DGInativos.CurrentRow.Index
                i = Me.DGInativos.CurrentCell.RowIndex
                Dim nombre As String = DGInativos.Item(1, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT cli.id
                        FROM cliente cli, clave_cliente cc,punto_venta pv
                        WHERE pv.id='" + idPuntoVenta.ToString + "'
                        AND cli.nombre='" + nombre.ToString + "'
                        AND cc.cliente_id=cli.id
                        AND cc.puntoventa_id=pv.id"
                idCliente = ComprobrarExistencia(sql)
                sql = "UPDATE cliente 
                        SET activo=true 
                        WHERE id='" + idCliente.ToString + "'"
                Insertar(sql, "", 2, "")
                sql = "UPDATE clave_cliente 
                        SET activo=true 
                        WHERE cliente_id='" + idCliente.ToString + "'"
                Insertar(sql, "", 2, "")
                sql = "UPDATE permiso_cliente 
                        SET activo=true 
                        WHERE cliente_id='" + idCliente.ToString + "'"
                Insertar(sql, "Cliente restaurado correctamente", 1, "Clientes")
                generarReporte()
                BtnRestaurar.Enabled = True
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, Title:="Clientes")
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ActualizarEstado()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ActualizarEstado()
    End Sub

    Private Sub TabClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabClientes.SelectedIndexChanged
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
        generarReporte()
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        generarReporte()
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        generarReporte()
    End Sub

    Private Sub CBPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPuntoVenta.SelectedIndexChanged
        generarReporte()
    End Sub

    Private Sub DGActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGActivos.CellContentClick
        BtnEliminar.Enabled = True
    End Sub

    Private Sub DGInativos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInativos.CellContentClick
        BtnRestaurar.Enabled = True
    End Sub
End Class