<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.lblGracias = New System.Windows.Forms.Label()
        Me.lblMiNombre = New System.Windows.Forms.Label()
        Me.lblUtu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(146, 24)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(97, 20)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "Bienvenida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Quieres saber que año es bisiesto?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingresa el año aqui:"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(180, 119)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(112, 20)
        Me.txtAño.TabIndex = 3
        '
        'btnAceptar2
        '
        Me.btnAceptar2.Location = New System.Drawing.Point(198, 145)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(74, 23)
        Me.btnAceptar2.TabIndex = 4
        Me.btnAceptar2.Text = "Aceptar"
        Me.btnAceptar2.UseVisualStyleBackColor = True
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(127, 191)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(55, 16)
        Me.lblRespuesta.TabIndex = 5
        Me.lblRespuesta.Text = "Label1"
        Me.lblRespuesta.Visible = False
        '
        'lblGracias
        '
        Me.lblGracias.AutoSize = True
        Me.lblGracias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGracias.Location = New System.Drawing.Point(147, 225)
        Me.lblGracias.Name = "lblGracias"
        Me.lblGracias.Size = New System.Drawing.Size(177, 15)
        Me.lblGracias.TabIndex = 6
        Me.lblGracias.Text = "¡Gracias por usar mi programa!"
        Me.lblGracias.Visible = False
        '
        'lblMiNombre
        '
        Me.lblMiNombre.AutoSize = True
        Me.lblMiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiNombre.Location = New System.Drawing.Point(127, 250)
        Me.lblMiNombre.Name = "lblMiNombre"
        Me.lblMiNombre.Size = New System.Drawing.Size(210, 15)
        Me.lblMiNombre.TabIndex = 7
        Me.lblMiNombre.Text = "Mi nombre es Manuel Do Canto"
        Me.lblMiNombre.Visible = False
        '
        'lblUtu
        '
        Me.lblUtu.AutoSize = True
        Me.lblUtu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtu.Location = New System.Drawing.Point(55, 276)
        Me.lblUtu.Name = "lblUtu"
        Me.lblUtu.Size = New System.Drawing.Size(352, 13)
        Me.lblUtu.TabIndex = 8
        Me.lblUtu.Text = "Soy alumno de 3ro. EMT de la Escuela Técnica María Espínola Espinola"
        Me.lblUtu.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(470, 318)
        Me.Controls.Add(Me.lblUtu)
        Me.Controls.Add(Me.lblMiNombre)
        Me.Controls.Add(Me.lblGracias)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.btnAceptar2)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Name = "Form2"
        Me.Text = "Año Bisiesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBienvenida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents btnAceptar2 As Button
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents lblGracias As Label
    Friend WithEvents lblMiNombre As Label
    Friend WithEvents lblUtu As Label
End Class
