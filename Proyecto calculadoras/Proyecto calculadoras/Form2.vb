
Option Explicit On
Public Class Form2

#Region "Variables"
    'Tenemos 4 variables para realizar las 4 operaciones basicas, PrimerNum para almacenar el primer numero que hayamos escrito, SegundoNum para almacenar el segundo numero que hayamos escrito,
    'ResultadoNum para almacenar el resultado de la operacion entre las otras dos variables ,  y finalmente Operador para guardar el tipo de operacion que queremos que haga la calculadora.
    Dim PrimerNum As Double
    Dim SegundoNum As Double
    Dim ResultadoNum As Double
    Dim Operador As String
#End Region

#Region "Numeros"
    'Para cada boton de cada numero, del 0 al 9, un metodo que añadira dicho numero al TextBox
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        Txt1.Text = Txt1.Text & 1
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        Txt1.Text = Txt1.Text & 2
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        Txt1.Text = Txt1.Text & 3
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        Txt1.Text = Txt1.Text & 4
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        Txt1.Text = Txt1.Text & 5
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        Txt1.Text = Txt1.Text & 6
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        Txt1.Text = Txt1.Text & 7
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        Txt1.Text = Txt1.Text & 8
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        Txt1.Text = Txt1.Text & 9
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        Txt1.Text = Txt1.Text & 0
    End Sub
#End Region

#Region "Operaciones"
    '4 metodos , uno para cada operacion , cuando le demos ocurrira lo siguiente, almacenará el valor del textbox en PrimerNum, pondra vacio el textbox, y segun que operacion hayamos clickado
    'pondra +, -, *, / a la variable Operador.
    'El ultimo metodo es para sacar el resultado de la operacion , cogera el valor del textbox y lo metera en SegundoNum , segun que valor tenga la variable Operador hara una u otra operación,
    'pondra el valor en ResultadoNum y al final lo mostrará en el Textbox.
    Private Sub BtnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSumar.Click
        PrimerNum = Val(Txt1.Text)
        Txt1.Text = ""
        Operador = "+"
    End Sub

    Private Sub BtnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestar.Click
        PrimerNum = Val(Txt1.Text)
        Txt1.Text = ""
        Operador = "-"
    End Sub

    Private Sub BtnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicar.Click
        PrimerNum = Val(Txt1.Text)
        Txt1.Text = ""
        Operador = "X"
    End Sub

    Private Sub BtnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDividir.Click
        PrimerNum = Val(Txt1.Text)
        Txt1.Text = ""
        Operador = "/"
    End Sub


    Private Sub BtnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResultado.Click
        SegundoNum = Val(Txt1.Text)
        If Operador = "+" Then
            ResultadoNum = PrimerNum + SegundoNum
        End If
        If Operador = "-" Then
            ResultadoNum = PrimerNum - SegundoNum
        End If
        If Operador = "X" Then
            ResultadoNum = PrimerNum * SegundoNum
        End If
        If Operador = "/" Then
            ResultadoNum = PrimerNum / SegundoNum
        End If
        Txt1.Text = ResultadoNum
    End Sub

#End Region

#Region "Borrados"
    'Cuando presionemos el boton de borrar , pondra el textbox vacio y todas las variables a 0
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Txt1.Text = ""
        PrimerNum = 0
        SegundoNum = 0
        ResultadoNum = 0
    End Sub
#End Region

#Region "Otros"
    'Metodo para volver al Menú de las calculadoras y oculta esta calculadora
    Private Sub BtnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver1.Click
        Me.Hide()
        Form1.Show()
    End Sub
#End Region

End Class
