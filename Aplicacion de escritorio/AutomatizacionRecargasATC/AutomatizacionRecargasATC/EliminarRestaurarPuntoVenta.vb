Public Class EliminarRestaurarPuntoVenta
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idPuntoVenta As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub EliminarRestaurarPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        generarReporte()
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    'Método que muestra en un DataGrid el reporte de activos o inactivos segun lo requerido por el usuario 
    Private Sub generarReporte()
        'Activos
        If TabPuntoVenta.SelectedIndex = 0 Then
            sql = "SELECT tipo AS NOMBRE
                    FROM punto_venta
                    WHERE empresa_id='" + idEmpresa.ToString + "'
                    AND activo=true
                    ORDER BY tipo ASC"
            mostrarDatosDataGridView(sql, DGActivos)
        Else
            'Inactivos
            sql = "SELECT tipo AS NOMBRE
                    FROM punto_venta
                    WHERE empresa_id='" + idEmpresa.ToString + "'
                    AND activo=false
                    ORDER BY tipo ASC"
            mostrarDatosDataGridView(sql, DGInactivos)
        End If
    End Sub
    Private Sub ActualizarEstado()
        If TabPuntoVenta.SelectedIndex = 0 Then
            Try
                Dim i As Integer = i = DGActivos.CurrentRow.Index
                i = Me.DGActivos.CurrentCell.RowIndex
                Dim nombre As String = DGActivos.Item(0, i).Value.ToString
                'Obtener el id del punto de venta
                sql = "SELECT id
                            FROM punto_venta
                            WHERE tipo='" + nombre + "'
                            AND empresa_id='" + idEmpresa.ToString + "'"
                idPuntoVenta = ComprobrarExistencia(sql)
                sql = "UPDATE punto_venta 
                        SET activo=false 
                        WHERE id='" + idPuntoVenta.ToString + "'"
                Insertar(sql, "Punto de Venta eliminado correctamente", 1, "Punto de Venta")
                generarReporte()
                BtnEliminar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún punto de venta", MsgBoxStyle.Exclamation, Title:="Punto de Venta")
            End Try
        Else
            Try
                Dim i As Integer = i = DGInactivos.CurrentRow.Index
                i = Me.DGInactivos.CurrentCell.RowIndex
                Dim nombre As String = DGInactivos.Item(0, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM punto_venta
                            WHERE tipo='" + nombre + "'
                            AND empresa_id='" + idEmpresa.ToString + "'"
                idPuntoVenta = ComprobrarExistencia(sql)
                sql = "UPDATE punto_venta 
                        SET activo=true 
                        WHERE id='" + idPuntoVenta.ToString + "'"
                Insertar(sql, "Punto de venta restaurado correctamente", 1, "Punto de Venta")
                generarReporte()
                BtnRestaurar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún punto de venta", MsgBoxStyle.Exclamation, Title:="Punto de Venta")
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ActualizarEstado()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ActualizarEstado()
    End Sub

    Private Sub TabPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPuntoVenta.SelectedIndexChanged
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
        generarReporte()
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        ObtenerIdEmpresa()
        generarReporte()
    End Sub

    Private Sub DGActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGActivos.CellContentClick
        BtnEliminar.Enabled = True
    End Sub

    Private Sub DGInactivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInactivos.CellContentClick
        BtnRestaurar.Enabled = True
    End Sub
End Class