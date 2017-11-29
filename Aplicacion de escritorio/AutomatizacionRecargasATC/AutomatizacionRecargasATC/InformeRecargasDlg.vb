Public Class InformeRecargasDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idCliente As Integer
    Dim idPuntoVenta As Integer
    Dim idCarrier As Integer
    Private Sub InformeRecargasDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cambiar formato de fecha en formato de mysql
        DTInicio.Format = DateTimePickerFormat.Custom
        DTInicio.CustomFormat = "yyyy-MM-dd"
        DTFin.Format = DateTimePickerFormat.Custom
        DTFin.CustomFormat = "yyyy-MM-dd"
        'Limpiar()
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
        ObtenerIdCliente()
        sql = "SELECT nombre 
                FROM carrier
                WHERE activo=true
                ORDER BY nombre ASC"
        mostrarEmpresa(sql, CBCarrier)
        ObtenerIdCarier()
        GenerarReporte()
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
    Private Sub ObtenerIdCarier()
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + CBCarrier.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
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
    Private Sub GenerarReporte()
        ObtenerIdEmpresa()
        ObtenerIdPuntoVenta()
        ObtenerIdCarier()
        ObtenerIdCliente()
        sql = "SELECT DISTINCT CONCAT(pv.tipo,'-',cc.numero) AS CLIENTE,
                act.fecha AS FECHA,act.folio AS FOLIO,
                carr.nombre AS COMPAÑIA,act.cantidad AS MONTO,num.digitos AS NUMERO
                FROM empresa emp,punto_venta pv,cliente cli,clave_cliente cc,numero num,activado act,carrier carr
                WHERE emp.id='" + idEmpresa.ToString + "'
                AND pv.empresa_id=emp.id
                AND pv.id='" + idPuntoVenta.ToString + "'
                AND cc.cliente_id=cli.id
                AND cli.id='" + idCliente.ToString + "'
                AND cc.puntoventa_id=pv.id
                AND cli.empresa_id=emp.id
                AND num.cliente_id=cli.id
                AND act.numero_id=num.id
                AND num.carrier_id=carr.id
                AND carr.id='" + idCarrier.ToString + "'
                AND DATE(act.fecha) >= '" + DTInicio.Text + "' and DATE(act.fecha)<='" + DTFin.Text + "'
                ORDER BY act.fecha ASC"
        mostrarDatosDataGridView(sql, DGConsulta)
        darFormatoReporte(3, 4)
    End Sub
    'Método que da formato al DataGridView del Reporte
    Public Sub darFormatoReporte(columnaEvaluar As Integer, columnaContar As Integer)
        'Validación que la consulta haya generanado valores
        Try
            Dim evaluar As String = DGConsulta.Item(columnaEvaluar, 0).Value
            If evaluar.Length() > 0 Then
                Dim contador As Integer = 0
                Dim monto As Integer = 0
                Dim contadorGeneral As Integer = 0
                Dim montoGeneral As Integer = 0
                Dim style As New DataGridViewCellStyle
                Dim j As Integer = 0
                style.Font = New Font(DGReporte.Font, FontStyle.Bold)
                'Recorre todas las filas de la consulta
                For i As Integer = 0 To DGConsulta.RowCount - 1
                    'Verifica que la recarga sea de la misma compañía
                    If evaluar = DGConsulta.Item(columnaEvaluar, i).Value Then
                        contador = contador + 1
                        monto = monto + DGConsulta.Item(columnaContar, i).Value
                        DGReporte.Rows.Add(DGConsulta.Item(0, i).Value, DGConsulta.Item(1, i).Value, DGConsulta.Item(2, i).Value, DGConsulta.Item(3, i).Value, DGConsulta.Item(4, i).Value, DGConsulta.Item(5, i).Value)
                        j = j + 1
                    Else
                        'Agrega el total de recargas de una compañia y el monto total
                        DGReporte.Rows.Add("", "", "Cantidad", contador, "Monto Total", monto)
                        DGReporte.Rows(j).DefaultCellStyle = style
                        j = j + 1
                    End If
                    'j = j + 1
                Next
            End If
        Catch ex As Exception
            'MsgBox("No se encontrarón recargas", MsgBoxStyle.Critical, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub

    Private Sub CBEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpresa.SelectedIndexChanged
        GenerarReporte()
    End Sub

    Private Sub CBPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPuntoVenta.SelectedIndexChanged
        GenerarReporte()
    End Sub

    Private Sub CBCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCarrier.SelectedIndexChanged
        GenerarReporte()
    End Sub

    Private Sub CBCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCliente.SelectedIndexChanged
        GenerarReporte()
    End Sub

    Private Sub DTInicio_ValueChanged(sender As Object, e As EventArgs) Handles DTInicio.ValueChanged
        GenerarReporte()
    End Sub

    Private Sub DTFin_ValueChanged(sender As Object, e As EventArgs) Handles DTFin.ValueChanged
        GenerarReporte()
    End Sub

    Private Sub PDReporte_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PDReporte.PrintPage
        'Definimos la fuente que vamos a usar para imprimir
        ' en este caso Arial de 10
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim printFontNegritas As System.Drawing.Font = New Font("Arial", 10, FontStyle.Bold)
        Dim printFontNegritasTitulo As System.Drawing.Font = New Font("Arial", 12, FontStyle.Bold)
        Dim printFontNegritasEmpresa As System.Drawing.Font = New Font("Arial", 14, FontStyle.Bold)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim row As System.Windows.Forms.DataGridViewRow
        Dim i As Integer = 0
        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        'Empresa del reporte
        texto = ""
        texto += CBEmpresa.Text
        yPos = topMargin + (count * printFontNegritasEmpresa.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFontNegritasEmpresa, System.Drawing.Brushes.Black, 10, yPos)
        'Título del reporte
        count += 4
        texto = "Informe de Recargas de: " + DTInicio.Text + " a " + DTFin.Text
        yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
        count += 2
        texto = "Cliente: " + CBCliente.Text + " Compañía: " + CBCarrier.Text
        yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
        'Encabezados
        count += 4
        texto = ""
        ' Imprimimos las cabeceras
        texto += "CLIENTE"
        texto += vbTab
        texto += "FECHA"
        texto += vbTab
        texto += vbTab
        texto += vbTab
        texto += "FOLIO"
        texto += vbTab
        texto += vbTab
        texto += vbTab
        texto += "COMPAÑÍA"
        texto += vbTab
        texto += vbTab
        texto += "MONTO"
        texto += vbTab
        texto += vbTab
        texto += "NÚMERO"
        yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < DGReporte.Rows.Count
            row = DGReporte.Rows(i)
            texto = ""
            Dim vacio As Integer = 0
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then
                    texto += celda.Value.ToString()
                    If celda.Value.ToString() = "Cantidad" Then
                        vacio = 2
                        texto += vbTab
                        texto += vbTab
                        texto += vbTab
                    End If
                    If celda.Value.ToString().Length() < 3 Then
                        texto += vbTab
                        texto += vbTab
                    Else
                        If celda.Value.ToString() = "TELCEL" Then
                            texto += vbTab
                        Else
                            texto += vbTab
                        End If

                    End If
                    'texto += vbTab
                End If
            Next
            If vacio = 0 Then
                ' Calculamos la posición en la que se escribe la línea
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

                ' Escribimos la línea con el objeto Graphics
                e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            Else
                ' Calculamos la posición en la que se escribe la línea
                yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))

                ' Escribimos la línea con el objeto Graphics
                e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
            End If

            ' Incrementamos los contadores
            count += 1
            i += 1
            vacio = 0
        End While
        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If i < DGReporte.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            i = 0
        End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Me.PPDReporte.Document = PDReporte
        Me.PPDReporte.ShowDialog()
    End Sub

    Private Sub PPDReporte_Load(sender As Object, e As EventArgs) Handles PPDReporte.Load

    End Sub
End Class