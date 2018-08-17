Public Class Frm_Petroleo_varios

    Dim nue_report As New clases.Petroleo_varios
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer
    Sub bloquear()
        gbx_Petroleo.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_nuevo.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_Petroleo.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_nuevo.Enabled = False
    End Sub

    Sub limpiar()
        txt_litros_de_consumo.Clear()
        txt_litros_de_consumo1.Clear()
        txt_litros_de_consumo2.Clear()
        txt_litros_de_consumo3.Clear()
        txt_litros_de_consumo4.Clear()
        txt_litros_de_consumo5.Clear()
        txt_litros_de_consumo6.Clear()
        txt_litros_de_consumo7.Clear()
        txt_litros_de_consumo8.Clear()
        txt_litros_de_consumo9.Clear()
        txt_codigo.Clear()
        txt_codigo1.Clear()
        txt_codigo2.Clear()
        txt_codigo3.Clear()
        txt_codigo4.Clear()
        txt_codigo5.Clear()
        txt_codigo6.Clear()
        txt_codigo7.Clear()
        txt_codigo8.Clear()
        txt_codigo9.Clear()

        txt_descripcion.Clear()
        txt_descripcion1.Clear()
        txt_descripcion2.Clear()
        txt_descripcion3.Clear()
        txt_descripcion4.Clear()
        txt_descripcion5.Clear()
        txt_descripcion6.Clear()
        txt_descripcion7.Clear()
        txt_descripcion8.Clear()
        txt_descripcion9.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_Petroleo.DataSource = nue_report.listar(Nombre_Obra)
        dgv_Petroleo.Columns(0).Visible = False
        dgv_Petroleo.Columns(1).HeaderText = "N° de Vale"
        dgv_Petroleo.Columns(2).HeaderText = "Código"
        dgv_Petroleo.Columns(3).HeaderText = "Fecha"
        dgv_Petroleo.Columns(4).HeaderText = "Litros de Consumo"
        dgv_Petroleo.Columns(4).DefaultCellStyle.Format = "#,#"
        dgv_Petroleo.AllowUserToOrderColumns = True
    End Sub


    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_descripcion.Enabled = False
        txt_descripcion1.Enabled = False
        txt_descripcion2.Enabled = False
        txt_descripcion3.Enabled = False
        txt_descripcion4.Enabled = False
        txt_descripcion5.Enabled = False
        txt_descripcion6.Enabled = False
        txt_descripcion7.Enabled = False
        txt_descripcion8.Enabled = False
        txt_descripcion9.Enabled = False
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo, codigo1, codigo2, codigo3, codigo4, codigo5, codigo6, codigo7, codigo8, codigo9, obra As String
        Dim litros_consumo, litros_consumo1, litros_consumo2, litros_consumo3, litros_consumo4, litros_consumo5, litros_consumo6, litros_consumo7, litros_consumo8, litros_consumo9, N_de_vale As Double

        If (txt_descripcion.Text <> "" And txt_descripcion1.Text <> "" And txt_descripcion2.Text <> "" And txt_descripcion3.Text <> "" And txt_descripcion4.Text <> "" And txt_descripcion5.Text <> "" And txt_descripcion6.Text <> "" And txt_descripcion7.Text <> "" And txt_descripcion8.Text <> "" And txt_descripcion9.Text <> "") Then

            codigo = txt_codigo.Text
            codigo1 = txt_codigo1.Text
            codigo2 = txt_codigo2.Text
            codigo3 = txt_codigo3.Text
            codigo4 = txt_codigo4.Text
            codigo5 = txt_codigo5.Text
            codigo6 = txt_codigo6.Text
            codigo7 = txt_codigo7.Text
            codigo8 = txt_codigo8.Text
            codigo9 = txt_codigo9.Text
            litros_consumo = Convert.ToInt64(txt_litros_de_consumo.Text)
            litros_consumo1 = Convert.ToInt64(txt_litros_de_consumo1.Text)
            litros_consumo2 = Convert.ToInt64(txt_litros_de_consumo2.Text)
            litros_consumo3 = Convert.ToInt64(txt_litros_de_consumo3.Text)
            litros_consumo4 = Convert.ToInt64(txt_litros_de_consumo4.Text)
            litros_consumo5 = Convert.ToInt64(txt_litros_de_consumo5.Text)
            litros_consumo6 = Convert.ToInt64(txt_litros_de_consumo6.Text)
            litros_consumo7 = Convert.ToInt64(txt_litros_de_consumo7.Text)
            litros_consumo8 = Convert.ToInt64(txt_litros_de_consumo8.Text)
            litros_consumo9 = Convert.ToInt64(txt_litros_de_consumo9.Text)
            N_de_vale = "0"
            obra = txt_nombre_obra.Text
            If sw = 0 Then
                nue_report.insertar(N_de_vale, codigo, CDate(txt_fecha.Text), litros_consumo, obra)
                nue_report.insertar(N_de_vale, codigo1, CDate(txt_fecha1.Text), litros_consumo1, obra)
                nue_report.insertar(N_de_vale, codigo2, CDate(txt_fecha2.Text), litros_consumo2, obra)
                nue_report.insertar(N_de_vale, codigo3, CDate(txt_fecha3.Text), litros_consumo3, obra)
                nue_report.insertar(N_de_vale, codigo4, CDate(txt_fecha4.Text), litros_consumo4, obra)
                nue_report.insertar(N_de_vale, codigo5, CDate(txt_fecha5.Text), litros_consumo5, obra)
                nue_report.insertar(N_de_vale, codigo6, CDate(txt_fecha6.Text), litros_consumo6, obra)
                nue_report.insertar(N_de_vale, codigo7, CDate(txt_fecha7.Text), litros_consumo7, obra)
                nue_report.insertar(N_de_vale, codigo8, CDate(txt_fecha8.Text), litros_consumo8, obra)
                nue_report.insertar(N_de_vale, codigo9, CDate(txt_fecha9.Text), litros_consumo9, obra)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Petroleo), N_de_vale, codigo, CDate(txt_fecha.Text), litros_consumo, obra)
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

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Cod_Petroleo = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim eliminar As MsgBoxResult
        If (Cod_Petroleo = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Petroleo))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub
    Private Sub txt_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_descripcion.Text = nue_report.descripcion_patente(txt_codigo.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo1.TextChanged
        txt_descripcion1.Text = nue_report.descripcion_patente(txt_codigo1.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo2.TextChanged
        txt_descripcion2.Text = nue_report.descripcion_patente(txt_codigo2.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo3.TextChanged
        txt_descripcion3.Text = nue_report.descripcion_patente(txt_codigo3.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo4.TextChanged
        txt_descripcion4.Text = nue_report.descripcion_patente(txt_codigo4.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo5.TextChanged
        txt_descripcion5.Text = nue_report.descripcion_patente(txt_codigo5.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo6.TextChanged
        txt_descripcion6.Text = nue_report.descripcion_patente(txt_codigo6.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo7.TextChanged
        txt_descripcion7.Text = nue_report.descripcion_patente(txt_codigo7.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo8.TextChanged
        txt_descripcion8.Text = nue_report.descripcion_patente(txt_codigo8.Text, txt_nombre_obra.Text)
    End Sub
    Private Sub txt_codigo9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo9.TextChanged
        txt_descripcion9.Text = nue_report.descripcion_patente(txt_codigo9.Text, txt_nombre_obra.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        actualizar_dgv()
    End Sub
End Class