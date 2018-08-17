﻿Imports System.Globalization
Public Class frm_Contrato

    Dim nue_cur As New clases.Contratos
    Dim cod_cur As String = ""
    Dim sw As Integer

    Sub limpiar()
        txt_cod_maq.Clear()
        txt_marca.Clear()
        txt_descripcion.Clear()
        txt_unid_paq.Clear()
        txt_medidas.Clear()
        txt_ancho.Clear()
        txt_largo.Clear()
        txt_area.Clear()
        txt_nombre_proveedor.Clear()
        txt_mapa.Clear()
        txt_tipo.Clear()
        txt_familia1.Clear()
        txt_familia2.Clear()
        txt_familia3.Clear()
        txt_area_neg.Clear()
        txt_precio.Clear()
        txt_precio_min.Clear()
        txt_stock.Clear()
        txt_categoria.Clear()
        txt_categoria2.Clear()
    End Sub

    'Sub actualizar_dgv()
    '    dgv_curso.DataSource = nue_cur.listar()
    '    dgv_curso.Columns(0).Visible = False
    '    dgv_curso.Columns(1).Width = 200
    '    dgv_curso.Columns(2).Width = 200
    '    dgv_curso.Columns(3).Width = 200
    '    dgv_curso.Columns(1).HeaderText = "Código de Producto"
    '    dgv_curso.Columns(2).HeaderText = "Marca"
    '    dgv_curso.Columns(3).HeaderText = "Descripción"
    '    dgv_curso.Columns(4).Visible = False
    '    dgv_curso.Columns(5).HeaderText = "Medidas"
    '    dgv_curso.Columns(6).HeaderText = "Unidades por Paquete"
    '    dgv_curso.Columns(7).HeaderText = "Ancho"
    '    dgv_curso.Columns(8).HeaderText = "Largo"
    '    dgv_curso.Columns(9).HeaderText = "Área"
    '    dgv_curso.Columns(10).Visible = False
    '    dgv_curso.Columns(11).Visible = False
    '    dgv_curso.Columns(12).Visible = False
    '    dgv_curso.Columns(13).Visible = False
    '    dgv_curso.Columns(14).Visible = False
    '    dgv_curso.Columns(15).Visible = False
    '    dgv_curso.Columns(16).Visible = False
    '    dgv_curso.Columns(17).Visible = False
    '    dgv_curso.Columns(18).Visible = False
    '    dgv_curso.Columns(19).HeaderText = "Stock"
    '    dgv_curso.Columns(20).Visible = False
    '    dgv_curso.Columns(21).HeaderText = "Precio de Lista"
    '    dgv_curso.Columns(21).HeaderText = "Fecha Caducidad"

    'End Sub
    Sub bloquear()
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        txt_cod_maq.Enabled = False
        txt_marca.Enabled = False
        txt_descripcion.Enabled = False
        txt_unid_paq.Enabled = False
        txt_medidas.Enabled = False
        txt_ancho.Enabled = False
        txt_largo.Enabled = False
        txt_area.Enabled = False
        txt_nombre_proveedor.Enabled = False
        txt_mapa.Enabled = False
        txt_tipo.Enabled = False
        txt_familia1.Enabled = False
        txt_familia2.Enabled = False
        txt_familia3.Enabled = False
        txt_area_neg.Enabled = False
        txt_precio.Enabled = False
        txt_precio_min.Enabled = False
        txt_fecha.Enabled = False
        txt_categoria.Enabled = False
        txt_categoria2.Enabled = False
        btn_calc.Enabled = False
    End Sub

    Sub desbloquear()
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btn_cancelar.Enabled = True
        btnEliminar.Enabled = False
        txt_cod_maq.Enabled = True
        txt_marca.Enabled = True
        txt_descripcion.Enabled = True
        txt_unid_paq.Enabled = True
        txt_medidas.Enabled = True
        'txt_ancho.Enabled = True
        'txt_largo.Enabled = True
        'txt_area.Enabled = True
        txt_nombre_proveedor.Enabled = True
        txt_mapa.Enabled = True
        txt_tipo.Enabled = True
        txt_familia1.Enabled = True
        txt_familia2.Enabled = True
        txt_familia3.Enabled = True
        txt_area_neg.Enabled = True
        txt_precio.Enabled = True
        txt_precio_min.Enabled = True
        txt_categoria.Enabled = True
        txt_categoria2.Enabled = True
        btn_calc.Enabled = True

    End Sub

    Private Sub frm_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoSize = True
        txt_fecha.Text = "9998-12-31"
        bloquear()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If (txt_cod_maq.Text <> "" And txt_marca.Text <> "" And txt_descripcion.Text <> "") Then
            Dim Codigo, Marca, Descripcion, Tipo_1, medidas, descripcion_2, area_negocio, proveedor, mapa, descripcion_3, obs, familia, familia_2, familia_3, activo, categoria, categoria2 As String
            Dim unid_paquete, ancho, largo, area, stock, medida_unid, precio, precio_min As Double

            If Not IsNumeric(txt_unid_paq.Text) Then
                txt_unid_paq.Text = 0
            End If
            If Not IsNumeric(txt_ancho.Text) Then
                txt_ancho.Text = 0
            End If
            If Not IsNumeric(txt_largo.Text) Then
                txt_largo.Text = 0
            End If
            If Not IsNumeric(txt_area.Text) Then
                txt_area.Text = 0
            End If
            If Not IsNumeric(txt_precio.Text) Then
                txt_precio.Text = 0
            End If
            If Not IsDate(txt_fecha.Text) Then
                txt_fecha.Text = "9998-12-31"
            End If
            If txt_stock.Text <> "" Then
                stock = txt_stock.Text
            Else
                txt_stock.Text = 0
            End If
            medida_unid = "0"
            unid_paquete = Convert.ToDouble(txt_unid_paq.Text)
            ancho = Convert.ToDouble(txt_ancho.Text)
            largo = Convert.ToDouble(txt_largo.Text)
            area = Convert.ToDouble(txt_area.Text)
            Codigo = txt_cod_maq.Text
            Marca = txt_marca.Text
            Descripcion = txt_descripcion.Text
            Tipo_1 = txt_tipo.Text
            medidas = txt_medidas.Text
            area_negocio = txt_area_neg.Text
            proveedor = txt_nombre_proveedor.Text
            mapa = txt_mapa.Text
            familia = txt_familia1.Text
            familia_2 = txt_familia2.Text
            familia_3 = txt_familia3.Text
            If txt_precio.Text <> "" Then
                precio = Convert.ToDouble(txt_precio.Text)
            Else
            End If
            If txt_precio_min.Text <> "" Then
                precio_min = Convert.ToDouble(txt_precio_min.Text)
            Else
            End If
            categoria = txt_categoria.Text
            categoria2 = txt_categoria2.Text
            activo = 1
            descripcion_2 = ""
            descripcion_3 = ""
            obs = ""

            If sw = 0 Then
                If (nue_cur.listar4(Me.txt_cod_maq.Text) = Me.txt_cod_maq.Text) Then
                    MessageBox.Show("Este Código de Producto ya existe")
                Else
                    nue_cur.insertar(Codigo, Marca, Descripcion, Tipo_1, medidas, unid_paquete, ancho, largo, area, descripcion_2, area_negocio, proveedor, mapa, descripcion_3, obs, familia, familia_2, familia_3, stock, medida_unid, precio, CDate(txt_fecha.Text), precio, precio_min, activo, categoria, categoria2)
                    actualizar_dgv2()
                End If
            Else
                nue_cur.modificar(CInt(cod_cur), Codigo, Marca, Descripcion, Tipo_1, medidas, unid_paquete, ancho, largo, area, descripcion_2, area_negocio, proveedor, mapa, descripcion_3, obs, familia, familia_2, familia_3, stock, medida_unid, precio, CDate(txt_fecha.Text), precio, precio_min, activo, categoria, categoria2)
                'nue_cur.modificar(Tipo_1, familia, familia_2, familia_3, precio_min, precio, mapa)
                actualizar_dgv2()
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
        txt_cod_maq.Text = dgv_curso.CurrentRow.Cells(1).Value.ToString()
        txt_marca.Text = dgv_curso.CurrentRow.Cells(2).Value.ToString()
        txt_descripcion.Text = dgv_curso.CurrentRow.Cells(3).Value.ToString()
        txt_tipo.Text = dgv_curso.CurrentRow.Cells(4).Value.ToString()
        txt_medidas.Text = dgv_curso.CurrentRow.Cells(5).Value.ToString()
        txt_unid_paq.Text = dgv_curso.CurrentRow.Cells(6).Value.ToString()
        txt_ancho.Text = dgv_curso.CurrentRow.Cells(7).Value.ToString()
        txt_largo.Text = dgv_curso.CurrentRow.Cells(8).Value.ToString()
        txt_area.Text = dgv_curso.CurrentRow.Cells(9).Value.ToString()
        txt_area_neg.Text = dgv_curso.CurrentRow.Cells(11).Value.ToString()
        txt_nombre_proveedor.Text = dgv_curso.CurrentRow.Cells(12).Value.ToString()
        txt_mapa.Text = dgv_curso.CurrentRow.Cells(13).Value.ToString()
        txt_familia1.Text = dgv_curso.CurrentRow.Cells(16).Value.ToString()
        txt_familia2.Text = dgv_curso.CurrentRow.Cells(17).Value.ToString()
        txt_familia3.Text = dgv_curso.CurrentRow.Cells(18).Value.ToString()
        txt_stock.Text = dgv_curso.CurrentRow.Cells(19).Value.ToString()
        txt_precio.Text = dgv_curso.CurrentRow.Cells(23).Value.ToString()
        txt_precio_min.Text = dgv_curso.CurrentRow.Cells(24).Value.ToString()
        If dgv_curso.CurrentRow.Cells(22).Value.ToString() <> "" Then
            txt_fecha.Value = dgv_curso.CurrentRow.Cells(22).Value.ToString()
        End If
        txt_categoria.Text = dgv_curso.CurrentRow.Cells(26).Value.ToString()
        txt_categoria2.Text = dgv_curso.CurrentRow.Cells(27).Value.ToString()

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
        txt_fecha.Text = "9998-12-31"
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (cod_cur = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_cur.eliminar(CInt(cod_cur))
                actualizar_dgv2()
            Else
                bloquear()

            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        actualizar_dgv2()
    End Sub
    Sub actualizar_dgv2()
        Dim codigo, nombre As String
        codigo = txt_codigo.Text
        nombre = txt_nombre.Text
        codigo = codigo.Replace(" ", String.Empty)
        If Len(nombre) < 4 Then
            nombre = nombre.Replace(" ", String.Empty)
        End If
        dgv_curso.DataSource = nue_cur.listar14(codigo, nombre)
        dgv_curso.Columns(0).Visible = False
        dgv_curso.Columns(1).HeaderText = "Código"
        dgv_curso.Columns(2).Visible = False
        dgv_curso.Columns(3).HeaderText = "Descripción"
        dgv_curso.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(4).Visible = False
        dgv_curso.Columns(5).Visible = False
        dgv_curso.Columns(6).Visible = False
        dgv_curso.Columns(3).Width = 250
        dgv_curso.Columns(5).Width = 60
        dgv_curso.Columns(21).Width = 60
        dgv_curso.Columns(7).Width = 60
        dgv_curso.Columns(8).Width = 60
        dgv_curso.Columns(19).Width = 60
        dgv_curso.Columns(7).HeaderText = "Ancho"
        dgv_curso.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(8).HeaderText = "Largo"
        dgv_curso.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(9).Visible = False
        dgv_curso.Columns(10).Visible = False
        dgv_curso.Columns(11).Visible = False
        dgv_curso.Columns(12).Visible = False
        dgv_curso.Columns(13).Visible = False
        dgv_curso.Columns(14).Visible = False
        dgv_curso.Columns(15).Visible = False
        dgv_curso.Columns(16).Visible = False
        dgv_curso.Columns(17).Visible = False
        dgv_curso.Columns(18).Visible = False
        dgv_curso.Columns(19).HeaderText = "Stock"
        dgv_curso.Columns(20).Visible = False
        dgv_curso.Columns(21).Visible = False
        dgv_curso.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(22).Visible = False
        dgv_curso.Columns(23).HeaderText = "Precio Máximo"
        dgv_curso.Columns(24).HeaderText = "Precio Mínimo"
        dgv_curso.Columns(25).Visible = False
        dgv_curso.Columns(26).Visible = False
        dgv_curso.Columns(27).Visible = False
        dgv_curso.AllowUserToOrderColumns = True
        dgv_curso.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(21).DefaultCellStyle.Format = "##,###."
        dgv_curso.Columns(23).DefaultCellStyle.Format = "##,###."
        dgv_curso.Columns(24).DefaultCellStyle.Format = "##,###."
        dgv_curso.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_curso.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Private Sub txt_ancho_TextChanged(sender As Object, e As EventArgs) Handles txt_ancho.TextChanged
        txt_area.Clear()
        If (IsNumeric(Me.txt_largo.Text) And IsNumeric(Me.txt_ancho.Text)) Then
            txt_area.Text = CDbl(Me.txt_ancho.Text) * CDbl(Me.txt_largo.Text)
            txt_area.Text = Format(CDbl(txt_area.Text), "##,##0.00")
        End If
    End Sub

    Private Sub txt_largo_TextChanged(sender As Object, e As EventArgs) Handles txt_largo.TextChanged
        txt_area.Clear()
        If (IsNumeric(Me.txt_largo.Text) And IsNumeric(Me.txt_ancho.Text)) Then
            txt_area.Text = CDbl(Me.txt_ancho.Text) * CDbl(Me.txt_largo.Text)
            txt_area.Text = Format(CDbl(txt_area.Text), "##,##0.00")
        End If
    End Sub



    Private Sub txt_medidas_LostFocus(sender As Object, e As EventArgs) Handles txt_medidas.LostFocus
        Dim medidas As String
        Dim aryTextFile() As String
        txt_medidas.Text = UCase(txt_medidas.Text)
        medidas = txt_medidas.Text
        If medidas.Contains("X") Then
            aryTextFile = medidas.Split("X")
            txt_ancho.Text = aryTextFile(0)
            txt_largo.Text = aryTextFile(1)
        Else
            txt_ancho.Clear()
            txt_largo.Clear()
        End If
    End Sub

End Class