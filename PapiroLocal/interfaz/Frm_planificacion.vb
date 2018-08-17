Imports System.Globalization
Public Class Frm_planificacion

    Dim nue_report As New clases.Mov_Tierra
    Dim nue_var As New clases.variables
    Dim Cod_Mov_Tierra As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double

   
    Private Sub Frm_planificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(500, 100)
    End Sub
End Class