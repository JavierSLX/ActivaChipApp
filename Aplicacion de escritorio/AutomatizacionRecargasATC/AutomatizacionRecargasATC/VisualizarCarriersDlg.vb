Public Class VisualizarCarriersDlg
    Dim sql As String
    Dim idCarrier As Integer = 0
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer = 0
    Dim mensaje As String
    Private Sub VisualizarCarriersDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarFormulario()
        MostrarCarrier()
    End Sub
    Private Sub MostrarCarrier()
        sql = "SELECT nombre AS NOMBRE 
                FROM carrier WHERE activo=true"
        mostrarDatosDataGridView(sql, DGCarrier)
    End Sub
    Private Sub GuardarCarrier()
        sql = "INSERT INTO carrier(nombre,activo)
                VALUES('" + TbxNombre.Text + "',true)"
        mensaje = "Compañía guardada correctamente"
    End Sub
    Private Sub EditarCarrier()
        sql = "UPDATE carrier 
                        SET nombre='" + TbxNombre.Text.ToString + "'
        WHERE id='" + idCarrier.ToString + "'"
        mensaje = "Compañía actualizada correctamente"
    End Sub
    Private Sub LimpiarFormulario()
        TbxNombre.Text = ""
        idCarrier = 0
        opcion = 1
        existeRegistro = 0
        TbxNombre.Select()
    End Sub
    Private Sub Generar()
        'Validación que el nombre del socio contenga información
        If TbxNombre.Text.Length() > 0 Then
            'Validación que no exista registros repetidos
            sql = "SELECT id
                            FROM carrier
                            WHERE nombre='" + TbxNombre.Text.ToString + "'"
            existeRegistro = ComprobrarExistencia(sql)
            If (existeRegistro > 0) Then
                MsgBox("Ya existe una compañía con estos datos", MsgBoxStyle.Exclamation, Title:="Compañía Telefónica")
                LimpiarFormulario()
            Else
                If opcion = 1 Then
                    GuardarCarrier()
                Else
                    EditarCarrier()
                End If
                Insertar(sql, mensaje, 1, "Compañía Telefónica")
                LimpiarFormulario()
                MostrarCarrier()
            End If
        Else
            MsgBox("No se permiten campos sin información", MsgBoxStyle.Exclamation, Title:="Compañía Telefónica")
            TbxNombre.Select()
        End If
    End Sub

    Private Sub DGCarrier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCarrier.CellContentClick
        TbxNombre.Text = DGCarrier.CurrentRow.Cells(0).Value
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + TbxNombre.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
        opcion = 2
        TbxNombre.Select()
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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarFormulario()
    End Sub
End Class