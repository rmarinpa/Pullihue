Public Class frm_serv_tec


    Private Sub frm_menu_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(400, 50)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_solicitud_servicio.Show()
    End Sub
End Class