Public Class Form3

#Region "Variables"

    Dim Numeros As Integer
    Dim PrimerNum As Double
    Dim SegundoNum As Double
    Dim Operador As String
    Dim texto2bool As Boolean
    Dim tmpValue As Double
    Dim porc As Integer
    Dim i As Integer
#End Region

#Region "Numeros"

    Public Sub Vaciado(ByRef texto2bool As Boolean)
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If
    End Sub

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
        texto2bool = False
        porc = 0
        BtnPorcentaje.Enabled = False
        Txt2.Text = ""
        Operador = ""
        PrimerNum = 0
        SegundoNum = 0
    End Sub

#End Region

#Region "Funciones"


    Private Sub BtnMasMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasMenos.Click
        Txt1.Text = -1 * Txt1.Text
    End Sub


    Private Sub BtnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComa.Click
        If InStr(Txt1.Text, ".") > 0 Then
            Exit Sub
        Else
            Txt1.Text = Txt1.Text & "."
        End If
    End Sub

    Private Sub BtnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSqrt.Click
        If Txt1.Text.Length <> 0 Then
            tmpValue = CType(Txt1.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            Txt1.Text = CType(tmpValue, String)
            texto2bool = False
            Txt2.Text = ""
        End If
    End Sub

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

    Function factorial(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return 1
        Else
            Return factorial(n - 1) * n
        End If
    End Function

    Private Sub BtnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFactorial.Click

        Txt1.Text = factorial(Txt1.Text)
        texto2bool = False
    End Sub
    Private Sub BtnFuncion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFuncion.Click
        Txt1.Text = 1 / Txt1.Text
        texto2bool = False
    End Sub

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

    Private Sub BtnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLog.Click

        Txt1.Text = Math.Log(Txt1.Text, 10)
        texto2bool = False

    End Sub

    Private Sub BtnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCos.Click
        Txt1.Text = Math.Cos(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub

    Private Sub BtnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSin.Click
        Txt1.Text = Math.Sin(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub

    Private Sub BtnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTan.Click
        Txt1.Text = Math.Tan(Txt1.Text * (Math.PI / 180))
        texto2bool = False
    End Sub
#End Region

#Region "Borrados"




    Private Sub BtnBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarTodo.Click
        Txt1.Text = ""
        Txt2.Text = ""
        PrimerNum = 0
        SegundoNum = 0
        porc = 0
        BtnPorcentaje.Enabled = False
    End Sub


    Private Sub BtnBorrarUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarUltimo.Click
        Txt1.Text = ""
        If Txt2.Text = "" Then
            Exit Sub
        End If

        Txt2.Text = Txt2.Text.Substring(0, Txt2.Text.Count() - Numeros)
        Numeros = 0
    End Sub

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

#Region "Otros"
    Private Sub BtnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver1.Click
        Me.Hide()
        Form1.Show()
    End Sub
#End Region

#Region "Conversor"
    Dim textto, result, textfrom As Double
    

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




End Class