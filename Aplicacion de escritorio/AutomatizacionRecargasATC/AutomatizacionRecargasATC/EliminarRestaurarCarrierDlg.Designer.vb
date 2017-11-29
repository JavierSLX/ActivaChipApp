<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarRestaurarCarrierDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarRestaurarCarrierDlg))
        Me.TabCarrer = New System.Windows.Forms.TabControl()
        Me.TabSociosAcitvos = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGActivos = New System.Windows.Forms.DataGridView()
        Me.TabSociosInativos = New System.Windows.Forms.TabPage()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.DGInactivos = New System.Windows.Forms.DataGridView()
        Me.TabCarrer.SuspendLayout()
        Me.TabSociosAcitvos.SuspendLayout()
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSociosInativos.SuspendLayout()
        CType(Me.DGInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCarrer
        '
        Me.TabCarrer.Controls.Add(Me.TabSociosAcitvos)
        Me.TabCarrer.Controls.Add(Me.TabSociosInativos)
        Me.TabCarrer.Location = New System.Drawing.Point(12, 12)
        Me.TabCarrer.Name = "TabCarrer"
        Me.TabCarrer.SelectedIndex = 0
        Me.TabCarrer.Size = New System.Drawing.Size(330, 288)
        Me.TabCarrer.TabIndex = 1
        '
        'TabSociosAcitvos
        '
        Me.TabSociosAcitvos.Controls.Add(Me.BtnEliminar)
        Me.TabSociosAcitvos.Controls.Add(Me.DGActivos)
        Me.TabSociosAcitvos.Location = New System.Drawing.Point(4, 22)
        Me.TabSociosAcitvos.Name = "TabSociosAcitvos"
        Me.TabSociosAcitvos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSociosAcitvos.Size = New System.Drawing.Size(322, 262)
        Me.TabSociosAcitvos.TabIndex = 0
        Me.TabSociosAcitvos.Text = "Activos"
        Me.TabSociosAcitvos.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(231, 9)
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
        Me.DGActivos.Location = New System.Drawing.Point(10, 9)
        Me.DGActivos.Name = "DGActivos"
        Me.DGActivos.Size = New System.Drawing.Size(211, 247)
        Me.DGActivos.TabIndex = 2
        '
        'TabSociosInativos
        '
        Me.TabSociosInativos.Controls.Add(Me.BtnRestaurar)
        Me.TabSociosInativos.Controls.Add(Me.DGInactivos)
        Me.TabSociosInativos.Location = New System.Drawing.Point(4, 22)
        Me.TabSociosInativos.Name = "TabSociosInativos"
        Me.TabSociosInativos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSociosInativos.Size = New System.Drawing.Size(322, 262)
        Me.TabSociosInativos.TabIndex = 1
        Me.TabSociosInativos.Text = "Inactivos"
        Me.TabSociosInativos.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRestaurar.Location = New System.Drawing.Point(228, 16)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(88, 28)
        Me.BtnRestaurar.TabIndex = 1
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
        Me.DGInactivos.Location = New System.Drawing.Point(6, 16)
        Me.DGInactivos.Name = "DGInactivos"
        Me.DGInactivos.Size = New System.Drawing.Size(211, 238)
        Me.DGInactivos.TabIndex = 0
        '
        'EliminarRestaurarCarrierDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 301)
        Me.Controls.Add(Me.TabCarrer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EliminarRestaurarCarrierDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar/Restaurar Compañías Telefónicas"
        Me.TabCarrer.ResumeLayout(False)
        Me.TabSociosAcitvos.ResumeLayout(False)
        CType(Me.DGActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSociosInativos.ResumeLayout(False)
        CType(Me.DGInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCarrer As TabControl
    Friend WithEvents TabSociosAcitvos As TabPage
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGActivos As DataGridView
    Friend WithEvents TabSociosInativos As TabPage
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents DGInactivos As DataGridView
End Class
