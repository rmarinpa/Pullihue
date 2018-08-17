Imports System.Net
Imports System.IO

Public Class frm_ticket_ver

    Dim asunto, nombre As String
    Dim minimo As Integer = 0
    Dim cantidadDatos, paginas As Integer

    Dim primerDato As Integer = 1
    Dim ultimoDato As Integer

    Dim nuevo_ticket As New clases.Ticket

    Private Sub ValidaCampos()
        If txt_nombre.Text.Trim().Length > 0 Then
            nombre = txt_nombre.Text.Trim()
        Else
            nombre = ""
        End If

        If txt_asunto.Text.Trim().Length > 0 Then
            asunto = txt_asunto.Text.Trim()
        Else
            asunto = ""
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        btn_siguiente.Visible = False
        btn_anterior.Visible = False
        ValidaCampos()
        cantidadDatos = nuevo_ticket.ListarTicket(nombre, asunto)
        paginas = 1
        minimo = 0
        btnBuscar()

        If cantidadDatos > 10 Then
            ultimoDato = 10
        Else
            ultimoDato = cantidadDatos
        End If

        Cantidades()
    End Sub

    Private Sub OrdernaData()
        With dgv_ticket
            ' columnas visibles
            .Columns("id").Visible = False
            .Columns("estado").Visible = False
            .Columns("fecha_respuesta").Visible = False
            .Columns("nombre").Visible = False
            .Columns("prioridad").Visible = False

            ' indice de orden de izquierda a derecha
            .Columns("fecha_ingreso").DisplayIndex = 0
            .Columns("departamento").DisplayIndex = 1
            .Columns("asunto").DisplayIndex = 2

            ' Evitar orden por columnas
            .Columns("fecha_ingreso").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("departamento").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("asunto").SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        DataColumnEstado()
    End Sub

    Private Sub DataColumnEstado()
        Dim cantidad As Integer = dgv_ticket.RowCount
        For index As Integer = 0 To cantidad
            If (index = cantidad) Then
                Exit For
            End If
            If CStr(dgv_ticket.Rows(index).Cells("estado").Value).Equals("1") Then
                dgv_ticket.Rows(index).Cells("col_estados").Value = "Abierto"
            Else
                dgv_ticket.Rows(index).Cells("col_estados").Value = "Cerrado"
            End If
        Next
    End Sub

    Private Sub AgregasColumnas()
        If dgv_ticket.Columns("col_estados") Is Nothing Then ' Condicional en la que si no existe columna TIPO entra.
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "Estado"
            col.Name = "col_estados" ' Se agrega el nombre de la columna 
            dgv_ticket.Columns.Add(col) ' Se agrega columna
        End If

        If dgv_ticket.Columns("Ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_ticket.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "btn_ver"
            col.UseColumnTextForButtonValue = True
        End If
    End Sub

    Private Sub EliminarColumnas()
        If Not dgv_ticket.Columns("col_estados") Is Nothing Then ' Condicional negativa en la que si existe la columna TIPO.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Motivo"
            dgv_ticket.Columns.Remove("col_estados") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If Not dgv_ticket.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Ver"
            dgv_ticket.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If
    End Sub

    Private Sub dgv_ticket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ticket.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim fila As Integer
            fila = dgv_ticket.CurrentRow.Index
            frm_ticket_historial.txt_id_solicitud.Text = dgv_ticket.Rows(fila).Cells(0).Value.ToString()
            frm_ticket_solicitud.abrir_en_panel(frm_ticket_historial, frm_ticket_solicitud.pnl_body)
            With frm_ticket_solicitud.lbl_titulo
                .Text = "Historial de " & dgv_ticket.Rows(fila).Cells("nombre").Value.ToString()
                .Location = New Point(160, 10)
                .Font = New Font("Microsoft Sans Serif", 20)
            End With
            Me.Close()
        End If
    End Sub

    Private Sub frm_ticket_ver_Load(sender As Object, e As EventArgs) Handles Me.Load
        nombre = frm_ticket_historial.txt_nombre.Text
        asunto = frm_ticket_historial.txt_asunto.Text
        If Not (nombre.Equals("")) Or Not (asunto.Equals("")) Then
            txt_nombre.Text = nombre
            txt_asunto.Text = asunto
        End If
    End Sub

    Private Sub btnSiguiente()
        paginas += 1
        minimo += 10
        btnBuscar()
        btn_anterior.Visible = True
    End Sub

    Private Sub btnAnterior()
        paginas -= 1
        minimo -= 10
        btnBuscar()
        If paginas = 1 Then
            btn_anterior.Visible = False
        End If
    End Sub

    Private Sub btnBuscar()
        EliminarColumnas()
        dgv_ticket.DataSource = nuevo_ticket.ListarTicket(nombre, asunto, minimo)

        If cantidadDatos > paginas * 10 Then
            btn_siguiente.Visible = True
        Else
            btn_siguiente.Visible = False
        End If

        If dgv_ticket.RowCount > 0 Then
            AgregasColumnas()
            OrdernaData()
        Else
            dgv_ticket.DataSource = Nothing
        End If
    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        btnSiguiente()
        primerDato = ultimoDato + 1
        ultimoDato += 10
        If Not cantidadDatos > ultimoDato Then
            ultimoDato = cantidadDatos
        End If
        Cantidades()
    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        btnAnterior()
        ultimoDato = primerDato - 1
        primerDato -= 10
        Cantidades()
    End Sub

    Private Sub Cantidades()
        lbl_cantidadTotal.Visible = True
        lbl_mostrando.Visible = True
        If cantidadDatos > 0 Then
            lbl_cantidadTotal.Text = "Se encontraron " & cantidadDatos & " registros."
            lbl_mostrando.Text = "Mostrando del " & primerDato & " al " & ultimoDato
        Else
            lbl_cantidadTotal.Text = "No se encontraron registros."
            lbl_mostrando.Visible = False
        End If
    End Sub
End Class