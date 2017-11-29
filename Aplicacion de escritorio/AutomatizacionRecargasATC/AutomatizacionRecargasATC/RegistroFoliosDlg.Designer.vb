<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroFoliosDlg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroFoliosDlg))
        Me.DGNumeros = New System.Windows.Forms.DataGridView()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bandera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.CBPuntoVenta = New System.Windows.Forms.ComboBox()
        Me.LbPuntoVenta = New System.Windows.Forms.Label()
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.LbClaveCliente = New System.Windows.Forms.Label()
        Me.CBCliente = New System.Windows.Forms.ComboBox()
        Me.LbFolio = New System.Windows.Forms.Label()
        Me.TbxFolio = New System.Windows.Forms.TextBox()
        Me.LbCarrier = New System.Windows.Forms.Label()
        Me.CBCarrier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TbxConfirmar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBMonto = New System.Windows.Forms.ComboBox()
        CType(Me.DGNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGNumeros
        '
        Me.DGNumeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGNumeros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGNumeros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGNumeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Folio, Me.Numero, Me.Bandera})
        Me.DGNumeros.Location = New System.Drawing.Point(146, 99)
        Me.DGNumeros.Name = "DGNumeros"
        Me.DGNumeros.Size = New System.Drawing.Size(185, 476)
        Me.DGNumeros.TabIndex = 7
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.Width = 54
        '
        'Numero
        '
        Me.Numero.HeaderText = "Número"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 69
        '
        'Bandera
        '
        Me.Bandera.HeaderText = "Bandera"
        Me.Bandera.Name = "Bandera"
        Me.Bandera.Visible = False
        '
        'BtnCargar
        '
        Me.BtnCargar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargar.Location = New System.Drawing.Point(12, 108)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(88, 28)
        Me.BtnCargar.TabIndex = 7
        Me.BtnCargar.Text = "Generar"
        Me.BtnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargar.UseVisualStyleBackColor = True
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
        Me.LbPuntoVenta.TabIndex = 28
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
        Me.LbEmpresa.TabIndex = 26
        Me.LbEmpresa.Text = "Empresa"
        '
        'LbClaveCliente
        '
        Me.LbClaveCliente.AutoSize = True
        Me.LbClaveCliente.Location = New System.Drawing.Point(193, 42)
        Me.LbClaveCliente.Name = "LbClaveCliente"
        Me.LbClaveCliente.Size = New System.Drawing.Size(39, 13)
        Me.LbClaveCliente.TabIndex = 29
        Me.LbClaveCliente.Text = "Cliente"
        '
        'CBCliente
        '
        Me.CBCliente.FormattingEnabled = True
        Me.CBCliente.Location = New System.Drawing.Point(238, 38)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(121, 21)
        Me.CBCliente.TabIndex = 2
        '
        'LbFolio
        '
        Me.LbFolio.AutoSize = True
        Me.LbFolio.Location = New System.Drawing.Point(193, 74)
        Me.LbFolio.Name = "LbFolio"
        Me.LbFolio.Size = New System.Drawing.Size(59, 13)
        Me.LbFolio.TabIndex = 31
        Me.LbFolio.Text = "Folio Inicial"
        '
        'TbxFolio
        '
        Me.TbxFolio.Location = New System.Drawing.Point(258, 69)
        Me.TbxFolio.Name = "TbxFolio"
        Me.TbxFolio.Size = New System.Drawing.Size(100, 20)
        Me.TbxFolio.TabIndex = 5
        '
        'LbCarrier
        '
        Me.LbCarrier.AutoSize = True
        Me.LbCarrier.Location = New System.Drawing.Point(376, 41)
        Me.LbCarrier.Name = "LbCarrier"
        Me.LbCarrier.Size = New System.Drawing.Size(56, 13)
        Me.LbCarrier.TabIndex = 33
        Me.LbCarrier.Text = "Compañía"
        '
        'CBCarrier
        '
        Me.CBCarrier.FormattingEnabled = True
        Me.CBCarrier.Location = New System.Drawing.Point(438, 35)
        Me.CBCarrier.Name = "CBCarrier"
        Me.CBCarrier.Size = New System.Drawing.Size(87, 21)
        Me.CBCarrier.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Monto de Recarga"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(438, 1)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 8
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TbxConfirmar
        '
        Me.TbxConfirmar.Location = New System.Drawing.Point(442, 70)
        Me.TbxConfirmar.Name = "TbxConfirmar"
        Me.TbxConfirmar.Size = New System.Drawing.Size(100, 20)
        Me.TbxConfirmar.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Confirmar Folio"
        '
        'CBMonto
        '
        Me.CBMonto.FormattingEnabled = True
        Me.CBMonto.Location = New System.Drawing.Point(114, 70)
        Me.CBMonto.Name = "CBMonto"
        Me.CBMonto.Size = New System.Drawing.Size(57, 21)
        Me.CBMonto.TabIndex = 4
        '
        'RegistroFoliosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 587)
        Me.Controls.Add(Me.CBMonto)
        Me.Controls.Add(Me.TbxConfirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBCarrier)
        Me.Controls.Add(Me.LbCarrier)
        Me.Controls.Add(Me.TbxFolio)
        Me.Controls.Add(Me.LbFolio)
        Me.Controls.Add(Me.CBCliente)
        Me.Controls.Add(Me.LbClaveCliente)
        Me.Controls.Add(Me.CBPuntoVenta)
        Me.Controls.Add(Me.LbPuntoVenta)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.DGNumeros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegistroFoliosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Números"
        CType(Me.DGNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGNumeros As DataGridView
    Friend WithEvents BtnCargar As Button
    Friend WithEvents CBPuntoVenta As ComboBox
    Friend WithEvents LbPuntoVenta As Label
    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents LbClaveCliente As Label
    Friend WithEvents CBCliente As ComboBox
    Friend WithEvents LbFolio As Label
    Friend WithEvents TbxFolio As TextBox
    Friend WithEvents LbCarrier As Label
    Friend WithEvents CBCarrier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Bandera As DataGridViewTextBoxColumn
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TbxConfirmar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBMonto As ComboBox
End Class
