Public Class descargar_datos

    Private Sub AbrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrorToolStripMenuItem.Click
        Dim ruta As String
        Dim nombre As String
        Dim extension As String
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog1.FileName
            nombre = "cn01"
            extension = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            MsgBox(extension)
            My.Computer.Network.UploadFile(ruta, "ftp://ftp.constructorafv.com/Cerro%20Castillo/" & nombre & extension & "", "gsolis@constructorafv.com", "gsolis2013", True, 500)
        End If
    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class