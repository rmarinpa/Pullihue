Public Class frm_Subcontratos

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

    Private Sub btn_matricula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(frm_matricula, pnl_body)
    End Sub

    Private Sub btn_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_curso.Show()
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        frm_autor.Show()
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        frm_autor.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("http://www.constructorafv.cl/")
    End Sub

    Private Sub frm_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub frm_principal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Frmreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(Frm_reports, pnl_body)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(Frm_Petroleo, pnl_body)
    End Sub

    Private Sub pnl_body_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl_body.Paint

    End Sub

    Private Sub btn_representantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_representantes.Click
        abrir_en_panel(frm_tipo_subcontrato, pnl_body)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abrir_en_panel(frm_registro_subcontrato, pnl_body)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        abrir_en_panel(Frm_avance_subcontratos, pnl_body)
    End Sub
End Class
