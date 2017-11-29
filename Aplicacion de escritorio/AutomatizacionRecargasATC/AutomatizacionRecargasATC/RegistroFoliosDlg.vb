
Public Class RegistroFoliosDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idCliente As Integer
    Dim idPuntoVenta As Integer
    Dim idCarrier As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub RegistroFoliosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Limpiar()
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
        sql = "SELECT nombre 
                FROM carrier
                WHERE activo=true
                ORDER BY nombre ASC"
        mostrarEmpresa(sql, CBCarrier)
        ObtenerIdCarier()
        MostrarMonto()
    End Sub
    Private Sub ObtenerIdPuntoVenta()
        Sql = "SELECT id
             FROM punto_venta
             WHERE tipo='" + CBPuntoVenta.Text + "'
             AND empresa_id='" + idEmpresa.ToString + "'"
        idPuntoVenta = ComprobrarExistencia(Sql)
    End Sub
    Private Sub ObtenerIdEmpresa()
        Sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(Sql)
    End Sub
    Private Sub ObtenerIdCliente()
        sql = "SELECT cli.id
                FROM cliente cli,punto_venta pv,clave_cliente cc
                WHERE cc.cliente_id=cli.id
                AND cc.puntoventa_id=pv.id
                AND pv.id='" + idPuntoVenta.ToString + "'
                AND cli.activo=true
                AND CONCAT(pv.tipo,'-',cc.numero)='" + CBCliente.Text.ToString + "'"
        idCliente = ComprobrarExistencia(sql)
    End Sub
    Private Sub ObtenerIdCarier()
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + CBCarrier.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
    End Sub
    Private Sub MostrarMonto()
        sql = "SELECT monto
                FROM recarga_carrier
                WHERE empresa_id='" + idEmpresa.ToString + "'
                AND carrier_id='" + idCarrier.ToString + "'"
        Dim monto As Integer = ObtenerMonto(sql)
        sql = "SELECT monto FROM monto_carrier
                WHERE carrier_id='" + idCarrier.ToString + "'
                ORDER BY monto ASC"
        mostrarMontoCarrier(sql, CBMonto)
        CBMonto.Text = monto
    End Sub
    Private Sub MostrarClientes()
        sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) AS CLAVE
                FROM cliente cli, punto_venta pv,clave_cliente cc
                WHERE cli.empresa_id='" + idEmpresa.ToString + "'
                AND cli.activo=true
                AND cc.cliente_id=cli.id
                AND cc.puntoventa_id=pv.id
                AND pv.id='" + idPuntoVenta.ToString + "'
                AND cli.activo=true
                ORDER BY CONCAT(pv.tipo,'-',cc.numero) ASC"
        mostrarClaveCliente(sql, CBCliente)
    End Sub
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        If opcion = 1 Then
            GenerarFolios()
        Else
            GuardarFolios()
        End If
    End Sub
    Private Sub GenerarFolios()
        If CBMonto.Text.Length() > 0 Then
            If TbxFolio.Text.Length() > 0 Then
                If TbxFolio.Text = TbxConfirmar.Text Then
                    'Dim folio As String = TbxFolio.Text
                    'Dim numero As Integer = CInt(Microsoft.VisualBasic.Right(folio, 3))
                    'Dim prefijo As String = Mid(folio, 1, folio.Length() - 3)
                    'Prueba nuevo folio
                    Dim cadena As String = TbxFolio.Text
                    Dim resultado As String = ""
                    Dim numero As String = ""
                    Dim bandera As Integer = 0
                    For x As Integer = 0 To cadena.Length() - 1
                        'If Char.IsDigit(cadena.Chars(x)) Then
                        '    numero += cadena.Chars(x)
                        'Else
                        '    resultado += cadena.Chars(x)
                        'End If
                        If cadena.Chars(x) = "-" Then
                            resultado += cadena.Chars(x)
                            bandera = 1
                            x = x + 1
                        End If
                        If bandera = 0 Then
                            resultado += cadena.Chars(x)
                        Else
                            numero += cadena.Chars(x)
                        End If

                    Next

                    Dim parteNumerica As Integer = CInt(numero)
                    LeerTxt(DGNumeros, resultado, parteNumerica)
                    opcion = 2
                    BtnCargar.Text = "Guardar"
                Else
                    MsgBox("Los folios no coinciden", MsgBoxStyle.Exclamation, Title:="Registro de Folios")
                    TbxFolio.Select()
                End If
            Else
                MsgBox("Favor de teclear el folio inicial", MsgBoxStyle.Exclamation, Title:="Registro de Folios")
                TbxFolio.Select()
            End If
        Else
            MsgBox("Favor de teclear el monto de la recarga", MsgBoxStyle.Exclamation, Title:="Registro de Folios")
            CBMonto.Select()
        End If
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
        MostrarMonto()
    End Sub

    Private Sub CBPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPuntoVenta.SelectedIndexChanged
        ObtenerIdPuntoVenta()
        MostrarClientes()
    End Sub

    Private Sub CBCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCarrier.SelectedIndexChanged
        ObtenerIdCarier()
        MostrarMonto()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        GuardarFolios()
    End Sub
    Private Sub GuardarFolios()
        ObtenerIdCarier()
        ObtenerIdPuntoVenta()
        ObtenerIdCliente()
        'Recorre todos los números solicitados
        For i As Integer = 0 To DGNumeros.RowCount - 2
            Dim folio As String = DGNumeros.Item(0, i).Value
            Dim digitos As String = ""
            'Validación que el número no haya sida ya procesado
            If DGNumeros.Item(2, i).Value = 0 Then
                'Validación que el número contenga 10 digitos
                digitos = DGNumeros.Item(1, i).Value
                If (digitos.Length() = 10) Then
                    'Validación que número solo contenga digitos
                    If IsNumeric(digitos) Then
                        'Validación que el folio no exista en la base de datos
                        sql = "SELECT num.id 
                                FROM numero num,cliente cli,empresa emp
                                WHERE num.folio='" + folio.ToString + "'
                                AND num.cliente_id=cli.id
                                AND cli.empresa_id=emp.id
                                AND emp.id='" + idEmpresa.ToString + "'"
                        existeRegistro = ComprobrarExistencia(sql)
                        If existeRegistro = 0 Then
                            'Validación que el número no exista en la base de datos
                            sql = "SELECT id
                                    FROM numero
                                    WHERE digitos='" + digitos.ToString + "'"
                            existeRegistro = ComprobrarExistencia(sql)
                            If existeRegistro = 0 Then
                                'Inserción en la base de datos
                                sql = "INSERT INTO numero(folio,digitos,fecha,monto,carrier_id,cliente_id)
                                        VALUES('" + folio.ToString + "','" + digitos.ToString + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + CBMonto.Text.ToString + "','" + idCarrier.ToString + "','" + idCliente.ToString + "')"
                                Insertar(sql, "", 2, "")
                                DGNumeros.Item(2, i).Value = 1
                            Else
                                MsgBox("Número ya capturado", MsgBoxStyle.Exclamation, Title:="Registro de números")
                                Me.DGNumeros.CurrentCell = Me.DGNumeros(1, i)
                                Me.DGNumeros.BeginEdit(True)
                                Return
                            End If

                        Else
                            MsgBox("Folio repetido", MsgBoxStyle.Exclamation, Title:="Registro de números")
                            Me.DGNumeros.CurrentCell = Me.DGNumeros(1, i)
                            Me.DGNumeros.BeginEdit(True)
                            Return
                        End If
                    Else
                        MsgBox("Número invalido", MsgBoxStyle.Exclamation, Title:="Registro de números")
                        Me.DGNumeros.CurrentCell = Me.DGNumeros(1, i)
                        Me.DGNumeros.BeginEdit(True)
                        Return
                    End If
                Else
                    MsgBox("Número invalido", MsgBoxStyle.Exclamation, Title:="Registro de números")
                    Me.DGNumeros.CurrentCell = Me.DGNumeros(1, i)
                    Me.DGNumeros.BeginEdit(True)
                    Return
                End If

            Else

            End If
        Next
        MsgBox("Captura de registros finalizada", MsgBoxStyle.Information, Title:="Registro de números")
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbxFolio.Text = ""
        DGNumeros.Rows.Clear()
        BtnCargar.Text = "Generar"
        opcion = 1
    End Sub

    Private Sub TbxMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
    End Sub

    Private Sub CBPuntoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles CBPuntoVenta.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub CBCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles CBCliente.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub CBCarrier_KeyDown(sender As Object, e As KeyEventArgs) Handles CBCarrier.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub TbxMonto_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub TbxFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxFolio.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub DGNumeros_KeyDown(sender As Object, e As KeyEventArgs) Handles DGNumeros.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TbxConfirmar_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxConfirmar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If opcion = 1 Then
                    GenerarFolios()
                Else
                    GuardarFolios()
                End If
        End Select
    End Sub

    Private Sub TbxConfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxConfirmar.KeyPress
        If Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class