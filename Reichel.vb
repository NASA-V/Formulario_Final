Imports System.Data.SqlClient

Public Class Reichel
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fechav As String = Me.fecha.Text
            Dim num As Long = Long.Parse(numTa.Text)
            Dim cvv As String = Me.cvv.Text
            Dim nom As String = Me.nombre.Text
            Dim query As String = "update Metodo_de_Pago set Nombre =@nombre, [Fecha de Vencimiento] = @fechav, CVV = @cvv where [Numero de Tarjeta] = @num"
            comando = New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@num", num)
            comando.Parameters.AddWithValue("@nombre", nom)
            comando.Parameters.AddWithValue("@fechav", fechav)
            comando.Parameters.AddWithValue("@cvv", cvv)
            Dim n As Integer = comando.ExecuteNonQuery()
            If (n > 0) Then
                MsgBox("Metodo de pago actualizado Correctamente")
                ''Form3.Show()
                Me.Hide()

            Else
                MsgBox("Error al actualizar el metodo de pago" & n)

            End If

        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim fechav As String = Me.fecha.Text
            Dim num As Long = Long.Parse(numTa.Text)
            Dim cvv As String = Me.cvv.Text
            Dim nom As String = Me.nombre.Text
            Dim query As String = "insert into Metodo_de_Pago([Numero de Tarjeta],[Nombre], [Fecha de Vencimiento], [CVV]) values(@num, @nombre, @fechav, @cvv)"
            comando = New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@num", num)
            comando.Parameters.AddWithValue("@nombre", nom)
            comando.Parameters.AddWithValue("@fechav", fechav)
            comando.Parameters.AddWithValue("@cvv", cvv)
            Dim n As Integer = comando.ExecuteNonQuery()
            If (n > 0) Then
                MsgBox("Metodo de pago agregado Correctamente")
                ''Form3.Show()
                Me.Hide()

            Else
                MsgBox("Error al agregar metodo de pago" & n)

            End If

        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Long = Long.Parse(numTa.Text)
        Dim query As String = "delete from Metodo_de_Pago where [Numero de Tarjeta] = @num "
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@num", num)
        Dim n As Integer = comando.ExecuteNonQuery()
        If (n > 0) Then
            MsgBox("Metodo de pago eliminado Correctamente")
            ''Form3.Show()
            Me.Hide()

        Else
            MsgBox("Error al eliminar el metodo de pago" & n)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.fecha.Text = ""
        numTa.Text = ""
        Me.cvv.Text = ""
        Me.nombre.Text = ""
        MsgBox("Formulario limpiado Correctamente")
    End Sub
End Class
