Imports System.IO
Public Class frm_agenda

    Dim nue_usua As New clases.Agenda
    Dim cod_usua As String = ""
    Dim sw As Integer
    Dim reg As String

    Private Sub frm_agenda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mCal.CalendarDimensions = New System.Drawing.Size(2, 2)
    End Sub

    Private Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalvar.Click
    End Sub

    Private Sub mCal_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mCal.DateSelected
    End Sub

    Private Sub mCal_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mCal.DateChanged
        lbl_fecha.Text = mCal.SelectionStart
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class