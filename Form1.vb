Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Imports System.Data

Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Bitmap
Public Class form1
    Public Catalogo As String
    Public cnn As New SqlConnection
    Public boton(99) As Button
    Public botonborrar(99) As Button
    Public ID(99) As Label
    Public superf3(99) As Label
    Public descrpcionf3(99) As Label
    Public preciof3(99) As Label
    Public imagex(99) As Label
    Public fondo(99) As Label
    Public vertical As Integer = 85
    Public horizontal As Integer = 300
    Public verticalimg As Integer = 85
    Public horizontalimg As Integer = 200


    Public busca As Integer = 0
    Public n As Integer = 0
    Public car As Integer = 1
    Public nuevon As Integer = 0
    Public super(99) As Label
    Public descrpcion(99) As Label
    Public precio(99) As Label
    Public disponible(99) As Label

    Public almacena(99) As String
    Private Sub CatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub filtro()
        Limpiar()


        Try
            Dim datos As New SqlDataAdapter("SELECT * FROM Articulos WHERE Nombre= '" & Catalogo & "'", conexion)
            Dim ds As New DataSet()
            datos.Fill(ds, "Articulos")


            Dim a = 0
            For x = 1 To 6



                imagex(x) = New Label
                imagex(x).Image = System.Drawing.Image.FromFile(ds.Tables("Articulos").Rows(a).Item(3))
                imagex(x).Size = New Size(100, 100)
                imagex(x).Location = New Point(horizontalimg, verticalimg)
                Me.Controls.Add(imagex(x))



                ID(x) = New Label
                ID(x).Text = ds.Tables("Articulos").Rows(a).Item(6)
                ID(x).TextAlign = ContentAlignment.MiddleCenter
                ID(x).BorderStyle = BorderStyle.FixedSingle
                ID(x).Font = New Font("Arial", 9, FontStyle.Bold)
                ID(x).Location = New Point(horizontal + 120, vertical)

                Me.Controls.Add(ID(x))
                ID(x).Visible = False
                '  Me.Controls.Add(panel)
                superf3(x) = New Label
                superf3(x).Text = ds.Tables("Articulos").Rows(a).Item(4)
                superf3(x).TextAlign = ContentAlignment.MiddleCenter
                superf3(x).BorderStyle = BorderStyle.FixedSingle
                superf3(x).Font = New Font("Arial", 9, FontStyle.Bold)
                superf3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(superf3(x))
                vertical = vertical + 30

                descrpcionf3(x) = New Label
                descrpcionf3(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                descrpcionf3(x).TextAlign = ContentAlignment.MiddleCenter
                descrpcionf3(x).BorderStyle = BorderStyle.FixedSingle
                descrpcionf3(x).Font = New Font("Arial", 9, FontStyle.Bold)
                descrpcionf3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(descrpcionf3(x))
                vertical = vertical + 30

                preciof3(x) = New Label
                preciof3(x).Text = ds.Tables("Articulos").Rows(a).Item(2)
                preciof3(x).TextAlign = ContentAlignment.MiddleCenter
                preciof3(x).BorderStyle = BorderStyle.FixedSingle
                preciof3(x).Font = New Font("Arial", 9, FontStyle.Bold)
                preciof3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(preciof3(x))
                vertical = vertical + 30

                boton(x) = New Button
                boton(x).Text = "Agregar"
                boton(x).Font = New Font("Arial", 12, FontStyle.Bold)
                boton(x).Width = 80
                boton(x).Height = 30
                boton(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(boton(x))



                a = a + 1
                horizontal = horizontal + 300
                horizontalimg = horizontalimg + 300
                vertical = vertical - 90
                If x Mod 2 = 0 Then
                    horizontal = 300
                    horizontalimg = 200
                    vertical = vertical + 150
                    verticalimg = verticalimg + 150
                End If
                Select Case x
                    Case 1
                        AddHandler boton(1).Click, AddressOf Me.accion1

                    Case 2
                        AddHandler boton(2).Click, AddressOf Me.accion2
                    Case 3
                        AddHandler boton(3).Click, AddressOf Me.accion3
                    Case 4
                        AddHandler boton(4).Click, AddressOf Me.accion4
                    Case 5
                        AddHandler boton(5).Click, AddressOf Me.accion5
                    Case 6
                        AddHandler boton(6).Click, AddressOf Me.accion6
                    Case Else

                End Select

                n = x

            Next
        Catch ex As Exception

        End Try



    End Sub

    Private Sub accionb1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = ID(1).Text Then
                almacena(c) = 0

                c = 100
            End If

        Next



    End Sub
    Private Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(1).Text

                c = 100
            End If

        Next



    End Sub



    Private Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(2).Text

                c = 100
            End If

        Next


    End Sub
    Private Sub accion3(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(3).Text

                c = 100
            End If

        Next


    End Sub
    Private Sub accion4(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(4).Text

                c = 100
            End If

        Next


    End Sub
    Private Sub accion5(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(5).Text

                c = 100
            End If

        Next


    End Sub
    Private Sub accion6(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(6).Text

                c = 100
            End If

        Next


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buscar.Click


        Limpiar()
        Catalogo = txtbusqueda.Text

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300

    End Sub



    Private Sub Limpiar()


        For i = 1 To n
            If busca > 0 Then
                If superf3(i).Text <> "" Then
                    superf3(i).Visible = False
                    descrpcionf3(i).Visible = False
                    preciof3(i).Visible = False
                    ID(i).Visible = False
                    boton(i).Visible = False
                    imagex(i).Visible = False

                End If
            End If

        Next

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        enlace()

        LABEL99.Text = estado


    End Sub


    Private Sub AguaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AguaToolStripMenuItem.Click
        Limpiar()

        Catalogo = "agua"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub ArrozToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrozToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Arroz"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub AzucarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzucarToolStripMenuItem.Click
        Limpiar()
        Catalogo = "azucar"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub CafeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CafeToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Cafe"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub CelularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelularesToolStripMenuItem.Click
        Limpiar()
        Catalogo = "celular"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub ConsolasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Limpiar()
        Catalogo = "celular"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub ConsolasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConsolasToolStripMenuItem.Click
        Limpiar()
        Catalogo = "consola"
        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub DesinfectantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesinfectantesToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Desinfectante"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub HuevosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuevosToolStripMenuItem.Click
        Limpiar()
        Catalogo = "huevos"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub JabonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JabonToolStripMenuItem.Click
        Limpiar()
        Catalogo = "jabon"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub JamonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JamonToolStripMenuItem.Click
        Limpiar()
        Catalogo = "jamon"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub JuegosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegosToolStripMenuItem.Click
        Limpiar()
        Catalogo = "juego"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub LactocremaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LactocremaToolStripMenuItem.Click
        Limpiar()
        Catalogo = "lactocrema"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub LecheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LecheToolStripMenuItem.Click
        Limpiar()
        Catalogo = "leche"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        Limpiar()
        Catalogo = "libro"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub LineaBlancaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineaBlancaToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Linea blanca"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub NatillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NatillaToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Natilla"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub PanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Pan"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub QuesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuesoToolStripMenuItem.Click
        Limpiar()
        Catalogo = "queso"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub PastaDeDientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastaDeDientesToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Pasta de Dientes"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub RopaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RopaToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Ropa"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub

    Private Sub SalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalToolStripMenuItem.Click
        Limpiar()
        Catalogo = "Sal"

        horizontalimg = 200
        verticalimg = 85
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 300
    End Sub
End Class