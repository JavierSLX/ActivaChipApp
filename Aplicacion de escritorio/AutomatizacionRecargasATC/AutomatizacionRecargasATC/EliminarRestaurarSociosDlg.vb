Public Class EliminarRestaurarSociosDlg
    Dim sql As String
    Dim socioId As Integer
    Dim mensaje As String
    Dim i As Integer = 0
    Private Sub EliminarRestaurarSociosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarReporte()
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
    End Sub
    'Método que muestra en un DataGrid el reporte de activos o inactivos segun lo requerido por el usuario 
    Private Sub generarReporte()
        'Activos
        If TabSocios.SelectedIndex = 0 Then
            sql = "SELECT emp.nombre AS NOMBRE,emp.direccion AS DIRECCION,emp.telefono AS TELEFONO,noti.email AS CORREO 
                    FROM empresa emp,notificaciones noti
                    WHERE emp.activo=true
                    AND noti.empresa_id=emp.id"
            mostrarDatosDataGridView(sql, DGSociosActivos)
        Else
            'Inactivos
            sql = "SELECT emp.nombre AS NOMBRE,emp.direccion AS DIRECCION,emp.telefono AS TELEFONO,noti.email AS CORREO 
                    FROM empresa emp,notificaciones noti
                    WHERE emp.activo=false
                    AND noti.empresa_id=emp.id"
            mostrarDatosDataGridView(sql, DGSociosInactivos)
        End If
    End Sub


    Private Sub ActualizarEstado()
        If TabSocios.SelectedIndex = 0 Then
            Try
                Dim i As Integer = i = DGSociosActivos.CurrentRow.Index
                i = Me.DGSociosActivos.CurrentCell.RowIndex
                Dim nombre As String = DGSociosActivos.Item(0, i).Value.ToString
                Dim direccion As String = DGSociosActivos.Item(1, i).Value.ToString
                Dim telefono As String = DGSociosActivos.Item(2, i).Value.ToString

                'Obtener el id del cliente
                sql = "SELECT id
                            FROM empresa
                            WHERE nombre='" + nombre + "'
                            AND direccion='" + direccion + "'
                            AND telefono='" + telefono + "'"
                    socioId = ComprobrarExistencia(sql)
                    sql = "UPDATE empresa 
                        SET activo=false 
                        WHERE id='" + socioId.ToString + "'"
                    Insertar(sql, "Socio eliminado correctamente", 1, "Socios")
                    generarReporte()
                    DGSociosActivos.ClearSelection()
                BtnEliminar.Enabled = False

            Catch ex As Exception
                MsgBox("No ha seleccionado ningún socio", MsgBoxStyle.Information, Title:="Socios")
            End Try
        Else
            Try
                Dim i As Integer = i = DGSociosInactivos.CurrentRow.Index
                i = Me.DGSociosInactivos.CurrentCell.RowIndex
                Dim nombre As String = DGSociosInactivos.Item(0, i).Value.ToString
                Dim direccion As String = DGSociosInactivos.Item(1, i).Value.ToString
                Dim telefono As String = DGSociosInactivos.Item(2, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM empresa
                            WHERE nombre='" + nombre + "'
                            AND direccion='" + direccion + "'
                            AND telefono='" + telefono + "'"
                    socioId = ComprobrarExistencia(sql)
                    sql = "UPDATE empresa 
                        SET activo=true 
                        WHERE id='" + socioId.ToString + "'"
                Insertar(sql, "Socio restaurado correctamente", 1, "Socios")
                generarReporte()
                    DGSociosInactivos.ClearSelection()
                BtnRestaurar.Enabled = False

            Catch ex As Exception
                MsgBox("No ha seleccionado ningún socio", MsgBoxStyle.Information, Title:="Socios")
            End Try
        End If
        socioId = 0
        TabSocios.Select()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ActualizarEstado()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ActualizarEstado()
    End Sub

    Private Sub TabSocios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabSocios.SelectedIndexChanged
        BtnEliminar.Enabled = False
        BtnRestaurar.Enabled = False
        generarReporte()
    End Sub

    Private Sub DGSociosActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSociosActivos.CellContentClick
        BtnEliminar.Enabled = True
    End Sub

    Private Sub DGSociosInactivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSociosInactivos.CellContentClick
        BtnRestaurar.Enabled = True
    End Sub

End Class