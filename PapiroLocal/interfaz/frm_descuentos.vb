Imports System.Globalization
Public Class frm_descuentos

    Dim nue_cur As New clases.Descuentos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_descripcion.Clear()
        txt_precio_unitario.Clear()
        txt_cantidad.Clear()
        txt_total.Clear()
    End Sub

    Sub actualizar_dgv()
        dgv_curso.DataSource = nue_cur.listar(Nombre_Obra)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).Width = 300
        dgv_curso.Columns(1).HeaderText = "Representante"
        dgv_curso.Columns(2).HeaderText = "Clasificación"
        dgv_curso.Columns(3).HeaderText = "Descripción"
        dgv_curso.Columns(4).HeaderText = "Cantidad"
        dgv_curso.Columns(5).HeaderText = "Unidad"
        dgv_curso.Columns(6).HeaderText = "Precio Unitario"
        dgv_curso.Columns(7).HeaderText = "Total"
        dgv_curso.Columns(8).HeaderText = "Cuenta Contable"
        dgv_curso.Columns(9).HeaderText = "Fecha"
        dgv_curso.Columns(3).Width = 200
        dgv_curso.Columns(8).Width = 200


    End Sub
    Public Sub actualizar_representantes()
        cmb_representante.DataSource = nue_cur.listar3(Nombre_Obra)
        cmb_representante.DisplayMember = "Nombre"
        cmb_representante.ValueMember = "Nombre"
    End Sub
    Public Sub actualizar_cuentas()
        cmb_cuenta_contable2.DataSource = nue_cur.listar2(Nombre_Obra)
        cmb_cuenta_contable2.DisplayMember = "Cuenta_costo"
        cmb_cuenta_contable2.ValueMember = "Cuenta_costo"
    End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        txt_descripcion.Enabled = False
        txt_precio_unitario.Enabled = False
        txt_cantidad.Enabled = False
        txt_total.Enabled = False
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        txt_descripcion.Enabled = True
        txt_precio_unitario.Enabled = True
        txt_cantidad.Enabled = True
        txt_total.Enabled = True
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        actualizar_representantes()
        actualizar_cuentas()
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_descripcion.Text <> "" And txt_precio_unitario.Text <> "" And txt_cantidad.Text <> "" And txt_total.Text <> "" And cmb_representante.Text <> "" And cmb_clasificacion.Text <> "" And cmb_unidad.Text <> "") Then
            Dim nombre, clasificacion, descripcion, unidad, cuenta_contable, obra As String
            Dim precio_unitario, cantidad, total As Double

            nombre = cmb_representante.Text
            clasificacion = cmb_clasificacion.Text
            descripcion = txt_descripcion.Text
            unidad = cmb_unidad.Text
            precio_unitario = Convert.ToDouble(txt_precio_unitario.Text)
            cantidad = Convert.ToDouble(txt_cantidad.Text)
            total = Convert.ToDouble(txt_total.Text)
            cuenta_contable = cmb_cuenta_contable2.Text
            obra = txt_nombre_obra.Text

            If sw = 0 Then
                nue_cur.insertar(nombre, clasificacion, descripcion, cantidad, unidad, precio_unitario, total, cuenta_contable, CDate(txt_fecha.Text), obra)
                actualizar_dgv()
            Else
                nue_cur.modificar(CInt(cod_cur), nombre, clasificacion, descripcion, cantidad, unidad, precio_unitario, total, cuenta_contable, CDate(txt_fecha.Text), obra)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (cod_cur = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            sw = 1
            desbloquear()
        End If
    End Sub

    Private Sub dgv_curso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_curso.CellDoubleClick
        cod_cur = dgv_curso.CurrentRow.Cells(0).Value.ToString()
        cmb_representante.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        cmb_clasificacion.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_descripcion.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        txt_cantidad.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        cmb_unidad.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_precio_unitario.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_total.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        cmb_cuenta_contable2.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_fecha.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (cod_cur = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_cur.eliminar(CInt(cod_cur))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub cmb_cuenta_contable2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cuenta_contable2.SelectedIndexChanged

    End Sub

    Private Sub txt_precio_unitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precio_unitario.TextChanged
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_unitario.Text)) Then
            Me.txt_precio_unitario.Text = 0
        End If
        If (Not IsNumeric(Me.txt_total.Text)) Then
            Me.txt_total.Text = 0
        End If

        txt_total.Text = CDbl(Me.txt_cantidad.Text) * CDbl(Me.txt_precio_unitario.Text)
    End Sub


    Private Sub txt_cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cantidad.TextChanged
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_unitario.Text)) Then
            Me.txt_precio_unitario.Text = 0
        End If
        If (Not IsNumeric(Me.txt_total.Text)) Then
            Me.txt_total.Text = 0
        End If

        txt_total.Text = CDbl(Me.txt_cantidad.Text) * CDbl(Me.txt_precio_unitario.Text)
    End Sub

    Private Sub txt_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total.TextChanged
        If (Not IsNumeric(Me.txt_cantidad.Text)) Then
            Me.txt_cantidad.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_unitario.Text)) Then
            Me.txt_precio_unitario.Text = 0
        End If
        If (Not IsNumeric(Me.txt_total.Text)) Then
            Me.txt_total.Text = 0
        End If

        txt_total.Text = CDbl(Me.txt_cantidad.Text) * CDbl(Me.txt_precio_unitario.Text)
    End Sub
End Class