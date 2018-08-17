<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Petroleo_list
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
        Me.lv_petroleo = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lv_petroleo
        '
        Me.lv_petroleo.Location = New System.Drawing.Point(323, 76)
        Me.lv_petroleo.Name = "lv_petroleo"
        Me.lv_petroleo.Size = New System.Drawing.Size(1084, 543)
        Me.lv_petroleo.TabIndex = 0
        Me.lv_petroleo.UseCompatibleStateImageBehavior = False
        '
        'Frm_Petroleo_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1419, 642)
        Me.Controls.Add(Me.lv_petroleo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Petroleo_list"
        Me.Text = "frm_estudiante"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_petroleo As System.Windows.Forms.ListView
End Class
