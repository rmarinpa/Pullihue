Imports System.Globalization
Public Class frm_mod_pagos

    Dim nue_cur As New clases.Registro_pagos
    Dim cod_cur As String = ""
    Dim sw As Integer
    Dim Cod_Pagos As String = ""

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Sub actualizar_dgv()
        dgv_pagos.DataSource = nue_cur.listar4(txt_rut.Text)
        dgv_pagos.Columns(0).Visible = False
        dgv_pagos.Columns(1).HeaderText = "Fecha Op."
        dgv_pagos.Columns(2).HeaderText = "Operación"
        dgv_pagos.Columns(3).HeaderText = "Banco"
        dgv_pagos.Columns(4).HeaderText = "Serie"
        dgv_pagos.Columns(5).HeaderText = "N° Factura"
        dgv_pagos.Columns(6).HeaderText = "Total Adeudado"
        dgv_pagos.Columns(7).HeaderText = "Monto"
        dgv_pagos.Columns(8).HeaderText = "Diferencia"
        dgv_pagos.Columns(9).HeaderText = "Fecha Cheque"
        dgv_pagos.Columns(10).Visible = False
        dgv_pagos.Columns(11).Visible = False
        dgv_pagos.Columns(12).Visible = False
        dgv_pagos.Columns(13).Visible = False

        dgv_pagos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pagos.Columns(1).Width = 70
        dgv_pagos.Columns(2).Width = 120
        dgv_pagos.Columns(3).Width = 100
        dgv_pagos.Columns(4).Width = 70
        dgv_pagos.Columns(5).Width = 70
        dgv_pagos.Columns(6).Width = 70
        dgv_pagos.Columns(7).Width = 70
        dgv_pagos.Columns(8).Width = 70
        dgv_pagos.Columns(9).Width = 70
        dgv_pagos.Columns(12).Width = 300
        dgv_pagos.Columns(6).DefaultCellStyle.Format = "##,###."
        dgv_pagos.Columns(7).DefaultCellStyle.Format = "##,###."
        dgv_pagos.Columns(8).DefaultCellStyle.Format = "##,###."
        dgv_pagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub frm_mod_pagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_dgv()
        cmb_operacion.Enabled = False
        txt_nombre.Enabled = False
        txt_rut.Enabled = False
    End Sub

    Private Sub dgv_pagos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pagos.CellClick
        Cod_Pagos = dgv_pagos.CurrentRow.Cells(0).Value.ToString()
        cmb_operacion.Text = dgv_pagos.CurrentRow.Cells(2).Value.ToString()
        cmb_banco.Text = dgv_pagos.CurrentRow.Cells(3).Value.ToString()
        txt_serie.Text = dgv_pagos.CurrentRow.Cells(4).Value.ToString()
        dtp_fecha_pago.Text = dgv_pagos.CurrentRow.Cells(9).Value.ToString()
        txt_factura.Text = dgv_pagos.CurrentRow.Cells(5).Value.ToString()
        txt_total.Text = dgv_pagos.CurrentRow.Cells(6).Value.ToString()
        txt_dif.Text = dgv_pagos.CurrentRow.Cells(8).Value.ToString()
        txt_monto.Text = dgv_pagos.CurrentRow.Cells(7).Value.ToString()
    End Sub
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If (Cod_Pagos = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            Dim operacion, banco, serie, factura As String
            Dim fecha As Date
            Dim monto, total, diferencia As Double

            operacion = cmb_operacion.Text
            banco = cmb_banco.Text
            serie = txt_serie.Text
            fecha = dtp_fecha_pago.Text
            factura = txt_factura.Text
            monto = txt_monto.Text
            total = txt_total.Text
            diferencia = txt_dif.Text

            nue_cur.modificar(CInt(Cod_Pagos), operacion, banco, serie, CDate(dtp_fecha_pago.Text), factura, monto, total, diferencia)
            actualizar_dgv()
            MessageBox.Show("SU REGISTRO SE HA MODIFICADO CON EXITO")
        End If
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Frm_clientes_busqueda_rp.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Pagos = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_cur.eliminar(CInt(Cod_Pagos))
                actualizar_dgv()
            Else
            End If
        End If
    End Sub

    Private Sub txt_monto_TextChanged(sender As Object, e As EventArgs) Handles txt_monto.TextChanged
        If IsNumeric(txt_monto.Text) Then
            txt_dif.Text = CDbl(txt_total.Text) - CDbl(txt_monto.Text)
        End If
    End Sub

    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged
        actualizar_dgv()
    End Sub
End Class