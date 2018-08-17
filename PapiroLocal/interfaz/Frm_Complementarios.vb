Public Class Frm_Complementarios


    Dim nue_report As New clases.Complementarios
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
        txt_codigo1.Enabled = False
        txt_descripcion1.Enabled = False
        txt_codigo2.Enabled = False
        txt_descripcion2.Enabled = False


    End Sub

    Sub desbloquear()
        gbx_Petroleo.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Sub limpiar()
        txt_descripcion1.Clear()
        txt_descripcion2.Clear()
        txt_codigo1.Clear()
        txt_codigo2.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_Petroleo.DataSource = nue_report.listar()
        dgv_Petroleo.Columns(0).Visible = False
        dgv_Petroleo.Columns(1).HeaderText = "Producto Complementario 1"
        dgv_Petroleo.Columns(2).HeaderText = "Descripción"
        dgv_Petroleo.Columns(3).HeaderText = "Producto Complementario 2"
        dgv_Petroleo.Columns(4).HeaderText = "Descripción"
        dgv_Petroleo.AllowUserToOrderColumns = True
        dgv_Petroleo.Columns(4).Width = 200
        dgv_Petroleo.Columns(2).Width = 200
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        txt_descripcion1.Enabled = False
        txt_descripcion2.Enabled = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo1, descripcion1, codigo2, descripcion2 As String


        If (txt_codigo1.Text <> "" And txt_descripcion1.Text <> "" And txt_descripcion2.Text <> "" And txt_codigo2.Text <> "") Then

            codigo1 = txt_codigo1.Text
            descripcion1 = txt_descripcion1.Text
            codigo2 = txt_codigo2.Text
            descripcion2 = txt_descripcion2.Text


            If sw = 0 Then
                nue_report.insertar(codigo1, descripcion1, codigo2, descripcion2)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Petroleo), codigo1, descripcion1, codigo2, descripcion2)
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

    Private Sub dgv_Petroleo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Petroleo.CellDoubleClick

        Cod_Petroleo = dgv_Petroleo.CurrentRow.Cells(0).Value.ToString()
        txt_codigo1.Text = dgv_Petroleo.CurrentRow.Cells(1).Value.ToString()
        txt_descripcion1.Text = dgv_Petroleo.CurrentRow.Cells(2).Value.ToString()
        txt_codigo2.Text = dgv_Petroleo.CurrentRow.Cells(3).Value.ToString()
        txt_descripcion2.Text = dgv_Petroleo.CurrentRow.Cells(4).Value.ToString()

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
        Frm_productos_complementario1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_productos_complementario2.Show()
    End Sub
End Class