Public Class frm_filtro_ejecutivo

    Dim nue_cur As New clases.Estados_de_pago
    Dim cod_cur As String = ""
    Dim sw As Integer


    Private Sub frm_filtro_ejecutivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizar_ejecutivos()
    End Sub

    Public Sub actualizar_ejecutivos()
        cmb_ejecutivo.DataSource = nue_cur.listar3()
        cmb_ejecutivo.DisplayMember = "ejec_cobranza"
        cmb_ejecutivo.ValueMember = "ejec_cobranza"
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        CR_Estado_de_cuenta_todos_ejecutivos.Show()
    End Sub
End Class