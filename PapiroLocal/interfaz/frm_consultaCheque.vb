Public Class frm_consultaCheque

    Dim nuevo_registroPagos As New clases.Registro_pagos

    Dim cheque As Integer = Nothing
    Dim mensaje As String = Nothing

    Private Sub frm_conultaCheque_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        limpiar()
        NoEncuentraDatos()
        Me.Location = New Point(150, 150)
        gpbx_protestado.Visible = False

        'Me.BackColor = Color.FromArgb(110, 145, 204)
    End Sub

    Sub limpiar()
        txt_nombre.Clear()
        txt_rut.Clear()
        DGV_resultado.DataSource = Nothing
    End Sub

    Public Sub actualiza_cheques()
        txt_numeroCheque.DataSource = nuevo_registroPagos.listar_cheques(txt_rut.Text)
        txt_numeroCheque.DisplayMember = "serie"
        txt_numeroCheque.ValueMember = "serie"
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Frm_clientes_busqueda_cobranza.ShowDialog()

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        frm_menu_pagos.Show()
        Me.Close()
    End Sub

    ' METODOS 
    Public Sub EncuentraDatos()
        'Me.Size = New System.Drawing.Size(821, 406)
        With DGV_resultado
            .Columns(0).HeaderText = "Fecha Ingreso"
            .Columns(1).HeaderText = "Banco"
            .Columns(2).HeaderText = "Factura"
            .Columns(3).HeaderText = "Total Adeudado"
            .Columns(4).HeaderText = "Monto"
            .Columns(5).HeaderText = "Diferencia"
            .Columns(6).HeaderText = "Fecha Cheque"
            .Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns(7).HeaderText = "Estado"
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        With GB_contenedor
            ' .Size = New System.Drawing.Size(526, 118)
        End With

        txt_nombre.Text = CStr(UCase(DGV_resultado.Rows(0).Cells(8).Value.ToString))
        txt_rut.Text = CStr(DGV_resultado.Rows(0).Cells(9).Value.ToString)

        If DGV_resultado.Rows(0).Cells(7).Value.ToString() Like "PROTESTADO" Then
            btn_cheque_protestado.BackColor = Color.Tomato
            gpbx_protestado.Visible = True
        Else
            btn_cheque_protestado.BackColor = Color.MediumTurquoise
            gpbx_protestado.Visible = False
        End If
    End Sub

    Private Sub NoEncuentraDatos()
        With GB_contenedor
            '.Size = New System.Drawing.Size(540, 75)
        End With
        'Me.Size = New System.Drawing.Size(821, 190)
        txt_numeroCheque.Focus()
        gpbx_protestado.Visible = False
        btn_cheque_protestado.BackColor = Color.MediumTurquoise
    End Sub


    Private Sub btn_cambio_cheque_Click(sender As Object, e As EventArgs) Handles btn_cheque_protestado.Click
        If DGV_resultado.Rows.Count > 0 Then
            If DGV_resultado.Rows(0).Cells(7).Value.ToString() <> "PROTESTADO" Then
                If MessageBox.Show("¿Seguro que desea cambiar el estado del documento a 'Protestado'?", "Confirmación de procedimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                    nuevo_registroPagos.modificar_estado(txt_numeroCheque.Text, txt_nombre.Text, "PROTESTADO")
                    nuevo_registroPagos.modificar_cliente(txt_rut.Text, "BL PROT")

                    nuevo_registroPagos.insertar_reg_cheque(txt_rut.Text, txt_numeroCheque.Text, "1", "SE REGISTRA PROTESTO DEL CHEQUE N°" + txt_numeroCheque.Text, Today, Nombre_Obra)

                    gpbx_protestado.Visible = True
                    btn_cheque_protestado.BackColor = Color.Tomato

                    cheque = CInt(txt_numeroCheque.Text.Trim())
                    DGV_resultado.DataSource = nuevo_registroPagos.RescataCheque(cheque, txt_rut.Text)
                    EncuentraDatos()
                    MsgBox("CHEQUE REGISTRADO COMO PROTESTADO Y CLIENTE BLOQUEADO POR PROTESTO")
                Else
                End If
            End If
        Else
            MsgBox("DEBE INGRESAR UN REGISTRO VÁLIDO")

        End If



    End Sub

    Private Sub btn_prorroga_Click(sender As Object, e As EventArgs) Handles btn_prorroga.Click
        If DGV_resultado.Rows.Count > 0 Then
            frm_prorroga_cheque.ShowDialog()
        Else
            MsgBox("DEBE INGRESAR UN CHEQUE VÁLIDO")
        End If
    End Sub

    Private Sub btn_redepositar_Click(sender As Object, e As EventArgs) Handles btn_redepositar.Click
        If DGV_resultado.Rows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea redepositar este documento?", "Confirmación de procedimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                nuevo_registroPagos.insertar_reg_cheque(txt_rut.Text, txt_numeroCheque.Text, "1", "SE REDEPOSITA EL CHEQUE N°" + txt_numeroCheque.Text, Today, Nombre_Obra)
                nuevo_registroPagos.modificar_estado(txt_numeroCheque.Text, DGV_resultado.Rows(0).Cells(8).Value.ToString(), "CARTERA")

                'nuevo_registroPagos.modificar_cliente(txt_rut.Text, "OK")

                cheque = CInt(txt_numeroCheque.Text.Trim())
                DGV_resultado.DataSource = nuevo_registroPagos.RescataCheque(cheque, txt_rut.Text)
                EncuentraDatos()
                MsgBox("CHEQUE REDEPOSITADO")
            End If
        Else
            MsgBox("DEBE INGRESAR UN REGISTRO VÁLIDO")
        End If
    End Sub

    Private Sub btn_cambiar_cheque_Click(sender As Object, e As EventArgs) Handles btn_cambiar_cheque.Click
        If DGV_resultado.Rows.Count > 0 Then
            frm_mod_pagos2.ShowDialog()
        Else
            MsgBox("DEBE INGRESAR UN CHEQUE VÁLIDO")
        End If
    End Sub

    Private Sub txt_numeroCheque_TextChanged(sender As Object, e As System.EventArgs) Handles txt_numeroCheque.TextChanged
        If IsNumeric(txt_numeroCheque.Text) Then
            cheque = CInt(txt_numeroCheque.Text.Trim())
            If (Not cheque.Equals("")) Then
                DGV_resultado.DataSource = nuevo_registroPagos.RescataCheque(cheque, txt_rut.Text)
                If (DGV_resultado.RowCount > 0) Then
                    EncuentraDatos()
                Else
                    NoEncuentraDatos()
                End If
            Else
                NoEncuentraDatos()
            End If
        Else
            NoEncuentraDatos()
        End If
    End Sub

    Private Sub btn_buscar2_Click(sender As Object, e As EventArgs) Handles btn_buscar2.Click
        Frm_clientes_busqueda_cobranza_doc.Show()
    End Sub
End Class