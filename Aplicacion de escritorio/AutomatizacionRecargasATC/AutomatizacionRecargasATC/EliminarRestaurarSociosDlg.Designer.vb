<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarRestaurarSociosDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarRestaurarSociosDlg))
        Me.TabSocios = New System.Windows.Forms.TabControl()
        Me.TabSociosAcitvos = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGSociosActivos = New System.Windows.Forms.DataGridView()
        Me.TabSociosInativos = New System.Windows.Forms.TabPage()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.DGSociosInactivos = New System.Windows.Forms.DataGridView()
        Me.TabSocios.SuspendLayout()
        Me.TabSociosAcitvos.SuspendLayout()
        CType(Me.DGSociosActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSociosInativos.SuspendLayout()
        CType(Me.DGSociosInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSocios
        '
        Me.TabSocios.Controls.Add(Me.TabSociosAcitvos)
        Me.TabSocios.Controls.Add(Me.TabSociosInativos)
        Me.TabSocios.Location = New System.Drawing.Point(12, 12)
        Me.TabSocios.Name = "TabSocios"
        Me.TabSocios.SelectedIndex = 0
        Me.TabSocios.Size = New System.Drawing.Size(634, 459)
        Me.TabSocios.TabIndex = 0
        '
        'TabSociosAcitvos
        '
        Me.TabSociosAcitvos.Controls.Add(Me.BtnEliminar)
        Me.TabSociosAcitvos.Controls.Add(Me.DGSociosActivos)
        Me.TabSociosAcitvos.Location = New System.Drawing.Point(4, 22)
        Me.TabSociosAcitvos.Name = "TabSociosAcitvos"
        Me.TabSociosAcitvos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSociosAcitvos.Size = New System.Drawing.Size(626, 433)
        Me.TabSociosAcitvos.TabIndex = 0
        Me.TabSociosAcitvos.Text = "Activos"
        Me.TabSociosAcitvos.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(532, 9)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(88, 28)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DGSociosActivos
        '
        Me.DGSociosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSociosActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSociosActivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGSociosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSociosActivos.Location = New System.Drawing.Point(10, 9)
        Me.DGSociosActivos.Name = "DGSociosActivos"
        Me.DGSociosActivos.Size = New System.Drawing.Size(516, 414)
        Me.DGSociosActivos.TabIndex = 2
        '
        'TabSociosInativos
        '
        Me.TabSociosInativos.Controls.Add(Me.BtnRestaurar)
        Me.TabSociosInativos.Controls.Add(Me.DGSociosInactivos)
        Me.TabSociosInativos.Location = New System.Drawing.Point(4, 22)
        Me.TabSociosInativos.Name = "TabSociosInativos"
        Me.TabSociosInativos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSociosInativos.Size = New System.Drawing.Size(626, 433)
        Me.TabSociosInativos.TabIndex = 1
        Me.TabSociosInativos.Text = "Inactivos"
        Me.TabSociosInativos.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRestaurar.Location = New System.Drawing.Point(528, 16)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(88, 28)
        Me.BtnRestaurar.TabIndex = 1
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'DGSociosInactivos
        '
        Me.DGSociosInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSociosInactivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSociosInactivos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGSociosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSociosInactivos.Location = New System.Drawing.Point(6, 16)
        Me.DGSociosInactivos.Name = "DGSociosInactivos"
        Me.DGSociosInactivos.Size = New System.Drawing.Size(516, 414)
        Me.DGSociosInactivos.TabIndex = 0
        '
        'EliminarRestaurarSociosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 477)
        Me.Controls.Add(Me.TabSocios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EliminarRestaurarSociosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar/Restaurar Socios"
        Me.TabSocios.ResumeLayout(False)
        Me.TabSociosAcitvos.ResumeLayout(False)
        CType(Me.DGSociosActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSociosInativos.ResumeLayout(False)
        CType(Me.DGSociosInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabSocios As TabControl
    Friend WithEvents TabSociosAcitvos As TabPage
    Friend WithEvents TabSociosInativos As TabPage
    Friend WithEvents DGSociosInactivos As DataGridView
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGSociosActivos As DataGridView
End Class
