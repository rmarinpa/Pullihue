Public Class frm_ruta

    Dim nue_usua As New clases.Ruta
    Dim cod_usua As String = ""
    Dim sw As Integer

    Sub actualizar_dgv()
        dgv_usuario.DataSource = nue_usua.listar2(Folio)
        dgv_usuario.Columns(0).Visible = False
        dgv_usuario.Columns(1).HeaderText = "Usuario"
        dgv_usuario.Columns(2).HeaderText = "Chofer"
        dgv_usuario.Columns(3).HeaderText = "Vehículo"
        dgv_usuario.Columns(4).Visible = False
        dgv_usuario.Columns(5).Visible = False
        dgv_usuario.Columns(6).HeaderText = "N° Pedido"
        dgv_usuario.Columns(7).HeaderText = "Ejecutivo"
        dgv_usuario.Columns(8).HeaderText = "Dirección"
        dgv_usuario.Columns(9).HeaderText = "Comuna"
        dgv_usuario.Columns(10).Visible = False
        dgv_usuario.Columns(1).Width = 65
        dgv_usuario.Columns(2).Width = 65
        dgv_usuario.Columns(3).Width = 65
        dgv_usuario.Columns(6).Width = 65
        dgv_usuario.Columns(7).Width = 65
        dgv_usuario.Columns(9).Width = 100
        dgv_usuario.Columns(8).Width = 350
    End Sub

    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
    End Sub

End Class