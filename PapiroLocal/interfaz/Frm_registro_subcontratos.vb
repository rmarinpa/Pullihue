Imports System.Globalization
Public Class Frm_registro_subcontratos

    Dim nue_report As New clases.registro_subcontratos
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub
    Sub bloquear()
        gbx_Mov_Tierra.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_Mov_Tierra.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Public Sub actualizar_contratos()
        cmb_codigo_subcontrato.DataSource = nue_report.listar2(Nombre_Obra)
        cmb_codigo_subcontrato.DisplayMember = "Id_representante"
        cmb_codigo_subcontrato.ValueMember = "Id_representante"
    End Sub
    Public Sub actualizar_glosa()
        cmb_glosa.DataSource = nue_report.listar3(Nombre_Obra, cmb_codigo_subcontrato.Text)
        cmb_glosa.DisplayMember = "glosa"
        cmb_glosa.ValueMember = "glosa"
    End Sub


    Sub limpiar()
        txt_cantidad.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_Mov_Tierra.DataSource = nue_report.listar(Nombre_Obra)
        dgv_Mov_Tierra.Columns(0).Visible = False
        dgv_Mov_Tierra.Columns(1).HeaderText = "Código Subcontrato"
        dgv_Mov_Tierra.Columns(2).HeaderText = "Glosa"
        dgv_Mov_Tierra.Columns(2).Width = 300
        dgv_Mov_Tierra.Columns(3).HeaderText = "Cantidad"
        dgv_Mov_Tierra.Columns(4).HeaderText = "Fecha"
        dgv_Mov_Tierra.Columns(5).HeaderText = "Obra"
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        actualizar_contratos()
        actualizar_glosa()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo, glosa, obra As String
        Dim cantidad As Double
        If (cmb_codigo_subcontrato.Text <> "" And cmb_glosa.Text <> "" And txt_cantidad.Text <> "") Then

            codigo = cmb_codigo_subcontrato.Text
            glosa = cmb_glosa.Text
            cantidad = txt_cantidad.Text
            obra = txt_nombre_obra.Text

            If sw = 0 Then
                nue_report.insertar(codigo, glosa, cantidad, CDate(txt_fecha.Text), obra)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Mov_Tierra), codigo, glosa, cantidad, CDate(txt_fecha.Text), obra)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Mov_Tierra.CellDoubleClick
        Cod_Mov_Tierra = dgv_Mov_Tierra.CurrentRow.Cells(0).Value.ToString()
        cmb_codigo_subcontrato.Text = dgv_Mov_Tierra.CurrentRow.Cells(1).Value.ToString()
        cmb_glosa.Text = dgv_Mov_Tierra.CurrentRow.Cells(2).Value.ToString()
        txt_cantidad.Text = dgv_Mov_Tierra.CurrentRow.Cells(3).Value.ToString()
        txt_fecha.Text = dgv_Mov_Tierra.CurrentRow.Cells(4).Value.ToString()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Mov_Tierra = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Mov_Tierra))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub

    Private Sub cmb_codigo_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_codigo_subcontrato.MouseClick
        actualizar_contratos()
    End Sub

End Class