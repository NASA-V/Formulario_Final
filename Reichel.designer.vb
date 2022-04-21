<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reichel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numTa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cvv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(63, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metodo De Pago"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(46, 160)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(181, 20)
        Me.nombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(46, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numero de tarjeta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(46, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre"
        '
        'numTa
        '
        Me.numTa.Location = New System.Drawing.Point(46, 227)
        Me.numTa.Name = "numTa"
        Me.numTa.Size = New System.Drawing.Size(181, 20)
        Me.numTa.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(46, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha de vencimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(214, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "CVV"
        '
        'cvv
        '
        Me.cvv.Location = New System.Drawing.Point(195, 300)
        Me.cvv.Name = "cvv"
        Me.cvv.Size = New System.Drawing.Size(76, 20)
        Me.cvv.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(19, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(214, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(46, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(46, 348)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(206, 28)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Eliminar metodo de pago"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(46, 381)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 19)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Agregar Metodo de Pago"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(53, 300)
        Me.fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fecha.Mask = "00/00"
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(56, 20)
        Me.fecha.TabIndex = 16
        '
        'Reichel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 488)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cvv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numTa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reichel"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numTa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cvv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents fecha As MaskedTextBox
End Class
