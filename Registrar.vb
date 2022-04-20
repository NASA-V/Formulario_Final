Public Class Registrar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As String = txtNcontrasena.Text
        Dim n As String = txtCNcontrasena.Text
        If (x = n) Then
            Try
                Dim consulta As String = "INSERT INTO USUARIO VALUES(@USUARIO, @CONTRASENA)"
                comando = New SqlClient.SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@USUARIO", txtNusuario.Text.ToUpper)
                comando.Parameters.AddWithValue("@CONTRASENA", txtNcontrasena.Text.ToUpper)
                comando.ExecuteNonQuery()
                MsgBox("Usuario agregado")
                Login.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Id ya existe")
            End Try
        Else
            MsgBox("Contraseña incorrecta")
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()

    End Sub
End Class