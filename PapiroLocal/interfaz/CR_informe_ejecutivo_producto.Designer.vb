<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CR_informe_ejeuctivo_producto
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Informe_ejecutivo1 = New Constructora_FV.Informe_ejecutivo()
        Me.Guia_de_despacho1 = New Constructora_FV.Guia_de_despacho()
        Me.Ventas1 = New Constructora_FV.Ventas()
        Me.Crrevision_petroleo2 = New Constructora_FV.Crrevision_petroleo()
        Me.Crrevision_petroleo1 = New Constructora_FV.Crrevision_petroleo()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Informe_ejecutivo1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(919, 321)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelWidth = 267
        '
        'CR_informe_ejeuctivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 321)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CR_informe_ejeuctivo"
        Me.Text = "Informe Ejecutivo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Crrevision_petroleo1 As Constructora_FV.Crrevision_petroleo
    Friend WithEvents Crrevision_petroleo2 As Constructora_FV.Crrevision_petroleo
    Friend WithEvents Ventas1 As Constructora_FV.Ventas
    Friend WithEvents Guia_de_despacho1 As Constructora_FV.Guia_de_despacho
    Friend WithEvents Informe_ejecutivo1 As Constructora_FV.Informe_ejecutivo
End Class
