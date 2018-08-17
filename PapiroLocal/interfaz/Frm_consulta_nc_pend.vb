Imports System.Globalization
Imports System.IO
Public Class Frm_consulta_nc_pend

    Dim nue_cur As New clases.emitir_nota_credito
    Dim cod_cur As String = ""
    Dim sw As Integer

    Private Sub Frm_despacho2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.WindowState = FormWindowState.Maximized
        actualizar_dgv_fecha()
        txt_total.ReadOnly = True
        txt_iva.ReadOnly = True
        txt_total2.ReadOnly = True
        If filtro_nc = 0 Then
            gp_autorizar.Visible = True
        ElseIf filtro_nc = 1 Then
            gp_autorizar.Visible = False
        End If
        Timer1.Enabled = True
    End Sub


    Private Sub dgv_despachos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_despachos.CellClick
        Dim numero_folio As Double
        numero_folio = dgv_despachos.CurrentRow.Cells(1).Value.ToString()
        btn_actualizar.DataSource = nue_cur.listar7_pend(numero_folio)
        btn_actualizar.Columns(0).Visible = False
        btn_actualizar.Columns(1).Visible = False
        btn_actualizar.Columns(2).Visible = False
        btn_actualizar.Columns(3).Visible = False
        btn_actualizar.Columns(4).Visible = False
        btn_actualizar.Columns(5).Visible = False
        btn_actualizar.Columns(6).Visible = False
        btn_actualizar.Columns(7).Visible = False
        btn_actualizar.Columns(8).Visible = False
        btn_actualizar.Columns(9).Visible = False
        btn_actualizar.Columns(10).Visible = False
        btn_actualizar.Columns(11).Visible = False
        btn_actualizar.Columns(12).Visible = False
        btn_actualizar.Columns(13).Visible = False
        btn_actualizar.Columns(14).Visible = False
        btn_actualizar.Columns(15).Visible = False
        btn_actualizar.Columns(16).HeaderText = "Precio"
        btn_actualizar.Columns(16).DefaultCellStyle.Format = "##,###.##"
        btn_actualizar.Columns(17).HeaderText = "Cantidad"
        btn_actualizar.Columns(17).DefaultCellStyle.Format = "##,###"
        btn_actualizar.Columns(18).HeaderText = "Total"
        btn_actualizar.Columns(18).DefaultCellStyle.Format = "##,###"
        btn_actualizar.Columns(19).Visible = False
        btn_actualizar.Columns(20).Visible = False
        btn_actualizar.Columns(21).Visible = False
        btn_actualizar.Columns(22).Visible = False
        btn_actualizar.Columns(23).Visible = False
        btn_actualizar.Columns(24).Visible = False
        btn_actualizar.Columns(25).Visible = False
        btn_actualizar.Columns(26).Visible = False
        btn_actualizar.Columns(27).Visible = False
        btn_actualizar.Columns(28).Visible = False
        btn_actualizar.Columns(29).Visible = False
        btn_actualizar.Columns(30).Visible = False
        btn_actualizar.Columns(31).Visible = False
        btn_actualizar.Columns(32).Visible = False
        btn_actualizar.Columns(33).Visible = False
        btn_actualizar.Columns(34).Visible = False
        btn_actualizar.Columns(35).HeaderText = "Descripción"
        btn_actualizar.Columns(36).HeaderText = "Medidas"


        btn_actualizar.Columns(35).DisplayIndex = 0
        btn_actualizar.Columns(36).DisplayIndex = 1
        btn_actualizar.Columns(16).DisplayIndex = 2
        btn_actualizar.Columns(17).DisplayIndex = 3
        btn_actualizar.Columns(18).DisplayIndex = 4

        btn_actualizar.Columns(35).Width = 200
        btn_actualizar.Columns(36).Width = 50
        btn_actualizar.Columns(16).Width = 50
        btn_actualizar.Columns(17).Width = 50
        btn_actualizar.Columns(18).Width = 80


        cod_cur = dgv_despachos.CurrentRow.Cells(0).Value.ToString()
        txt_folio2.Text = dgv_despachos.CurrentRow.Cells(1).Value.ToString()

        actualizar_dgv_cliente()
        txt_total.Text = btn_actualizar.Rows(0).Cells(9).Value.ToString()
        txt_total.Text = Format(CDbl(txt_total.Text), "###,##0.")
    End Sub
    Sub actualizar_dgv_fecha()
        dgv_despachos.DataSource = Nothing

        If Not dgv_despachos.Columns("col_motivo") Is Nothing Then ' Condicional negativa en la que si existe la columna TIPO.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Motivo"
            dgv_despachos.Columns.Remove("col_motivo") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If Not dgv_despachos.Columns("btn_ver") Is Nothing Then ' Condicional negativa en la que si existe la columna VER.
            'Dim col As New DataGridViewTextBoxColumn
            'col.Name = "Ver"
            dgv_despachos.Columns.Remove("btn_ver") ' Es removida la columna con la nombre Visualizar, para posteriormente crearla.
        End If

        If filtro_nc = 0 Then
            dgv_despachos.DataSource = nue_cur.listar14_pend()
        ElseIf filtro_nc = 1 Then
            dgv_despachos.DataSource = nue_cur.listar8()
        End If

        If dgv_despachos.Columns("col_motivo") Is Nothing Then ' Condicional en la que si no existe columna TIPO entra.
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "Motivo"
            col.Name = "col_motivo" ' Se agrega el nombre de la columna 
            dgv_despachos.Columns.Add(col) ' Se agrega columna
        End If

        If dgv_despachos.Columns("Ver") Is Nothing Then ' De no existir la columna VER entra
            Dim col As New DataGridViewButtonColumn ' Variable de tipo boton datagridview
            dgv_despachos.Columns.Add(col) ' Se agrega botón a las columnas del data
            col.HeaderText = "Visualizar" ' Nombre de la columna
            col.Text = "Ver" ' Texto del botón 
            col.Name = "btn_ver"
            col.UseColumnTextForButtonValue = True
        End If

        With dgv_despachos

            ' Columnas NO visibles
            .Columns(0).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False

            ' Titulo columnas
            .Columns(1).HeaderText = "N° de Folio"
            .Columns(2).HeaderText = "Nota de Crédito"
            .Columns(3).HeaderText = "Factura"
            .Columns(4).HeaderText = "Cliente"

            ' Dimenciones de celdas
            .Columns(1).Width = 55
            .Columns(2).Width = 50
            .Columns(3).Width = 55
            .Columns(4).Width = 300
            .Columns("col_motivo").Width = 150
            .Columns("btn_ver").Width = 70

            .Columns(1).DefaultCellStyle.Format = "###,###,###" ' Formato de celda
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Alinación titulo columnas

            ' Alineamineto del contenido
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
        ' Bucle en el que itera sobre el resoltado (Cantidad de resultado encontrados)
        For x As Integer = 0 To dgv_despachos.RowCount - 1
            Dim valor As String = System.Convert.ToString(dgv_despachos.Rows(x).Cells(16).Value) ' Se convierte a String el valor de la celda iterada
            ' Agrega valor a la columna TIPO el valor dependiendo de valor de la celda de la columna tipo guia (13)
            Select Case valor
                Case "Motivo_1"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Diferencia precio"
                Case "Motivo_2"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Descuento comercial"
                Case "Motivo_3"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Mercadería defectuosa"
                Case "Motivo_4"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "Devolución mercadería"
                Case "Motivo_5"
                    dgv_despachos.Rows(x).Cells("col_motivo").Value = "No sale de bodega"
            End Select
        Next
    End Sub

    Sub actualizar_dgv_cliente()
        Dim rut As String
        rut = btn_actualizar.Rows(0).Cells(4).Value.ToString()
        dgv_clientes.DataSource = nue_cur.listar12(rut)
    End Sub
    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_iva.Text = FormatNumber(txt_total.Text * 0.19, 0)
        txt_total2.Text = FormatNumber(CInt(txt_total.Text) + CInt(txt_iva.Text), 0)
    End Sub

    Private Sub btn_autorizar_Click(sender As Object, e As EventArgs) Handles btn_autorizar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 1)
            nue_cur.insertar2(2, "NC", txt_folio2.Text, 1, "Autoriza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA AUTORIZADO LA NOTA DE CRÉDITO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub

    Private Sub btn_rechazar_Click(sender As Object, e As EventArgs) Handles btn_rechazar.Click
        If txt_folio2.Text <> "" Then
            nue_cur.modificar2(CInt(cod_cur), 2)
            nue_cur.insertar2(2, "NC", txt_folio2.Text, 2, "Rechaza", Nombre_Obra, CDate(DateTime.Today), CDate(txt_hora.Text))
            actualizar_dgv_fecha()
            MsgBox("SE HA RECHAZADO LA NOTA DE CRÉDITO")
        Else
            MsgBox("DEBE SELECCIONAR PRIMERO LA NOTA DE CRÉDITO RESPECTIVA")
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_hora.Text = TimeOfDay
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        actualizar_dgv_fecha()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class

