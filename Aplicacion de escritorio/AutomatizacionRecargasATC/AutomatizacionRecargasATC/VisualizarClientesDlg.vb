Public Class VisualizarClientesDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idCliente As Integer
    Dim idPuntoVenta As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub VisualizarClientesDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        MostrarClientes()
    End Sub
    'Método que muestra los socios activos en un DataGridView
    Private Sub MostrarClientes()
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) AS CLAVE,cli.nombre AS NOMBRE,cli.direccion AS DIRECCIÓN,cli.telefono AS TELÉFONO
                FROM cliente cli, punto_venta pv,clave_cliente cc
                WHERE cli.empresa_id='" + idEmpresa.ToString + "'
                AND cli.activo=true
                AND cc.cliente_id=cli.id
                AND cc.puntoventa_id=pv.id
                AND pv.id='" + idPuntoVenta.ToString + "'
                AND cli.activo=true
                ORDER BY cli.id ASC"
        mostrarDatosDataGridView(sql, DGClientes)
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    Private Sub ObtenerIdPuntoVenta()
        sql = "SELECT id
             FROM punto_venta
             WHERE tipo='" + CBPuntoVenta.Text + "'
             AND empresa_id='" + idEmpresa.ToString + "'"
        idPuntoVenta = ComprobrarExistencia(sql)
    End Sub
    Private Sub LimpiarFormulario()
        TbxNombre.Text = ""
        TbxPass.Text = ""
        TbxNick.Text = ""
        TbxDireccion.Text = ""
        TbxTelefono.Text = ""
        opcion = 1
        existeRegistro = 0
        TbxNombre.Select()
    End Sub
    Private Sub GuardarCliente()
        sql = "INSERT INTO cliente(nombre,direccion,telefono,activo,empresa_id)
                VALUES('" + TbxNombre.Text + "','" + TbxDireccion.Text.ToString + "','" + TbxTelefono.Text.ToString + "',true,'" + idEmpresa.ToString + "')"
        Insertar(sql, "", 2, "")
        sql = "SELECT id 
                FROM cliente 
                WHERE empresa_id='" + idEmpresa.ToString + "'
                ORDER BY id DESC LIMIT 1"
        idCliente = ComprobrarExistencia(sql)
        Dim passwordEncriptado As String = EncriptarPassword(TbxPass.Text)
        sql = "INSERT INTO permiso_cliente(nickname,pass,activo,cliente_id)
                VALUES('" + TbxNick.Text + "','" + passwordEncriptado.ToString + "',true,'" + idCliente.ToString + "')"
        Insertar(sql, "", 2, "")
        sql = "SELECT numero
                FROM clave_cliente
                WHERE puntoventa_id='" + idPuntoVenta.ToString + "'
                ORDER BY numero DESC LIMIT 1"
        Dim clave As Integer = ObtnenerClave(sql)
        clave = clave + 1
        Dim numero As String = clave
        Dim ceros As String = ""
        For i As Integer = numero.ToString.Length() To 2
            ceros += "0"
        Next
        Dim clave_cliente As String = ceros
        clave_cliente += numero
        sql = "INSERT INTO clave_cliente(numero,activo,cliente_id,puntoventa_id)
                VALUES('" + clave_cliente.ToString + "',true,'" + idCliente.ToString + "','" + idPuntoVenta.ToString + "')"
        Insertar(sql, "Cliente guardado correctamente", 1, "Clientes")

    End Sub
    Private Sub EditarUsuario()
        sql = "UPDATE cliente 
                SET nombre='" + TbxNombre.Text + "',direccion='" + TbxDireccion.Text + "',telefono='" + TbxTelefono.Text + "'
                WHERE id='" + idCliente.ToString + "'"
        Insertar(sql, "", 2, "")
        Dim passwordEncriptado As String = EncriptarPassword(TbxPass.Text)
        sql = "UPDATE permiso_cliente
                SET nickname='" + TbxNick.Text.ToString + "', pass='" + passwordEncriptado.ToString + "'
                WHERE cliente_id='" + idCliente.ToString + "'"
        Insertar(sql, "Cliente actualizado correctamente", 1, "Clientes")
    End Sub
    Private Sub Generar()
        'Validación que el nombre del cliente contenga información
        If TbxNombre.Text.Length() > 0 Then
            'Validación que el nick contenga información
            If TbxNick.Text.Length() > 0 Then
                'Validación password contenga información
                If TbxPass.Text.Length() > 0 Then
                    If TbxDireccion.Text.Length() > 0 Then
                        If TbxTelefono.Text.Length() = 10 Then
                            'Validación que no exista registros repetidos
                            sql = "SELECT cli.id
                            FROM cliente cli,permiso_cliente pc
                            WHERE cli.activo=true
                            AND cli.nombre='" + TbxNombre.Text.ToString + "'
                            AND cli.direccion='" + TbxDireccion.Text.ToString + "'
                            AND cli.telefono='" + TbxTelefono.Text.ToString + "'
                            AND pc.nickname='" + TbxNick.Text.ToString + "'
                            AND pc.pass='" + EncriptarPassword(TbxPass.Text) + "'
                            And cli.empresa_id='" + idEmpresa.ToString + "'"

                            existeRegistro = ComprobrarExistencia(sql)

                            If (existeRegistro > 0) Then
                                MsgBox("Ya existe un cliente con estos datos", MsgBoxStyle.Exclamation, Title:="Cliente")
                                LimpiarFormulario()
                            Else
                                If opcion = 1 Then
                                    GuardarCliente()
                                Else
                                    EditarUsuario()
                                End If
                                LimpiarFormulario()
                                MostrarClientes()
                            End If
                        Else
                            MsgBox("Número invalido", MsgBoxStyle.Exclamation, Title:="Cliente")
                            TbxTelefono.Select()
                        End If
                    Else
                        MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Cliente")
                        TbxDireccion.Select()
                    End If
                Else
                    MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Cliente")
                    TbxPass.Select()
                End If
            Else
                MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Cliente")
                TbxNick.Select()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Cliente")
            TbxNombre.Select()
        End If
    End Sub

    Private Sub DGClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellContentClick
        TbxNombre.Text = DGClientes.CurrentRow.Cells(1).Value
        TbxDireccion.Text = DGClientes.CurrentRow.Cells(2).Value
        TbxTelefono.Text = DGClientes.CurrentRow.Cells(3).Value
        'Obtener el id del usuario
        sql = "SELECT id
                FROM cliente
                WHERE empresa_id='" + idEmpresa.ToString + "'
                AND nombre='" + TbxNombre.Text.ToString + "'"
        idCliente = ComprobrarExistencia(sql)

        sql = "SELECT id,nickname,pass 
                FROM permiso_cliente 
                WHERE cliente_id='" + idCliente.ToString + "'"
        existeRegistro = ObtenerAcceso(sql)
        Dim passwordDesEncriptado As String = DesencriptarPassword(pass)
        TbxNick.Text = nickname
        TbxPass.Text = passwordDesEncriptado
        opcion = 2
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        ObtenerIdEmpresa()
        sql = "SELECT tipo
                FROM punto_venta
                WHERE activo=true
                AND empresa_id='" + idEmpresa.ToString + "'
                ORDER BY tipo ASC"
        mostrarPuntoVenta(sql, CBPuntoVenta)
        ObtenerIdPuntoVenta()
        MostrarClientes()
    End Sub

    Private Sub CBPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPuntoVenta.SelectedIndexChanged
        MostrarClientes()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        MostrarClientes()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Generar()
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

    Private Sub CBEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles CBEmpresa.KeyDown
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        MostrarClientes()
    End Sub

    Private Sub CBPuntoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles CBPuntoVenta.KeyDown
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        MostrarClientes()
    End Sub

    Private Sub GBCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles GBCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
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


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
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

End Class