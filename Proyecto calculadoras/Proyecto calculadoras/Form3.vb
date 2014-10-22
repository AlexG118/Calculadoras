Public Class Form3
    Dim Numeros As Integer
    Dim PrimerNum As Double
    Dim SegundoNum As Double
    Dim TercerNum As Double
    Dim ResultadoNum As Double
    Dim Operador As String
    Dim texto2bool As Boolean
    Dim tmpValue As Double
    Dim porc As Integer
    Dim i As Integer

    Private Sub BtnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver1.Click
        Me.Hide()
        Form1.Show()
    End Sub




    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 1
        Txt2.Text = Txt2.Text & 1
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 2
        Txt2.Text = Txt2.Text & 2
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 3
        Txt2.Text = Txt2.Text & 3
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 4
        Txt2.Text = Txt2.Text & 4
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 5
        Txt2.Text = Txt2.Text & 5
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 6
        Txt2.Text = Txt2.Text & 6
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1
        Txt1.Text = Txt1.Text & 7
        Txt2.Text = Txt2.Text & 7
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If

        Numeros = Numeros + 1

        Txt1.Text = Txt1.Text & 8
        Txt2.Text = Txt2.Text & 8
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If
        Numeros = Numeros + 1
        Txt1.Text = Txt1.Text & 9
        Txt2.Text = Txt2.Text & 9
    End Sub

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        If texto2bool = False Then
            Txt1.Text = ""
            Txt2.Text = ""
            Numeros = 0
            texto2bool = True
        End If
        Numeros = Numeros + 1
        Txt1.Text = Txt1.Text & 0
        Txt2.Text = Txt2.Text & 0
    End Sub


    Private Sub BtnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSumar.Click
        PrimerNum = Val(Txt1.Text)
        If Operador <> "" Then
            SegundoNum = PrimerNum
        Else
            SegundoNum = SegundoNum + PrimerNum
        End If

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

        If Operador <> "" Then
            PrimerNum = Val(Txt1.Text)
        Else
            PrimerNum = SegundoNum
        End If

        SegundoNum = PrimerNum - Txt2.Text.Substring(Txt2.Text.Count() - Numeros, Numeros)
        TercerNum = TercerNum - SegundoNum

        Numeros = 0
        PrimerNum = Val(Txt1.Text)
        Txt2.Text = Txt2.Text + "-"
        Txt1.Text = ""
        Operador = "-"
        porc = porc + 1
        If porc > 1 Then
            BtnPorcentaje.Enabled = False
        End If
    End Sub

    Private Sub BtnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicar.Click

        If Operador <> "" Then
            PrimerNum = Val(Txt1.Text)
        Else
            PrimerNum = SegundoNum
        End If

        SegundoNum = PrimerNum * Txt2.Text.Substring(Txt2.Text.Count() - Numeros, Numeros)
        TercerNum = TercerNum * SegundoNum

        Numeros = 0
        PrimerNum = Val(Txt1.Text)
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

        If Operador <> "" Then
            PrimerNum = Val(Txt1.Text)
        Else
            PrimerNum = SegundoNum
        End If

        SegundoNum = PrimerNum / Txt2.Text.Substring(Txt2.Text.Count() - Numeros, Numeros)
        TercerNum = TercerNum / SegundoNum

            Numeros = 0
            PrimerNum = Val(Txt1.Text)
            Txt2.Text = Txt2.Text + "/"
            Txt1.Text = ""
            Operador = "/"
            porc = porc + 1
            If porc > 1 Then
                BtnPorcentaje.Enabled = False
            End If


    End Sub


    Private Sub BtnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResultado.Click
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
        texto2bool = False
        porc = 0
        BtnPorcentaje.Enabled = False
        Txt2.Text = ""
        Operador = ""
        PrimerNum = 0
        SegundoNum = 0
        TercerNum = 0
    End Sub






    Private Sub BtnBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarTodo.Click
        Txt1.Text = ""
        Txt2.Text = ""
        PrimerNum = 0
        SegundoNum = 0
        ResultadoNum = 0
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

End Class