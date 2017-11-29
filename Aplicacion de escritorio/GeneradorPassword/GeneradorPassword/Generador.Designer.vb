<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generador
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
        Me.DGPassword = New System.Windows.Forms.DataGridView()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Encriptado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Script = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        CType(Me.DGPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGPassword
        '
        Me.DGPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGPassword.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGPassword.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPassword.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario, Me.Password, Me.Encriptado, Me.Script})
        Me.DGPassword.Location = New System.Drawing.Point(12, 33)
        Me.DGPassword.Name = "DGPassword"
        Me.DGPassword.Size = New System.Drawing.Size(916, 421)
        Me.DGPassword.TabIndex = 0
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 68
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.Width = 78
        '
        'Encriptado
        '
        Me.Encriptado.HeaderText = "Encriptado"
        Me.Encriptado.Name = "Encriptado"
        Me.Encriptado.Width = 83
        '
        'Script
        '
        Me.Script.HeaderText = "Script"
        Me.Script.Name = "Script"
        Me.Script.Width = 59
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(169, 4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerar.TabIndex = 1
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Generador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 475)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.DGPassword)
        Me.Name = "Generador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Password"
        CType(Me.DGPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGPassword As DataGridView
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Encriptado As DataGridViewTextBoxColumn
    Friend WithEvents Script As DataGridViewTextBoxColumn
End Class
