<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarUsuariosDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarUsuariosDlg))
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.DGUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TbxPass = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TbxNick = New System.Windows.Forms.TextBox()
        Me.LbNick = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbPermiso = New System.Windows.Forms.Label()
        Me.CBPermiso = New System.Windows.Forms.ComboBox()
        Me.GBUsuario = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBUsuario.SuspendLayout()
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
        'DGUsuarios
        '
        Me.DGUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuarios.Location = New System.Drawing.Point(12, 42)
        Me.DGUsuarios.Name = "DGUsuarios"
        Me.DGUsuarios.Size = New System.Drawing.Size(278, 388)
        Me.DGUsuarios.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(120, 165)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TbxPass
        '
        Me.TbxPass.Location = New System.Drawing.Point(93, 93)
        Me.TbxPass.Name = "TbxPass"
        Me.TbxPass.Size = New System.Drawing.Size(203, 20)
        Me.TbxPass.TabIndex = 2
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(33, 100)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(53, 13)
        Me.LbPassword.TabIndex = 13
        Me.LbPassword.Text = "Password"
        '
        'TbxNick
        '
        Me.TbxNick.Location = New System.Drawing.Point(93, 59)
        Me.TbxNick.Name = "TbxNick"
        Me.TbxNick.Size = New System.Drawing.Size(203, 20)
        Me.TbxNick.TabIndex = 1
        '
        'LbNick
        '
        Me.LbNick.AutoSize = True
        Me.LbNick.Location = New System.Drawing.Point(33, 66)
        Me.LbNick.Name = "LbNick"
        Me.LbNick.Size = New System.Drawing.Size(29, 13)
        Me.LbNick.TabIndex = 12
        Me.LbNick.Text = "Nick"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(93, 23)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(203, 20)
        Me.TbxNombre.TabIndex = 0
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(33, 30)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 10
        Me.LbNombre.Text = "Nombre"
        '
        'LbPermiso
        '
        Me.LbPermiso.AutoSize = True
        Me.LbPermiso.Location = New System.Drawing.Point(38, 132)
        Me.LbPermiso.Name = "LbPermiso"
        Me.LbPermiso.Size = New System.Drawing.Size(44, 13)
        Me.LbPermiso.TabIndex = 14
        Me.LbPermiso.Text = "Permiso"
        '
        'CBPermiso
        '
        Me.CBPermiso.FormattingEnabled = True
        Me.CBPermiso.Location = New System.Drawing.Point(93, 129)
        Me.CBPermiso.Name = "CBPermiso"
        Me.CBPermiso.Size = New System.Drawing.Size(121, 21)
        Me.CBPermiso.TabIndex = 3
        '
        'GBUsuario
        '
        Me.GBUsuario.Controls.Add(Me.LbNombre)
        Me.GBUsuario.Controls.Add(Me.CBPermiso)
        Me.GBUsuario.Controls.Add(Me.TbxNombre)
        Me.GBUsuario.Controls.Add(Me.LbPermiso)
        Me.GBUsuario.Controls.Add(Me.LbNick)
        Me.GBUsuario.Controls.Add(Me.BtnGuardar)
        Me.GBUsuario.Controls.Add(Me.TbxNick)
        Me.GBUsuario.Controls.Add(Me.TbxPass)
        Me.GBUsuario.Controls.Add(Me.LbPassword)
        Me.GBUsuario.Location = New System.Drawing.Point(309, 37)
        Me.GBUsuario.Name = "GBUsuario"
        Me.GBUsuario.Size = New System.Drawing.Size(317, 203)
        Me.GBUsuario.TabIndex = 15
        Me.GBUsuario.TabStop = False
        Me.GBUsuario.Text = "Datos del Usuario"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(538, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'VisualizarUsuariosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 442)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GBUsuario)
        Me.Controls.Add(Me.DGUsuarios)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VisualizarUsuariosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBUsuario.ResumeLayout(False)
        Me.GBUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbEmpresa As Label
    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents DGUsuarios As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TbxPass As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents TbxNick As TextBox
    Friend WithEvents LbNick As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbPermiso As Label
    Friend WithEvents CBPermiso As ComboBox
    Friend WithEvents GBUsuario As GroupBox
    Friend WithEvents BtnLimpiar As Button
End Class
