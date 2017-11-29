<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarRestaurarPuntoVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarRestaurarPuntoVenta))
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.TabPuntoVenta = New System.Windows.Forms.TabControl()
        Me.Activos = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGActivos = New System.Windows.Forms.DataGridView()
        Me.TabInactivos = New System.Windows.Forms.TabPage()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.DGInactivos = New System.Windows.Forms.DataGridView()
        Me.TabPuntoVenta.SuspendLayout()
        Me.Activos.SuspendLayout()
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInactivos.SuspendLayout()
        CType(Me.DGInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEmpresa
        '
        Me.CBEmpresa.FormattingEnabled = True
        Me.CBEmpresa.Location = New System.Drawing.Point(66, 15)
        Me.CBEmpresa.Name = "CBEmpresa"
        Me.CBEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.CBEmpresa.TabIndex = 3
        '
        'LbEmpresa
        '
        Me.LbEmpresa.AutoSize = True
        Me.LbEmpresa.Location = New System.Drawing.Point(12, 18)
        Me.LbEmpresa.Name = "LbEmpresa"
        Me.LbEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.LbEmpresa.TabIndex = 4
        Me.LbEmpresa.Text = "Empresa"
        '
        'TabPuntoVenta
        '
        Me.TabPuntoVenta.Controls.Add(Me.Activos)
        Me.TabPuntoVenta.Controls.Add(Me.TabInactivos)
        Me.TabPuntoVenta.Location = New System.Drawing.Point(15, 55)
        Me.TabPuntoVenta.Name = "TabPuntoVenta"
        Me.TabPuntoVenta.SelectedIndex = 0
        Me.TabPuntoVenta.Size = New System.Drawing.Size(373, 454)
        Me.TabPuntoVenta.TabIndex = 5
        '
        'Activos
        '
        Me.Activos.Controls.Add(Me.BtnEliminar)
        Me.Activos.Controls.Add(Me.DGActivos)
        Me.Activos.Location = New System.Drawing.Point(4, 22)
        Me.Activos.Name = "Activos"
        Me.Activos.Padding = New System.Windows.Forms.Padding(3)
        Me.Activos.Size = New System.Drawing.Size(365, 428)
        Me.Activos.TabIndex = 0
        Me.Activos.Text = "Activos"
        Me.Activos.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(272, 8)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(88, 28)
        Me.BtnEliminar.TabIndex = 3
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
        Me.DGActivos.Location = New System.Drawing.Point(16, 8)
        Me.DGActivos.Name = "DGActivos"
        Me.DGActivos.Size = New System.Drawing.Size(247, 413)
        Me.DGActivos.TabIndex = 2
        '
        'TabInactivos
        '
        Me.TabInactivos.Controls.Add(Me.BtnRestaurar)
        Me.TabInactivos.Controls.Add(Me.DGInactivos)
        Me.TabInactivos.Location = New System.Drawing.Point(4, 22)
        Me.TabInactivos.Name = "TabInactivos"
        Me.TabInactivos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInactivos.Size = New System.Drawing.Size(365, 428)
        Me.TabInactivos.TabIndex = 1
        Me.TabInactivos.Text = "Inactivos"
        Me.TabInactivos.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRestaurar.Location = New System.Drawing.Point(264, 8)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(88, 28)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'DGInactivos
        '
        Me.DGInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGInactivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGInactivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInactivos.Location = New System.Drawing.Point(8, 8)
        Me.DGInactivos.Name = "DGInactivos"
        Me.DGInactivos.Size = New System.Drawing.Size(247, 413)
        Me.DGInactivos.TabIndex = 4
        '
        'EliminarRestaurarPuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 521)
        Me.Controls.Add(Me.TabPuntoVenta)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EliminarRestaurarPuntoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar/Restaurar Punto de Venta"
        Me.TabPuntoVenta.ResumeLayout(False)
        Me.Activos.ResumeLayout(False)
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInactivos.ResumeLayout(False)
        CType(Me.DGInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents TabPuntoVenta As TabControl
    Friend WithEvents Activos As TabPage
    Friend WithEvents TabInactivos As TabPage
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGActivos As DataGridView
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents DGInactivos As DataGridView
End Class
