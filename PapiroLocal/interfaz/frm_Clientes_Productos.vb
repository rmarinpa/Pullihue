﻿Public Class frm_Clientes_Productos


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
        System.Diagnostics.Process.Start("http://www.papiro.cl//")
    End Sub

    Private Sub frm_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Frmreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(Frm_reports, pnl_body)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(Frm_Petroleo, pnl_body)
    End Sub

    'Private Sub btn_representantes_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_representantes.MouseClick
    '    abrir_en_panel(frm_representates, pnl_body)
    'End Sub

    Private Sub btn_contratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_contratos.Click
        abrir_en_panel(frm_Contrato, pnl_body)
    End Sub

    Private Sub btn_representantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_representantes.Click
        abrir_en_panel(frm_representates, pnl_body)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(frm_Tipo_maq, pnl_body)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(frm_categoria_maq, pnl_body)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrir_en_panel(frm_tipo_trabajo, pnl_body)
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abrir_en_panel(frm_representates_imp, pnl_body)
    End Sub
End Class
