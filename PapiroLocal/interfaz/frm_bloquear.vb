Public Class frm_bloquear
    Dim nue_report As New clases.Alerta
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Sub actualizar_dgv()
        'dgv_bloqueo1.DataSource = nue_report.listar3()

        dgv_bloqueo1.Columns(0).HeaderText = "Cliente"
        dgv_bloqueo1.Columns(1).HeaderText = "Rut"
        dgv_bloqueo1.Columns(2).HeaderText = "Fecha"



        'dgv_tiempo.Columns(0).Visible = False
        'dgv_Mov_Tierra.AllowUserToOrderColumns = True
        'dgv_Mov_Tierra.Columns(1).Visible = False
        'dgv_Mov_Tierra.Columns(1).Width = 200
        'dgv_Mov_Tierra.Columns(2).Visible = False
        'dgv_Mov_Tierra.Columns(3).Visible = False
        'dgv_Mov_Tierra.Columns(4).Visible = False
        'dgv_Mov_Tierra.Columns(5).Visible = False
        'dgv_Mov_Tierra.Columns(6).Visible = False
        'dgv_Mov_Tierra.Columns(7).Visible = False
        'dgv_Mov_Tierra.Columns(8).Visible = False
        'dgv_Mov_Tierra.Columns(9).Visible = False
        'dgv_Mov_Tierra.Columns(10).HeaderText = "Medidas"
        'dgv_Mov_Tierra.Columns(11).Visible = False
        'dgv_Mov_Tierra.Columns(12).Visible = False
        'dgv_Mov_Tierra.Columns(13).HeaderText = "Descripción"
        'dgv_Mov_Tierra.Columns(13).Width = 230
        'dgv_Mov_Tierra.Columns(14).HeaderText = "Área Un."
        'dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Format = "##,###.##"
        'dgv_Mov_Tierra.Columns(15).HeaderText = "Cantidad"
        'dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(16).Visible = False
        'dgv_Mov_Tierra.Columns(17).Visible = False
        'dgv_Mov_Tierra.Columns(18).HeaderText = "Precio M2"
        'dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Format = "##,###.##"
        'dgv_Mov_Tierra.Columns(19).HeaderText = "Venta"
        'dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Format = "##,###.##"
        'dgv_Mov_Tierra.Columns(20).Visible = False
        'dgv_Mov_Tierra.Columns(21).Visible = False
        'dgv_Mov_Tierra.Columns(22).Visible = False
        'dgv_Mov_Tierra.Columns(23).Visible = False
        'dgv_Mov_Tierra.Columns(24).Visible = False
        'dgv_Mov_Tierra.Columns(25).Visible = False
        'dgv_Mov_Tierra.Columns(26).Visible = False
        'dgv_Mov_Tierra.Columns(27).Visible = False
        'dgv_Mov_Tierra.Columns(27).DefaultCellStyle.Format = "##,###."
        'dgv_Mov_Tierra.Columns(28).HeaderText = "Precio Un."
        'dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Format = "##,###."
        'dgv_Mov_Tierra.Columns(29).HeaderText = "Fecha"
        'dgv_Mov_Tierra.Columns(30).Visible = False
        'dgv_Mov_Tierra.Columns(31).Visible = False
        'dgv_Mov_Tierra.Columns(32).Visible = False
        'dgv_Mov_Tierra.Columns(33).Visible = False
        'dgv_Mov_Tierra.Columns(34).HeaderText = "N° Venta"
        'dgv_Mov_Tierra.Columns(35).Visible = False
        'dgv_Mov_Tierra.Columns(36).Visible = False

        'dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(34).DefaultCellStyle.Format = "###,###,###"
        'dgv_Mov_Tierra.Columns(34).DisplayIndex = 0
        'dgv_Mov_Tierra.Columns(29).DisplayIndex = 1
        'dgv_Mov_Tierra.Columns(13).DisplayIndex = 2
        'dgv_Mov_Tierra.Columns(10).DisplayIndex = 3
        'dgv_Mov_Tierra.Columns(15).DisplayIndex = 4
        'dgv_Mov_Tierra.Columns(18).DisplayIndex = 5
        'dgv_Mov_Tierra.Columns(14).DisplayIndex = 6
        'dgv_Mov_Tierra.Columns(28).DisplayIndex = 7
        'dgv_Mov_Tierra.Columns(19).DisplayIndex = 8
        'dgv_Mov_Tierra.Columns(30).DisplayIndex = 9
        'dgv_Mov_Tierra.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_Mov_Tierra.Columns(30).Width = 50
        'dgv_Mov_Tierra.Columns(10).Width = 60
        'dgv_Mov_Tierra.Columns(15).Width = 50
        'dgv_Mov_Tierra.Columns(28).Width = 60
        'dgv_Mov_Tierra.Columns(29).Width = 65
        'dgv_Mov_Tierra.Columns(18).Width = 60
        'dgv_Mov_Tierra.Columns(19).Width = 60
        'dgv_Mov_Tierra.Columns(34).Width = 60
        'dgv_Mov_Tierra.Columns(14).Width = 40
        'dgv_Mov_Tierra.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Sub actualiza_columnas()
        'dgv_alerta.Rows.Clear()
        'Dim cantDatosAgregados As Integer = dgv_tiempo.RowCount - 1

        'If dgv_tiempo.Rows.Count > 1 Then
        '    dgv_alerta.Rows.Add(dgv_tiempo.Rows.Count - 1)

        '    For i = 0 To dgv_tiempo.Rows.Count - 1
        '        dgv_alerta.Rows(i).Cells(0).Value = dgv_tiempo.Rows(i).Cells(0).Value.ToString()
        '        dgv_alerta.Rows(i).Cells(1).Value = dgv_tiempo.Rows(i).Cells(1).Value.ToString()
        '        dgv_alerta.Rows(i).Cells(2).Value = dgv_tiempo.Rows(i).Cells(2).Value.ToString()

        '    Next i
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar_dgv()
        'actualiza_columnas()
    End Sub
End Class