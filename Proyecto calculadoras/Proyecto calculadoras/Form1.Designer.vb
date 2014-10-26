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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnNiños = New System.Windows.Forms.Button()
        Me.BtnOficina = New System.Windows.Forms.Button()
        Me.BtnAncianos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNiños
        '
        Me.BtnNiños.BackgroundImage = CType(resources.GetObject("BtnNiños.BackgroundImage"), System.Drawing.Image)
        Me.BtnNiños.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNiños.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNiños.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNiños.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNiños.Location = New System.Drawing.Point(124, 79)
        Me.BtnNiños.Name = "BtnNiños"
        Me.BtnNiños.Size = New System.Drawing.Size(267, 89)
        Me.BtnNiños.TabIndex = 0
        Me.BtnNiños.Text = "Calculadora para niños"
        Me.BtnNiños.UseVisualStyleBackColor = True
        '
        'BtnOficina
        '
        Me.BtnOficina.BackgroundImage = CType(resources.GetObject("BtnOficina.BackgroundImage"), System.Drawing.Image)
        Me.BtnOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOficina.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOficina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOficina.Location = New System.Drawing.Point(124, 195)
        Me.BtnOficina.Name = "BtnOficina"
        Me.BtnOficina.Size = New System.Drawing.Size(267, 84)
        Me.BtnOficina.TabIndex = 1
        Me.BtnOficina.Text = "Calculadora Oficina"
        Me.BtnOficina.UseVisualStyleBackColor = True
        '
        'BtnAncianos
        '
        Me.BtnAncianos.BackgroundImage = CType(resources.GetObject("BtnAncianos.BackgroundImage"), System.Drawing.Image)
        Me.BtnAncianos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAncianos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAncianos.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAncianos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAncianos.Location = New System.Drawing.Point(124, 312)
        Me.BtnAncianos.Name = "BtnAncianos"
        Me.BtnAncianos.Size = New System.Drawing.Size(267, 87)
        Me.BtnAncianos.TabIndex = 2
        Me.BtnAncianos.Text = "Calculadora para ancianos"
        Me.BtnAncianos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(517, 471)
        Me.Controls.Add(Me.BtnAncianos)
        Me.Controls.Add(Me.BtnOficina)
        Me.Controls.Add(Me.BtnNiños)
        Me.Name = "Form1"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNiños As System.Windows.Forms.Button
    Friend WithEvents BtnOficina As System.Windows.Forms.Button
    Friend WithEvents BtnAncianos As System.Windows.Forms.Button
End Class
