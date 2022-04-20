Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        lb1.Text = estado


        Dim buscartabla As String = "SELECT * FROM PERFIL "
        Dim basedatos As SqlDataAdapter
        Dim tabla As New DataTable
        Try
            basedatos = New SqlDataAdapter(buscartabla, conexion)
            basedatos.Fill(tabla)
            'Me.DataGridView = da
            DataGridView1.DataSource = tabla

            ' txt1.Text = String.Format("Total datos en la tabla:{0}", tabla.Rows.Count)


        Catch ex As Exception
            '  txt1.Text = "Error: " & ex.Message
        End Try
    End Sub

    Public Sub Mostrartabla()

        Dim buscartabla As String = "SELECT * FROM PERFIL "
        Dim basedatos As SqlDataAdapter
        Dim tabla As New DataTable
        Try
            basedatos = New SqlDataAdapter(buscartabla, conexion)
            basedatos.Fill(tabla)
            'Me.DataGridView = da
            DataGridView1.DataSource = tabla

            ' txt1.Text = String.Format("Total datos en la tabla:{0}", tabla.Rows.Count)


        Catch ex As Exception
            '  txt1.Text = "Error: " & ex.Message
        End Try


    End Sub
    Public Sub Agregartabla()
        Try
            Dim consulta As String = "INSERT INTO Perfil VALUES(@IMAGEN, @NOMBRE, @APELLIDO, @TELEFONO,@CORREOELECTRONICO,@USUARIO)"
            comando = New SqlClient.SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@IMAGEN", txtimg.Text.ToUpper)
            comando.Parameters.AddWithValue("@NOMBRE", txtnom.Text.ToUpper)
            comando.Parameters.AddWithValue("@APELLIDO", txtape.Text.ToUpper)
            comando.Parameters.AddWithValue("@TELEFONO", txtcel.Text.ToUpper)
            comando.Parameters.AddWithValue("@CORREOELECTRONICO", txtcorreo.Text.ToUpper)
            comando.Parameters.AddWithValue("@USUARIO", txtid.Text.ToUpper)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Id ya existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try
        'MsgBox("Listo")
    End Sub

    Public Sub Actualizar()
        Try
            Dim actualiza As String = "update Perfil Set Imagen='" & txtimg.Text & "', Nombre='" & txtnom.Text & "', Apellidos='" & txtape.Text & "', Telefono='" & txtcel.Text & "', CorreoElectronico='" & txtcorreo.Text & "' WHERE Usuario='" & txtid.Text & "'"
            comando = New SqlCommand(actualiza, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            'MsgBox("Listo")
        Catch ex As Exception
            MsgBox("Id no existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try
    End Sub
    Public Sub BUSCARID()
        Try
            Dim datos As New SqlDataAdapter("SELECT p.Imagen,p.Nombre,p.Apellidos,p.Telefono,p.CorreoElectronico,p.Usuario FROM Perfil p,Usuario u WHERE p.Usuario=u.id and  p.Usuario='" & txtid.Text & "'", conexion)
            Dim ds As New DataSet()
            datos.Fill(ds, "Perfil")
            txtimg.Text = ds.Tables("Perfil").Rows(0).Item(0)
            txtnom.Text = ds.Tables("Perfil").Rows(0).Item(1)
            txtape.Text = ds.Tables("Perfil").Rows(0).Item(2)
            txtcel.Text = ds.Tables("Perfil").Rows(0).Item(3)
            txtcorreo.Text = ds.Tables("Perfil").Rows(0).Item(4)


        Catch ex As Exception
            MsgBox("Id no existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Actualizar()
        Mostrartabla()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BUSCARID()
    End Sub
End Class