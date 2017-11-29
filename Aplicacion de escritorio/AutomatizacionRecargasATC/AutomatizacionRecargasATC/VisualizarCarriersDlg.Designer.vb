<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarCarriersDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarCarriersDlg))
        Me.DGCarrier = New System.Windows.Forms.DataGridView()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TbxNombre = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGCarrier
        '
        Me.DGCarrier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCarrier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGCarrier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGCarrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCarrier.Location = New System.Drawing.Point(15, 6)
        Me.DGCarrier.Name = "DGCarrier"
        Me.DGCarrier.Size = New System.Drawing.Size(183, 206)
        Me.DGCarrier.TabIndex = 1
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(10, 24)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 2
        Me.LbNombre.Text = "Nombre"
        '
        'TbxNombre
        '
        Me.TbxNombre.Location = New System.Drawing.Point(57, 19)
        Me.TbxNombre.Name = "TbxNombre"
        Me.TbxNombre.Size = New System.Drawing.Size(137, 20)
        Me.TbxNombre.TabIndex = 3
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(60, 45)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 28)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbxNombre)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.LbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 84)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compañia Telefónica"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.cargar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(317, 5)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 28)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'VisualizarCarriersDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 230)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGCarrier)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VisualizarCarriersDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compañías Telefónicas"
        CType(Me.DGCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGCarrier As DataGridView
    Friend WithEvents LbNombre As Label
    Friend WithEvents TbxNombre As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLimpiar As Button
End Class
