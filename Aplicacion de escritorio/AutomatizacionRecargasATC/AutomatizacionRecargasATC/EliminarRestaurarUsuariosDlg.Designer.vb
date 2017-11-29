<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarRestaurarUsuariosDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarRestaurarUsuariosDlg))
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.TabUsuarios = New System.Windows.Forms.TabControl()
        Me.TabActivos = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGActivos = New System.Windows.Forms.DataGridView()
        Me.TabInactivos = New System.Windows.Forms.TabPage()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.DGInativos = New System.Windows.Forms.DataGridView()
        Me.TabUsuarios.SuspendLayout()
        Me.TabActivos.SuspendLayout()
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInactivos.SuspendLayout()
        CType(Me.DGInativos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LbEmpresa.TabIndex = 2
        Me.LbEmpresa.Text = "Empresa"
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Controls.Add(Me.TabActivos)
        Me.TabUsuarios.Controls.Add(Me.TabInactivos)
        Me.TabUsuarios.Location = New System.Drawing.Point(15, 42)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.SelectedIndex = 0
        Me.TabUsuarios.Size = New System.Drawing.Size(527, 451)
        Me.TabUsuarios.TabIndex = 1
        '
        'TabActivos
        '
        Me.TabActivos.Controls.Add(Me.BtnEliminar)
        Me.TabActivos.Controls.Add(Me.DGActivos)
        Me.TabActivos.Location = New System.Drawing.Point(4, 22)
        Me.TabActivos.Name = "TabActivos"
        Me.TabActivos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabActivos.Size = New System.Drawing.Size(519, 425)
        Me.TabActivos.TabIndex = 0
        Me.TabActivos.Text = "Activos"
        Me.TabActivos.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(420, 6)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(88, 28)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DGActivos
        '
        Me.DGActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGActivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGActivos.Location = New System.Drawing.Point(6, 6)
        Me.DGActivos.Name = "DGActivos"
        Me.DGActivos.Size = New System.Drawing.Size(410, 413)
        Me.DGActivos.TabIndex = 0
        '
        'TabInactivos
        '
        Me.TabInactivos.Controls.Add(Me.BtnRestaurar)
        Me.TabInactivos.Controls.Add(Me.DGInativos)
        Me.TabInactivos.Location = New System.Drawing.Point(4, 22)
        Me.TabInactivos.Name = "TabInactivos"
        Me.TabInactivos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInactivos.Size = New System.Drawing.Size(519, 425)
        Me.TabInactivos.TabIndex = 1
        Me.TabInactivos.Text = "Inactivos"
        Me.TabInactivos.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRestaurar.Location = New System.Drawing.Point(427, 6)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(88, 28)
        Me.BtnRestaurar.TabIndex = 1
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'DGInativos
        '
        Me.DGInativos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGInativos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGInativos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGInativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInativos.Location = New System.Drawing.Point(15, 6)
        Me.DGInativos.Name = "DGInativos"
        Me.DGInativos.Size = New System.Drawing.Size(410, 413)
        Me.DGInativos.TabIndex = 0
        '
        'EliminarRestaurarUsuariosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 498)
        Me.Controls.Add(Me.TabUsuarios)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EliminarRestaurarUsuariosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar/Restaurar Usuarios"
        Me.TabUsuarios.ResumeLayout(False)
        Me.TabActivos.ResumeLayout(False)
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInactivos.ResumeLayout(False)
        CType(Me.DGInativos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents TabUsuarios As TabControl
    Friend WithEvents TabActivos As TabPage
    Friend WithEvents TabInactivos As TabPage
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGActivos As DataGridView
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents DGInativos As DataGridView
End Class
