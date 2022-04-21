Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Facturacion
    Public descripcion(99) As Label
    Public subtotall(99) As Label
    Public impuestol(99) As Label
    Public totall(99) As Label
    Public subtotaln(99) As TextBox
    Public impueston(99) As TextBox
    Public totaln(99) As TextBox
    Public pagar(99) As Button
    Public cancelar(99) As Button
    Public codigo As Integer = 1

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Vertical = 50

        Try
            lb2.Text = codigo


            Dim a = 0

            For x = 1 To 20

                If Form10.almacena(x) > 0 Then
                    Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE _id='" & carritomenu.alamcenaid(x) & "'", conexion)
                    Dim ds As New DataSet()
                    datos.Fill(ds, "Articulos")

                    descripcion(x) = New Label
                    descripcion(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                    descripcion(x).Size = New Size(100, 20)
                    descripcion(x).Location = New Point(100, Vertical)
                    Me.Controls.Add(descripcion(x))
                    Vertical = Vertical + 20
                End If
            Next
            Dim n = 1
            Dim suma = 0
            Dim alm = 0
            For n = 1 To carritomenu.n

                suma = carritomenu.total(n).Text
                alm = alm + suma
                suma = 0


            Next
            subtotall(n) = New Label
            subtotall(n).Text = "subtotal:"
            subtotall(n).Location = New Point(5, Vertical)
            Me.Controls.Add(subtotall(n))

            subtotaln(n) = New TextBox
            subtotaln(n).Text = alm
            subtotaln(n).Location = New Point(105, Vertical)
            Me.Controls.Add(subtotaln(n))


            Vertical = Vertical + 20
            impuestol(n) = New Label
            impuestol(n).Text = "Impuesto:"
            impuestol(n).Location = New Point(5, Vertical)
            Me.Controls.Add(impuestol(n))

            impueston(n) = New TextBox
            impueston(n).Text = alm * 0.13
            impueston(n).Location = New Point(105, Vertical)
            Me.Controls.Add(impueston(n))

            Vertical = Vertical + 20
            totall(n) = New Label
            totall(n).Text = "Total:"
            totall(n).Location = New Point(5, Vertical)
            Me.Controls.Add(totall(n))

            totaln(n) = New TextBox
            totaln(n).Text = alm + (alm * 0.13)
            totaln(n).Location = New Point(105, Vertical)
            Me.Controls.Add(totaln(n))






        Catch ex As Exception

        End Try

        Vertical = Vertical + 40
        cancelar(1) = New Button
        cancelar(1).Text = "cancelar"
        cancelar(1).Width = 60
        cancelar(1).Height = 25
        cancelar(1).Location = New Point(100, Vertical)
        Me.Controls.Add(cancelar(1))

        pagar(1) = New Button
        pagar(1).Text = "pagar"
        pagar(1).Width = 60
        pagar(1).Height = 25
        pagar(1).Location = New Point(175, Vertical)
        Me.Controls.Add(pagar(1))

        AddHandler pagar(1).Click, AddressOf Me.accion1
        AddHandler cancelar(1).Click, AddressOf Me.accion2


        ' que llame la descripcion del producto
        '  Dim suma = 0
        '  Dim alm = 0
        ' For x = 1 To carritomenu.n

        '  suma = carritomenu.total(x).Text
        '  alm = alm + suma
        '     suma = 0
        '    subtotal.Text = alm

        '   Next
        '   TOTAL.Text = subtotal.Text + (subtotal.Text * 0.13)
    End Sub

    Public Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Compra Exitosa")
        Me.Hide()
        Form10.Show()
        For x = 1 To carritomenu.n
            Form10.almacena(x) = 0
            carritomenu.alamcenaid(x) = 0
        Next
        Form10.Form1_Load(e, e)
    End Sub
    Public Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        carritomenu.Show()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subtotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LB1.Click

    End Sub
End Class