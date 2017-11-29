Public Class MontoRecargaDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idCarrier As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub MontoRecargaDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
    Private Sub ObtenerIdEmpresa()
        sql = "SELECT id
             FROM empresa
             WHERE nombre='" + CBEmpresa.Text + "'"
        idEmpresa = ComprobrarExistencia(sql)
    End Sub
    Private Sub Limpiar()
        'TbxMonto.Text = ""
        TbxCarrier.Text = ""
        idCarrier = 0
        idEmpresa = 0
    End Sub
    'Método que muestra en un DataGrid el reporte de activos o inactivos segun lo requerido por el usuario 
    Private Sub generarReporte()
        ObtenerIdEmpresa()
        'Activos
        If TabMonto.SelectedIndex = 0 Then
            sql = "SELECT carr.nombre,rc.monto
                    FROM carrier carr,recarga_carrier rc
                    WHERE rc.carrier_id=carr.id
                    AND carr.activo=true
                    AND rc.empresa_id='" + idEmpresa.ToString + "'
                    ORDER BY carr.nombre ASC"
            mostrarDatosDataGridView(sql, DGAsignado)
        Else
            'Inactivos
            sql = "SELECT nombre AS Nombre
                    FROM carrier
                    WHERE id NOT IN (select carrier_id FROM recarga_carrier WHERE empresa_id='" + idEmpresa.ToString + "')
                    ORDER BY nombre ASC"
            mostrarDatosDataGridView(sql, DGSinAsignar)
        End If
    End Sub
    'Método que inserta o actualiza según requiera el usuario
    Private Sub Guardar()
        If CBMonto.Text.Length() > 0 Then
            'Activos
            If TabMonto.SelectedIndex = 0 Then
                sql = "UPDATE recarga_carrier
                        SET monto='" + CBMonto.Text.ToString + "'
                        WHERE empresa_id='" + idEmpresa.ToString + "'
                        AND carrier_id='" + idCarrier.ToString + "'"
                Insertar(sql, "Monto de recarga actualizado correctamente", 1, "Monto Recargas")
                Limpiar()
                generarReporte()
            Else
                'Inactivos
                sql = "INSERT INTO recarga_carrier(monto,empresa_id,carrier_id)
                        VALUES('" + CBMonto.Text.ToString + "','" + idEmpresa.ToString + "','" + idCarrier.ToString + "')"
                Insertar(sql, "Monto de recarga guardado correctamente", 1, "Monto Recargas")
                Limpiar()
                generarReporte()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Monto Recargas")
            CBMonto.Select()
        End If

    End Sub


    Private Sub TabMonto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabMonto.SelectedIndexChanged
        Limpiar()
        generarReporte()
    End Sub

    Private Sub DGActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAsignado.CellContentClick
        Dim i As Integer = i = DGAsignado.CurrentRow.Index
        i = Me.DGAsignado.CurrentCell.RowIndex
        TbxCarrier.Text = DGAsignado.Item(0, i).Value.ToString
        TbxCarrier.Enabled = False
        'TbxMonto.Text = DGAsignado.Item(1, i).Value.ToString
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + TbxCarrier.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
        sql = "SELECT monto FROM monto_carrier
                WHERE carrier_id='" + idCarrier.ToString + "'
                ORDER BY monto ASC"
        mostrarMontoCarrier(sql, CBMonto)
        CBMonto.Text = DGAsignado.Item(1, i).Value.ToString
    End Sub

    Private Sub DGSinAsignar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSinAsignar.CellContentClick
        Dim i As Integer = i = DGSinAsignar.CurrentRow.Index
        i = Me.DGSinAsignar.CurrentCell.RowIndex
        TbxCarrier.Text = DGSinAsignar.Item(0, i).Value.ToString
        TbxCarrier.Enabled = False
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + TbxCarrier.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
        sql = "SELECT monto FROM monto_carrier
                WHERE carrier_id='" + idCarrier.ToString + "'
                ORDER BY monto ASC"
        mostrarMontoCarrier(sql, CBMonto)
        CBMonto.Select()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub TbxCarrier_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxCarrier.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Guardar()
        End Select
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        Limpiar()
        generarReporte()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub
End Class