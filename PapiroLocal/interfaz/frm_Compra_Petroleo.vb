Imports System.Globalization
Public Class Frm_Compra_Petroleo

    Dim nue_report As New clases.Compra_petroleo
    Dim nue_var As New clases.variables
    Dim Cod_Petroleo As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Integer
    Dim const_dias As Integer

    Sub bloquear()
        gbx_Petroleo.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
        gbx_valores_compra.Enabled = False

    End Sub

    Sub desbloquear()
        gbx_Petroleo.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
        gbx_valores_compra.Enabled = True
    End Sub


    Sub limpiar()
        txt_proveedor.Clear()
        txt_rut.Clear()
        txt_litros.Clear()
        txt_N_factura.Clear()
        txt_precio.Clear()
        txt_iev.Clear()
        txt_ief.Clear()
        txt_descuento.Clear()

    End Sub

    Sub actualizar_dgv()
        dgv_Petroleo.DataSource = nue_report.listar(Nombre_Obra)
        dgv_Petroleo.Columns(0).Visible = False
        dgv_Petroleo.Columns(1).Visible = True
        dgv_Petroleo.Columns(2).Visible = True
        dgv_Petroleo.Columns(3).Visible = True
        dgv_Petroleo.Columns(4).Visible = True
        dgv_Petroleo.Columns(2).HeaderText = "N° de Factura"
        'dgv_Petroleo.Columns(2).DefaultCellStyle.Format = "#.#"
        dgv_Petroleo.Columns(15).HeaderText = "Litros de Compra"
        ' dgv_Petroleo.Columns(15).DefaultCellStyle.Format = "#.#"
        dgv_Petroleo.Columns(5).Visible = False
        dgv_Petroleo.Columns(6).Visible = False
        dgv_Petroleo.Columns(7).Visible = False
        dgv_Petroleo.Columns(8).Visible = False
        dgv_Petroleo.Columns(9).Visible = False
        dgv_Petroleo.Columns(10).Visible = False
        dgv_Petroleo.Columns(11).Visible = False
        dgv_Petroleo.Columns(12).Visible = False
        dgv_Petroleo.Columns(13).Visible = False
        dgv_Petroleo.Columns(14).Visible = True
        dgv_Petroleo.Columns(15).Visible = True
        ' dgv_Petroleo.Columns(14).DefaultCellStyle.Format = "#.#"
        dgv_Petroleo.AllowUserToOrderColumns = True
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgv()
        bloquear()
        gbx_total_compra.Enabled = False
        txt_nombre_obra.Text = Nombre_Obra
        txt_nombre_obra.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim descuento, N_factura, litros, precio, iev, ief, precio_base, total_neto, total_iev, total_ief, total_iva, total_compra As Double
        Dim proveedor, rut, obra As String

        If (txt_N_factura.Text <> "" And txt_litros.Text <> "" And txt_proveedor.Text <> "" And txt_rut.Text <> "") Then

            N_factura = txt_N_factura.Text
            proveedor = txt_proveedor.Text
            rut = txt_rut.Text
            If Not IsNumeric(txt_precio.Text) Then
                txt_precio.Text = 0
            End If
            If Not IsNumeric(txt_iev.Text) Then
                txt_iev.Text = 0
            End If
            If Not IsNumeric(txt_ief.Text) Then
                txt_ief.Text = 0
            End If
            If Not IsNumeric(txt_descuento.Text) Then
                txt_descuento.Text = 0
            End If
            If Not IsNumeric(txt_precio_base.Text) Then
                txt_precio_base.Text = 0
            End If

            litros = Convert.ToDouble(txt_litros.Text)
            precio = Convert.ToDouble(txt_precio.Text)
            iev = Convert.ToDouble(txt_iev.Text)
            ief = Convert.ToDouble(txt_ief.Text)
            descuento = Convert.ToDouble(txt_descuento.Text)
            precio_base = Convert.ToDouble(txt_precio_base.Text)
            total_neto = Convert.ToDouble(txt_total_neto.Text)
            total_iev = Convert.ToDouble(txt_total_iev.Text)
            total_ief = Convert.ToDouble(txt_total_ief.Text)
            total_iva = Convert.ToDouble(txt_total_iva.Text)
            total_compra = Convert.ToDouble(txt_total_compra.Text)
            obra = txt_nombre_obra.Text

            If sw = 0 Then
                nue_report.insertar(CDate(txt_fecha.Text), N_factura, proveedor, rut, descuento, iev, ief, precio_base, total_neto, total_iva, total_iev, total_ief, total_compra, precio, litros, obra)
                actualizar_dgv()
            Else
                nue_report.modificar(CInt(Cod_Petroleo), CDate(txt_fecha.Text), N_factura, proveedor, rut, descuento, iev, ief, precio_base, total_neto, total_iva, total_iev, total_ief, total_compra, precio, litros, obra)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_Petroleo = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_Petroleo = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_Petroleo))
                actualizar_dgv()
            Else
                bloquear()

            End If
        End If
    End Sub
    Private Sub dgv_Petroleo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Petroleo.CellDoubleClick

        Cod_Petroleo = dgv_Petroleo.CurrentRow.Cells(0).Value.ToString()
        txt_fecha.Text = dgv_Petroleo.CurrentRow.Cells(1).Value.ToString()
        txt_N_factura.Text = dgv_Petroleo.CurrentRow.Cells(2).Value.ToString()
        txt_proveedor.Text = dgv_Petroleo.CurrentRow.Cells(3).Value.ToString()
        txt_rut.Text = dgv_Petroleo.CurrentRow.Cells(4).Value.ToString()
        txt_descuento.Text = dgv_Petroleo.CurrentRow.Cells(5).Value.ToString()
        txt_iev.Text = dgv_Petroleo.CurrentRow.Cells(6).Value.ToString()
        txt_ief.Text = dgv_Petroleo.CurrentRow.Cells(7).Value.ToString()
        txt_precio_base.Text = dgv_Petroleo.CurrentRow.Cells(8).Value.ToString()
        txt_total_neto.Text = dgv_Petroleo.CurrentRow.Cells(9).Value.ToString()
        txt_total_iva.Text = dgv_Petroleo.CurrentRow.Cells(10).Value.ToString()
        txt_total_iev.Text = dgv_Petroleo.CurrentRow.Cells(11).Value.ToString()
        txt_total_ief.Text = dgv_Petroleo.CurrentRow.Cells(12).Value.ToString()
        txt_total_compra.Text = dgv_Petroleo.CurrentRow.Cells(13).Value.ToString()
        txt_precio.Text = dgv_Petroleo.CurrentRow.Cells(14).Value.ToString()
        txt_litros.Text = dgv_Petroleo.CurrentRow.Cells(15).Value.ToString()

    End Sub


    Private Sub txt_precio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_precio.TextChanged
        If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub


    Private Sub txt_precio_base_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_precio_base.TextChanged
        If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub


    Private Sub txt_litros_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_litros.TextChanged
        If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub



    Private Sub txt_ief_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ief.TextChanged
         If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub



    Private Sub txt_iev_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_iev.TextChanged
         If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub


    Private Sub txt_descuento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_descuento.TextChanged
        If (Not IsNumeric(Me.txt_litros.Text)) Then
            Me.txt_litros.Text = 0
        End If

        If (Not IsNumeric(Me.txt_iev.Text)) Then
            Me.txt_iev.Text = 0
        End If
        If (Not IsNumeric(Me.txt_ief.Text)) Then
            Me.txt_ief.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio.Text)) Then
            Me.txt_precio.Text = 0
        End If
        If (Not IsNumeric(Me.txt_descuento.Text)) Then
            Me.txt_descuento.Text = 0
        End If
        If (Not IsNumeric(Me.txt_precio_base.Text)) Then
            Me.txt_precio_base.Text = 0
        End If
        txt_total_iev.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_iev.Text)
        txt_total_ief.Text = CDbl(Me.txt_litros.Text) * CDbl(Me.txt_ief.Text)
        txt_precio_base.Text = (CDbl(Me.txt_precio.Text) - CDbl(Me.txt_iev.Text) - CDbl(Me.txt_ief.Text) - CDbl(Me.txt_descuento.Text)) / 1.19
        txt_total_neto.Text = CDbl(Me.txt_precio_base.Text) * CDbl(Me.txt_litros.Text)
        txt_total_iva.Text = 0.19 * CDbl(Me.txt_total_neto.Text)
        txt_total_compra.Text = CDbl(Me.txt_total_neto.Text) + CDbl(Me.txt_total_iev.Text) + CDbl(Me.txt_total_ief.Text) + CDbl(Me.txt_total_iva.Text)
    End Sub
End Class