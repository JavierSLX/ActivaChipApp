<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginDlg))
        Me.LbNick = New System.Windows.Forms.Label()
        Me.TbxNick = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TbxPass = New System.Windows.Forms.TextBox()
        Me.BtnAcceso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNick
        '
        Me.LbNick.AutoSize = True
        Me.LbNick.Location = New System.Drawing.Point(12, 20)
        Me.LbNick.Name = "LbNick"
        Me.LbNick.Size = New System.Drawing.Size(29, 13)
        Me.LbNick.TabIndex = 0
        Me.LbNick.Text = "Nick"
        '
        'TbxNick
        '
        Me.TbxNick.Location = New System.Drawing.Point(71, 17)
        Me.TbxNick.Name = "TbxNick"
        Me.TbxNick.Size = New System.Drawing.Size(195, 20)
        Me.TbxNick.TabIndex = 0
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(12, 53)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(53, 13)
        Me.LbPassword.TabIndex = 2
        Me.LbPassword.Text = "Password"
        '
        'TbxPass
        '
        Me.TbxPass.Location = New System.Drawing.Point(71, 50)
        Me.TbxPass.Name = "TbxPass"
        Me.TbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPass.Size = New System.Drawing.Size(195, 20)
        Me.TbxPass.TabIndex = 1
        '
        'BtnAcceso
        '
        Me.BtnAcceso.Image = Global.AutomatizacionRecargasATC.My.Resources.Resources.aceptar
        Me.BtnAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAcceso.Location = New System.Drawing.Point(100, 76)
        Me.BtnAcceso.Name = "BtnAcceso"
        Me.BtnAcceso.Size = New System.Drawing.Size(75, 23)
        Me.BtnAcceso.TabIndex = 2
        Me.BtnAcceso.Text = "Entrar"
        Me.BtnAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAcceso.UseVisualStyleBackColor = True
        '
        'LoginDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 121)
        Me.Controls.Add(Me.BtnAcceso)
        Me.Controls.Add(Me.TbxPass)
        Me.Controls.Add(Me.LbPassword)
        Me.Controls.Add(Me.TbxNick)
        Me.Controls.Add(Me.LbNick)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNick As Label
    Friend WithEvents TbxNick As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents TbxPass As TextBox
    Friend WithEvents BtnAcceso As Button
End Class
