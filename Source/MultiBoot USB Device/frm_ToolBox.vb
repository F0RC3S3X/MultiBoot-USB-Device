Imports System.Windows.Forms

Public Class frm_ToolBox
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Zip.Show()
    End Sub
End Class
