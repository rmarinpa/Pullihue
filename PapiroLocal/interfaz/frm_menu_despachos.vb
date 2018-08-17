Public Class frm_menu_despachos

    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btn_estudiante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(frm_estudiante, pnl_body)
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        frm_autor.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("http://www.papiro.cl//")
    End Sub

    Private Sub btn_despachos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_guia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guia.Click
        abrir_en_panel(frm_sel_doc, pnl_body)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abrir_en_panel(frm_prod_despachados, pnl_body)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub
End Class
