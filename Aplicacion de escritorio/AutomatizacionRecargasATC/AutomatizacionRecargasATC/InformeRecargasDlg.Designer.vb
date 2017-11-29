<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeRecargasDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeRecargasDlg))
        Me.CBCarrier = New System.Windows.Forms.ComboBox()
        Me.LbCarrier = New System.Windows.Forms.Label()
        Me.CBCliente = New System.Windows.Forms.ComboBox()
        Me.LbClaveCliente = New System.Windows.Forms.Label()
        Me.CBPuntoVenta = New System.Windows.Forms.ComboBox()
        Me.LbPuntoVenta = New System.Windows.Forms.Label()
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbFin = New System.Windows.Forms.Label()
        Me.DTFin = New System.Windows.Forms.DateTimePicker()
        Me.DTInicio = New System.Windows.Forms.DateTimePicker()
        Me.LbInicio = New System.Windows.Forms.Label()
        Me.DGReporte = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.PDReporte = New System.Drawing.Printing.PrintDocument()
        Me.PPDReporte = New System.Windows.Forms.PrintPreviewDialog()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBCarrier
        '
        Me.CBCarrier.FormattingEnabled = True
        Me.CBCarrier.Location = New System.Drawing.Point(438, 35)
        Me.CBCarrier.Name = "CBCarrier"
        Me.CBCarrier.Size = New System.Drawing.Size(87, 21)
        Me.CBCarrier.TabIndex = 3
        '
        'LbCarrier
        '
        Me.LbCarrier.AutoSize = True
        Me.LbCarrier.Location = New System.Drawing.Point(376, 41)
        Me.LbCarrier.Name = "LbCarrier"
        Me.LbCarrier.Size = New System.Drawing.Size(56, 13)
        Me.LbCarrier.TabIndex = 41
        Me.LbCarrier.Text = "Compañía"
        '
        'CBCliente
        '
        Me.CBCliente.FormattingEnabled = True
        Me.CBCliente.Location = New System.Drawing.Point(238, 38)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(121, 21)
        Me.CBCliente.TabIndex = 2
        '
        'LbClaveCliente
        '
        Me.LbClaveCliente.AutoSize = True
        Me.LbClaveCliente.Location = New System.Drawing.Point(193, 42)
        Me.LbClaveCliente.Name = "LbClaveCliente"
        Me.LbClaveCliente.Size = New System.Drawing.Size(39, 13)
        Me.LbClaveCliente.TabIndex = 40
        Me.LbClaveCliente.Text = "Cliente"
        '
        'CBPuntoVenta
        '
        Me.CBPuntoVenta.FormattingEnabled = True
        Me.CBPuntoVenta.Location = New System.Drawing.Point(99, 39)
        Me.CBPuntoVenta.Name = "CBPuntoVenta"
        Me.CBPuntoVenta.Size = New System.Drawing.Size(88, 21)
        Me.CBPuntoVenta.TabIndex = 1
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.Location = New System.Drawing.Point(12, 42)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(81, 13)
        Me.LbPuntoVenta.TabIndex = 39
        Me.LbPuntoVenta.Text = "Punto de Venta"
        '
        'CBEmpresa
        '
        Me.CBEmpresa.FormattingEnabled = True
        Me.CBEmpresa.Location = New System.Drawing.Point(66, 6)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.CBEmpresa.TabIndex = 0
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 9)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.LbEmpresa.TabIndex = 38
        Me.LbEmpresa.Text = "Empresa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbFin)
        Me.GroupBox1.Controls.Add(Me.DTFin)
        Me.GroupBox1.Controls.Add(Me.DTInicio)
        Me.GroupBox1.Controls.Add(Me.LbInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(540, 9)
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
        Me.LbFin.TabIndex = 17
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
        Me.LbInicio.TabIndex = 15
        Me.LbInicio.Text = "De"
        '
        'DGReporte
        '
        Me.DGReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGReporte.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.Fecha, Me.Folio, Me.Carrier, Me.Monto, Me.Numero})
        Me.DGReporte.Location = New System.Drawing.Point(12, 103)
        Me.DGReporte.Name = "DGReporte"
        Me.DGReporte.Size = New System.Drawing.Size(746, 482)
        Me.DGReporte.TabIndex = 43
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 64
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 62
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.Width = 54
        '
        'Carrier
        '
        Me.Carrier.HeaderText = "Compañía"
        Me.Carrier.Name = "Carrier"
        Me.Carrier.Width = 81
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 62
        '
        'Numero
        '
        Me.Numero.HeaderText = "Número"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 69
        '
        'DGConsulta
        '
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Location = New System.Drawing.Point(365, 57)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.Size = New System.Drawing.Size(41, 43)
        Me.DGConsulta.TabIndex = 44
        Me.DGConsulta.Visible = False
        '
        'PDReporte
        '
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
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.imprimir
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(770, 4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(88, 28)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'InformeRecargasDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 597)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DGConsulta)
        Me.Controls.Add(Me.DGReporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBCarrier)
        Me.Controls.Add(Me.LbCarrier)
        Me.Controls.Add(Me.CBCliente)
        Me.Controls.Add(Me.LbClaveCliente)
        Me.Controls.Add(Me.CBPuntoVenta)
        Me.Controls.Add(Me.LbPuntoVenta)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InformeRecargasDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Recargas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBCarrier As ComboBox
    Friend WithEvents LbCarrier As Label
    Friend WithEvents CBCliente As ComboBox
    Friend WithEvents LbClaveCliente As Label
    Friend WithEvents CBPuntoVenta As ComboBox
    Friend WithEvents LbPuntoVenta As Label
    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbFin As Label
    Friend WithEvents DTFin As DateTimePicker
    Friend WithEvents DTInicio As DateTimePicker
    Friend WithEvents LbInicio As Label
    Friend WithEvents DGReporte As DataGridView
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents Carrier As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents PDReporte As Printing.PrintDocument
    Friend WithEvents PPDReporte As PrintPreviewDialog
End Class
