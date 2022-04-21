<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNusuario = New System.Windows.Forms.TextBox()
        Me.txtNcontrasena = New System.Windows.Forms.TextBox()
        Me.txtCNcontrasena = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar contraseña:"
        '
        'txtNusuario
        '
        Me.txtNusuario.Location = New System.Drawing.Point(127, 38)
        Me.txtNusuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNusuario.Name = "txtNusuario"
        Me.txtNusuario.Size = New System.Drawing.Size(174, 20)
        Me.txtNusuario.TabIndex = 3
        '
        'txtNcontrasena
        '
        Me.txtNcontrasena.Location = New System.Drawing.Point(127, 71)
        Me.txtNcontrasena.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNcontrasena.Name = "txtNcontrasena"
        Me.txtNcontrasena.Size = New System.Drawing.Size(174, 20)
        Me.txtNcontrasena.TabIndex = 4
        '
        'txtCNcontrasena
        '
        Me.txtCNcontrasena.Location = New System.Drawing.Point(127, 100)
        Me.txtCNcontrasena.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCNcontrasena.Name = "txtCNcontrasena"
        Me.txtCNcontrasena.Size = New System.Drawing.Size(174, 20)
        Me.txtCNcontrasena.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 141)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 141)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Agregar Usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 177)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCNcontrasena)
        Me.Controls.Add(Me.txtNcontrasena)
        Me.Controls.Add(Me.txtNusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Registrar"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNusuario As TextBox
    Friend WithEvents txtNcontrasena As TextBox
    Friend WithEvents txtCNcontrasena As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
