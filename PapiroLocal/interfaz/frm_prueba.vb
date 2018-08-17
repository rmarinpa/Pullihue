Public Class frm_prueba

    Dim nue_usua As New clases.Ruta
    Dim cod_usua As String = ""
    Dim sw As Integer

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim prueba As String
        prueba = TextBox1.Text
        If TextBox1.Text = "OK" Then
            MsgBox("PRUEBA EXITOSA")
        Else

        End If
        ' TextBox1.Text.Contains()
    End Sub
End Class