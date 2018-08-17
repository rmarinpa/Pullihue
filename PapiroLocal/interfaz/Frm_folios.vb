Imports System.Globalization
Public Class Frm_folios
    Dim nue_report As New clases.Folios
    Dim nue_var As New clases.variables
    Dim Cod_folios As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub bloquear()
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        txt_tipo.Enabled = False
        txt_doc.Enabled = False
        txt_folio_in.Enabled = False
        txt_folio_fin.Enabled = False
        txt_ult_folio.Enabled = False

    End Sub

    Sub desbloquear()
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
        txt_tipo.Enabled = True
        txt_doc.Enabled = True
        txt_folio_in.Enabled = True
        txt_folio_fin.Enabled = True
        txt_ult_folio.Enabled = True

    End Sub
    Sub limpiar()
        txt_tipo.Clear()
        txt_doc.Clear()
        txt_folio_in.Clear()
        txt_folio_fin.Clear()
        txt_ult_folio.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_folios.DataSource = nue_report.listar()
        dgv_folios.Columns(0).Visible = False
        dgv_folios.Columns(1).HeaderText = "Tipo Doc."
        dgv_folios.Columns(2).HeaderText = "Documento"
        dgv_folios.Columns(3).HeaderText = "Folio Inicial"
        dgv_folios.Columns(3).DefaultCellStyle.Format = "#,#"
        dgv_folios.Columns(4).HeaderText = "Folio Final"
        dgv_folios.Columns(4).DefaultCellStyle.Format = "#,#"
        dgv_folios.Columns(5).HeaderText = "Último Folio"
        dgv_folios.Columns(5).DefaultCellStyle.Format = "#,#"
        dgv_folios.AllowUserToOrderColumns = True
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_folios = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_folios))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub
    Private Sub dgv_folios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_folios.DoubleClick
        Cod_folios = dgv_folios.CurrentRow.Cells(0).Value.ToString()
        txt_tipo.Text = dgv_folios.CurrentRow.Cells(1).Value.ToString()
        txt_doc.Text = dgv_folios.CurrentRow.Cells(2).Value.ToString()
        txt_folio_in.Text = dgv_folios.CurrentRow.Cells(3).Value.ToString()
        txt_folio_fin.Text = dgv_folios.CurrentRow.Cells(4).Value.ToString()
        txt_ult_folio.Text = dgv_folios.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btn_nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub Frm_folios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar_dgv()
        bloquear()
    End Sub

    Private Sub btn_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim tipo, doc As String
        Dim fol_in, fol_fin, ult_fol As Integer

        If (txt_tipo.Text <> "" And txt_doc.Text <> "" And txt_folio_in.Text <> "" And txt_folio_fin.Text <> "" And txt_ult_folio.Text <> "") Then

            tipo = txt_tipo.Text
            doc = txt_doc.Text
            fol_in = Convert.ToInt64(txt_folio_in.Text)
            fol_fin = Convert.ToInt64(txt_folio_fin.Text)
            ult_fol = Convert.ToInt64(txt_ult_folio.Text)

            If sw = 0 Then
                nue_report.insertar(tipo, doc, fol_in, fol_fin, ult_fol)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_folios), tipo, doc, fol_in, fol_fin, ult_fol)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_folios = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub
End Class