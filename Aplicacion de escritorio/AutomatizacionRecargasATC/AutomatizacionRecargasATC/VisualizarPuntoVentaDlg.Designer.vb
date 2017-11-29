<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarPuntoVentaDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarPuntoVentaDlg))
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.DGPuntoVenta = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.GBPuntoVenta = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGPuntoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPuntoVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBEmpresa
        '
        Me.CBEmpresa.FormattingEnabled = True
        Me.CBEmpresa.Location = New System.Drawing.Point(66, 16)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.CBEmpresa.TabIndex = 1
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 19)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.LbEmpresa.TabIndex = 2
        Me.LbEmpresa.Text = "Empresa"
        '
        'DGPuntoVenta
        '
        Me.DGPuntoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGPuntoVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGPuntoVenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGPuntoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPuntoVenta.Location = New System.Drawing.Point(12, 52)
        Me.DGPuntoVenta.Name = "DGPuntoVenta"
        Me.DGPuntoVenta.Size = New System.Drawing.Size(175, 290)
        Me.DGPuntoVenta.TabIndex = 3
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 54)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(70, 19)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(121, 20)
        Me.TbxNombre.TabIndex = 11
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(10, 26)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 13
        Me.LbNombre.Text = "Nombre"
        '
        'GBPuntoVenta
        '
        Me.GBPuntoVenta.Controls.Add(Me.TbxNombre)
        Me.GBPuntoVenta.Controls.Add(Me.BtnGuardar)
        Me.GBPuntoVenta.Controls.Add(Me.LbNombre)
        Me.GBPuntoVenta.Location = New System.Drawing.Point(193, 52)
        Me.GBPuntoVenta.Name = "GBPuntoVenta"
        Me.GBPuntoVenta.Size = New System.Drawing.Size(215, 100)
        Me.GBPuntoVenta.TabIndex = 14
        Me.GBPuntoVenta.TabStop = False
        Me.GBPuntoVenta.Text = "Punto de Venta"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(320, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 15
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'VisualizarPuntoVentaDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 351)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GBPuntoVenta)
        Me.Controls.Add(Me.DGPuntoVenta)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VisualizarPuntoVentaDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puntos de Venta"
        CType(Me.DGPuntoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPuntoVenta.ResumeLayout(False)
        Me.GBPuntoVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents DGPuntoVenta As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents GBPuntoVenta As GroupBox
    Friend WithEvents BtnLimpiar As Button
End Class
