<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cr_nota_credito
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
        Me.crv_informe_nota_credito = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crv_informe_nota_credito
        '
        Me.crv_informe_nota_credito.AccessibleDescription = "_"
        Me.crv_informe_nota_credito.ActiveViewIndex = -1
        Me.crv_informe_nota_credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_informe_nota_credito.CachedPageNumberPerDoc = 10
        Me.crv_informe_nota_credito.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_informe_nota_credito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_informe_nota_credito.Location = New System.Drawing.Point(0, 0)
        Me.crv_informe_nota_credito.Name = "crv_informe_nota_credito"
        Me.crv_informe_nota_credito.Size = New System.Drawing.Size(534, 331)
        Me.crv_informe_nota_credito.TabIndex = 0
        '
        'frm_cr_nota_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 331)
        Me.Controls.Add(Me.crv_informe_nota_credito)
        Me.Name = "frm_cr_nota_credito"
        Me.Text = "Nota de crédito"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_informe_nota_credito As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
