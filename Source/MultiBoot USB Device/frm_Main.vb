Imports System.IO
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frm_Main
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Dim aktuellerBenutzer As WindowsIdentity = WindowsIdentity.GetCurrent
        Dim princ As New WindowsPrincipal(aktuellerBenutzer)
        If Not princ.IsInRole(WindowsBuiltInRole.Administrator) Then
            Me.Text = Me.Text & " | Angemeldet als Standard Benutzer"
        End If
        LinkLabel1.Text = Environment.UserName
        Label3.Text = My.Computer.Info.OSFullName
        Try
            For Each a As String In IO.Directory.GetDirectories(Application.StartupPath & "Wallpaper\")
                Dim fi As New IO.FileInfo(a)
                ListBox1.Items.Add(fi.Name)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            Process.Start("C:\Users\" & LinkLabel1.Text & "\AppData\")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        End
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Web Browser\Firefox Setup 127.0.2.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Tools\7z2408-x64.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Tools\vlc-3.0.21-win64.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Try
            Process.Start(Application.StartupPath & "E:\software\Tools\Visual C++ AIO\install_all.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        System.IO.File.WriteAllText("C:\Users\" & Environment.UserName & "\Documents\Defender_Settings.vbs", My.Settings.Defend)
        Try
            Dim pf As String = IO.Path.Combine("C:\Users\" & Environment.UserName & "\Documents\Defender_Settings.vbs")
            Dim Prozess As New ProcessStartInfo(pf)
            Prozess.UseShellExecute = True
            Prozess.Verb = "runas"
            Process.Start(Prozess)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Adobe Software\Adobe Acrobat DC Pro (15.7.20033.2203)\Installer\Adobe Acrobat\Setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Adobe Software\Adobe Acrobat Pro DC 2024.002.20991 (x64) Pre Multilingual\autoplay.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Adobe Software\Adobe Audition 2025 v25.0 Multilingual x64\Set-up.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Adobe Software\Adobe Photoshop 2025 v26.1.0.121 Multilingual\autoplay.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Adobe Software\Adobe Photoshop CC 2019 20.0.10.120 (x64) Multilingual\Set-up.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked

    End Sub

    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe") = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe")
            Try
                My.Computer.FileSystem.CopyFile(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.renamed", Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe")
                Process.Start(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe")
            Catch ex As Exception

            End Try
        Else
            Try
                My.Computer.FileSystem.CopyFile(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.renamed", Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe")
                Process.Start(Application.StartupPath & "software\Adobe Software\AMTEmu\amtemu.v0.9.2-painter.exe")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub NsButton4_Click(sender As Object, e As EventArgs) Handles NsButton4.Click
        Try
            Process.Start(Application.StartupPath & "software\Aktivierungen\Scripts\Microsoft All-in-One.cmd")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\Advanced SystemCare Pro Portable 18.0.1.175 Multilingual\AdvancedSystemCarePortable.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\IObit Driver Booster Pro Portable 12.1.0.469 Multilingual\DriverBoosterPortable.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub NsButton5_Click(sender As Object, e As EventArgs) Handles NsButton5.Click
        Try
            Process.Start(".\")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\Advanced SystemCare Ultimate 17.1.0.93 Multilingual\asc-ultimate-setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\IObit Malware Fighter Pro 12.0.0.1433 Multilingual\iobit_malware_fighter_setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\iTop Screen Recorder 5.3.0.2849\itop-isr-deseo_hp-installer.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\IObit Driver Booster Pro 12.1.0.469\driver_booster_setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub NsButton6_Click(sender As Object, e As EventArgs) Handles NsButton6.Click
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\Advanced SystemCare Ultimate 17.1.0.93 Multilingual\Crack\Activation.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\IObit\Advanced SystemCare Ultimate\\ASC.exe") Then
            NsButton6.Enabled = True
        Else
            NsButton6.Enabled = False
        End If
    End Sub

    Private Sub NsButton7_Click(sender As Object, e As EventArgs) Handles NsButton7.Click
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\IObit Malware Fighter Pro 12.0.0.1433 Multilingual\Crack\Activation.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub NsButton9_Click(sender As Object, e As EventArgs) Handles NsButton9.Click
        My.Computer.Clipboard.SetText("CE85F-92575-65BA3-533B5")
        MsgBox("Der Lizenzschlüssel wurde in die Zwischenablage kopiert und kann nun einfach mit (STRG+V) eingefügt werden." & vbNewLine & vbNewLine & "CE85F-92575-65BA3-533B5" & vbNewLine)
    End Sub

    Private Sub NsButton8_Click(sender As Object, e As EventArgs) Handles NsButton8.Click
        Try
            Process.Start(Application.StartupPath & "software\iObit Software\IObit Driver Booster Pro 12.1.0.469\Activation.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel21_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel21.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Magix Software\MAGIX Samplitude Music Studio X8 19.2.1.24220\Setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel20_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Magix Software\MAGIX Samplitude Pro X8 Suite 19.2.1.24220 Multilingual\Samplitude_Pro_X8_Suite_Setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel19_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Magix Software\SoundForge Pro (Build 18.0.0.21)\SOUND_FORGE_Pro_18.0.0.21.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel22_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Magix Software\SoundForge Pro Suite (Build 18.0.0.21)\SOUND_FORGE_Pro_18.0.0.21_Suite.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel30_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\CyberLink PowerDirector Ultimate 2025 v23.0.1204.0\PowerDirector_23.0.1204.0_Ultimate.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel29_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\CyberLink PowerDVD Ultra 23.0.2319.62\PowerDVD_23.0.2319.62_Ultra.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel28_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\CyberLink Screen Recorder Deluxe 4.2.9.15396 Windows\ScreenRecorder_4.2.9.15396_Deluxe.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel27_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\Icecream Slideshow Maker Pro 5.15 Multilingual\slideshow_maker_setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel31_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\MediaHuman YouTube Downloader 3.9.9.96 (0312)\YouTubeDownloader-x64.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel32_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel32.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\Red Giant Universe 2024.2 Win64\Universe Installer.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel41_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel41.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Tools\RocketDock_Setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel39_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel39.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Windows 10\StarDock Start10 1.98 (Repack)\Stardock.Start10-1.98.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel40_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel40.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Windows 11\Stardock Start11 2.1.1 Final (x64) Multilingual\Start11v2-setup.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tbClip.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub LinkLabel47_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel47.LinkClicked
        My.Computer.Clipboard.SetText("https://de.taiwebs.com")
    End Sub

    Private Sub LinkLabel46_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel46.LinkClicked
        My.Computer.Clipboard.SetText("https://diakov.net/")
    End Sub

    Private Sub LinkLabel45_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel45.LinkClicked
        My.Computer.Clipboard.SetText("https://rsload.net/")
    End Sub

    Private Sub LinkLabel44_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel44.LinkClicked
        My.Computer.Clipboard.SetText("https://4download.net/")
    End Sub

    Private Sub LinkLabel43_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel43.LinkClicked
        My.Computer.Clipboard.SetText("https://lrepacks.net/")
    End Sub

    Private Sub LinkLabel51_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel51.LinkClicked
        My.Computer.Clipboard.SetText("https://streamkiste.tv/")
    End Sub

    Private Sub LinkLabel50_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel50.LinkClicked
        My.Computer.Clipboard.SetText("https://s.to/serien")
    End Sub

    Private Sub LinkLabel49_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel49.LinkClicked
        My.Computer.Clipboard.SetText("https://bs.to/andere-serien")
    End Sub

    Private Sub LinkLabel48_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel48.LinkClicked
        My.Computer.Clipboard.SetText("https://aniworld.to/animes")
    End Sub

    Private Sub LinkLabel42_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel42.LinkClicked
        My.Computer.Clipboard.SetText("https://streamcloud.my/streamcloud/")
    End Sub

    Private Sub NsButton10_Click(sender As Object, e As EventArgs) Handles NsButton10.Click
        Dim Web As New Process
        Web.StartInfo.FileName = "C:\Program Files\Mozilla Firefox\firefox.exe"
        Web.StartInfo.Arguments = tbClip.Text
        Try
            Web.Start()
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frm_Info.ShowDialog()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Try
            For Each a As String In IO.Directory.GetFiles(Application.StartupPath & "Wallpaper\" & ListBox1.SelectedItem & "\")
                Dim fi As New IO.FileInfo(a)
                ListBox2.Items.Add(fi.Name)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        PictureBox5.Load(Application.StartupPath & "Wallpaper\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim App As New Process
        App.StartInfo.FileName = "C:\Windows\system32\compmgmt.msc"
        App.StartInfo.Arguments = "/s"
        Try
            App.Start()
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim App As New Process
        App.StartInfo.FileName = "C:\Windows\system32\regedit.exe"
        App.StartInfo.Arguments = ""
        Try
            App.Start()
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim App As New Process
        App.StartInfo.FileName = "C:\Windows\system32\WF.msc"
        App.StartInfo.Arguments = ""
        Try
            App.Start()
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim App As New Process
        App.StartInfo.FileName = "C:\Windows\system32\eventvwr.msc"
        App.StartInfo.Arguments = "/s"
        Try
            App.Start()
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel56_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel56.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\Windows Update Packs\WindowsXP-KB936929-SP3-x86-DEU.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel53_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel53.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\Windows Update Packs\Windows 10 AIO Update Pack\UpdateInstaller.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel54_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel54.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\Windows Update Packs\WinFuture_7SP1_x64_UpdatePack_2.107_Januar_2020-Vollversion.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frm_Firewall.ShowDialog()
    End Sub

    Private Sub LinkLabel57_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel57.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\kodi-21.1-Omega-x64.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel59_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel59.LinkClicked
        My.Computer.Network.DownloadFile("https://streamxstream.github.io/xStreamRepoWeb/repository.xstream-1.2.4.zip", "C:\Users\Public\Downloads\repository.xstream-1.2.4.zip")
        MsgBox("Die Datei befindet sich im Öffentlichen Download Verzeichnis." & vbNewLine & vbNewLine & "C:\Users\Public\Downloads\")
    End Sub

    Private Sub LinkLabel58_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel58.LinkClicked
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/thecrewwh/zips/refs/heads/master/matrix/_zip/plugin.audio.mp3streams/plugin.audio.mp3streams-2022.0.2.zip", "C:\Users\Public\Downloads\plugin.audio.mp3streams-2022.0.2.zip")
        MsgBox("Die Datei befindet sich im Öffentlichen Download Verzeichnis." & vbNewLine & vbNewLine & "C:\Users\Public\Downloads\")
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        NsTextBox1.Text = ListBox3.SelectedItem
    End Sub

    Private Sub NsButton11_Click(sender As Object, e As EventArgs) Handles NsButton11.Click
        Try
            ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1
        Catch ex As Exception
            ListBox3.SelectedIndex = 1
        End Try
    End Sub

    Private Sub LinkLabel61_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel61.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Sonstiges\VMware Workstation Pro 17.6.1 Build 24319023 Win64\VMware-workstation-17.6.1-24319023.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel62_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel62.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Tools\Windows-Photo-Viewer.reg")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel63_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel63.LinkClicked
        My.Computer.Clipboard.SetText("https://de.spankbang.com")
    End Sub

    Private Sub LinkLabel64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel64.LinkClicked
        My.Computer.Clipboard.SetText("https://sxyprn.com/")
    End Sub

    Private Sub LinkLabel65_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel65.LinkClicked
        My.Computer.Clipboard.SetText("https://www.fpo.xxx/")
    End Sub

    Private Sub LinkLabel66_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel66.LinkClicked
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Ausführbare Datei (*.exe)|*.exe"
        sfd.FileName = "566.36-desktop-win10-win11-64bit-international-dch-whql.exe"
        If sfd.ShowDialog = DialogResult.OK Then
            MsgBox("Der Download beginnt nun, wenn die Datei geladen ist erscheint eine Meldung")
            Try
                My.Computer.Network.DownloadFile("https://de.download.nvidia.com/Windows/566.36/566.36-desktop-win10-win11-64bit-international-dch-whql.exe", sfd.FileName)
                MsgBox("Die Datei wurde geladen und kann nun verwendet werden.")
            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

    Private Sub LinkLabel69_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel69.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\AVS Audio Editor 10.5.2.579\Patch\Patch.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel68_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel68.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\AVS Audio Converter 10.5.2.644\AVSAudioConverter.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel67_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel67.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Media Tools\AVS Audio Editor 10.5.2.579\AVSAudioEditor.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel70_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel70.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\dotnetfx35.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel71_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel71.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\NDP472-KB4054530-x86-x64-AllOS-ENU.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub LinkLabel72_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel72.LinkClicked
        Try
            Process.Start(Application.StartupPath & "software\Updates\NDP48-x86-x64-AllOS-ENU.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start(Application.StartupPath & "software\Tools\Raspi Imager\rpi-imager.exe")
        Catch ex As Exception
            MsgBox("Das System kann die angegebene Datei nicht finden.")
        End Try
    End Sub

    Private Sub NsButton12_Click(sender As Object, e As EventArgs) Handles NsButton12.Click
        frm_ToolBox.ShowDialog()
    End Sub
End Class
