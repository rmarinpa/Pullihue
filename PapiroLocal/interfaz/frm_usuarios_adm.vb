Public Class frm_usuarios_adm


    Private Sub btn_logistica_Click(sender As Object, e As EventArgs) Handles btn_logistica.Click
        frm_usua_log.Show()
    End Sub

    Private Sub frm_usuarios_adm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(25, 50)
        'Me.Size = New System.Drawing.Size(338, 493)
    End Sub
End Class