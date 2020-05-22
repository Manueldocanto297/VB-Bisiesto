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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar1 = New System.Windows.Forms.Button()
        Me.radHombre = New System.Windows.Forms.RadioButton()
        Me.radMujer = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(115, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese su nombre para continuar:"
        '
        'btnAceptar1
        '
        Me.btnAceptar1.Location = New System.Drawing.Point(183, 163)
        Me.btnAceptar1.Name = "btnAceptar1"
        Me.btnAceptar1.Size = New System.Drawing.Size(90, 23)
        Me.btnAceptar1.TabIndex = 2
        Me.btnAceptar1.Text = "Aceptar"
        Me.btnAceptar1.UseVisualStyleBackColor = True
        '
        'radHombre
        '
        Me.radHombre.AutoSize = True
        Me.radHombre.Location = New System.Drawing.Point(14, 16)
        Me.radHombre.Name = "radHombre"
        Me.radHombre.Size = New System.Drawing.Size(62, 17)
        Me.radHombre.TabIndex = 3
        Me.radHombre.TabStop = True
        Me.radHombre.Text = "Hombre"
        Me.radHombre.UseVisualStyleBackColor = True
        '
        'radMujer
        '
        Me.radMujer.AutoSize = True
        Me.radMujer.Location = New System.Drawing.Point(14, 40)
        Me.radMujer.Name = "radMujer"
        Me.radMujer.Size = New System.Drawing.Size(51, 17)
        Me.radMujer.TabIndex = 4
        Me.radMujer.TabStop = True
        Me.radMujer.Text = "Mujer"
        Me.radMujer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMujer)
        Me.GroupBox1.Controls.Add(Me.radHombre)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 68)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione su género:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(462, 238)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Menú Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAceptar1 As Button
    Friend WithEvents radHombre As RadioButton
    Friend WithEvents radMujer As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
