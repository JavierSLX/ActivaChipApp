Public Class VisualizarPuntoVentaDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idPuntoVenta As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub VisualizarPuntoVentaDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        MostrarPuntoVenta()
        TbxNombre.Select()
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    'Método que muestra los socios activos en un DataGridView
    Private Sub MostrarPuntoVenta()
        sql = "SELECT tipo AS NOMBRE
                FROM punto_venta
                WHERE activo=true
                AND empresa_id='" + idEmpresa.ToString + "'
                ORDER BY tipo ASC"
        mostrarDatosDataGridView(sql, DGPuntoVenta)
    End Sub
    Private Sub GuardarPuntoVenta()
        sql = "INSERT INTO punto_venta(tipo,activo,empresa_id)
                VALUES('" + TbxNombre.Text + "',true,'" + idEmpresa.ToString + "')"
        Insertar(sql, "Punto de Venta guardado correctamente", 1, "Punto de Venta")
    End Sub
    Private Sub EditarPuntoVenta()
        sql = "UPDATE punto_venta 
                SET tipo='" + TbxNombre.Text + "'
                WHERE id='" + idPuntoVenta.ToString + "'"
        Insertar(sql, "Punto de Venta editado correctamente", 1, "Punto de Venta")
    End Sub
    Private Sub LimpiarFormulario()
        TbxNombre.Text = ""
        opcion = 1
        existeRegistro = 0
        TbxNombre.Select()
    End Sub
    Private Sub Generar()
        'Validación que el nombre del socio contenga información
        If TbxNombre.Text.Length() > 0 Then
            'Validación que no exista registros repetidos
            sql = "SELECT id
                            FROM punto_venta
                            WHERE tipo='" + TbxNombre.Text.ToString + "'
                            And empresa_id='" + idEmpresa.ToString + "'"

            existeRegistro = ComprobrarExistencia(sql)

            If (existeRegistro > 0) Then
                MsgBox("Ya existe un punto de venta con estos datos", MsgBoxStyle.Exclamation, Title:="Punto de Venta")
                LimpiarFormulario()
            Else
                If opcion = 1 Then
                    GuardarPuntoVenta()
                Else
                    EditarPuntoVenta()
                End If
                LimpiarFormulario()
                MostrarPuntoVenta()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Punto de Venta")
            TbxNombre.Select()
        End If
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Generar()
    End Sub

    Private Sub TbxNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Generar()
        End Select
    End Sub

    Private Sub DGPuntoVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPuntoVenta.CellContentClick
        TbxNombre.Text = DGPuntoVenta.CurrentRow.Cells(0).Value
        'Obtener el id del usuario
        sql = "SELECT id
                FROM punto_venta
                WHERE empresa_id='" + idEmpresa.ToString + "'
                AND tipo='" + TbxNombre.Text.ToString + "'"
        idPuntoVenta = ComprobrarExistencia(sql)
        opcion = 2
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        LimpiarFormulario()
        ObtenerIdEmpresa()
        MostrarPuntoVenta()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub
End Class