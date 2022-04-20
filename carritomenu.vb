Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class carritomenu
    Public horizontal As Integer = 130
    Public vertical As Integer = 61
    Public supern(99) As Label
    Public image(99) As Label
    Public descrpcion(99) As Label
    Public precio(99) As Label
    Public botonsuma(99) As Button
    Public botonresta(99) As Button
    Public botonborrar(99) As PictureBox
    Public campo(99) As Label
    Public total(99) As TextBox
    Public alamcenaid(99) As Integer
    Public restar As Integer = 0
    Public sumar As Integer = 0
    Public n As Integer = 0
    Public totalprecio(99) As TextBox
    Public suma As Integer = 0
    Public panel(99) As Panel
    Public verticalfondo As Integer = 55
    Public botonfinal(2) As PictureBox
    Public nprecio(99) As Label
    Public ntotal(99) As Label
    ' Public disponible(99) As Label
    'Dim TextBoxArray(6) As TextBox



    Public Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Clear()
        InitializeComponent()
        verticalfondo = 55
        For cargar = 1 To 99
            If menub.almacena(cargar) > 0 Then
                alamcenaid(cargar) = menub.almacena(cargar)
            End If
        Next
        For b = 1 To 20
            If menub.almacena(b) = 0 Then
                menub.almacena(b) = menub.almacena(b + 1)
                alamcenaid(b) = alamcenaid(b + 1)



            End If
        Next
        For z = 1 To 20
            If menub.almacena(z) = menub.almacena(z + 1) Then
                menub.almacena(z + 1) = 0
                alamcenaid(z + 1) = 0
            End If
        Next




        vertical = 61
        Try

            Dim a = 0
            For x = 1 To 20

                If menub.almacena(x) > 0 Then
                    Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE _id='" & menub.almacena(x) & "'", conexion)
                    Dim ds As New DataSet()
                    datos.Fill(ds, "Articulos")

                    panel(x) = New Panel
                    panel(x).BackColor = Color.White
                    panel(x).Size = New Size(900, 120)
                    ' panel(x).BackgroundImage = System.Drawing.Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\Imagenes\panelnu.jpg")
                    panel(x).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                    panel(x).Location = New Point(10, verticalfondo)
                    verticalfondo = verticalfondo + 130

                    image(x) = New Label
                    image(x).Image = System.Drawing.Image.FromFile(ds.Tables("Articulos").Rows(a).Item(3))
                    image(x).Size = New Size(95, 95)
                    image(x).Location = New Point(20, vertical)
                    Me.Controls.Add(image(x))

                    supern(x) = New Label
                    supern(x).Text = "Supermercado: " & ds.Tables("Articulos").Rows(a).Item(4)
                    supern(x).AutoSize = True

                    supern(x).TextAlign = ContentAlignment.TopLeft
                    supern(x).BorderStyle = BorderStyle.FixedSingle
                    supern(x).BorderStyle = FlatStyle.Flat
                    supern(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    supern(x).Location = New Point(horizontal, vertical)

                    Me.Controls.Add(supern(x))
                    vertical = vertical + 30

                    descrpcion(x) = New Label
                    descrpcion(x).Text = "Descripción: " & ds.Tables("Articulos").Rows(a).Item(1)
                    descrpcion(x).AutoSize = True
                    descrpcion(x).TextAlign = ContentAlignment.TopLeft
                    descrpcion(x).ForeColor = Color.Black
                    descrpcion(x).BorderStyle = BorderStyle.FixedSingle
                    descrpcion(x).BorderStyle = FlatStyle.Flat
                    descrpcion(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    descrpcion(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(descrpcion(x))
                    vertical = vertical + 30

                    nprecio(x) = New Label
                    nprecio(x).Text = "Precio:"
                    nprecio(x).AutoSize = True
                    nprecio(x).Location = New Point(horizontal, vertical)
                    nprecio(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    Me.Controls.Add(nprecio(x))

                    precio(x) = New Label
                    precio(x).Text = ds.Tables("Articulos").Rows(a).Item(2)
                    precio(x).AutoSize = True
                    precio(x).TextAlign = ContentAlignment.TopLeft
                    precio(x).BorderStyle = BorderStyle.FixedSingle
                    precio(x).BorderStyle = FlatStyle.Flat
                    precio(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    precio(x).Location = New Point(196.5, vertical)
                    Me.Controls.Add(precio(x))
                    vertical = vertical + 10

                    botonresta(x) = New Button
                    botonresta(x).Text = "-"
                    botonresta(x).BackgroundImageLayout = False
                    botonresta(x).Width = 40
                    botonresta(x).Height = 23
                    botonresta(x).Location = New Point(400, vertical)
                    Me.Controls.Add(botonresta(x))


                    campo(x) = New Label
                    campo(x).Text = 1
                    campo(x).BorderStyle = FlatStyle.Flat
                    campo(x).Width = 85
                    campo(x).Height = 23
                    campo(x).Enabled = False
                    campo(x).TextAlign = ContentAlignment.MiddleCenter
                    campo(x).Location = New Point(450, vertical)

                    Me.Controls.Add(campo(x))

                    ntotal(x) = New Label
                    ntotal(x).Text = "Total:"
                    ntotal(x).Width = 50
                    ntotal(x).Height = 19
                    ntotal(x).BorderStyle = FlatStyle.Flat
                    ntotal(x).Location = New Point(666, vertical)
                    Me.Controls.Add(ntotal(x))

                    total(x) = New TextBox
                    total(x).Text = campo(x).Text * precio(x).Text
                    total(x).Multiline = True
                    total(x).Width = 65
                    total(x).Height = 20
                    total(x).Enabled = False
                    total(x).Location = New Point(717, vertical)
                    Me.Controls.Add(total(x))

                    botonsuma(x) = New Button
                    botonsuma(x).Text = "+"
                    botonsuma(x).BackgroundImageLayout = False
                    botonsuma(x).Width = 40
                    botonsuma(x).Height = 23
                    botonsuma(x).Location = New Point(550, vertical)
                    Me.Controls.Add(botonsuma(x))

                    vertical = vertical - 30
                    botonborrar(x) = New PictureBox
                    botonborrar(x).Image = System.Drawing.Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\Imagenes\bs164.png")
                    botonborrar(x).Width = 64
                    botonborrar(x).Height = 64
                    botonborrar(x).Location = New Point(820, vertical)
                    botonborrar(x).BackColor = Color.White
                    Me.Controls.Add(botonborrar(x))
                    Me.Controls.Add(panel(x))



                    vertical = vertical + 90



                    '  totalprecio(1) = New TextBox
                    ' totalprecio(1).Text = suma
                    '  totalprecio(1).Width = 60
                    '  totalprecio(1).Height = 30
                    ' totalprecio(1).Location = New Point(800, 400)
                    '   Me.Controls.Add(totalprecio(1))

                    Select Case x
                        Case 1
                            AddHandler botonresta(1).Click, AddressOf Me.accion1
                            AddHandler botonsuma(1).Click, AddressOf Me.accions1
                            AddHandler botonborrar(1).Click, AddressOf Me.accionb1

                        Case 2
                            AddHandler botonresta(2).Click, AddressOf Me.accion2
                            AddHandler botonsuma(2).Click, AddressOf Me.accions2
                            AddHandler botonborrar(2).Click, AddressOf Me.accionb2
                        Case 3
                            AddHandler botonresta(3).Click, AddressOf Me.accion3
                            AddHandler botonsuma(3).Click, AddressOf Me.accions3
                            AddHandler botonborrar(3).Click, AddressOf Me.accionb3
                        Case 4
                            AddHandler botonresta(4).Click, AddressOf Me.accion4
                            AddHandler botonsuma(4).Click, AddressOf Me.accions4
                            AddHandler botonborrar(4).Click, AddressOf Me.accionb4
                        Case 5
                            AddHandler botonresta(5).Click, AddressOf Me.accion5
                            AddHandler botonsuma(5).Click, AddressOf Me.accions5
                            AddHandler botonborrar(5).Click, AddressOf Me.accionb5
                        Case 6
                            AddHandler botonresta(6).Click, AddressOf Me.accion6
                            AddHandler botonsuma(6).Click, AddressOf Me.accions6
                            AddHandler botonborrar(6).Click, AddressOf Me.accionb6
                        Case 7
                            AddHandler botonresta(7).Click, AddressOf Me.accion7
                            AddHandler botonsuma(7).Click, AddressOf Me.accions7
                            AddHandler botonborrar(7).Click, AddressOf Me.accionb7
                        Case 8
                            AddHandler botonresta(8).Click, AddressOf Me.accion8
                            AddHandler botonsuma(8).Click, AddressOf Me.accions8
                            AddHandler botonborrar(8).Click, AddressOf Me.accionb8
                        Case 9
                            AddHandler botonresta(9).Click, AddressOf Me.accion9
                            AddHandler botonsuma(9).Click, AddressOf Me.accions9
                            AddHandler botonborrar(9).Click, AddressOf Me.accionb9
                        Case 10
                            AddHandler botonresta(10).Click, AddressOf Me.accion10
                            AddHandler botonsuma(10).Click, AddressOf Me.accions10
                            AddHandler botonborrar(10).Click, AddressOf Me.accionb10
                        Case 11
                            AddHandler botonresta(11).Click, AddressOf Me.accion11
                            AddHandler botonsuma(11).Click, AddressOf Me.accions11
                            AddHandler botonborrar(11).Click, AddressOf Me.accionb11
                        Case 12
                            AddHandler botonresta(12).Click, AddressOf Me.accion12
                            AddHandler botonsuma(12).Click, AddressOf Me.accions12
                            AddHandler botonborrar(12).Click, AddressOf Me.accionb12
                        Case 13
                            AddHandler botonresta(13).Click, AddressOf Me.accion13
                            AddHandler botonsuma(13).Click, AddressOf Me.accions13
                            AddHandler botonborrar(13).Click, AddressOf Me.accionb13
                        Case 14
                            AddHandler botonresta(14).Click, AddressOf Me.accion14
                            AddHandler botonsuma(14).Click, AddressOf Me.accions14
                            AddHandler botonborrar(14).Click, AddressOf Me.accionb14
                        Case 15
                            AddHandler botonresta(15).Click, AddressOf Me.accion15
                            AddHandler botonsuma(15).Click, AddressOf Me.accions15
                            AddHandler botonborrar(15).Click, AddressOf Me.accionb15
                        Case 16
                            AddHandler botonresta(16).Click, AddressOf Me.accion16
                            AddHandler botonsuma(16).Click, AddressOf Me.accions16
                            AddHandler botonborrar(16).Click, AddressOf Me.accionb16
                        Case 17
                            AddHandler botonresta(17).Click, AddressOf Me.accion17
                            AddHandler botonsuma(17).Click, AddressOf Me.accions17
                            AddHandler botonborrar(17).Click, AddressOf Me.accionb17
                        Case 18
                            AddHandler botonresta(18).Click, AddressOf Me.accion18
                            AddHandler botonsuma(18).Click, AddressOf Me.accions18
                            AddHandler botonborrar(18).Click, AddressOf Me.accionb18
                        Case 19
                            AddHandler botonresta(19).Click, AddressOf Me.accion19
                            AddHandler botonsuma(19).Click, AddressOf Me.accions19
                            AddHandler botonborrar(19).Click, AddressOf Me.accionb19
                        Case 20
                            AddHandler botonresta(20).Click, AddressOf Me.accion20
                            AddHandler botonsuma(20).Click, AddressOf Me.accions20
                            AddHandler botonborrar(20).Click, AddressOf Me.accionb20
                        Case Else

                    End Select
                    n = x





                End If

            Next

            botonfinal(1) = New PictureBox
            botonfinal(1).Image = System.Drawing.Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\Imagenes\cancelap.jpg")
            botonfinal(1).Width = 147
            botonfinal(1).Height = 37
            botonfinal(1).Location = New Point(525, vertical)
            Me.Controls.Add(botonfinal(1))

            botonfinal(2) = New PictureBox
            botonfinal(2).Image = System.Drawing.Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\Imagenes\btcont.jpg")
            botonfinal(2).BackgroundImageLayout = ImageLayout.Stretch
            botonfinal(2).Width = 240
            botonfinal(2).Height = 37
            botonfinal(2).Location = New Point(685, vertical)
            Me.Controls.Add(botonfinal(2))
            AddHandler botonfinal(1).Click, AddressOf Me.accionbf1
            AddHandler botonfinal(2).Click, AddressOf Me.accionbf2
        Catch ex As Exception
            '  MsgBox("Id no existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try

    End Sub

    Public Sub restarn()
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
            totalprecio(1).Text = total(restar).Text
        End If

    End Sub
    Public Sub suman()
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Public Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 1
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 2
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 3
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 4
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 5
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 6
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 7
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 8
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 9
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 10
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 11
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 12
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 13
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 14
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 15
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 16
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 17
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 18
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 19
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Public Sub accion20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 20
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub


    Public Sub accions1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 1
        If campo(1).Text < 20 Then
            campo(1).Text = campo(1).Text + 1
            total(1).Text = campo(1).Text * precio(sumar).Text
        End If
        TOTALFINAl()
    End Sub
    Public Sub accions2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 2
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 3
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 4
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 5
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 6
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 7
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 8
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 9
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 10
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 11
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 12
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Public Sub accions13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 13
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 14
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Public Sub accions15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 15
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 16
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 17
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 18
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 19
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accions20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 20
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accionb1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 1
        menub.almacena(x) = 0

        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 2
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 3
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 4
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '    InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 5
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        ' InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 6
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 7
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 8
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 9
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '     Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 10
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '    Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 11
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '    InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 12
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '    Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 13
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '    InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 14
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '   Me.Controls.Clear()
        '    InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 15
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '    Me.Controls.Clear()
        '    InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 16
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 17
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 18
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 19
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '    Me.Controls.Clear()
        '   InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 20
        menub.almacena(x) = 0
        alamcenaid(x) = 0
        '  Me.Controls.Clear()
        '  InitializeComponent()
        Form5_Load(e, e)
    End Sub

    Public Sub accionbf1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For I = 1 To n

            If alamcenaid(I) = 0 Then
                image(I).Dispose()
                image(I).Dispose()
                descrpcion(I).Dispose()
                precio(I).Dispose()
                campo(I).Dispose()
                total(I).Dispose()
                'totalprecio(I).Visible = False
                botonborrar(I).Dispose()
                botonresta(I).Dispose()
                botonsuma(I).Dispose()



            Else
                menub.almacena(I) = alamcenaid(I)


            End If

        Next
        Me.Hide()

        menub.Show()
    End Sub
    Public Sub accionbf2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Facturacion.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For I = 1 To n


            menub.almacena(I) = alamcenaid(I)




        Next
        Me.Hide()

        menub.Show()

    End Sub
    Private Sub carga(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub

    Private Sub Form5_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ' Form5_Load(e, e)
    End Sub

    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Me.Refresh()
    End Sub

    Public Sub TOTALFINAl()
        For x = 1 To n
            suma = suma + total(x).Text

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Facturacion.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        For I = 1 To n

            If alamcenaid(I) = 0 Then
                image(I).Dispose()
                image(I).Dispose()
                descrpcion(I).Dispose()
                precio(I).Dispose()
                campo(I).Dispose()
                total(I).Dispose()
                'totalprecio(I).Visible = False
                botonborrar(I).Dispose()
                botonresta(I).Dispose()
                botonsuma(I).Dispose()



            Else
                menub.almacena(I) = alamcenaid(I)


            End If

        Next
        Me.Hide()

        menub.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Facturacion.Show()
    End Sub
End Class