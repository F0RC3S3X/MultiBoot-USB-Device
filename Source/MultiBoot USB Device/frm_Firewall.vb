Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Public Class frm_Firewall

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_Firewall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        If RadioButton1.Checked = True Then
            tbOut.Text = My.Settings.NetRule.Replace("%DESC%", tbName.Text)
            tbOut.Text = tbOut.Text.Replace("%PROTO%", tbProto.Text)
            tbOut.Text = tbOut.Text.Replace("%PRT%", tbPort.Text)
            tbOut.Text = tbOut.Text.Replace("%Action%", "allow")
            System.IO.File.WriteAllText("C:\Users\Public\Documents\AddRule.bat", tbOut.Text)
            Try
                Process.Start("C:\Users\Public\Documents\AddRule.bat")
            Catch ex As Exception

            End Try
        Else
            tbOut.Text = My.Settings.NetRule.Replace("%DESC%", tbName.Text)
            tbOut.Text = tbOut.Text.Replace("%PROTO%", tbProto.Text)
            tbOut.Text = tbOut.Text.Replace("%PRT%", tbPort.Text)
            tbOut.Text = tbOut.Text.Replace("%Action%", "block")
            System.IO.File.WriteAllText("C:\Users\Public\Documents\AddRule.bat", tbOut.Text)
            Try
                Process.Start("C:\Users\Public\Documents\AddRule.bat")
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
