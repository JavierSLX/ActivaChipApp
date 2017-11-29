Public Class VisualizarUsuariosDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idUsuario As Integer
    Dim idPermiso As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub VisualizarUsuariosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                FROM permiso
                ORDER BY tipo ASC"
        mostrarPermiso(sql, CBPermiso)
        MostrarUsuarios()
        TbxNombre.Select()
    End Sub
    'Método que muestra los socios activos en un DataGridView
    Private Sub MostrarUsuarios()
        sql = "SELECT adm.nombre AS NOMBRE,per.tipo AS PERMISO
                FROM empresa emp,administrador adm,permiso per,permiso_administrador pa
                WHERE adm.empresa_id=emp.id
                AND emp.nombre='" + CBEmpresa.Text.ToString + "'
                AND pa.administrador_id=adm.id
                AND pa.permiso_id=per.id
                AND pa.activo=true
                ORDER BY adm.nombre ASC"
        mostrarDatosDataGridView(sql, DGUsuarios)
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    Private Sub ObtenerIdPermiso()
        sql = "SELECT id
             FROM permiso
             WHERE tipo='" + CBPermiso.Text + "'"
        idPermiso = ComprobrarExistencia(sql)
    End Sub
    Private Sub GuardarUsuario()
        sql = "INSERT INTO administrador(nombre,empresa_id)
                VALUES('" + TbxNombre.Text + "','" + idEmpresa.ToString + "')"
        Insertar(sql, "", 2, "Usuarios")
        sql = "SELECT id FROM administrador WHERE empresa_id='" + idEmpresa.ToString + "'ORDER BY id DESC LIMIT 1"

        idUsuario = ComprobrarExistencia(sql)
        Dim passwordEncriptado As String = EncriptarPassword(TbxPass.Text)
        sql = "INSERT INTO permiso_administrador(nickname,pass,activo,administrador_id,permiso_id)
                VALUES('" + TbxNick.Text + "','" + passwordEncriptado.ToString + "',true,'" + idUsuario.ToString + "','" + idPermiso.ToString + "')"

        Insertar(sql, "Usuario guardado correctamente", 1, "Usuarios")
    End Sub
    Private Sub EditarUsuario()
        sql = "UPDATE administrador 
                SET nombre='" + TbxNombre.Text + "'
                WHERE id='" + idUsuario.ToString + "'"
        Insertar(sql, "", 2, "Usuarios")
        Dim passwordEncriptado As String = EncriptarPassword(TbxPass.Text)
        sql = "UPDATE permiso_administrador
                SET nickname='" + TbxNick.Text.ToString + "', pass='" + passwordEncriptado.ToString + "',permiso_id='" + idPermiso.ToString + "'
                WHERE administrador_id='" + idUsuario.ToString + "'"
        Insertar(sql, "Usuario actualizado correctamente", 1, "Usuarios")
    End Sub
    Private Sub LimpiarFormulario()
        TbxNombre.Text = ""
        TbxPass.Text = ""
        TbxNick.Text = ""
        opcion = 1
        existeRegistro = 0
        TbxNombre.Select()
    End Sub
    Private Sub Generar()
        'Validación que el nombre del socio contenga información
        If TbxNombre.Text.Length() > 0 Then
            'Validación que la información del socio contenga información
            If TbxNick.Text.Length() > 0 Then
                'Validación que el teléfono del socio contenga información
                If TbxPass.Text.Length() > 0 Then
                    'Validación que no exista registros repetidos
                    sql = "SELECT adm.id
                            FROM administrador adm,permiso_administrador pa
                            WHERE adm.nombre='" + TbxNombre.Text.ToString + "'
                            AND pa.nickname='" + TbxNick.Text.ToString + "'
                            AND pa.permiso_id='" + idPermiso.ToString + "'
                            And adm.empresa_id='" + idEmpresa.ToString + "'"

                    existeRegistro = ComprobrarExistencia(sql)

                    If (existeRegistro > 0) Then
                        MsgBox("Ya existe un socio con estos datos", MsgBoxStyle.Exclamation, Title:="Usuarios")
                        LimpiarFormulario()
                    Else
                        If opcion = 1 Then
                            GuardarUsuario()
                        Else
                            EditarUsuario()
                        End If
                        LimpiarFormulario()
                        MostrarUsuarios()
                    End If
                Else
                    MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Usuarios")
                    TbxPass.Select()
                End If
            Else
                MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Usuarios")
                TbxNick.Select()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Usuarios")
            TbxNombre.Select()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Generar()
    End Sub

    Private Sub DGUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentClick
        TbxNombre.Text = DGUsuarios.CurrentRow.Cells(0).Value
        'Obtener el id del usuario
        sql = "SELECT id
                FROM administrador
                WHERE empresa_id='" + idEmpresa.ToString + "'
                AND nombre='" + TbxNombre.Text.ToString + "'"
        idUsuario = ComprobrarExistencia(sql)

        sql = "SELECT id,nickname,pass 
                FROM permiso_administrador 
                WHERE administrador_id='" + idUsuario.ToString + "'"
        existeRegistro = ObtenerAcceso(sql)
        Dim passwordDesEncriptado As String = DesencriptarPassword(pass)
        TbxNick.Text = nickname
        TbxPass.Text = passwordDesEncriptado
        Dim permiso As String = DGUsuarios.CurrentRow.Cells(1).Value
        CBPermiso.Text = permiso
        opcion = 2
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        ObtenerIdEmpresa()
        MostrarUsuarios()
    End Sub

    Private Sub CBPermiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPermiso.SelectedIndexChanged
        ObtenerIdPermiso()
    End Sub

    Private Sub TbxNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxNick_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxNick.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub CBPermiso_KeyDown(sender As Object, e As KeyEventArgs) Handles CBPermiso.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub
End Class