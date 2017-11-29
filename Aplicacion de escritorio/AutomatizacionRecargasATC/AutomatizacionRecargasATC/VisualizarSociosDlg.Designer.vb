<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarSociosDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarSociosDlg))
        Me.DGSociosActivos = New System.Windows.Forms.DataGridView()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.TbxDireccion = New System.Windows.Forms.TextBox()
        Me.LbDireccion = New System.Windows.Forms.Label()
        Me.TbxTelefono = New System.Windows.Forms.TextBox()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.LbCorreo = New System.Windows.Forms.Label()
        Me.TbxCorreo = New System.Windows.Forms.TextBox()
        Me.GBSocio = New System.Windows.Forms.GroupBox()
        Me.TbxClave = New System.Windows.Forms.TextBox()
        Me.LbClaveOperador = New System.Windows.Forms.Label()
        Me.TbxPass = New System.Windows.Forms.TextBox()
        Me.LbPass = New System.Windows.Forms.Label()
        Me.TbxUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TbxWSDL = New System.Windows.Forms.TextBox()
        Me.LblWsdl = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGSociosActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSocio.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGSociosActivos
        '
        Me.DGSociosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSociosActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSociosActivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGSociosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSociosActivos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGSociosActivos.Location = New System.Drawing.Point(12, 45)
        Me.DGSociosActivos.Name = "DGSociosActivos"
        Me.DGSociosActivos.Size = New System.Drawing.Size(950, 504)
        Me.DGSociosActivos.TabIndex = 4
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(41, 27)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 2
        Me.LbNombre.Text = "Nombre"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(101, 20)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(203, 20)
        Me.TbxNombre.TabIndex = 0
        '
        'TbxDireccion
        '
        Me.TbxDireccion.Location = New System.Drawing.Point(101, 56)
        Me.TbxDireccion.Name = "TbxDireccion"
        Me.TbxDireccion.Size = New System.Drawing.Size(203, 20)
        Me.TbxDireccion.TabIndex = 1
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Location = New System.Drawing.Point(41, 63)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LbDireccion.TabIndex = 4
        Me.LbDireccion.Text = "Dirección"
        '
        'TbxTelefono
        '
        Me.TbxTelefono.Location = New System.Drawing.Point(101, 90)
        Me.TbxTelefono.Name = "TbxTelefono"
        Me.TbxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbxTelefono.TabIndex = 2
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(41, 97)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LbTelefono.TabIndex = 6
        Me.LbTelefono.Text = "Teléfono"
        '
        'LbCorreo
        '
        Me.LbCorreo.AutoSize = True
        Me.LbCorreo.Location = New System.Drawing.Point(46, 131)
        Me.LbCorreo.Name = "LbCorreo"
        Me.LbCorreo.Size = New System.Drawing.Size(38, 13)
        Me.LbCorreo.TabIndex = 7
        Me.LbCorreo.Text = "Correo"
        '
        'TbxCorreo
        '
        Me.TbxCorreo.Location = New System.Drawing.Point(101, 128)
        Me.TbxCorreo.Name = "TbxCorreo"
        Me.TbxCorreo.Size = New System.Drawing.Size(201, 20)
        Me.TbxCorreo.TabIndex = 3
        '
        'GBSocio
        '
        Me.GBSocio.Controls.Add(Me.TbxClave)
        Me.GBSocio.Controls.Add(Me.LbClaveOperador)
        Me.GBSocio.Controls.Add(Me.TbxPass)
        Me.GBSocio.Controls.Add(Me.LbPass)
        Me.GBSocio.Controls.Add(Me.TbxUsuario)
        Me.GBSocio.Controls.Add(Me.LblUsuario)
        Me.GBSocio.Controls.Add(Me.TbxWSDL)
        Me.GBSocio.Controls.Add(Me.LblWsdl)
        Me.GBSocio.Controls.Add(Me.LbNombre)
        Me.GBSocio.Controls.Add(Me.TbxCorreo)
        Me.GBSocio.Controls.Add(Me.TbxNombre)
        Me.GBSocio.Controls.Add(Me.LbCorreo)
        Me.GBSocio.Controls.Add(Me.LbDireccion)
        Me.GBSocio.Controls.Add(Me.BtnGuardar)
        Me.GBSocio.Controls.Add(Me.TbxDireccion)
        Me.GBSocio.Controls.Add(Me.TbxTelefono)
        Me.GBSocio.Controls.Add(Me.LbTelefono)
        Me.GBSocio.Location = New System.Drawing.Point(989, 42)
        Me.GBSocio.Name = "GBSocio"
        Me.GBSocio.Size = New System.Drawing.Size(330, 343)
        Me.GBSocio.TabIndex = 0
        Me.GBSocio.TabStop = False
        Me.GBSocio.Text = "Datos del Socio"
        '
        'TbxClave
        '
        Me.TbxClave.Location = New System.Drawing.Point(143, 272)
        Me.TbxClave.Name = "TbxClave"
        Me.TbxClave.Size = New System.Drawing.Size(159, 20)
        Me.TbxClave.TabIndex = 7
        '
        'LbClaveOperador
        '
        Me.LbClaveOperador.AutoSize = True
        Me.LbClaveOperador.Location = New System.Drawing.Point(41, 275)
        Me.LbClaveOperador.Name = "LbClaveOperador"
        Me.LbClaveOperador.Size = New System.Drawing.Size(96, 13)
        Me.LbClaveOperador.TabIndex = 14
        Me.LbClaveOperador.Text = "Clave de Operador"
        '
        'TbxPass
        '
        Me.TbxPass.Location = New System.Drawing.Point(101, 233)
        Me.TbxPass.Name = "TbxPass"
        Me.TbxPass.Size = New System.Drawing.Size(203, 20)
        Me.TbxPass.TabIndex = 6
        '
        'LbPass
        '
        Me.LbPass.AutoSize = True
        Me.LbPass.Location = New System.Drawing.Point(46, 233)
        Me.LbPass.Name = "LbPass"
        Me.LbPass.Size = New System.Drawing.Size(53, 13)
        Me.LbPass.TabIndex = 12
        Me.LbPass.Text = "Password"
        '
        'TbxUsuario
        '
        Me.TbxUsuario.Location = New System.Drawing.Point(101, 193)
        Me.TbxUsuario.Name = "TbxUsuario"
        Me.TbxUsuario.Size = New System.Drawing.Size(203, 20)
        Me.TbxUsuario.TabIndex = 5
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(46, 196)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuario.TabIndex = 10
        Me.LblUsuario.Text = "Usuario"
        '
        'TbxWSDL
        '
        Me.TbxWSDL.Location = New System.Drawing.Point(101, 158)
        Me.TbxWSDL.Name = "TbxWSDL"
        Me.TbxWSDL.Size = New System.Drawing.Size(203, 20)
        Me.TbxWSDL.TabIndex = 4
        '
        'LblWsdl
        '
        Me.LblWsdl.AutoSize = True
        Me.LblWsdl.Location = New System.Drawing.Point(46, 161)
        Me.LblWsdl.Name = "LblWsdl"
        Me.LblWsdl.Size = New System.Drawing.Size(39, 13)
        Me.LblWsdl.TabIndex = 8
        Me.LblWsdl.Text = "WSDL"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(129, 298)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(1226, 3)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'VisualizarSociosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 561)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GBSocio)
        Me.Controls.Add(Me.DGSociosActivos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VisualizarSociosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios"
        CType(Me.DGSociosActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSocio.ResumeLayout(False)
        Me.GBSocio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGSociosActivos As DataGridView
    Friend WithEvents LbNombre As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents TbxDireccion As TextBox
    Friend WithEvents LbDireccion As Label
    Friend WithEvents TbxTelefono As TextBox
    Friend WithEvents LbTelefono As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LbCorreo As Label
    Friend WithEvents TbxCorreo As TextBox
    Friend WithEvents GBSocio As GroupBox
    Friend WithEvents TbxWSDL As TextBox
    Friend WithEvents LblWsdl As Label
    Friend WithEvents TbxUsuario As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TbxPass As TextBox
    Friend WithEvents LbPass As Label
    Friend WithEvents TbxClave As TextBox
    Friend WithEvents LbClaveOperador As Label
    Friend WithEvents BtnLimpiar As Button
End Class
