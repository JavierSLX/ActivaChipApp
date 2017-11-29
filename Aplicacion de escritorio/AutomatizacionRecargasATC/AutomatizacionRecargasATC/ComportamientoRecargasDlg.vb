Public Class ComportamientoRecargasDlg
    Dim sql As String
    Dim idEmpresa As Integer
    Dim idPuntoVenta As Integer
    Dim idCarrier As Integer
    Dim opcion As Integer = 1
    Dim existeRegistro As Integer
    Private Sub ComportamientoRecargasDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cambiar formato de fecha en formato de mysql
        DTInicio.Format = DateTimePickerFormat.Custom
        DTInicio.CustomFormat = "yyyy-MM-dd"
        DTFin.Format = DateTimePickerFormat.Custom
        DTFin.CustomFormat = "yyyy-MM-dd"
        CBTipoReporte.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CBTipoReporte.AutoCompleteSource = AutoCompleteSource.ListItems
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
        sql = "SELECT nombre 
                FROM carrier
                WHERE activo=true
                ORDER BY nombre ASC"
        mostrarEmpresa(sql, CBCarrier)
        ObtenerIdCarier()
        GenerarReporte()
        CBTipoReporte.Text = "Porcentaje de activados"
    End Sub
    Private Sub ObtenerIdCarier()
        sql = "SELECT id
                FROM carrier
                WHERE nombre='" + CBCarrier.Text.ToString + "'"
        idCarrier = ComprobrarExistencia(sql)
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
    Private Sub GenerarReporte()
        DGReportePorcentajeActivos.Rows.Clear()
        DGReporteTotalRecargas.Rows.Clear()
        DGReporteCaducidad.Rows.Clear()
        ObtenerIdEmpresa()
        ObtenerIdCarier()
        ObtenerIdPuntoVenta()
        If CBTipoReporte.Text = "Porcentaje de activados" Then
            sql = "SELECT carr.nombre AS COMPAÑIA,
                COUNT(*)AS TOTAL,(SELECT count(*)
                FROM carrier carri,cliente clie,numero nume,activado acti
                WHERE nume.cliente_id=clie.id
                AND nume.carrier_id=carri.id
                AND clie.empresa_id='" + idEmpresa.ToString + "'
                AND acti.numero_id=nume.id
                AND carri.id=carr.id) AS ACTIVOS
                FROM carrier carr,cliente cli,numero num
                WHERE num.cliente_id=cli.id
                AND num.carrier_id=carr.id
                AND cli.empresa_id='" + idEmpresa.ToString + "'
                group by carr.id
                ORDER BY carr.nombre ASC"
            mostrarDatosDataGridView(sql, DGConsulta)
            darFormatoReporte()
        Else
            If CBTipoReporte.Text = "Total recargas en un periodo" Then
                sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) AS CLIENTE,
                        (SELECT COUNT(*)
                        FROM carrier carri,cliente clie,numero nume,activado acti,punto_venta pv
                        WHERE nume.cliente_id=clie.id
                        AND nume.carrier_id=carri.id
                        AND clie.empresa_id='" + idEmpresa.ToString + "'
                        AND carri.id='" + idCarrier.ToString + "'
                        AND pv.id='" + idPuntoVenta.ToString + "'
                        AND acti.numero_id=nume.id
                        AND DATE(acti.fecha) >= '" + DTInicio.Text + "' and DATE(acti.fecha)<='" + DTFin.Text + "'
                        AND clie.id=cli.id) AS RECARGAS,
                        (SELECT SUM(IFNULL(acti.cantidad,0))
                        FROM carrier carri,cliente clie,numero nume,activado acti,punto_venta pv
                        WHERE nume.cliente_id=clie.id
                        AND nume.carrier_id=carri.id
                        AND clie.empresa_id='" + idEmpresa.ToString + "'
                        AND carri.id='" + idCarrier.ToString + "'
                        AND pv.id='" + idPuntoVenta.ToString + "'
                        AND acti.numero_id=nume.id
                        AND DATE(acti.fecha) >= '" + DTInicio.Text + "' and DATE(acti.fecha)<='" + DTFin.Text + "'
                        AND clie.id=cli.id) AS MONTO 
                        FROM carrier carr,cliente cli,numero num,punto_venta pv,clave_cliente cc,activado act
                        WHERE num.cliente_id=cli.id
                        AND num.carrier_id=carr.id
                        AND cli.empresa_id='" + idEmpresa.ToString + "'
                        AND carr.id='" + idCarrier.ToString + "'
                        AND act.numero_id=num.id
                        AND cc.cliente_id=cli.id
                        AND cc.puntoventa_id=pv.id
                        AND pv.id='" + idPuntoVenta.ToString + "'
                        GROUP BY cli.id"
                mostrarDatosDataGridView(sql, DGConsulta)
                darFormatoReporte()
            Else
                If CBTipoReporte.Text = "Mejores clientes" Then
                    sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) as CLIENTE,
                            (SELECT COUNT(*)
                            FROM carrier carri,cliente clie,numero nume,activado acti
                            WHERE nume.cliente_id=clie.id
                            AND nume.carrier_id=carri.id
                            AND clie.empresa_id='" + idEmpresa.ToString + "'
                            AND carri.id='" + idCarrier.ToString + "'
                            AND acti.numero_id=nume.id
                            AND DATE(acti.fecha) >= '" + DTInicio.Text + "' and DATE(acti.fecha)<='" + DTFin.Text + "'
                            AND clie.id=cli.id) AS TOTAL
                            FROM carrier carr,cliente cli,numero num,punto_venta pv,clave_cliente cc
                            WHERE num.cliente_id=cli.id
                            AND num.carrier_id=carr.id
                            AND cli.empresa_id='" + idEmpresa.ToString + "'
                            AND carr.id='" + idCarrier.ToString + "'
                            AND cc.cliente_id=cli.id
                            AND cc.puntoventa_id=pv.id
                            AND pv.id='" + idPuntoVenta.ToString + "'
                            group by cli.id
                            ORDER BY TOTAL DESC LIMIT 10"
                    mostrarDatosDataGridView(sql, DGConsulta)
                Else
                    If CBTipoReporte.Text = "Porcentaje de caducados" Then
                        sql = "SELECT carr.nombre AS COMPAÑIÁ,
                                (SELECT COUNT(*)
                                FROM numero nume,carrier carri,cliente clie,clave_cliente cc,punto_venta pv
                                WHERE nume.carrier_id=carr.id
                                AND nume.cliente_id=clie.id
                                AND clie.empresa_id='" + idEmpresa.ToString + "'
                                AND cc.cliente_id=clie.id
                                AND cc.puntoventa_id=pv.id
                                AND pv.id='" + idPuntoVenta.ToString + "'
                                AND carri.id=carr.id)AS CANTIDAD,
                                (SELECT COUNT(*)
                                FROM numero nume,carrier carri,cliente clie,clave_cliente cc,punto_venta pv
                                WHERE nume.id NOT IN(SELECT numero_id FROM activado)
                                AND nume.carrier_id=carri.id
                                AND nume.cliente_id=clie.id
                                AND clie.empresa_id='" + idEmpresa.ToString + "'
                                AND cc.cliente_id=clie.id
                                AND cc.puntoventa_id=pv.id
                                AND pv.id='" + idPuntoVenta.ToString + "'
                                AND nume.fecha<DATE_SUB(NOW(), INTERVAL 29 DAY)
                                AND carri.id=carr.id)AS CADUCADOS
                                FROM carrier carr
                                WHERE carr.activo=true
                                AND carr.nombre<>'TELCEL'
                                AND carr.nombre<>'SERVICIOS TELCEL'"
                        mostrarDatosDataGridView(sql, DGConsulta)
                        darFormatoReporte()
                    End If
                End If
            End If
        End If

    End Sub
    'Método que da formato al DataGridView del Reporte
    Public Sub darFormatoReporte()
        If CBTipoReporte.Text = "Porcentaje de activados" Then
            'Validación que la consulta haya generanado valores
            Try
                Dim evaluar As String = DGConsulta.Item(0, 0).Value
                If evaluar.Length() > 0 Then
                    Dim ActivosGeneral As Integer = 0
                    Dim InactivosGeneral As Integer = 0
                    Dim TotalGeneral As Integer = 0
                    Dim style As New DataGridViewCellStyle
                    Dim j As Integer = 0
                    style.Font = New Font(DGReportePorcentajeActivos.Font, FontStyle.Bold)
                    'Recorre todas las filas de la consulta

                    For i As Integer = 0 To DGConsulta.RowCount - 2
                        Dim carrier As String = DGConsulta.Item(0, i).Value
                        Dim total As Integer = DGConsulta.Item(1, i).Value
                        Dim activos As Integer = DGConsulta.Item(2, i).Value
                        Dim inactivos As Integer = total - activos
                        Dim porcentaje As Double = Format((activos * 100) / total, "0.00")
                        DGReportePorcentajeActivos.Rows.Add(carrier, activos, inactivos, Format((activos * 100) / total, "0.00"))
                        TotalGeneral += total
                        ActivosGeneral += activos
                        InactivosGeneral += inactivos
                        j = j + 1
                    Next
                    DGReportePorcentajeActivos.Rows.Add("Total", ActivosGeneral, InactivosGeneral, Format((ActivosGeneral * 100) / TotalGeneral, "0.00"))
                    DGReportePorcentajeActivos.Rows(j).DefaultCellStyle = style
                    j = j + 1
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Else
            'Reporte de total de recargas en un periodo
            If CBTipoReporte.Text = "Total recargas en un periodo" Then
                'Validación que la consulta haya generanado valores
                Try
                    Dim evaluar As String = DGConsulta.Item(0, 0).Value
                    If evaluar.Length() > 0 Then
                        Dim recargasTotal As Integer = 0
                        Dim montoTotal As Integer = 0
                        Dim style As New DataGridViewCellStyle
                        Dim j As Integer = 0
                        style.Font = New Font(DGReporteTotalRecargas.Font, FontStyle.Bold)
                        'Recorre todas las filas de la consulta

                        For i As Integer = 0 To DGConsulta.RowCount - 2
                            Dim clave As String = DGConsulta.Item(0, i).Value
                            Dim cantidad As Integer = DGConsulta.Item(1, i).Value
                            Dim monto As Integer = DGConsulta.Item(2, i).Value
                            DGReporteTotalRecargas.Rows.Add(clave, cantidad, monto)
                            recargasTotal += cantidad
                            montoTotal += monto
                            j = j + 1
                        Next
                        DGReporteTotalRecargas.Rows.Add("Total", recargasTotal, montoTotal)
                        DGReporteTotalRecargas.Rows(j).DefaultCellStyle = style
                        j = j + 1
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            Else
                'Caducidad
                If CBTipoReporte.Text = "Porcentaje de caducados" Then
                    Try
                        Dim evaluar As String = DGConsulta.Item(0, 0).Value
                        If evaluar.Length() > 0 Then
                            Dim chipsTotal As Integer = 0
                            Dim caducadosTotal As Integer = 0
                            Dim style As New DataGridViewCellStyle
                            Dim j As Integer = 0
                            style.Font = New Font(DGReporteCaducidad.Font, FontStyle.Bold)
                            'Recorre todas las filas de la consulta

                            For i As Integer = 0 To DGConsulta.RowCount - 2
                                Dim clave As String = DGConsulta.Item(0, i).Value
                                Dim chips As Integer = DGConsulta.Item(1, i).Value
                                Dim caducados As Integer = DGConsulta.Item(2, i).Value
                                If chips > 0 Then
                                    DGReporteCaducidad.Rows.Add(clave, chips, caducados, Format((caducados * 100) / chips, "0.00"))
                                    chipsTotal += chips
                                    caducadosTotal += caducados
                                    j = j + 1
                                End If

                            Next
                            'Format((activos * 100) / total, "0.00")
                            DGReporteCaducidad.Rows.Add("Total", chipsTotal, caducadosTotal, Format((caducadosTotal * 100) / chipsTotal, "0.00"))
                            DGReporteCaducidad.Rows(j).DefaultCellStyle = style
                            j = j + 1
                        End If
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                End If
            End If
            End If
    End Sub

    Private Sub CBTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReporte.SelectedIndexChanged
        If CBTipoReporte.Text = "Porcentaje de activados" Then
            LbPuntoVenta.Visible = False
            CBPuntoVenta.Visible = False
            GroupBox1.Visible = False
            LbCarrier.Visible = False
            CBCarrier.Visible = False
            DGReportePorcentajeActivos.Visible = True
            DGReporteTotalRecargas.Visible = False
            DGConsulta.Visible = False
            DGReporteCaducidad.Visible = False
        Else
            If CBTipoReporte.Text = "Total recargas en un periodo" Then
                LbPuntoVenta.Visible = True
                CBPuntoVenta.Visible = True
                GroupBox1.Visible = True
                LbCarrier.Visible = True
                CBCarrier.Visible = True
                DGReportePorcentajeActivos.Visible = False
                DGReporteTotalRecargas.Visible = True
                DGConsulta.Visible = False
                DGReporteCaducidad.Visible = False
            Else
                If CBTipoReporte.Text = "Mejores clientes" Then
                    LbPuntoVenta.Visible = True
                    CBPuntoVenta.Visible = True
                    GroupBox1.Visible = True
                    LbCarrier.Visible = True
                    CBCarrier.Visible = True
                    DGReportePorcentajeActivos.Visible = False
                    DGReporteTotalRecargas.Visible = False
                    DGConsulta.Visible = True
                    DGReporteCaducidad.Visible = False
                Else
                    If CBTipoReporte.Text = "Porcentaje de caducados" Then
                        LbPuntoVenta.Visible = True
                        CBPuntoVenta.Visible = True
                        GroupBox1.Visible = False
                        LbCarrier.Visible = False
                        CBCarrier.Visible = False
                        DGReportePorcentajeActivos.Visible = False
                        DGReporteTotalRecargas.Visible = False
                        DGConsulta.Visible = False
                        DGReporteCaducidad.Visible = True
                    End If
                End If
                End If
        End If
        GenerarReporte()
    End Sub

    Private Sub DTInicio_ValueChanged(sender As Object, e As EventArgs) Handles DTInicio.ValueChanged
        GenerarReporte()
    End Sub

    Private Sub DTFin_ValueChanged(sender As Object, e As EventArgs) Handles DTFin.ValueChanged
        GenerarReporte()
    End Sub

    Private Sub CBPuntoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPuntoVenta.SelectedIndexChanged
        GenerarReporte()
    End Sub

    Private Sub CBCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCarrier.SelectedIndexChanged
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
        If CBTipoReporte.Text = "Porcentaje de activados" Then
            'Título del reporte
            count += 4
            texto = "Porcentaje de chips activados con recarga al " + DateTime.Now()
            yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
            e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
            'Encabezados
            count += 4
            texto = ""
            ' Imprimimos las cabeceras
            texto += "COMPAÑÍA"
            texto += vbTab
            texto += vbTab
            texto += "ACTIVOS"
            texto += vbTab
            texto += vbTab
            texto += "INACTIVOS"
            texto += vbTab
            texto += vbTab
            texto += "% ACTIVOS"
            yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))
            e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
            ' Dejamos una línea de separación
            count += 2
            While count < linesPerPage AndAlso i < DGReportePorcentajeActivos.Rows.Count
                row = DGReportePorcentajeActivos.Rows(i)
                texto = ""
                Dim vacio As Integer = 0
                For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                    'Comprobamos que la celda tenga algún valor, en caso de 
                    'permitir añadir filas esto es muy importante
                    If celda.Value IsNot Nothing Then
                        texto += celda.Value.ToString()
                        If celda.Value.ToString() = "Total" Then
                            vacio = 2
                        End If
                        If celda.Value.ToString().Length() <= 8 Then
                            texto += vbTab
                            texto += vbTab
                            If celda.Value.ToString() = "TELCEL" Then
                                texto += vbTab
                            Else
                                If celda.Value.ToString().Length() <= 5 Then
                                    texto += vbTab
                                End If
                            End If
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
            If i < DGReportePorcentajeActivos.Rows.Count Then
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
        Else
            'Reporte total de recargas en un periodo
            If CBTipoReporte.Text = "Total recargas en un periodo" Then
                'Título del reporte
                count += 4
                texto = "Total de recargas de " + DTInicio.Text + " a " + DTFin.Text
                yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                count += 2
                texto = "Punto de venta: " + CBPuntoVenta.Text + " Compañía: " + CBCarrier.Text
                yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                'Encabezados
                count += 4
                texto = ""
                ' Imprimimos las cabeceras
                texto += "CLIENTE"
                texto += vbTab
                texto += vbTab
                texto += "CANTIDAD"
                texto += vbTab
                texto += vbTab
                texto += "MONTO"
                yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))
                e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
                ' Dejamos una línea de separación
                count += 2
                While count < linesPerPage AndAlso i < DGReporteTotalRecargas.Rows.Count
                    row = DGReporteTotalRecargas.Rows(i)
                    texto = ""
                    Dim vacio As Integer = 0
                    For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                        'Comprobamos que la celda tenga algún valor, en caso de 
                        'permitir añadir filas esto es muy importante
                        If celda.Value IsNot Nothing Then
                            texto += celda.Value.ToString()
                            If celda.Value.ToString() = "Total" Then
                                vacio = 2
                            End If
                            If celda.Value.ToString().Length() <= 8 Then
                                texto += vbTab
                                texto += vbTab
                                If celda.Value.ToString() = "TELCEL" Then
                                    texto += vbTab
                                Else
                                    If celda.Value.ToString().Length() <= 5 Then
                                        texto += vbTab
                                    End If
                                End If
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
                If i < DGReporteTotalRecargas.Rows.Count Then
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
            Else
                'Reporte Mejores Clientes
                If CBTipoReporte.Text = "Mejores clientes" Then
                    'Título del reporte
                    count += 4
                    texto = "Clientes con más recargas de " + DTInicio.Text + " a " + DTFin.Text
                    yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                    e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                    count += 2
                    texto = "Punto de venta: " + CBPuntoVenta.Text + " Compañía: " + CBCarrier.Text
                    yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                    e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                    'Encabezados
                    count += 4
                    texto = ""
                    ' Imprimimos las cabeceras
                    texto += "CLIENTE"
                    texto += vbTab
                    texto += vbTab
                    texto += "CANTIDAD"
                    yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))
                    e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
                    ' Dejamos una línea de separación
                    count += 2
                    While count < linesPerPage AndAlso i < DGConsulta.Rows.Count
                        row = DGConsulta.Rows(i)
                        texto = ""
                        Dim vacio As Integer = 0
                        For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                            'Comprobamos que la celda tenga algún valor, en caso de 
                            'permitir añadir filas esto es muy importante
                            If celda.Value IsNot Nothing Then
                                texto += celda.Value.ToString()
                                If celda.Value.ToString() = "Total" Then
                                    vacio = 2
                                End If
                                If celda.Value.ToString().Length() <= 8 Then
                                    texto += vbTab
                                    texto += vbTab
                                    If celda.Value.ToString() = "TELCEL" Then
                                        texto += vbTab
                                    Else
                                        If celda.Value.ToString().Length() <= 5 Then
                                            texto += vbTab
                                        End If
                                    End If
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
                    If i < DGConsulta.Rows.Count Then
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
                Else
                    'reporte
                    If CBTipoReporte.Text = "Porcentaje de caducados" Then
                        'Título del reporte
                        count += 4
                        texto = "Porcentaje de chips caducados "
                        yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                        e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                        count += 2
                        texto = "Punto de venta: " + CBPuntoVenta.Text
                        yPos = topMargin + (count * printFontNegritasTitulo.GetHeight(e.Graphics))
                        e.Graphics.DrawString(texto, printFontNegritasTitulo, System.Drawing.Brushes.Black, 10, yPos)
                        'Encabezados
                        count += 4
                        texto = ""
                        ' Imprimimos las cabeceras
                        texto += "CLIENTE"
                        texto += vbTab
                        texto += vbTab
                        texto += "CANTIDAD"
                        texto += vbTab
                        texto += vbTab
                        texto += "CADUCADOS"
                        texto += vbTab
                        texto += vbTab
                        texto += "% CADUCADOS"
                        yPos = topMargin + (count * printFontNegritas.GetHeight(e.Graphics))
                        e.Graphics.DrawString(texto, printFontNegritas, System.Drawing.Brushes.Black, 10, yPos)
                        ' Dejamos una línea de separación
                        count += 2
                        While count < linesPerPage AndAlso i < DGReporteCaducidad.Rows.Count
                            row = DGReporteCaducidad.Rows(i)
                            texto = ""
                            Dim vacio As Integer = 0
                            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                                'Comprobamos que la celda tenga algún valor, en caso de 
                                'permitir añadir filas esto es muy importante
                                If celda.Value IsNot Nothing Then
                                    texto += celda.Value.ToString()
                                    If celda.Value.ToString() = "Total" Then
                                        vacio = 2
                                    End If
                                    If celda.Value.ToString().Length() <= 8 Then
                                        texto += vbTab
                                        texto += vbTab
                                        If celda.Value.ToString() = "VIRGIN" Then
                                            texto += vbTab
                                        Else
                                            If celda.Value.ToString().Length() <= 5 Then
                                                texto += vbTab
                                            End If
                                        End If
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
                        If i < DGReporteCaducidad.Rows.Count Then
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
                    End If
                End If
            End If
            End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Me.PPDReporte.Document = PDReporte
        Me.PPDReporte.ShowDialog()
    End Sub
End Class