<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuInicio = New System.Windows.Forms.MenuStrip()
        Me.AccesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRestaurarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRestauararUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRestaurarPuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRestaurarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MontoDeRecargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroNúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDeRecargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.GBBienvenido = New System.Windows.Forms.GroupBox()
        Me.ComportamientoDeRecargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuInicio.SuspendLayout()
        Me.GBBienvenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuInicio
        '
        Me.MenuInicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesoToolStripMenuItem, Me.SociosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.NumerosToolStripMenuItem})
        Me.MenuInicio.Location = New System.Drawing.Point(0, 0)
        Me.MenuInicio.Name = "MenuInicio"
        Me.MenuInicio.Size = New System.Drawing.Size(913, 24)
        Me.MenuInicio.TabIndex = 0
        Me.MenuInicio.Text = "MenuStrip1"
        '
        'AccesoToolStripMenuItem
        '
        Me.AccesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AccesoToolStripMenuItem.Name = "AccesoToolStripMenuItem"
        Me.AccesoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AccesoToolStripMenuItem.Text = "Acceso"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarSociosToolStripMenuItem, Me.EliminarRestaurarSociosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PuntoDeVentaToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'VisualizarSociosToolStripMenuItem
        '
        Me.VisualizarSociosToolStripMenuItem.Name = "VisualizarSociosToolStripMenuItem"
        Me.VisualizarSociosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.VisualizarSociosToolStripMenuItem.Text = "Visualizar Socios"
        '
        'EliminarRestaurarSociosToolStripMenuItem
        '
        Me.EliminarRestaurarSociosToolStripMenuItem.Name = "EliminarRestaurarSociosToolStripMenuItem"
        Me.EliminarRestaurarSociosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EliminarRestaurarSociosToolStripMenuItem.Text = "Eliminar/Restaurar Socios"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarUsuariosToolStripMenuItem, Me.EliminarRestauararUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'VisualizarUsuariosToolStripMenuItem
        '
        Me.VisualizarUsuariosToolStripMenuItem.Name = "VisualizarUsuariosToolStripMenuItem"
        Me.VisualizarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.VisualizarUsuariosToolStripMenuItem.Text = "Agregar Usuarios"
        '
        'EliminarRestauararUsuariosToolStripMenuItem
        '
        Me.EliminarRestauararUsuariosToolStripMenuItem.Name = "EliminarRestauararUsuariosToolStripMenuItem"
        Me.EliminarRestauararUsuariosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.EliminarRestauararUsuariosToolStripMenuItem.Text = "Eliminar/Restaurar Usuarios"
        '
        'PuntoDeVentaToolStripMenuItem
        '
        Me.PuntoDeVentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPuntoDeVentaToolStripMenuItem, Me.EliminarRestaurarPuntoDeVentaToolStripMenuItem})
        Me.PuntoDeVentaToolStripMenuItem.Name = "PuntoDeVentaToolStripMenuItem"
        Me.PuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PuntoDeVentaToolStripMenuItem.Text = "Punto de Venta"
        '
        'AgregarPuntoDeVentaToolStripMenuItem
        '
        Me.AgregarPuntoDeVentaToolStripMenuItem.Name = "AgregarPuntoDeVentaToolStripMenuItem"
        Me.AgregarPuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.AgregarPuntoDeVentaToolStripMenuItem.Text = "Agregar Punto de Venta"
        '
        'EliminarRestaurarPuntoDeVentaToolStripMenuItem
        '
        Me.EliminarRestaurarPuntoDeVentaToolStripMenuItem.Name = "EliminarRestaurarPuntoDeVentaToolStripMenuItem"
        Me.EliminarRestaurarPuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.EliminarRestaurarPuntoDeVentaToolStripMenuItem.Text = "Eliminar/Restaurar Punto de Venta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarClientesToolStripMenuItem, Me.EliminarRestaurarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VisualizarClientesToolStripMenuItem
        '
        Me.VisualizarClientesToolStripMenuItem.Name = "VisualizarClientesToolStripMenuItem"
        Me.VisualizarClientesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.VisualizarClientesToolStripMenuItem.Text = "Agregar Clientes"
        '
        'EliminarRestaurarClientesToolStripMenuItem
        '
        Me.EliminarRestaurarClientesToolStripMenuItem.Name = "EliminarRestaurarClientesToolStripMenuItem"
        Me.EliminarRestaurarClientesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.EliminarRestaurarClientesToolStripMenuItem.Text = "Eliminar/Restaurar Clientes"
        '
        'NumerosToolStripMenuItem
        '
        Me.NumerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MontoDeRecargaToolStripMenuItem, Me.RegistroNúmerosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.NumerosToolStripMenuItem.Name = "NumerosToolStripMenuItem"
        Me.NumerosToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.NumerosToolStripMenuItem.Text = "Admon. Recargas"
        '
        'MontoDeRecargaToolStripMenuItem
        '
        Me.MontoDeRecargaToolStripMenuItem.Name = "MontoDeRecargaToolStripMenuItem"
        Me.MontoDeRecargaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MontoDeRecargaToolStripMenuItem.Text = "Monto de Recarga"
        '
        'RegistroNúmerosToolStripMenuItem
        '
        Me.RegistroNúmerosToolStripMenuItem.Name = "RegistroNúmerosToolStripMenuItem"
        Me.RegistroNúmerosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegistroNúmerosToolStripMenuItem.Text = "Registro Números"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeDeRecargasToolStripMenuItem, Me.ComportamientoDeRecargasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'InformeDeRecargasToolStripMenuItem
        '
        Me.InformeDeRecargasToolStripMenuItem.Name = "InformeDeRecargasToolStripMenuItem"
        Me.InformeDeRecargasToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InformeDeRecargasToolStripMenuItem.Text = "Informe de Recargas"
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmpresa.Location = New System.Drawing.Point(6, 16)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(174, 42)
        Me.LbEmpresa.TabIndex = 1
        Me.LbEmpresa.Text = "Empresa"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.Location = New System.Drawing.Point(10, 58)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(93, 25)
        Me.LbNombre.TabIndex = 2
        Me.LbNombre.Text = "Usuario"
        '
        'GBBienvenido
        '
        Me.GBBienvenido.Controls.Add(Me.LbEmpresa)
        Me.GBBienvenido.Controls.Add(Me.LbNombre)
        Me.GBBienvenido.Location = New System.Drawing.Point(12, 27)
        Me.GBBienvenido.Name = "GBBienvenido"
        Me.GBBienvenido.Size = New System.Drawing.Size(200, 100)
        Me.GBBienvenido.TabIndex = 3
        Me.GBBienvenido.TabStop = False
        Me.GBBienvenido.Text = "Bienvenido"
        '
        'ComportamientoDeRecargasToolStripMenuItem
        '
        Me.ComportamientoDeRecargasToolStripMenuItem.Name = "ComportamientoDeRecargasToolStripMenuItem"
        Me.ComportamientoDeRecargasToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ComportamientoDeRecargasToolStripMenuItem.Text = "Comportamiento de Recargas"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 493)
        Me.Controls.Add(Me.GBBienvenido)
        Me.Controls.Add(Me.MenuInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuInicio
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recargas ATC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuInicio.ResumeLayout(False)
        Me.MenuInicio.PerformLayout()
        Me.GBBienvenido.ResumeLayout(False)
        Me.GBBienvenido.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuInicio As MenuStrip
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRestaurarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRestaurarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRestauararUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntoDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPuntoDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRestaurarPuntoDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MontoDeRecargaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroNúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeDeRecargasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBBienvenido As GroupBox
    Friend WithEvents ComportamientoDeRecargasToolStripMenuItem As ToolStripMenuItem
End Class
