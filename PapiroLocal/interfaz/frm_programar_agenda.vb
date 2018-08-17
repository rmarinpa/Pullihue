Public Class frm_programar_agenda
    Dim nue_cur As New clases.Registro_llamada
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub frm_registro_llamada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_fecha.ReadOnly = True
        Timer1.Enabled = True
        txt_usuario.ReadOnly = True
        txt_usuario.Text = Nombre_Obra
        limpiar()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txt_fecha.Text = Today
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_clientes_busqueda_agenda.Show()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim hecho, cliente, atendio, motivo, telefono, tipo_llamada, estado_de_linea, importancia, informe, fecha, usuario, tipo, tipo_medio, folio, Tipo_dia As String
        Dim llamada_iniciada, llamada_finalizada, duracion, fecha_actual, fecha_programada As Date

        hecho = "no"

        If txt_cliente.Text <> "" And txt_informe.Text <> "" Then
            If editar = 0 Then
                cliente = txt_cliente.Text
                atendio = ""
                motivo = txt_motivo.Text
                telefono = ""
                tipo_llamada = ""
                llamada_iniciada = CDate(txt_fecha.Text)
                llamada_finalizada = CDate(txt_fecha.Text)
                duracion = CDate(txt_fecha.Text)
                estado_de_linea = ""
                importancia = txt_motivo.Text
                informe = txt_informe.Text
                fecha = CDate(txt_fecha.Text)
                usuario = txt_usuario.Text
                tipo = "Programación"
                tipo_medio = ""
                txt_folio.Text = nue_cur.descripcion_numero_folio() + 1
                folio = txt_folio.Text
                fecha_actual = CDate(txt_fecha.Text)
                fecha_programada = CDate(txt_fecha_prog.Text)
                Tipo_dia = cmb_dia.Text
                nue_cur.insertar(cliente, atendio, motivo, telefono, tipo_llamada, llamada_iniciada, llamada_finalizada, duracion, estado_de_linea, importancia, informe, fecha, usuario, tipo, tipo_medio, folio)
                nue_cur.insertar2(fecha_actual, fecha_programada, Tipo_dia, folio, hecho)
                limpiar()
                MessageBox.Show("SU REGISTRO HA SIDO PROGRAMADO")
                frm_agenda2.actualizar_dgv()
            ElseIf editar = 1 Then
                cliente = txt_cliente.Text
                fecha_programada = CDate(txt_fecha_prog.Text)
                Tipo_dia = cmb_dia.Text
                motivo = txt_motivo.Text
                informe = txt_informe.Text
                folio = txt_folio.Text
                nue_cur.modificar(cliente, motivo, informe, folio)
                nue_cur.modificar2(fecha_programada, Tipo_dia, folio)
                MessageBox.Show("SU REGISTRO HA SIDO MODIFICADO")
                frm_agenda2.actualizar_dgv()
                Me.Close()
            End If
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
    Sub limpiar()
        txt_cliente.Clear()
        Timer1.Enabled = True
        txt_informe.Clear()
        txt_motivo.Clear()
    End Sub
End Class