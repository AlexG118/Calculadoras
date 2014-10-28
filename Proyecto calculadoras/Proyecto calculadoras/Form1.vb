Public Class Form1
    'En la primera pantalla tenemos el Menú para elegir que calculadora queremos abrir , cuando se le de a uno de los 3 botones este menú de esconderá y
    'aparecerá el que queriamos abrir.
    Private Sub BtnNiños_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNiños.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOficina.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAncianos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAncianos.Click
        Form4.Show()
        Me.Hide()
    End Sub

End Class