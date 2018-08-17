Imports System.Globalization
Public Class Frm_autorizar_nc
    Dim nue_report As New clases.Nota_credito
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

    Sub actualizar_dgv()
        dgv_venta2.DataSource = nue_report.listar2(motivo1, motivo2, motivo3)
        dgv_venta2.Columns(0).Visible = False
        dgv_venta2.Columns(1).HeaderText = "Nota de Crédito"
        dgv_venta2.Columns(2).Visible = False
        dgv_venta2.Columns(3).HeaderText = "Factura"
        dgv_venta2.Columns(4).HeaderText = "Cliente"
        dgv_venta2.Columns(5).Visible = False
        dgv_venta2.Columns(6).Visible = False
        dgv_venta2.Columns(7).Visible = False
        dgv_venta2.Columns(8).Visible = False
        dgv_venta2.Columns(9).Visible = False
        dgv_venta2.Columns(10).Visible = False
        dgv_venta2.Columns(11).Visible = False
        dgv_venta2.Columns(12).Visible = False
        dgv_venta2.Columns(13).Visible = False
        dgv_venta2.Columns(14).Visible = False
        dgv_venta2.Columns(15).Visible = False
        dgv_venta2.Columns(16).Visible = False
        dgv_venta2.Columns(17).HeaderText = "Status"
        dgv_venta2.Columns(18).Visible = False
        dgv_venta2.Columns(19).Visible = False
        dgv_venta2.Columns(20).Visible = False

        dgv_venta2.Columns(1).Width = 70
        dgv_venta2.Columns(2).Width = 70
        dgv_venta2.Columns(3).Width = 70
        dgv_venta2.Columns(4).Width = 300
        dgv_venta2.Columns(17).Width = 100

    End Sub

    Private Sub Frm_autorizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If motivo = "VENTA" Then
            motivo1 = "Motivo_1"
            motivo2 = "Motivo_2"
            motivo3 = "Motivo_2"
            Venta.Enabled = True
            Logistica.Enabled = False
            Servicio_Tecnico.Enabled = False
            txt_usuario.Text = Nombre_Obra
        ElseIf motivo = "LOGISTICA" Then
            motivo1 = "Motivo_3"
            motivo2 = "Motivo_4"
            motivo3 = "Motivo_5"
            Venta.Enabled = False
            Logistica.Enabled = True
            Servicio_Tecnico.Enabled = False
            txt_usuario1.Text = Nombre_Obra
        ElseIf motivo = "SERVICIO TECNICO" Then
            motivo1 = "Motivo_3"
            motivo2 = "Motivo_3"
            motivo3 = "Motivo_3"
            Venta.Enabled = False
            Logistica.Enabled = False
            Servicio_Tecnico.Enabled = True
            txt_usuario2.Text = Nombre_Obra
        Else
            Venta.Enabled = False
            Logistica.Enabled = False
            Servicio_Tecnico.Enabled = False
        End If
        actualizar_dgv()
        Me.Location = New Point(200, 10)
        GroupBox6.Visible = False
        txt_usuario.ReadOnly = True
        txt_usuario1.ReadOnly = True
        txt_usuario2.ReadOnly = True
        txt_motivo.ReadOnly = True
        cmb_status.Text = "PENDIENTE"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dgv()
    End Sub


    Private Sub dgv_venta2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta2.CellDoubleClick

        If dgv_venta2.CurrentRow.Cells(16).Value.ToString() = "Motivo_1" Then
            txt_motivo.Text = "Diferencia de Precio - Autorización Venta"
        ElseIf dgv_venta2.CurrentRow.Cells(16).Value.ToString() = "Motivo_2" Then
            txt_motivo.Text = "Descuento Comercial - Autorización Venta"
        ElseIf dgv_venta2.CurrentRow.Cells(16).Value.ToString() = "Motivo_3" Then
            txt_motivo.Text = "Mercadería Defectuosa - Autorización Logística y Servicio Técnico"
        ElseIf dgv_venta2.CurrentRow.Cells(16).Value.ToString() = "Motivo_4" Then
            txt_motivo.Text = "Devolución Mercaderia - Autorización Logística"
        ElseIf dgv_venta2.CurrentRow.Cells(16).Value.ToString() = "Motivo_5" Then
            txt_motivo.Text = "No Sale de Bodega - Autorización Logística"
        End If
        txt_folio.Text = dgv_venta2.CurrentRow.Cells(1).Value.ToString()

        txt_obs_venta.Text = dgv_venta2.CurrentRow.Cells(7).Value.ToString()
        txt_obs_log.Text = dgv_venta2.CurrentRow.Cells(10).Value.ToString()
        txt_obs_serv.Text = dgv_venta2.CurrentRow.Cells(12).Value.ToString()
        txt_respuesta.Text = dgv_venta2.CurrentRow.Cells(20).Value.ToString()
        txt_contacto.Text = dgv_venta2.CurrentRow.Cells(19).Value.ToString()

        If motivo = "VENTA" Then
            txt_usuario1.Text = dgv_venta2.CurrentRow.Cells(14).Value.ToString()
            txt_usuario2.Text = dgv_venta2.CurrentRow.Cells(15).Value.ToString()
        ElseIf motivo = "LOGISTICA" Then
            txt_usuario.Text = dgv_venta2.CurrentRow.Cells(13).Value.ToString()
            txt_usuario2.Text = dgv_venta2.CurrentRow.Cells(15).Value.ToString()
        ElseIf motivo = "SERVICIO TECNICO" Then
            txt_usuario.Text = dgv_venta2.CurrentRow.Cells(13).Value.ToString()
            txt_usuario1.Text = dgv_venta2.CurrentRow.Cells(14).Value.ToString()
        Else
        End If

        If dgv_venta2.CurrentRow.Cells(18).Value.ToString() <> "" Then
            dtp_fecha.Text = dgv_venta2.CurrentRow.Cells(18).Value.ToString()
        Else
        End If
        cmb_status.Text = dgv_venta2.CurrentRow.Cells(17).Value.ToString()

        If dgv_venta2.CurrentRow.Cells(5).Value.ToString() = "1" Then
            rdbtn_cliente1.Checked = True
        ElseIf dgv_venta2.CurrentRow.Cells(5).Value.ToString() = "2" Then
            rdbtn_cliente2.Checked = True
        ElseIf dgv_venta2.CurrentRow.Cells(5).Value.ToString() = "3" Then
            rdbtn_cliente3.Checked = True
        Else
            rdbtn_cliente3.Checked = False
            rdbtn_cliente1.Checked = False
            rdbtn_cliente2.Checked = False
        End If

        If dgv_venta2.CurrentRow.Cells(6).Value.ToString() = "1" Then
            bodega_si.Checked = True
        ElseIf dgv_venta2.CurrentRow.Cells(6).Value.ToString() = "2" Then
            bodega_no.Checked = True
        Else
            bodega_no.Checked = False
            bodega_si.Checked = False
        End If

        If dgv_venta2.CurrentRow.Cells(8).Value.ToString() = "1" Then
            material_si.Checked = True
        ElseIf dgv_venta2.CurrentRow.Cells(8).Value.ToString() = "2" Then
            material_no.Checked = True
        Else
            material_si.Checked = False
            material_no.Checked = False
        End If

        If dgv_venta2.CurrentRow.Cells(11).Value.ToString() = "1" Then
            inventario_si.Checked = True
        ElseIf dgv_venta2.CurrentRow.Cells(11).Value.ToString() = "2" Then
            inventario_no.Checked = True
        Else
            inventario_no.Checked = False
            inventario_si.Checked = False
        End If
        CR_Nota_Credito_aut.Show()
    End Sub

    Private Sub inventario_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inventario_si.CheckedChanged
        If inventario_si.Checked = False Then
            GroupBox6.Visible = True
        ElseIf inventario_si.Checked = True Then
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub inventario_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inventario_no.CheckedChanged
        If inventario_no.Checked = True Then
            GroupBox6.Visible = True
        ElseIf inventario_no.Checked = False Then
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim folio, con_venta, con_prod, obs_venta, con_material, con_desp, obs_logistica, con_inv, obs_serv, autoriza_venta, autoriza_logistica, autoriza_serv, status, contacto, respuesta As String
        Dim fecha_reclamo As Date

        If rdbtn_cliente1.Checked = True Then
            con_venta = "1"
        ElseIf rdbtn_cliente2.Checked = True Then
            con_venta = "2"
        ElseIf rdbtn_cliente3.Checked = True Then
            con_venta = "3"
        Else
            con_venta = "0"
        End If

        If bodega_si.Checked = True Then
            con_prod = "1"
        ElseIf bodega_no.Checked = True Then
            con_prod = "2"
        Else
            con_prod = "0"
        End If

        obs_venta = txt_obs_venta.Text

        If material_si.Checked = True Then
            con_material = "1"
        ElseIf material_no.Checked = True Then
            con_material = "2"
        Else
            con_material = "0"
        End If

        con_desp = ""
        obs_logistica = txt_obs_log.Text
        If inventario_si.Checked = True Then
            con_inv = "1"
        ElseIf inventario_no.Checked = True Then
            con_inv = "2"
        Else
            con_inv = "0"
        End If

        obs_serv = txt_obs_serv.Text
        autoriza_venta = txt_usuario.Text
        autoriza_logistica = txt_usuario1.Text
        autoriza_serv = txt_usuario2.Text
        'motivo
        status = cmb_status.Text
        If dtp_fecha.Text = "" Then
            fecha_reclamo = Today
        Else
            fecha_reclamo = CDate(dtp_fecha.Text)
        End If
        contacto = txt_contacto.Text
        respuesta = txt_respuesta.Text
        folio = txt_folio.Text

        If (txt_motivo.Text <> "") Then
            nue_report.modificar(folio, con_venta, con_prod, obs_venta, con_material, con_desp, obs_logistica, con_inv, obs_serv, autoriza_venta, autoriza_logistica, autoriza_serv, status, fecha_reclamo, contacto, respuesta)
            actualizar_dgv()
            limpiar()
            MessageBox.Show("SU REGISTRO HA SIDO ACTUALIZADO")
        Else
            MessageBox.Show("SELECCIONA UN REGISTRO")
        End If
    End Sub
    Public Sub limpiar()
        txt_usuario.Clear()
        txt_usuario1.Clear()
        txt_usuario2.Clear()
        rdbtn_cliente1.Checked = False
        rdbtn_cliente2.Checked = False
        rdbtn_cliente3.Checked = False
        bodega_si.Checked = False
        bodega_no.Checked = False
        material_si.Checked = False
        material_no.Checked = False
        inventario_si.Checked = False
        inventario_no.Checked = False
        txt_contacto.Clear()
        txt_respuesta.Clear()
        txt_obs_serv.Clear()
        txt_obs_log.Clear()
        txt_obs_venta.Clear()
        cmb_status.Text = "PENDIENTE"
        dtp_fecha.Text = Today
        GroupBox6.Visible = False
        txt_motivo.Clear()
    End Sub

    Private Sub dgv_venta2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_venta2.CellContentClick

    End Sub
End Class