Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=DMC;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub
    'JOSUE DAVID ARIAS MONTERO: "Data Source=localhost;Initial Catalog=Comparador;Integrated Security=True"
    'DIEGO ADRIAN ANGULO LEON: "Data Source=DMC;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
    'REICHEL MICHEL AVILA GARCIA: "Data Source=DESKTOP-U9MD6FG;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
    'SAYMON XAVIER ARAYA GARRO: "Data Source=DESKTOP-CKS2QM4;Initial Catalog=administrador;Integrated Security=True"
End Module