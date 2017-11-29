<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComportamientoRecargasDlg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComportamientoRecargasDlg))
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.DGReportePorcentajeActivos = New System.Windows.Forms.DataGridView()
        Me.Carrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inactivos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeActivos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTipoReporte = New System.Windows.Forms.ComboBox()
        Me.LbPuntoVenta = New System.Windows.Forms.Label()
        Me.CBPuntoVenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbFin = New System.Windows.Forms.Label()
        Me.DTFin = New System.Windows.Forms.DateTimePicker()
        Me.DTInicio = New System.Windows.Forms.DateTimePicker()
        Me.LbInicio = New System.Windows.Forms.Label()
        Me.CBCarrier = New System.Windows.Forms.ComboBox()
        Me.LbCarrier = New System.Windows.Forms.Label()
        Me.DGReporteTotalRecargas = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGReporteCaducidad = New System.Windows.Forms.DataGridView()
        Me.ClaveCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caducidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.PPDReporte = New System.Windows.Forms.PrintPreviewDialog()
        Me.PDReporte = New System.Drawing.Printing.PrintDocument()
        CType(Me.DGReportePorcentajeActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGReporteTotalRecargas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGReporteCaducidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEmpresa
        '
        Me.CBEmpresa.FormattingEnabled = True
        Me.CBEmpresa.Location = New System.Drawing.Point(350, 6)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.CBEmpresa.TabIndex = 1
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Location = New System.Drawing.Point(296, 9)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.LbEmpresa.TabIndex = 6
        Me.LbEmpresa.Text = "Empresa"
        '
        'DGReportePorcentajeActivos
        '
        Me.DGReportePorcentajeActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGReportePorcentajeActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGReportePorcentajeActivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReportePorcentajeActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReportePorcentajeActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Carrier, Me.Activos, Me.Inactivos, Me.PorcentajeActivos})
        Me.DGReportePorcentajeActivos.Location = New System.Drawing.Point(113, 128)
        Me.DGReportePorcentajeActivos.Name = "DGReportePorcentajeActivos"
        Me.DGReportePorcentajeActivos.Size = New System.Drawing.Size(451, 272)
        Me.DGReportePorcentajeActivos.TabIndex = 7
        '
        'Carrier
        '
        Me.Carrier.HeaderText = "Compañía"
        Me.Carrier.Name = "Carrier"
        Me.Carrier.Width = 81
        '
        'Activos
        '
        Me.Activos.HeaderText = "Activos"
        Me.Activos.Name = "Activos"
        Me.Activos.Width = 67
        '
        'Inactivos
        '
        Me.Inactivos.HeaderText = "Inactivos"
        Me.Inactivos.Name = "Inactivos"
        Me.Inactivos.Width = 75
        '
        'PorcentajeActivos
        '
        Me.PorcentajeActivos.HeaderText = "% Activos"
        Me.PorcentajeActivos.Name = "PorcentajeActivos"
        Me.PorcentajeActivos.Width = 78
        '
        'DGConsulta
        '
        Me.DGConsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Location = New System.Drawing.Point(113, 128)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.Size = New System.Drawing.Size(451, 272)
        Me.DGConsulta.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo de Reporte"
        '
        'CBTipoReporte
        '
        Me.CBTipoReporte.FormattingEnabled = True
        Me.CBTipoReporte.Items.AddRange(New Object() {"Porcentaje de activados", "Total recargas en un periodo", "Mejores clientes", "Porcentaje de caducados"})
        Me.CBTipoReporte.Location = New System.Drawing.Point(79, 6)
        Me.CBTipoReporte.Name = "CBTipoReporte"
        Me.CBTipoReporte.Size = New System.Drawing.Size(219, 21)
        Me.CBTipoReporte.TabIndex = 0
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.Location = New System.Drawing.Point(477, 9)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(81, 13)
        Me.LbPuntoVenta.TabIndex = 11
        Me.LbPuntoVenta.Text = "Punto de Venta"
        '
        'CBPuntoVenta
        '
        Me.CBPuntoVenta.FormattingEnabled = True
        Me.CBPuntoVenta.Location = New System.Drawing.Point(555, 6)
        Me.CBPuntoVenta.Name = "CBPuntoVenta"
        Me.CBPuntoVenta.Size = New System.Drawing.Size(121, 21)
        Me.CBPuntoVenta.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbFin)
        Me.GroupBox1.Controls.Add(Me.DTFin)
        Me.GroupBox1.Controls.Add(Me.DTInicio)
        Me.GroupBox1.Controls.Add(Me.LbInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'LbFin
        '
        Me.LbFin.AutoSize = True
        Me.LbFin.Location = New System.Drawing.Point(149, 28)
        Me.LbFin.Name = "LbFin"
        Me.LbFin.Size = New System.Drawing.Size(14, 13)
        Me.LbFin.TabIndex = 1
        Me.LbFin.Text = "A"
        '
        'DTFin
        '
        Me.DTFin.Location = New System.Drawing.Point(112, 44)
        Me.DTFin.Name = "DTFin"
        Me.DTFin.Size = New System.Drawing.Size(91, 20)
        Me.DTFin.TabIndex = 1
        '
        'DTInicio
        '
        Me.DTInicio.Location = New System.Drawing.Point(5, 44)
        Me.DTInicio.Name = "DTInicio"
        Me.DTInicio.Size = New System.Drawing.Size(91, 20)
        Me.DTInicio.TabIndex = 0
        '
        'LbInicio
        '
        Me.LbInicio.AutoSize = True
        Me.LbInicio.Location = New System.Drawing.Point(37, 28)
        Me.LbInicio.Name = "LbInicio"
        Me.LbInicio.Size = New System.Drawing.Size(21, 13)
        Me.LbInicio.TabIndex = 0
        Me.LbInicio.Text = "De"
        '
        'CBCarrier
        '
        Me.CBCarrier.FormattingEnabled = True
        Me.CBCarrier.Location = New System.Drawing.Point(74, 45)
        Me.CBCarrier.Name = "CBCarrier"
        Me.CBCarrier.Size = New System.Drawing.Size(151, 21)
        Me.CBCarrier.TabIndex = 3
        '
        'LbCarrier
        '
        Me.LbCarrier.AutoSize = True
        Me.LbCarrier.Location = New System.Drawing.Point(12, 51)
        Me.LbCarrier.Name = "LbCarrier"
        Me.LbCarrier.Size = New System.Drawing.Size(56, 13)
        Me.LbCarrier.TabIndex = 45
        Me.LbCarrier.Text = "Compañía"
        '
        'DGReporteTotalRecargas
        '
        Me.DGReporteTotalRecargas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReporteTotalRecargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporteTotalRecargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.Cantidad, Me.Monto})
        Me.DGReporteTotalRecargas.Location = New System.Drawing.Point(113, 128)
        Me.DGReporteTotalRecargas.Name = "DGReporteTotalRecargas"
        Me.DGReporteTotalRecargas.Size = New System.Drawing.Size(451, 272)
        Me.DGReporteTotalRecargas.TabIndex = 46
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto Total"
        Me.Monto.Name = "Monto"
        '
        'DGReporteCaducidad
        '
        Me.DGReporteCaducidad.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReporteCaducidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporteCaducidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaveCliente, Me.CantidadCliente, Me.Caducidad, Me.Porcentaje})
        Me.DGReporteCaducidad.Location = New System.Drawing.Point(113, 128)
        Me.DGReporteCaducidad.Name = "DGReporteCaducidad"
        Me.DGReporteCaducidad.Size = New System.Drawing.Size(451, 272)
        Me.DGReporteCaducidad.TabIndex = 47
        '
        'ClaveCliente
        '
        Me.ClaveCliente.HeaderText = "Cliente"
        Me.ClaveCliente.Name = "ClaveCliente"
        '
        'CantidadCliente
        '
        Me.CantidadCliente.HeaderText = "Cantidad"
        Me.CantidadCliente.Name = "CantidadCliente"
        '
        'Caducidad
        '
        Me.Caducidad.HeaderText = "Caducados"
        Me.Caducidad.Name = "Caducidad"
        '
        'Porcentaje
        '
        Me.Porcentaje.HeaderText = "% Caducados"
        Me.Porcentaje.Name = "Porcentaje"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.imprimir
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(588, 38)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(88, 28)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'PPDReporte
        '
        Me.PPDReporte.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPDReporte.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPDReporte.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPDReporte.Enabled = True
        Me.PPDReporte.Icon = CType(resources.GetObject("PPDReporte.Icon"), System.Drawing.Icon)
        Me.PPDReporte.Name = "PPDReporte"
        Me.PPDReporte.Visible = False
        '
        'PDReporte
        '
        '
        'ComportamientoRecargasDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 406)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DGReporteCaducidad)
        Me.Controls.Add(Me.DGReporteTotalRecargas)
        Me.Controls.Add(Me.CBCarrier)
        Me.Controls.Add(Me.LbCarrier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBPuntoVenta)
        Me.Controls.Add(Me.LbPuntoVenta)
        Me.Controls.Add(Me.CBTipoReporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGConsulta)
        Me.Controls.Add(Me.DGReportePorcentajeActivos)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ComportamientoRecargasDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comportamiento de Recargas"
        CType(Me.DGReportePorcentajeActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGReporteTotalRecargas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGReporteCaducidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents DGReportePorcentajeActivos As DataGridView
    Friend WithEvents Carrier As DataGridViewTextBoxColumn
    Friend WithEvents Activos As DataGridViewTextBoxColumn
    Friend WithEvents Inactivos As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeActivos As DataGridViewTextBoxColumn
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CBTipoReporte As ComboBox
    Friend WithEvents LbPuntoVenta As Label
    Friend WithEvents CBPuntoVenta As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbFin As Label
    Friend WithEvents DTFin As DateTimePicker
    Friend WithEvents DTInicio As DateTimePicker
    Friend WithEvents LbInicio As Label
    Friend WithEvents CBCarrier As ComboBox
    Friend WithEvents LbCarrier As Label
    Friend WithEvents DGReporteTotalRecargas As DataGridView
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents DGReporteCaducidad As DataGridView
    Friend WithEvents ClaveCliente As DataGridViewTextBoxColumn
    Friend WithEvents CantidadCliente As DataGridViewTextBoxColumn
    Friend WithEvents Caducidad As DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents PPDReporte As PrintPreviewDialog
    Friend WithEvents PDReporte As Printing.PrintDocument
End Class
