Public Class VisualizarSociosDlg
    Dim sql As String
    Dim idSocio As Integer = 0
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer = 0
    Dim mensaje As String
    Private Sub VisualizarSociosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarFormulario()
        MostrarSocios()

    End Sub
    'Método que muestra los socios activos en un DataGridView
    Private Sub MostrarSocios()
        sql = "SELECT emp.nombre AS NOMBRE,emp.direccion AS DIRECCION,emp.telefono AS TELEFONO,noti.email AS CORREO,
                ae.wsdl AS WSDL,ae.usuario AS USUARIO,ae.pass AS PASSWORD,ae.clave_operador AS CLAVE
                FROM empresa emp,notificaciones noti,acceso_empresa ae
                WHERE emp.activo=true
                AND noti.empresa_id=emp.id
                AND ae.empresa_id=emp.id"
        mostrarDatosDataGridView(sql, DGSociosActivos)
    End Sub
    Private Sub GuardarSocio()
        sql = "INSERT INTO empresa(nombre,direccion,telefono,activo)
                VALUES('" + TbxNombre.Text + "','" + TbxDireccion.Text + "','" + TbxTelefono.Text + "',true)"
        mensaje = "Socio guardado correctamente"
        Insertar(sql, mensaje, 2, "Socios")
        sql = "SELECT id FROM empresa ORDER BY id DESC LIMIT 1"
        idSocio = ComprobrarExistencia(sql)
        Dim wsdl As String = TbxWSDL.Text
        Dim usuario As String = TbxUsuario.Text
        Dim password As String = TbxPass.Text
        Dim clave As String = TbxClave.Text
        sql = "INSERT INTO acceso_empresa(wsdl,usuario,pass,clave_operador,empresa_id)
                VALUES('" + wsdl.ToString + "','" + usuario.ToString + "','" + password.ToString + "','" + clave.ToString + "','" + idSocio.ToString + "')"
        Insertar(sql, "", 2, "Socios")
        sql = "INSERT INTO notificaciones(email,activo,empresa_id)
                VALUES('" + TbxCorreo.Text.ToString + "',true,'" + idSocio.ToString + "')"
        mensaje = "Socio guardado correctamente"
        Insertar(sql, mensaje, 2, "Socios")
        sql = "SELECT id FROM notificaciones ORDER BY id DESC LIMIT 1"
        Dim idNotificaciones As Integer = ComprobrarExistencia(sql)
        sql = "INSERT INTO alerta_notificaciones(activo,notificaciones_id)
                VALUES(false,'" + idNotificaciones.ToString + "')"
        Insertar(sql, mensaje, 1, "Socios")
    End Sub
    Private Sub EditarSocio()
        sql = "UPDATE empresa 
                        SET nombre='" + TbxNombre.Text.ToString + "',direccion='" + TbxDireccion.Text.ToString + "',telefono='" + TbxTelefono.Text + "'
        WHERE id='" + idSocio.ToString + "'"
        mensaje = "Socio actualizado correctamente"
        Insertar(sql, mensaje, 2, "Socios")
        sql = "UPDATE notificaciones
                SET email='" + TbxCorreo.Text.ToString + "'
                WHERE empresa_id='" + idSocio.ToString + "'"
        Insertar(sql, mensaje, 2, "Socios")
        sql = "UPDATE acceso_empresa SET wsdl='" + TbxWSDL.Text.ToString + "',usuario='" + TbxUsuario.Text.ToString + "',pass='" + TbxPass.Text.ToString + "',clave_operador='" + TbxClave.Text.ToString + "'
                WHERE empresa_id='" + idSocio.ToString + "'"
        Insertar(sql, mensaje, 1, "Socios")
    End Sub
    Private Sub LimpiarFormulario()
        TbxNombre.Text = ""
        TbxDireccion.Text = ""
        TbxTelefono.Text = ""
        TbxCorreo.Text = ""
        TbxWSDL.Text = ""
        TbxUsuario.Text = ""
        TbxPass.Text = ""
        TbxClave.Text = ""
        idSocio = 0
        opcion = 1
        existeRegistro = 0
        TbxNombre.Select()
    End Sub
    Private Sub Generar()
        'Validación que el nombre del socio contenga información
        If TbxNombre.Text.Length() > 0 Then
            'Validación que la información del socio contenga información
            If TbxDireccion.Text.Length() > 0 Then
                'Validación que el teléfono del socio contenga información
                If TbxTelefono.Text.Length() > 0 Then
                    'Validación que el telefono sea correcto
                    If TbxTelefono.Text.Length = 10 Then
                        'Validación que el correo tenga información
                        If TbxCorreo.Text.Length() > 0 Then
                            'Validación que el WSDL tenga información
                            If TbxWSDL.Text.Length() > 0 Then
                                'Validación que el usuario tenga información
                                If TbxUsuario.Text.Length() > 0 Then
                                    'Validcación que el password tenga información
                                    If TbxPass.Text.Length() > 0 Then
                                        'Validación que la clave tenga información
                                        If TbxClave.Text.Length() > 0 Then
                                            'Validación que no exista registros repetidos
                                            sql = "SELECT emp.id
                                                    FROM empresa emp, notificaciones noti
                                                    WHERE emp.nombre='" + TbxNombre.Text.ToString + "'
                                                    AND emp.direccion='" + TbxDireccion.Text.ToString + "'
                                                    AND emp.telefono='" + TbxTelefono.Text.ToString + "'
                                                    AND noti.empresa_id=emp.id
                                                    AND noti.email='" + TbxCorreo.Text.ToString + "'"
                                            existeRegistro = ComprobrarExistencia(sql)
                                            If (existeRegistro > 0) Then
                                                MsgBox("Ya existe un socio con estos datos", MsgBoxStyle.Exclamation, Title:="Socios")
                                                LimpiarFormulario()
                                            Else
                                                If opcion = 1 Then
                                                    GuardarSocio()
                                                Else
                                                    EditarSocio()
                                                End If

                                                LimpiarFormulario()
                                                MostrarSocios()
                                            End If
                                        Else
                                            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                                            TbxClave.Select()
                                        End If
                                    Else
                                        MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                                        TbxPass.Select()
                                    End If
                                Else
                                    MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                                    TbxUsuario.Select()
                                End If
                            Else
                                MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                                TbxWSDL.Select()
                            End If
                        Else
                            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                            TbxTelefono.Select()
                        End If
                    Else
                        MsgBox("Teléfono invalido", MsgBoxStyle.Exclamation, Title:="Socios")
                        TbxTelefono.Select()
                    End If
                Else
                    MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                    TbxTelefono.Select()
                End If
            Else
                MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
                TbxDireccion.Select()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Socios")
            TbxNombre.Select()
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Generar()
    End Sub

    Private Sub DGSociosActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSociosActivos.CellContentClick
        TbxNombre.Text = DGSociosActivos.CurrentRow.Cells(0).Value
        TbxDireccion.Text = DGSociosActivos.CurrentRow.Cells(1).Value
        TbxTelefono.Text = DGSociosActivos.CurrentRow.Cells(2).Value
        TbxCorreo.Text = DGSociosActivos.CurrentRow.Cells(3).Value
        TbxWSDL.Text = DGSociosActivos.CurrentRow.Cells(4).Value
        TbxUsuario.Text = DGSociosActivos.CurrentRow.Cells(5).Value
        TbxPass.Text = DGSociosActivos.CurrentRow.Cells(6).Value
        TbxClave.Text = DGSociosActivos.CurrentRow.Cells(7).Value
        sql = "SELECT id
                FROM empresa
                WHERE nombre='" + TbxNombre.Text.ToString + "'"
        idSocio = ComprobrarExistencia(sql)
        opcion = 2
        TbxNombre.Select()
    End Sub

    Private Sub TbxNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxDireccion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxTelefono.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub


    Private Sub TbxTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbxTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
        If TbxTelefono.Text.Length() > 9 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxCorreo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxWSDL_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxWSDL.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub TbxUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUsuario.KeyDown
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

    Private Sub TbxClave_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxClave.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub
End Class