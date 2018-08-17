Public Class frm_estado_de_pago_subcontrato
    Dim nue_cur As New clases.Estados_de_pago_subcontrato
    Dim cod_cur As String = ""
    Dim sw As Integer



    Private Sub frm_codigo_petroleo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        actualizar_representantes()
    End Sub
    Public Sub actualizar_representantes()
        cmb_representante.DataSource = nue_cur.listar2(Nombre_Obra)
        cmb_representante.DisplayMember = "Nombre"
        cmb_representante.ValueMember = "Nombre"
    End Sub
    Private Sub cmb_representante_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_representante.MouseClick
        actualizar_representantes()
    End Sub

    Public Sub actualizar_contratos()
        cmb_subcontrato.DataSource = nue_cur.listar3(Nombre_Obra, cmb_representante.Text)
        cmb_subcontrato.DisplayMember = "tipo_subcontrato"
        cmb_subcontrato.ValueMember = "tipo_subcontrato"
    End Sub
    Public Sub fecha_anterior()
        cmb_fecha_anterior.DataSource = nue_cur.listar4(Nombre_Obra, cmb_representante.Text, cmb_subcontrato.Text)
        cmb_fecha_anterior.DisplayMember = "fecha"
        cmb_fecha_anterior.ValueMember = "fecha"
    End Sub
    Public Sub fecha_actual()
        cmb_fecha_actual.DataSource = nue_cur.listar5(Nombre_Obra, cmb_representante.Text, cmb_subcontrato.Text)
        cmb_fecha_actual.DisplayMember = "fecha"
        cmb_fecha_actual.ValueMember = "fecha"
    End Sub

    Private Sub cmb_subcontrato_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_subcontrato.MouseClick
        actualizar_contratos()
    End Sub
    Private Sub cmb_fecha_actual_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_fecha_actual.TextChanged
        If cmb_fecha_actual.Text = cmb_fecha_anterior.Text Then
            cmb_fecha_anterior.Text = "2000-01-01"
        End If
        ' cmb_fecha_anterior.Text = nue_cur.fecha_anterior(Nombre_Obra, cmb_representante.Text, cmb_subcontrato.Text, cmb_fecha_actual.Text)
    End Sub
    Private Sub cmb_subcontrato_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_subcontrato.TextChanged
        fecha_actual()
        fecha_anterior()
    End Sub
    Private Sub cmb_fecha_anterior_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_fecha_anterior.TextChanged
        If cmb_fecha_actual.Text = cmb_fecha_anterior.Text Then
            cmb_fecha_actual.Text = "2999-01-01"
        End If
    End Sub
End Class