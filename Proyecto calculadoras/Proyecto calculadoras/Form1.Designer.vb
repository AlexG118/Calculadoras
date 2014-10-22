<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnNiños = New System.Windows.Forms.Button()
        Me.BtnOficina = New System.Windows.Forms.Button()
        Me.BtnAncianos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNiños
        '
        Me.BtnNiños.Location = New System.Drawing.Point(88, 61)
        Me.BtnNiños.Name = "BtnNiños"
        Me.BtnNiños.Size = New System.Drawing.Size(147, 23)
        Me.BtnNiños.TabIndex = 0
        Me.BtnNiños.Text = "Calculadora para niños"
        Me.BtnNiños.UseVisualStyleBackColor = True
        '
        'BtnOficina
        '
        Me.BtnOficina.Location = New System.Drawing.Point(88, 125)
        Me.BtnOficina.Name = "BtnOficina"
        Me.BtnOficina.Size = New System.Drawing.Size(147, 23)
        Me.BtnOficina.TabIndex = 1
        Me.BtnOficina.Text = "Calculadora Oficina"
        Me.BtnOficina.UseVisualStyleBackColor = True
        '
        'BtnAncianos
        '
        Me.BtnAncianos.Location = New System.Drawing.Point(88, 184)
        Me.BtnAncianos.Name = "BtnAncianos"
        Me.BtnAncianos.Size = New System.Drawing.Size(147, 23)
        Me.BtnAncianos.TabIndex = 2
        Me.BtnAncianos.Text = "Calculadora para ancianos"
        Me.BtnAncianos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 282)
        Me.Controls.Add(Me.BtnAncianos)
        Me.Controls.Add(Me.BtnOficina)
        Me.Controls.Add(Me.BtnNiños)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNiños As System.Windows.Forms.Button
    Friend WithEvents BtnOficina As System.Windows.Forms.Button
    Friend WithEvents BtnAncianos As System.Windows.Forms.Button
End Class
