Public Class frm_ticket_modificar

    Dim nuevo_ticket As New clases.ticket

    Dim prioridad, nombre, asunto As String
    Dim estado As Boolean
    Dim fecha_ingreso, fecha_final As Date
    Dim ident As Integer

    Private Sub frm_modificar_ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        Bloqueado()
    End Sub

    Private Sub Bloqueado()
        dtp_fecha.Enabled = False
        rbt_abierto.Enabled = False
        rbt_cerrado.Enabled = False
        cmb_prioridad.Enabled = False
        btn_guardar.Enabled = False
    End Sub

    Private Sub Desbloqueo()
        If frm_ticket_solicitud.lbl_solicitante.Text.Equals("GSOLIS") Then
            dtp_fecha.Enabled = True
            rbt_abierto.Enabled = True
            rbt_cerrado.Enabled = True
            cmb_prioridad.Enabled = True
            btn_guardar.Enabled = True
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not dgv_ticket.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_ticket.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If
        dgv_ticket.DataSource = Nothing
        nombre = txt_nombre.Text.Trim()
        If (Not nombre.Equals("")) Then
            'dgv_ticket.DataSource = nuevo_ticket.BuscarTicket(nombre, asunto)
            'OrdenColumnasData()
        End If
        Bloqueado()
    End Sub

    Private Sub dgv_ticket_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ticket.CellClick
        Dim fila As Integer
        fila = dgv_ticket.CurrentRow.Index

        If (dgv_ticket.RowCount > 0) Then
            Asignar(fila)

            If (estado) Then
                rbt_abierto.Checked = True
            Else
                rbt_cerrado.Checked = True
            End If
            txt_nombre.Text = nombre
            cmb_prioridad.SelectedItem = prioridad
            txt_asunto.Text = asunto
            Desbloqueo()
        End If
        If e.ColumnIndex = 9 Then
            AsignarParametros()
        End If

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Bloqueado()
        If (rbt_abierto.Checked) Then
            estado = True
        Else
            estado = False
        End If
        nuevo_ticket.ModificarTicket(ident, cmb_prioridad.SelectedItem, dtp_fecha.Text, estado, txt_nombre.Text)
        Limpiar()
    End Sub

    Private Sub Asignar(fila)
        asunto = dgv_ticket.Rows(fila).Cells(1).Value.ToString()
        prioridad = dgv_ticket.Rows(fila).Cells(8).Value.ToString()
        nombre = dgv_ticket.Rows(fila).Cells(7).Value.ToString()
        If (dgv_ticket.Rows(fila).Cells(3).Value.ToString().Equals("1")) Then
            estado = True
        Else
            estado = False
        End If
        fecha_ingreso = CDate(dgv_ticket.Rows(fila).Cells(4).Value)
        If Not dgv_ticket.Rows(fila).Cells(5).Value.ToString().Equals("") Then
            fecha_final = CDate(dgv_ticket.Rows(fila).Cells(5).Value)
        Else
            fecha_final = "1900-01-01"
        End If
        ident = dgv_ticket.Rows(fila).Cells(0).Value.ToString()
    End Sub
    Public Sub Limpiar()
        cmb_prioridad.SelectedIndex = 0
        rbt_abierto.Checked = True
        txt_nombre.Text = Nothing
        txt_asunto.Text = Nothing
        dgv_ticket.DataSource = Nothing
        If Not dgv_ticket.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            dgv_ticket.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If
    End Sub

    Private Sub OrdenColumnasData()

        If dgv_ticket.Columns("btn_ver") Is Nothing Then ' De no existir la columna VER entra
            Dim btn As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_ticket.Columns.Add(btn) ' Se agrega botón a las columnas del data
            btn.HeaderText = "Historial" ' Nombre de la columna
            btn.Text = "Ver" ' Texto del botón 
            btn.Name = "btn_ver"
            btn.UseColumnTextForButtonValue = True
        End If

        With dgv_ticket

            .Columns("id").Visible = False
            .Columns("estado").Visible = False
            .Columns("nombre").Visible = False
            .Columns("prioridad").Visible = False
            .Columns("asunto").Visible = False
            .Columns("imagen").Visible = False

            .Columns("fecha_ingreso").DisplayIndex = 0
            .Columns("departamento").DisplayIndex = 1
            .Columns("fecha_respuesta").DisplayIndex = 2
            .Columns("btn_ver").DisplayIndex = 3

            .Columns("fecha_ingreso").HeaderText = "Ingresado"
            .Columns("fecha_respuesta").HeaderText = "Culminado"

            .AutoSizeColumnsMode = .AutoSizeColumnsMode.Fill

        End With

        For Each fila As DataGridViewRow In dgv_ticket.Rows
            If fila.Cells("estado").Value Then
                fila.DefaultCellStyle.BackColor = Color.Lime
            Else
                fila.DefaultCellStyle.BackColor = Color.IndianRed
            End If
        Next

    End Sub

    Private Sub AsignarParametros()
        frm_ticket_historial.txt_id_solicitud.Text = ident
        'frm_historial_ticket.chb_nueva_busqueda.Checked = False
        frm_ticket_solicitud.abrir_en_panel(frm_ticket_historial, frm_ticket_solicitud.pnl_body)
        'If estado Then
        '    frm_historial_ticket.txt_estado.Text = "Abierto"
        'Else
        '    frm_historial_ticket.txt_estado.Text = "Cerrado"
        'End If
        'If prioridad.Equals("Seleccione") Then
        '    prioridad = "Sin asignar"
        'End If
        'frm_historial_ticket.txt_prioridad.Text = prioridad
        'frm_historial_ticket.dtp_ingreso.Text = fecha_ingreso
        'frm_historial_ticket.dtp_finaliza.Text = CStr(fecha_final)

    End Sub

End Class