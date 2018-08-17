<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cr_guia_despacho
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
        Me.cvr_guias_despachos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cvr_guias_despachos
        '
        Me.cvr_guias_despachos.ActiveViewIndex = -1
        Me.cvr_guias_despachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cvr_guias_despachos.CachedPageNumberPerDoc = 10
        Me.cvr_guias_despachos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cvr_guias_despachos.DisplayStatusBar = False
        Me.cvr_guias_despachos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cvr_guias_despachos.Location = New System.Drawing.Point(0, 0)
        Me.cvr_guias_despachos.Name = "cvr_guias_despachos"
        Me.cvr_guias_despachos.Size = New System.Drawing.Size(679, 367)
        Me.cvr_guias_despachos.TabIndex = 0
        '
        'frm_cr_guia_despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 367)
        Me.Controls.Add(Me.cvr_guias_despachos)
        Me.Name = "frm_cr_guia_despacho"
        Me.Text = "Guía de despacho"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cvr_guias_despachos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
