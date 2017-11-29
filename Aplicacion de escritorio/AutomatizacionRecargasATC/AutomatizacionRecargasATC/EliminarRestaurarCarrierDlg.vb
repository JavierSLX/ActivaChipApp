Public Class EliminarRestaurarCarrierDlg
    Dim sql As String
    Dim carrierId As Integer
    Dim mensaje As String
    Private Sub EliminarRestaurarCarrierDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarReporte()
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
    End Sub
    'Método que muestra en un DataGrid el reporte de activos o inactivos segun lo requerido por el usuario 
    Private Sub generarReporte()
        'Activos
        If TabCarrer.SelectedIndex = 0 Then
            sql = "SELECT nombre AS NOMBRE
                    FROM carrier 
                    WHERE activo=true"
            mostrarDatosDataGridView(sql, DGActivos)
        Else
            'Inactivos
            sql = "SELECT nombre AS NOMBRE
                    FROM carrier 
                    WHERE activo=false"
            mostrarDatosDataGridView(sql, DGInactivos)
        End If
    End Sub
    Private Sub ActualizarEstado()
        If TabCarrer.SelectedIndex = 0 Then
            Try
                Dim i As Integer = i = DGActivos.CurrentRow.Index
                i = Me.DGActivos.CurrentCell.RowIndex
                Dim nombre As String = DGActivos.Item(0, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM carrier
                            WHERE nombre='" + nombre + "'"
                carrierId = ComprobrarExistencia(sql)
                sql = "UPDATE carrier 
                        SET activo=false 
                        WHERE id='" + carrierId.ToString + "'"
                Insertar(sql, "Compañía eliminada correctamente", 1, "Compañías")
                generarReporte()
                BtnEliminar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ninguna compañía", MsgBoxStyle.Exclamation, Title:="Compañías")
            End Try
        Else
            Try
                Dim i As Integer = i = DGInactivos.CurrentRow.Index
                i = Me.DGInactivos.CurrentCell.RowIndex
                Dim nombre As String = DGInactivos.Item(0, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM carrier
                            WHERE nombre='" + nombre + "'"
                carrierId = ComprobrarExistencia(sql)
                sql = "UPDATE carrier 
                        SET activo=true 
                        WHERE id='" + carrierId.ToString + "'"
                Insertar(sql, "Compañía restaurada correctamente", 1, "Compañías")
                generarReporte()
                BtnRestaurar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ninguna compañía", MsgBoxStyle.Exclamation, Title:="Compañías")
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ActualizarEstado()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ActualizarEstado()
    End Sub

    Private Sub TabCarrer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabCarrer.SelectedIndexChanged
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
        generarReporte()
    End Sub

    Private Sub DGActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGActivos.CellContentClick
        BtnEliminar.Enabled = True
    End Sub

    Private Sub DGInactivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInactivos.CellContentClick
        BtnRestaurar.Enabled = True
    End Sub
End Class