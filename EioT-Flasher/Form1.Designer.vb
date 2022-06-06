<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbResults = New System.Windows.Forms.ListBox()
        Me.cmdInitialize = New System.Windows.Forms.Button()
        Me.groupFlash = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbCOMPorts = New System.Windows.Forms.ComboBox()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.txtSecretkey = New System.Windows.Forms.TextBox()
        Me.txtBackend = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.txtFlash = New System.Windows.Forms.TextBox()
        Me.groupImage = New System.Windows.Forms.GroupBox()
        Me.cmbImage = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.groupFlash.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.groupImage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbResults)
        Me.GroupBox1.Controls.Add(Me.cmdInitialize)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initialize:"
        '
        'lbResults
        '
        Me.lbResults.FormattingEnabled = True
        Me.lbResults.Location = New System.Drawing.Point(6, 49)
        Me.lbResults.Name = "lbResults"
        Me.lbResults.Size = New System.Drawing.Size(265, 43)
        Me.lbResults.TabIndex = 1
        '
        'cmdInitialize
        '
        Me.cmdInitialize.Location = New System.Drawing.Point(6, 19)
        Me.cmdInitialize.Name = "cmdInitialize"
        Me.cmdInitialize.Size = New System.Drawing.Size(265, 24)
        Me.cmdInitialize.TabIndex = 0
        Me.cmdInitialize.Text = "Initialize first run"
        Me.cmdInitialize.UseVisualStyleBackColor = True
        '
        'groupFlash
        '
        Me.groupFlash.Controls.Add(Me.GroupBox3)
        Me.groupFlash.Controls.Add(Me.Label5)
        Me.groupFlash.Controls.Add(Me.Label4)
        Me.groupFlash.Controls.Add(Me.Label3)
        Me.groupFlash.Controls.Add(Me.Label2)
        Me.groupFlash.Controls.Add(Me.Label1)
        Me.groupFlash.Controls.Add(Me.txtDeviceName)
        Me.groupFlash.Controls.Add(Me.txtSecretkey)
        Me.groupFlash.Controls.Add(Me.txtBackend)
        Me.groupFlash.Controls.Add(Me.txtPassword)
        Me.groupFlash.Controls.Add(Me.txtSSID)
        Me.groupFlash.Enabled = False
        Me.groupFlash.Location = New System.Drawing.Point(12, 298)
        Me.groupFlash.Name = "groupFlash"
        Me.groupFlash.Size = New System.Drawing.Size(284, 357)
        Me.groupFlash.TabIndex = 1
        Me.groupFlash.TabStop = False
        Me.groupFlash.Text = "Flashing"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbCOMPorts)
        Me.GroupBox3.Controls.Add(Me.btnFlash)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(272, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COM Port"
        '
        'cmbCOMPorts
        '
        Me.cmbCOMPorts.FormattingEnabled = True
        Me.cmbCOMPorts.Location = New System.Drawing.Point(6, 19)
        Me.cmbCOMPorts.Name = "cmbCOMPorts"
        Me.cmbCOMPorts.Size = New System.Drawing.Size(259, 21)
        Me.cmbCOMPorts.TabIndex = 0
        '
        'btnFlash
        '
        Me.btnFlash.Location = New System.Drawing.Point(6, 48)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(260, 31)
        Me.btnFlash.TabIndex = 1
        Me.btnFlash.Text = "Flash EioT Device"
        Me.btnFlash.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Device Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Secret Key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Backend Server IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your WiFi Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter your WiFi SSID:"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(6, 224)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(272, 20)
        Me.txtDeviceName.TabIndex = 10
        Me.txtDeviceName.Text = "Thermy-"
        '
        'txtSecretkey
        '
        Me.txtSecretkey.Location = New System.Drawing.Point(6, 177)
        Me.txtSecretkey.Name = "txtSecretkey"
        Me.txtSecretkey.Size = New System.Drawing.Size(272, 20)
        Me.txtSecretkey.TabIndex = 9
        Me.txtSecretkey.Text = "1234567890"
        '
        'txtBackend
        '
        Me.txtBackend.Location = New System.Drawing.Point(6, 133)
        Me.txtBackend.Name = "txtBackend"
        Me.txtBackend.Size = New System.Drawing.Size(272, 20)
        Me.txtBackend.TabIndex = 8
        Me.txtBackend.Text = "192.168.178.107"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(272, 20)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "MyWiFi-Password"
        '
        'txtSSID
        '
        Me.txtSSID.Location = New System.Drawing.Point(6, 43)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(272, 20)
        Me.txtSSID.TabIndex = 6
        Me.txtSSID.Text = "MyWiFi"
        '
        'txtFlash
        '
        Me.txtFlash.Location = New System.Drawing.Point(307, 133)
        Me.txtFlash.Multiline = True
        Me.txtFlash.Name = "txtFlash"
        Me.txtFlash.ReadOnly = True
        Me.txtFlash.Size = New System.Drawing.Size(554, 521)
        Me.txtFlash.TabIndex = 2
        '
        'groupImage
        '
        Me.groupImage.Controls.Add(Me.cmbImage)
        Me.groupImage.Enabled = False
        Me.groupImage.Location = New System.Drawing.Point(12, 241)
        Me.groupImage.Name = "groupImage"
        Me.groupImage.Size = New System.Drawing.Size(284, 48)
        Me.groupImage.TabIndex = 3
        Me.groupImage.TabStop = False
        Me.groupImage.Text = "Image"
        '
        'cmbImage
        '
        Me.cmbImage.FormattingEnabled = True
        Me.cmbImage.Items.AddRange(New Object() {"Thermostat", "Motionsensor"})
        Me.cmbImage.Location = New System.Drawing.Point(6, 19)
        Me.cmbImage.Name = "cmbImage"
        Me.cmbImage.Size = New System.Drawing.Size(265, 21)
        Me.cmbImage.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EioT_Flasher.My.Resources.Resources.eiotflasher_logo
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(852, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 661)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupImage)
        Me.Controls.Add(Me.txtFlash)
        Me.Controls.Add(Me.groupFlash)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EioT-Flasher by Clusterzx"
        Me.GroupBox1.ResumeLayout(False)
        Me.groupFlash.ResumeLayout(False)
        Me.groupFlash.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.groupImage.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdInitialize As Button
    Friend WithEvents lbResults As ListBox
    Friend WithEvents groupFlash As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFlash As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecretkey As TextBox
    Friend WithEvents txtBackend As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents cmbCOMPorts As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeviceName As TextBox
    Friend WithEvents txtFlash As TextBox
    Friend WithEvents groupImage As GroupBox
    Friend WithEvents cmbImage As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
