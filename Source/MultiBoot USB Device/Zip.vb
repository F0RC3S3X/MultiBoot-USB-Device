Public Class Zip
    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        Dim zip As New Process
        zip.StartInfo.FileName = ""
        zip.StartInfo.Arguments = ""
        Try
            System.IO.File.WriteAllText(".\Unzip.bat", "@ECHO OFF" & vbNewLine & " e -t7z " & NsTextBox2.Text & NsTextBox1.Text)
            Process.Start(".\Unzip.bat")
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Zip_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        frm_ToolBox.Show()
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        frm_ToolBox.ShowDialog()
        If frm_ToolBox.ShowDialog = DialogResult.OK Then
            NsTextBox1.Text = fbd.SelectedPath & "\"
        End If
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        If frm_ToolBox.ShowDialog = DialogResult.OK Then
            NsTextBox2.Text = fbd.SelectedPath & "\"
        End If
    End Sub
End Class