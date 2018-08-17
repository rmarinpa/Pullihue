Public Class frm_agenda2
    Dim nue_report As New clases.Agenda_2
    Dim nue_var As New clases.variables
    Dim Cod_agenda As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        actualizar_dgv()
    End Sub

    Private Sub frm_agenda2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With MonthCalendar1
            .ShowToday = True
            .ShowTodayCircle = False
            .CalendarDimensions = New System.Drawing.Size(2, 2)
            .FirstDayOfWeek = Day.Monday
            .ShowWeekNumbers = True
        End With
        actualizar_dgv()
        txt_rev.ReadOnly = True
        txt_rev2.ReadOnly = True
    End Sub
    Sub actualizar_dgv()
        Dim fecha As String
        fecha = MonthCalendar1.SelectionStart.ToShortDateString
        fecha = Format(CDate(fecha), "yyyy/MM/dd")
        dgv_agenda.DataSource = nue_report.listar(fecha)
        dgv_agenda.AllowUserToOrderColumns = True
        dgv_agenda.Columns(0).HeaderText = "Fecha Registro"
        dgv_agenda.Columns(1).Visible = False
        dgv_agenda.Columns(2).HeaderText = "Horario Programado"
        dgv_agenda.Columns(3).HeaderText = "Cliente"
        dgv_agenda.Columns(4).HeaderText = "Atendió"
        dgv_agenda.Columns(5).Visible = False
        dgv_agenda.Columns(6).Visible = False
        dgv_agenda.Columns(7).Visible = False
        dgv_agenda.Columns(8).Visible = False
        dgv_agenda.Columns(9).Visible = False
        dgv_agenda.Columns(10).Visible = False
        dgv_agenda.Columns(11).Visible = False
        dgv_agenda.Columns(12).HeaderText = "Importancia"
        dgv_agenda.Columns(13).HeaderText = "Descripción"
        dgv_agenda.Columns(14).Visible = False
        dgv_agenda.Columns(15).HeaderText = "Usuario"
        dgv_agenda.Columns(16).Visible = False
        dgv_agenda.Columns(17).Visible = False
        dgv_agenda.Columns(18).Visible = False
        dgv_agenda.Columns(19).Visible = False

        dgv_agenda.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_agenda.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_agenda.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_agenda.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_agenda.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_agenda.Columns(0).Width = 70
        dgv_agenda.Columns(2).Width = 70
        dgv_agenda.Columns(3).Width = 300
        dgv_agenda.Columns(4).Width = 130
        dgv_agenda.Columns(12).Width = 130
        dgv_agenda.Columns(13).Width = 450
        dgv_agenda.Columns(15).Width = 100

        dgv_agenda.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub dgv_agenda_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_agenda.CellFormatting
        Try
            For Each Row As DataGridViewRow In dgv_agenda.Rows

                If Row.Cells("hecho").Value Like "si" Then
                    Row.DefaultCellStyle.BackColor = Color.LightSkyBlue
                ElseIf Row.Cells("hecho").Value Like "no" Then
                    Row.DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    Row.DefaultCellStyle.BackColor = Color.White
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub btn_hecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hecho.Click
        Dim hecho As String
        Try
            Cod_agenda = dgv_agenda.CurrentRow.Cells(19).Value.ToString()
            If dgv_agenda.CurrentRow.Cells(18).Value.ToString() = "si" Then
                hecho = "no"
                nue_report.modificar(CInt(Cod_agenda), hecho)
                actualizar_dgv()
                MessageBox.Show("SE HA CAMBIADO EL STATUS DEL REGISTRO")
            ElseIf dgv_agenda.CurrentRow.Cells(18).Value.ToString() = "no" Then
                hecho = "si"
                nue_report.modificar(CInt(Cod_agenda), hecho)
                actualizar_dgv()
                MessageBox.Show("SE HA CAMBIADO EL STATUS DEL REGISTRO")
            End If
        Catch
            MessageBox.Show("SELECCIONA UN REGISTRO")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        editar = 0
        frm_programar_agenda.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        actualizar_dgv()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cod_agenda = dgv_agenda.CurrentRow.Cells(19).Value.ToString()
        If Cod_agenda <> "" Then
            editar = 1
            frm_programar_agenda.Show()
            frm_programar_agenda.txt_cliente.Text = dgv_agenda.CurrentRow.Cells(3).Value.ToString()
            frm_programar_agenda.txt_fecha_prog.Text = dgv_agenda.CurrentRow.Cells(1).Value.ToString()
            frm_programar_agenda.cmb_dia.Text = dgv_agenda.CurrentRow.Cells(2).Value.ToString()
            frm_programar_agenda.txt_motivo.Text = dgv_agenda.CurrentRow.Cells(5).Value.ToString()
            frm_programar_agenda.txt_informe.Text = dgv_agenda.CurrentRow.Cells(13).Value.ToString()
            frm_programar_agenda.txt_folio.Text = dgv_agenda.CurrentRow.Cells(19).Value.ToString()
        Else
            MsgBox("NECESITA MARCAR UN REGISTRO")
        End If

    End Sub
End Class