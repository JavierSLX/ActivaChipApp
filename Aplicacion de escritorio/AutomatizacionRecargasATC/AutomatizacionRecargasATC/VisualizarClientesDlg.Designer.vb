<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarClientesDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarClientesDlg))
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.DGClientes = New System.Windows.Forms.DataGridView()
        Me.LbPuntoVenta = New System.Windows.Forms.Label()
        Me.CBPuntoVenta = New System.Windows.Forms.ComboBox()
        Me.GBCliente = New System.Windows.Forms.GroupBox()
        Me.TbxTelefono = New System.Windows.Forms.TextBox()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.TbxDireccion = New System.Windows.Forms.TextBox()
        Me.LbDireccion = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TbxPass = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TbxNick = New System.Windows.Forms.TextBox()
        Me.LbNick = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 9)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.LbEmpresa.TabIndex = 0
        Me.LbEmpresa.Text = "Empresa"
        '
        'CBEmpresa
        '
        Me.CBEmpresa.FormattingEnabled = True
        Me.CBEmpresa.Location = New System.Drawing.Point(66, 6)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.CBEmpresa.TabIndex = 0
        '
        'DGClientes
        '
        Me.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClientes.Location = New System.Drawing.Point(12, 33)
        Me.DGClientes.Name = "DGClientes"
        Me.DGClientes.Size = New System.Drawing.Size(493, 489)
        Me.DGClientes.TabIndex = 3
        '
        'LbPuntoVenta
        '
        Me.LbPuntoVenta.AutoSize = True
        Me.LbPuntoVenta.Location = New System.Drawing.Point(210, 9)
        Me.LbPuntoVenta.Name = "LbPuntoVenta"
        Me.LbPuntoVenta.Size = New System.Drawing.Size(81, 13)
        Me.LbPuntoVenta.TabIndex = 21
        Me.LbPuntoVenta.Text = "Punto de Venta"
        '
        'CBPuntoVenta
        '
        Me.CBPuntoVenta.FormattingEnabled = True
        Me.CBPuntoVenta.Location = New System.Drawing.Point(297, 6)
        Me.CBPuntoVenta.Name = "CBPuntoVenta"
        Me.CBPuntoVenta.Size = New System.Drawing.Size(121, 21)
        Me.CBPuntoVenta.TabIndex = 1
        '
        'GBCliente
        '
        Me.GBCliente.Controls.Add(Me.TbxTelefono)
        Me.GBCliente.Controls.Add(Me.LbTelefono)
        Me.GBCliente.Controls.Add(Me.TbxDireccion)
        Me.GBCliente.Controls.Add(Me.LbDireccion)
        Me.GBCliente.Controls.Add(Me.BtnGuardar)
        Me.GBCliente.Controls.Add(Me.TbxPass)
        Me.GBCliente.Controls.Add(Me.LbPassword)
        Me.GBCliente.Controls.Add(Me.TbxNick)
        Me.GBCliente.Controls.Add(Me.LbNick)
        Me.GBCliente.Controls.Add(Me.TbxNombre)
        Me.GBCliente.Controls.Add(Me.LbNombre)
        Me.GBCliente.Location = New System.Drawing.Point(537, 38)
        Me.GBCliente.Name = "GBCliente"
        Me.GBCliente.Size = New System.Drawing.Size(330, 233)
        Me.GBCliente.TabIndex = 2
        Me.GBCliente.TabStop = False
        Me.GBCliente.Text = "Datos del Cliente"
        '
        'TbxTelefono
        '
        Me.TbxTelefono.Location = New System.Drawing.Point(78, 92)
        Me.TbxTelefono.Name = "TbxTelefono"
        Me.TbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbxTelefono.TabIndex = 2
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(18, 95)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LbTelefono.TabIndex = 37
        Me.LbTelefono.Text = "Teléfono"
        '
        'TbxDireccion
        '
        Me.TbxDireccion.Location = New System.Drawing.Point(78, 57)
        Me.TbxDireccion.Name = "TbxDireccion"
        Me.TbxDireccion.Size = New System.Drawing.Size(203, 20)
        Me.TbxDireccion.TabIndex = 1
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Location = New System.Drawing.Point(18, 64)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LbDireccion.TabIndex = 35
        Me.LbDireccion.Text = "Dirección"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(124, 187)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TbxPass
        '
        Me.TbxPass.Location = New System.Drawing.Point(78, 156)
        Me.TbxPass.Name = "TbxPass"
        Me.TbxPass.Size = New System.Drawing.Size(203, 20)
        Me.TbxPass.TabIndex = 4
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(18, 163)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(53, 13)
        Me.LbPassword.TabIndex = 34
        Me.LbPassword.Text = "Password"
        '
        'TbxNick
        '
        Me.TbxNick.Location = New System.Drawing.Point(78, 122)
        Me.TbxNick.Name = "TbxNick"
        Me.TbxNick.Size = New System.Drawing.Size(203, 20)
        Me.TbxNick.TabIndex = 3
        '
        'LbNick
        '
        Me.LbNick.AutoSize = True
        Me.LbNick.Location = New System.Drawing.Point(18, 129)
        Me.LbNick.Name = "LbNick"
        Me.LbNick.Size = New System.Drawing.Size(29, 13)
        Me.LbNick.TabIndex = 33
        Me.LbNick.Text = "Nick"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(78, 22)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(203, 20)
        Me.TbxNombre.TabIndex = 0
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(18, 29)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 32
        Me.LbNombre.Text = "Nombre"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(779, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 22
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'VisualizarClientesDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 534)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GBCliente)
        Me.Controls.Add(Me.CBPuntoVenta)
        Me.Controls.Add(Me.LbPuntoVenta)
        Me.Controls.Add(Me.DGClientes)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VisualizarClientesDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCliente.ResumeLayout(False)
        Me.GBCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbEmpresa As Label
    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents DGClientes As DataGridView
    Friend WithEvents LbPuntoVenta As Label
    Friend WithEvents CBPuntoVenta As ComboBox
    Friend WithEvents GBCliente As GroupBox
    Friend WithEvents TbxTelefono As TextBox
    Friend WithEvents LbTelefono As Label
    Friend WithEvents TbxDireccion As TextBox
    Friend WithEvents LbDireccion As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TbxPass As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents TbxNick As TextBox
    Friend WithEvents LbNick As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents BtnLimpiar As Button
End Class
