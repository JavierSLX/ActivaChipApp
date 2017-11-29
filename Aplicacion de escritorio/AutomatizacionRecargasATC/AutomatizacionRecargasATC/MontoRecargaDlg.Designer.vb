<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MontoRecargaDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MontoRecargaDlg))
        Me.CBEmpresa = New System.Windows.Forms.ComboBox()
        Me.LbEmpresa = New System.Windows.Forms.Label()
        Me.TabMonto = New System.Windows.Forms.TabControl()
        Me.Asignados = New System.Windows.Forms.TabPage()
        Me.DGAsignado = New System.Windows.Forms.DataGridView()
        Me.TabSinAsignar = New System.Windows.Forms.TabPage()
        Me.DGSinAsignar = New System.Windows.Forms.DataGridView()
        Me.GBCarrier = New System.Windows.Forms.GroupBox()
        Me.CBMonto = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LbCarrier = New System.Windows.Forms.Label()
        Me.LbMonto = New System.Windows.Forms.Label()
        Me.TbxCarrier = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TabMonto.SuspendLayout()
        Me.Asignados.SuspendLayout()
        CType(Me.DGAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSinAsignar.SuspendLayout()
        CType(Me.DGSinAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCarrier.SuspendLayout()
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
        Me.LbEmpresa.TabIndex = 6
        Me.LbEmpresa.Text = "Empresa"
        '
        'TabMonto
        '
        Me.TabMonto.Controls.Add(Me.Asignados)
        Me.TabMonto.Controls.Add(Me.TabSinAsignar)
        Me.TabMonto.Location = New System.Drawing.Point(12, 33)
        Me.TabMonto.Name = "TabMonto"
        Me.TabMonto.SelectedIndex = 0
        Me.TabMonto.Size = New System.Drawing.Size(222, 266)
        Me.TabMonto.TabIndex = 2
        '
        'Asignados
        '
        Me.Asignados.Controls.Add(Me.DGAsignado)
        Me.Asignados.Location = New System.Drawing.Point(4, 22)
        Me.Asignados.Name = "Asignados"
        Me.Asignados.Padding = New System.Windows.Forms.Padding(3)
        Me.Asignados.Size = New System.Drawing.Size(214, 240)
        Me.Asignados.TabIndex = 0
        Me.Asignados.Text = "Monto Asignado"
        Me.Asignados.UseVisualStyleBackColor = True
        '
        'DGAsignado
        '
        Me.DGAsignado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAsignado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGAsignado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAsignado.Location = New System.Drawing.Point(6, 8)
        Me.DGAsignado.Name = "DGAsignado"
        Me.DGAsignado.Size = New System.Drawing.Size(202, 226)
        Me.DGAsignado.TabIndex = 0
        '
        'TabSinAsignar
        '
        Me.TabSinAsignar.Controls.Add(Me.DGSinAsignar)
        Me.TabSinAsignar.Location = New System.Drawing.Point(4, 22)
        Me.TabSinAsignar.Name = "TabSinAsignar"
        Me.TabSinAsignar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSinAsignar.Size = New System.Drawing.Size(214, 240)
        Me.TabSinAsignar.TabIndex = 1
        Me.TabSinAsignar.Text = "Sin Asignar Monto"
        Me.TabSinAsignar.UseVisualStyleBackColor = True
        '
        'DGSinAsignar
        '
        Me.DGSinAsignar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSinAsignar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSinAsignar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGSinAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSinAsignar.Location = New System.Drawing.Point(8, 8)
        Me.DGSinAsignar.Name = "DGSinAsignar"
        Me.DGSinAsignar.Size = New System.Drawing.Size(200, 225)
        Me.DGSinAsignar.TabIndex = 0
        '
        'GBCarrier
        '
        Me.GBCarrier.Controls.Add(Me.CBMonto)
        Me.GBCarrier.Controls.Add(Me.BtnGuardar)
        Me.GBCarrier.Controls.Add(Me.LbCarrier)
        Me.GBCarrier.Controls.Add(Me.LbMonto)
        Me.GBCarrier.Controls.Add(Me.TbxCarrier)
        Me.GBCarrier.Location = New System.Drawing.Point(236, 57)
        Me.GBCarrier.Name = "GBCarrier"
        Me.GBCarrier.Size = New System.Drawing.Size(209, 106)
        Me.GBCarrier.TabIndex = 1
        Me.GBCarrier.TabStop = False
        Me.GBCarrier.Text = "Datos de la Recarga"
        '
        'CBMonto
        '
        Me.CBMonto.FormattingEnabled = True
        Me.CBMonto.Location = New System.Drawing.Point(63, 44)
        Me.CBMonto.Name = "CBMonto"
        Me.CBMonto.Size = New System.Drawing.Size(72, 21)
        Me.CBMonto.TabIndex = 8
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(57, 70)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LbCarrier
        '
        Me.LbCarrier.AutoSize = True
        Me.LbCarrier.Location = New System.Drawing.Point(6, 21)
        Me.LbCarrier.Name = "LbCarrier"
        Me.LbCarrier.Size = New System.Drawing.Size(56, 13)
        Me.LbCarrier.TabIndex = 13
        Me.LbCarrier.Text = "Compañía"
        '
        'LbMonto
        '
        Me.LbMonto.AutoSize = True
        Me.LbMonto.Location = New System.Drawing.Point(6, 51)
        Me.LbMonto.Name = "LbMonto"
        Me.LbMonto.Size = New System.Drawing.Size(37, 13)
        Me.LbMonto.TabIndex = 16
        Me.LbMonto.Text = "Monto"
        '
        'TbxCarrier
        '
        Me.TbxCarrier.Location = New System.Drawing.Point(63, 18)
        Me.TbxCarrier.Name = "TbxCarrier"
        Me.TbxCarrier.Size = New System.Drawing.Size(140, 20)
        Me.TbxCarrier.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(324, 6)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'MontoRecargaDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 307)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GBCarrier)
        Me.Controls.Add(Me.TabMonto)
        Me.Controls.Add(Me.CBEmpresa)
        Me.Controls.Add(Me.LbEmpresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MontoRecargaDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Montos Mínimos de Recarga"
        Me.TabMonto.ResumeLayout(False)
        Me.Asignados.ResumeLayout(False)
        CType(Me.DGAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSinAsignar.ResumeLayout(False)
        CType(Me.DGSinAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCarrier.ResumeLayout(False)
        Me.GBCarrier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEmpresa As ComboBox
    Friend WithEvents LbEmpresa As Label
    Friend WithEvents TabMonto As TabControl
    Friend WithEvents Asignados As TabPage
    Friend WithEvents DGAsignado As DataGridView
    Friend WithEvents TabSinAsignar As TabPage
    Friend WithEvents DGSinAsignar As DataGridView
    Friend WithEvents GBCarrier As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LbCarrier As Label
    Friend WithEvents LbMonto As Label
    Friend WithEvents TbxCarrier As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CBMonto As ComboBox
End Class
