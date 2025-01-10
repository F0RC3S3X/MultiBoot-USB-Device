<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zip
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zip))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsTextBox1 = New MultiBoot_USB_Device.NSTextBox()
        Me.NsButton1 = New MultiBoot_USB_Device.NSButton()
        Me.NsButton2 = New MultiBoot_USB_Device.NSButton()
        Me.NsTextBox2 = New MultiBoot_USB_Device.NSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NsButton3 = New MultiBoot_USB_Device.NSButton()
        Me.NsButton4 = New MultiBoot_USB_Device.NSButton()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quellverzeichnis:"
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Enabled = False
        Me.NsTextBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsTextBox1.Location = New System.Drawing.Point(30, 62)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(501, 29)
        Me.NsTextBox1.TabIndex = 1
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(537, 62)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(24, 29)
        Me.NsButton1.TabIndex = 2
        Me.NsButton1.Text = "..."
        '
        'NsButton2
        '
        Me.NsButton2.Location = New System.Drawing.Point(537, 151)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(24, 29)
        Me.NsButton2.TabIndex = 5
        Me.NsButton2.Text = "..."
        '
        'NsTextBox2
        '
        Me.NsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox2.Enabled = False
        Me.NsTextBox2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsTextBox2.Location = New System.Drawing.Point(30, 151)
        Me.NsTextBox2.MaxLength = 32767
        Me.NsTextBox2.Multiline = False
        Me.NsTextBox2.Name = "NsTextBox2"
        Me.NsTextBox2.ReadOnly = False
        Me.NsTextBox2.Size = New System.Drawing.Size(501, 29)
        Me.NsTextBox2.TabIndex = 4
        Me.NsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox2.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Zielverzeichnis:"
        '
        'NsButton3
        '
        Me.NsButton3.Location = New System.Drawing.Point(460, 223)
        Me.NsButton3.Name = "NsButton3"
        Me.NsButton3.Size = New System.Drawing.Size(101, 43)
        Me.NsButton3.TabIndex = 6
        Me.NsButton3.Text = "     Entpacken"
        '
        'NsButton4
        '
        Me.NsButton4.Location = New System.Drawing.Point(353, 223)
        Me.NsButton4.Name = "NsButton4"
        Me.NsButton4.Size = New System.Drawing.Size(101, 43)
        Me.NsButton4.TabIndex = 7
        Me.NsButton4.Text = "     Schließen"
        '
        'Zip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 303)
        Me.Controls.Add(Me.NsButton4)
        Me.Controls.Add(Me.NsButton3)
        Me.Controls.Add(Me.NsButton2)
        Me.Controls.Add(Me.NsTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NsButton1)
        Me.Controls.Add(Me.NsTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Zip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dateien Extrahieren"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsButton2 As NSButton
    Friend WithEvents NsTextBox2 As NSTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NsButton3 As NSButton
    Friend WithEvents NsButton4 As NSButton
    Friend WithEvents fbd As FolderBrowserDialog
End Class
