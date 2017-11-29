Public Class EliminarRestaurarUsuariosDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idUsuario As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub EliminarRestaurarUsuariosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If TabUsuarios.SelectedIndex = 0 Then
            sql = "SELECT adm.nombre AS NOMBRE,per.tipo AS PERMISO
                FROM empresa emp,administrador adm,permiso per,permiso_administrador pa
                WHERE adm.empresa_id=emp.id
                AND emp.nombre='" + CBEmpresa.Text.ToString + "'
                AND pa.administrador_id=adm.id
                AND pa.permiso_id=per.id
                AND pa.activo=true
                ORDER BY adm.nombre ASC"
            mostrarDatosDataGridView(sql, DGActivos)
        Else
            'Inactivos
            sql = "SELECT adm.nombre AS NOMBRE,per.tipo AS PERMISO
                FROM empresa emp,administrador adm,permiso per,permiso_administrador pa
                WHERE adm.empresa_id=emp.id
                AND emp.nombre='" + CBEmpresa.Text.ToString + "'
                AND pa.administrador_id=adm.id
                AND pa.permiso_id=per.id
                AND pa.activo=false
                ORDER BY adm.nombre ASC"
            mostrarDatosDataGridView(sql, DGInativos)
        End If
    End Sub
    Private Sub ActualizarEstado()
        If TabUsuarios.SelectedIndex = 0 Then
            Try
                Dim i As Integer = i = DGActivos.CurrentRow.Index
                i = Me.DGActivos.CurrentCell.RowIndex
                Dim nombre As String = DGActivos.Item(0, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM administrador
                            WHERE nombre='" + nombre + "'
                            AND empresa_id='" + idEmpresa.ToString + "'"
                idUsuario = ComprobrarExistencia(sql)
                sql = "UPDATE permiso_administrador 
                        SET activo=false 
                        WHERE administrador_id='" + idUsuario.ToString + "'"
                Insertar(sql, "Usuario eliminado correctamente", 1, "Usuarios")
                generarReporte()
                BtnEliminar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún usuario", MsgBoxStyle.Exclamation, Title:="Usuarios")
            End Try
        Else
            Try
                Dim i As Integer = i = DGInativos.CurrentRow.Index
                i = Me.DGInativos.CurrentCell.RowIndex
                Dim nombre As String = DGInativos.Item(0, i).Value.ToString
                'Obtener el id del cliente
                sql = "SELECT id
                            FROM administrador
                            WHERE nombre='" + nombre + "'
                            AND empresa_id='" + idEmpresa.ToString + "'"
                idUsuario = ComprobrarExistencia(sql)
                sql = "UPDATE permiso_administrador 
                        SET activo=true 
                        WHERE administrador_id='" + idUsuario.ToString + "'"
                Insertar(sql, "Usuario restaurado correctamente", 1, "Usuarios")
                generarReporte()
                BtnRestaurar.Enabled = False
            Catch ex As Exception
                MsgBox("No ha seleccionado ningún usuario", MsgBoxStyle.Exclamation, Title:="Usuarios")
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ActualizarEstado()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        ActualizarEstado()
    End Sub

    Private Sub TabUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabUsuarios.SelectedIndexChanged
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

    Private Sub DGInativos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInativos.CellContentClick
        BtnRestaurar.Enabled = True
    End Sub
End Class