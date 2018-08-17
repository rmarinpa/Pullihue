Public Class Frm_Petroleo

    Dim nue_report As New clases.Petroleo
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer


    Sub bloquear()
        gbx_Petroleo.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True

    End Sub

    Sub desbloquear()
        gbx_Petroleo.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Public Sub actualizar_contratos()
        txt_codigo.DataSource = nue_report.listar2(Nombre_Obra)
        txt_codigo.DisplayMember = "Codigo_maquina"
        txt_codigo.ValueMember = "Id_contrato"
    End Sub

    Sub limpiar()
        txt_litros_de_consumo.Clear()
        txt_n_de_vale.Clear()

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
        actualizar_contratos()
        txt_descripcion.Enabled = False
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo, obra As String
        Dim litros_consumo, N_de_vale As Double



        If (txt_codigo.Text <> "" And txt_litros_de_consumo.Text <> "" And txt_descripcion.Text <> "") Then

            codigo = txt_codigo.Text
            If Not IsNumeric(txt_n_de_vale.Text) Then
                txt_n_de_vale.Text = 0
            End If
            litros_consumo = Convert.ToInt64(txt_litros_de_consumo.Text)
            N_de_vale = Convert.ToInt64(txt_n_de_vale.Text)
            obra = txt_nombre_obra.Text


            If sw = 0 Then
                nue_report.insertar(N_de_vale, codigo, CDate(txt_fecha.Text), litros_consumo, obra)
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

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_Petroleo = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_Petroleo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Petroleo.CellClick

    End Sub

    Private Sub dgv_Petroleo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Petroleo.CellDoubleClick

        Cod_Petroleo = dgv_Petroleo.CurrentRow.Cells(0).Value.ToString()
        txt_n_de_vale.Text = dgv_Petroleo.CurrentRow.Cells(1).Value.ToString()
        txt_codigo.Text = dgv_Petroleo.CurrentRow.Cells(2).Value.ToString()
        txt_fecha.Text = dgv_Petroleo.CurrentRow.Cells(3).Value.ToString()
        txt_litros_de_consumo.Text = dgv_Petroleo.CurrentRow.Cells(4).Value.ToString()

    End Sub
    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_descripcion.Text = nue_report.descripcion_patente(txt_codigo.Text, txt_nombre_obra.Text)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_storage.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        actualizar_dgv()
    End Sub

    Private Sub txt_codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.SelectedIndexChanged

    End Sub

    Private Sub dgv_Petroleo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Petroleo.CellContentClick

    End Sub
End Class