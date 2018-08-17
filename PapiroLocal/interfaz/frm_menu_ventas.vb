Public Class frm_menu_ventas


    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btn_representantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_representantes.Click
        abrir_en_panel(frm_lc_representates, pnl_body)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abrir_en_panel(Frm_Sustitutos, pnl_body)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        abrir_en_panel(Frm_Complementarios, pnl_body)
    End Sub

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        abrir_en_panel(frm_Contrato_adm, pnl_body)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("http://www.papiro.cl//")
    End Sub


    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        frm_autor.Close()

    End Sub
End Class
