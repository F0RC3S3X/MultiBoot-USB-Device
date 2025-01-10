<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Firewall
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
        Me.NsButton1 = New MultiBoot_USB_Device.NSButton()
        Me.NsButton2 = New MultiBoot_USB_Device.NSButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New MultiBoot_USB_Device.NSTextBox()
        Me.tbProto = New MultiBoot_USB_Device.NSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPort = New MultiBoot_USB_Device.NSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NsButton3 = New MultiBoot_USB_Device.NSButton()
        Me.tbOut = New MultiBoot_USB_Device.NSTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(465, 211)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(75, 27)
        Me.NsButton1.TabIndex = 2
        Me.NsButton1.Text = " Abbrechen"
        '
        'NsButton2
        '
        Me.NsButton2.Location = New System.Drawing.Point(384, 211)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(75, 27)
        Me.NsButton2.TabIndex = 3
        Me.NsButton2.Text = "      Okay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bezeichnung:"
        '
        'tbName
        '
        Me.tbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbName.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(30, 58)
        Me.tbName.MaxLength = 32767
        Me.tbName.Multiline = False
        Me.tbName.Name = "tbName"
        Me.tbName.ReadOnly = False
        Me.tbName.Size = New System.Drawing.Size(195, 27)
        Me.tbName.TabIndex = 5
        Me.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbName.UseSystemPasswordChar = False
        '
        'tbProto
        '
        Me.tbProto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbProto.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProto.Location = New System.Drawing.Point(238, 58)
        Me.tbProto.MaxLength = 32767
        Me.tbProto.Multiline = False
        Me.tbProto.Name = "tbProto"
        Me.tbProto.ReadOnly = False
        Me.tbProto.Size = New System.Drawing.Size(77, 27)
        Me.tbProto.TabIndex = 7
        Me.tbProto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbProto.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Protokoll:"
        '
        'tbPort
        '
        Me.tbPort.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPort.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPort.Location = New System.Drawing.Point(329, 58)
        Me.tbPort.MaxLength = 32767
        Me.tbPort.Multiline = False
        Me.tbPort.Name = "tbPort"
        Me.tbPort.ReadOnly = False
        Me.tbPort.Size = New System.Drawing.Size(77, 27)
        Me.tbPort.TabIndex = 9
        Me.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbPort.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Port:"
        '
        'NsButton3
        '
        Me.NsButton3.Location = New System.Drawing.Point(395, 111)
        Me.NsButton3.Name = "NsButton3"
        Me.NsButton3.Size = New System.Drawing.Size(107, 42)
        Me.NsButton3.TabIndex = 10
        Me.NsButton3.Text = "   Regel erstellen"
        '
        'tbOut
        '
        Me.tbOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbOut.Enabled = False
        Me.tbOut.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOut.Location = New System.Drawing.Point(30, 111)
        Me.tbOut.MaxLength = 32767
        Me.tbOut.Multiline = True
        Me.tbOut.Name = "tbOut"
        Me.tbOut.ReadOnly = False
        Me.tbOut.Size = New System.Drawing.Size(340, 77)
        Me.tbOut.TabIndex = 11
        Me.tbOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbOut.UseSystemPasswordChar = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(428, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = " Erlauben"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(428, 68)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = " Blockieren"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frm_Firewall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 250)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.tbOut)
        Me.Controls.Add(Me.NsButton3)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbProto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NsButton2)
        Me.Controls.Add(Me.NsButton1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Firewall"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Windows Firewall - Regel hinzufügen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsButton2 As NSButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As NSTextBox
    Friend WithEvents tbProto As NSTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPort As NSTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NsButton3 As NSButton
    Friend WithEvents tbOut As NSTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
