Public Class Form3

#Region "Variables"

    'Tenemos 3 variables para realizar las 4 operaciones basicas, PrimerNum para almacenar el primer numero que hayamos escrito, SegundoNum para almacenar el segundo numero que hayamos escrito,
    'y Operador para guardar el tipo de operacion que queremos que haga la calculadora.
    Dim PrimerNum As Double
    Dim SegundoNum As Double
    Dim Operador As String

    'La funcion de esta variable es guardar el numero de posiciones que hay desde que empezamos a escribir numeros despues de haber añadido una operacion , 
    'asi si queremos borrar el ultimo numero que hemos puesto , le daremos a CE y borrará solo ese numero tanto en la textbox1 y textbox2.
    Dim Numeros As Integer

    'Este boolean lo utilizo para que despues que hayamos completado una operacion y aparezca el resultado en el textbox1, al presionar un numero de la calculadora borre los dos textbox y ponga 
    'la variable Numeros a 0, esto esta presentado en el metodo Vaciado.
    Dim texto2bool As Boolean

    'Una variable temporal que uso en los metodos de Raiz cuadrada y porcentaje.
    Dim tmpValue As Double

    'Una variable para que cuando multipliquemos 2 numeros podamos acceder al boton de porcentaje.
    Dim porc As Integer


#End Region

#Region "Numeros"
    'Este metodo lo utilizo en cada numero para que despues que hayamos completado una operacion y aparezca el resultado en el textbox1, al presionar un numero de la
    'calculadora borre los dos textbox y ponga la variable Numeros a 0.
    Public Sub Vaciado(ByRef texto2bool As Boolean)
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If
    End Sub
    'Para cada boton de cada numero, del 0 al 9, un metodo que añadira dicho numero al TextBox con el metodo Vaciado y cada vez que añadimos un numero sume uno a la variable Numeros.
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 1
        Txt2.Text = Txt2.Text & 1
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 2
        Txt2.Text = Txt2.Text & 2
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 3
        Txt2.Text = Txt2.Text & 3
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 4
        Txt2.Text = Txt2.Text & 4
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 5
        Txt2.Text = Txt2.Text & 5
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 6
        Txt2.Text = Txt2.Text & 6
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1
        Txt1.Text = Txt1.Text & 7
        Txt2.Text = Txt2.Text & 7
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 8
        Txt2.Text = Txt2.Text & 8
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 9
        Txt2.Text = Txt2.Text & 9
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        Vaciado(texto2bool)

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 0
        Txt2.Text = Txt2.Text & 0
    End Sub


#End Region

#Region "Operaciones"
    'El metodo Resultado sirve para que cada vez que pulsemos sobre una operacion(+,-,*,/) haga la operacion de los numeros anteriores , y lo meta en la variable PrimerNum
    'y asi poder hacer operaciones consecutivas.
    Public Sub Resultado(ByRef operador As String)
        Select Case (operador)
            Case "+" : SegundoNum = Val(Txt1.Text)
                PrimerNum = PrimerNum + SegundoNum
            Case "-" : SegundoNum = Val(Txt1.Text)
                PrimerNum = PrimerNum - SegundoNum
            Case "X" : SegundoNum = Val(Txt1.Text)
                PrimerNum = PrimerNum * SegundoNum
            Case "/" : SegundoNum = Val(Txt1.Text)
                PrimerNum = PrimerNum / SegundoNum
            Case "" : PrimerNum = Val(Txt1.Text)
        End Select

    End Sub
    'Las cuatro operaciones tiene el metodo resultado , definido arriba , despues tenemos que la variable Numeros es igual a 0 porque asi la reinicializamos y
    'cuando pulsemos CE no borre todo sino solo los ultimos numeros desde la ultima operacion; despues tenemos que textbox2 se vaya acumulando para mostrar 
    'toda las operaciones hasta que presionemos el boton =,consecutivamente pongo el textbox1 en blanco para poner el siguiente numero, despues a la variable porc le sumo 1 para que
    'si intentamos hacer un porcentaje solo deje cuando haya 1 numero multiplicado por otro(esta contemplado en la operacion multiplicar), y por ultimo si porc es mayor que 1 no deje
    'hacer el porcentaje para que si multiplicamos un numero por otro y queremos sumarle,restar o dividir despues no deje hacer el porcentaje, solo se pondra en Enabled cuando sean 2 numeros,
    'uno multiplicado por el otro.

    Private Sub BtnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSumar.Click
        Resultado(Operador)

        Numeros = 0
        Txt2.Text = Txt2.Text + "+"
        Txt1.Text = ""
        Operador = "+"
        porc = porc + 1
        If porc > 1 Then
            BtnPorcentaje.Enabled = False
        End If
    End Sub


    Private Sub BtnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestar.Click

        Resultado(Operador)

        Numeros = 0
        Txt2.Text = Txt2.Text + "-"
        Txt1.Text = ""
        Operador = "-"
        porc = porc + 1
        If porc > 1 Then
            BtnPorcentaje.Enabled = False
        End If
    End Sub


    Private Sub BtnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicar.Click

        Resultado(Operador)

        Numeros = 0
        Txt2.Text = Txt2.Text + "*"
        Txt1.Text = ""
        Operador = "X"
        porc = porc + 1
        If porc = 1 Then
            BtnPorcentaje.Enabled = True
        Else
            BtnPorcentaje.Enabled = False
        End If
    End Sub


    Private Sub BtnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDividir.Click

        Resultado(Operador)

        Numeros = 0
        Txt2.Text = Txt2.Text + "/"
        Txt1.Text = ""
        Operador = "/"
        porc = porc + 1
        If porc > 1 Then
            BtnPorcentaje.Enabled = False
        End If


    End Sub

    'El metodo Resultado coge el valor de PrimerNum, que sera todas las operaciones que hayamos hecho antes de darle a este boton, y segun el valor de operador 
    'lo sumara,restara,multiplicara o dividira al ultimo valor escrito que se metera en la variable SegundoNum. Despues el textbox1 mostrara la variable SegundoNum,tambien pongo en blanco el textbox 2,
    'pondra el boolean texto2bool en false para que si presionamos un numero se vacie los dos textbox y se reinicie la variable Numeros(contemplado en el metodo Vaciado en la region numeros), 
    'despues desactivo el boton porcentaje y por ultimo reinicializo las variables porc, operador, PrimerNum y SegundoNum.
    Private Sub BtnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResultado.Click
        SegundoNum = Val(Txt1.Text)
        If Operador = "+" Then
            PrimerNum = PrimerNum + SegundoNum
        End If
        If Operador = "-" Then
            PrimerNum = PrimerNum - SegundoNum
        End If
        If Operador = "X" Then
            PrimerNum = PrimerNum * SegundoNum
        End If
        If Operador = "/" Then
            PrimerNum = PrimerNum / SegundoNum
        End If

        Txt1.Text = PrimerNum
        Txt2.Text = ""
        texto2bool = False
        BtnPorcentaje.Enabled = False
        porc = 0
        Operador = ""
        PrimerNum = 0
        SegundoNum = 0
    End Sub

#End Region

#Region "Funciones"

    'Funcion para añadir un mas o un menos a la operacion
    Private Sub BtnMasMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasMenos.Click
        Txt1.Text = -1 * Txt1.Text
    End Sub

    'Funcion para añadir una coma al numero escrito en el textbox1
    Private Sub BtnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComa.Click
        If InStr(Txt1.Text, ".") > 0 Then
            Exit Sub
        Else
            Txt1.Text = Txt1.Text & "."
        End If
    End Sub

    'Funcion de raiz cuadrada
    Private Sub BtnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSqrt.Click
        If Txt1.Text.Length <> 0 Then
            tmpValue = CType(Txt1.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            Txt1.Text = CType(tmpValue, String)
            texto2bool = False
            Txt2.Text = ""
        End If
    End Sub

    'Funcion de Porcentaje
    Private Sub BtnPorcentaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPorcentaje.Click
        SegundoNum = Val(Txt1.Text)
        tmpValue = CType(Txt1.Text, Double)
        tmpValue = (PrimerNum * SegundoNum) / 100
        Txt1.Text = CType(tmpValue, String)
        texto2bool = False
        Txt2.Text = ""
        porc = 0
        BtnPorcentaje.Enabled = False

    End Sub

    'Funcion de factorial
    Function factorial(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return 1
        Else
            Return factorial(n - 1) * n
        End If
    End Function

    'Metodo que usa la funcion de factorial.
    Private Sub BtnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFactorial.Click

        Txt1.Text = factorial(Txt1.Text)
        texto2bool = False
    End Sub

    'Funcion de 1/x
    Private Sub BtnFuncion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFuncion.Click
        Txt1.Text = 1 / Txt1.Text
        texto2bool = False
    End Sub

    'Funcion para potencia
    Private Sub BtnPotencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPotencia.Click

        If PrimerNum <> 0 Then
            Txt1.Text = PrimerNum ^ Txt1.Text
            texto2bool = False
        Else
            PrimerNum = Txt1.Text
            Txt2.Text = PrimerNum & "^"
            Txt1.Text = ""
        End If

    End Sub

    'Funcion de logaritmo
    Private Sub BtnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLog.Click

        Txt1.Text = Math.Log(Txt1.Text, 10)
        texto2bool = False

    End Sub

    'Funcion paroa coseno
    Private Sub BtnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCos.Click
        Txt1.Text = Math.Cos(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub
    'Funcion paroa seno
    Private Sub BtnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSin.Click
        Txt1.Text = Math.Sin(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub
    'Funcion paroa tangente
    Private Sub BtnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTan.Click
        Txt1.Text = Math.Tan(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub
#End Region

#Region "Borrados"



    'Metodo que borrar todo(Los 2 textbox, las variables PrimerNum y SegundoNum, porc, y desactiva el boton porcentaje)
    Private Sub BtnBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarTodo.Click
        Txt1.Text = ""
        Txt2.Text = ""
        PrimerNum = 0
        SegundoNum = 0
        porc = 0
        BtnPorcentaje.Enabled = False
    End Sub

    'Metodo que borra el ultimo numero introducido gracias a la variable Numeros.
    Private Sub BtnBorrarUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarUltimo.Click
        Txt1.Text = ""
        If Txt2.Text = "" Then
            Exit Sub
        End If

        Txt2.Text = Txt2.Text.Substring(0, Txt2.Text.Count() - Numeros)
        Numeros = 0
    End Sub

    'Metodo para borrar numero por numero , en el textbox 2 solo puede borrar numeros del ultimo introducido despues de la ultima operacion.
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        If Txt1.Text = "" Then
            Exit Sub
        End If

        If texto2bool = False Then
            Txt1.Text = Txt1.Text.Substring(0, Txt1.Text.Count() - 1)
        Else
            If Txt1.Text = "" Or Txt2.Text = "" Then
                Exit Sub
            Else
                Txt1.Text = Txt1.Text.Substring(0, Txt1.Text.Count() - 1)
                Txt2.Text = Txt2.Text.Substring(0, Txt2.Text.Count() - 1)
            End If
        End If



    End Sub

#End Region

#Region "Conversor"
    Dim textto, result, textfrom As Double
    
    'Conversor de divisas , primero elegimos la moneda que queremos convertir y despues su covnersion , para realizarlo primero cogo la primera moneda y la convierto a Euros sea cual sea ,
    'despues de euros la paso a la que queremos saber y saldra en resultado en pantalla.
    Private Sub CBFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFrom.SelectedIndexChanged

        Select Case CBFrom.Text
            Case "Japanese YEN - JPY"
                textfrom = 0.00730386
            Case "Euro - EUR"
                textfrom = 1
            Case "British Pound - GBP"
                textfrom = 1.26937
            Case "U.S. Dollar - USD"
                textfrom = 0.78754
        End Select

    End Sub

    Private Sub CBTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTo.SelectedIndexChanged

        Select Case CBTo.Text
            Case "Japanese YEN - JPY"
                textto = 136.936
            Case "Euro - EUR"
                textto = 1
            Case "British Pound - GBP"
                textto = 0.787758
            Case "U.S. Dollar - USD"
                textto = 1.26967
        End Select

    End Sub

    Private Sub Enterbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConvertir.Click
        Dim moneda As Decimal

        moneda = Val(Txt3.Text)
        result = moneda * textfrom
        result = result * textto
        Txt4.Text = result

    End Sub
#End Region

#Region "Otros"
    'Metodo para volver al Menú de las calculadoras y oculta esta calculadora
    Private Sub BtnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    'Metodo para mostrar o ocultar el conversor de divisas
    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged

        If gb1.Visible = False Then
            gb1.Visible = True
            Me.Size = New Point(970, 457)
        Else
            gb1.Visible = False
            Me.Size = New Point(669, 457)
        End If

    End Sub
#End Region

End Class