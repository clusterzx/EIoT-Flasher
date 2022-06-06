Imports System.Collections.ObjectModel
Imports System.IO.Compression
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text


Public Class Form1
    Dim downloadPath As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim EioTPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "/EioT-Flasher"
    Dim libs_path As String = "C:\Users\" + Environment.UserName + "\AppData\Local\Arduino15\staging\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        If My.Settings.firstRun = False Then
            cmdInitialize.Enabled = False
            lbResults.Items.Add("Already installed. Proceed with flashing")
            groupFlash.Enabled = True
            groupImage.Enabled = True
            GetSerialPortNames()
        End If
    End Sub

    Private Async Sub cmdInitialize_Click(sender As Object, e As EventArgs) Handles cmdInitialize.Click
        Try
            cmdInitialize.Enabled = False
            Dim webclient As System.Net.WebClient
            webclient = New System.Net.WebClient
            webclient.DownloadFile("https://downloads.arduino.cc/arduino-cli/arduino-cli_latest_Windows_64bit.zip", downloadPath + "/arduino-cli.zip")
            Try
                ZipFile.ExtractToDirectory(downloadPath + "/arduino-cli.zip", EioTPath)
            Catch ex As Exception
                MsgBox("File already exists!", vbExclamation, "Warning!")
            End Try
            Dim tasks As New List(Of Task)()
            tasks.Add(Task.Run(AddressOf Install))
            Await Task.WhenAll(tasks)
            'Dim libs_byte As Byte() = My.Resources.libraries
            'My.Computer.FileSystem.WriteAllBytes(libs_path + "libraries.zip", libs_byte, False)
            'If System.IO.File.Exists(libs_path + "libraries.zip") Then
            '    ZipFile.ExtractToDirectory(libs_path + "libraries.zip", libs_path)
            'Else
            '    MsgBox(libs_path + "libraries.zip ... does not exist")
            'End If
        Catch ex As Exception
            MsgBox("Error while installing: " + ex.Message, vbCritical, "Error :(")
        End Try

    End Sub
    Private Sub Install()
        lbResults.Items.Add("Installing all libraries...")
        RunScript(EioTPath + "/arduino-cli.exe config init; Add-Content C:\Users\" + Environment.UserName + "\AppData\Local\Arduino15\arduino-cli.yaml '" + My.Settings.append + "';" + EioTPath + "/arduino-cli.exe core install esp8266:esp8266")
        System.Threading.Thread.Sleep(3000)
        lbResults.Items.Add("Installtion done...")
        My.Settings.firstRun = True
        groupFlash.Enabled = True
        groupImage.Enabled = True
        GetSerialPortNames()
    End Sub
    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMPorts.Items.Add(sp)
        Next
    End Sub
    Private Function RunScript(ByVal script As String) As String
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline As Pipeline = runspace.CreatePipeline()
        pipeline.Commands.AddScript(script)
        pipeline.Commands.Add("Out-String")
        Dim results As Collection(Of PSObject) = pipeline.Invoke()
        runspace.Close()
        Dim stringBuilder As StringBuilder = New StringBuilder()
        For Each ps As PSObject In results
            stringBuilder.AppendLine(ps.ToString())
        Next
        Return stringBuilder.ToString()
    End Function

    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        txtFlash.Text = "Start flashing... Please wait." & vbNewLine
        Dim sourceMod As String
        If cmbImage.SelectedItem = "Thermostat" Then
            sourceMod = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(My.Settings.srcThermy_bak))
        ElseIf cmbImage.SelectedItem = "Motionsensor" Then
            sourceMod = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(My.Settings.srcMotion))
        End If
        sourceMod = sourceMod.Replace("%SSID%", txtSSID.Text)
        sourceMod = sourceMod.Replace("%SSIDPASSWORD%", txtPassword.Text)
        sourceMod = sourceMod.Replace("%SECRETKEY%", txtSecretkey.Text)
        sourceMod = sourceMod.Replace("%BACKEND%", txtBackend.Text)
        sourceMod = sourceMod.Replace("%ESPNAME%", txtDeviceName.Text)
        System.IO.File.WriteAllText(EioTPath + "/EioT-Flasher.ino", sourceMod)
        Dim libs As String() = {"ESP8266WiFi", "ESP8266HTTPClient", "WiFiClient", "Arduino_JSON", """DHT sensor library""", "ArduinoJson"}
        For Each xlib As String In libs
            txtFlash.Text = txtFlash.Text + RunScript(EioTPath + "/arduino-cli.exe lib install " + xlib + ";")
        Next

        Clipboard.SetText(EioTPath + "/arduino-cli.exe compile --fqbn  esp8266:esp8266:nodemcu EioT-Flasher;" + EioTPath + "/arduino-cli.exe upload -p " + cmbCOMPorts.SelectedItem.ToString + " --fqbn  esp8266:esp8266:nodemcu EioT-Flasher")

        Dim compile As Process
        compile = Process.Start("powershell.exe", "cd " + EioTPath + ";.\arduino-cli.exe compile --fqbn  esp8266:esp8266:nodemcu EioT-Flasher;" + EioTPath + ".\arduino-cli.exe upload -p " + cmbCOMPorts.SelectedItem.ToString + " --fqbn  esp8266:esp8266:nodemcu EioT-Flasher")
        compile.WaitForExit()

        'txtFlash.Text = txtFlash.Text + RunScript(EioTPath + "/arduino-cli.exe compile --fqbn  esp8266:esp8266:nodemcu EioT-Flasher;" + EioTPath + "/arduino-cli.exe upload -p " + cmbCOMPorts.SelectedItem.ToString + " --fqbn  esp8266:esp8266:nodemcu EioT-Flasher")
        txtFlash.Text = txtFlash.Text + vbNewLine + "Flashing complete... DONE! :)"
    End Sub

    Private Sub cmbImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbImage.SelectedIndexChanged
        Dim Generator As System.Random = New System.Random()
        Dim randomInt As Integer = Generator.Next(10, 999)
        If cmbImage.SelectedItem = "Thermostat" Then
            txtDeviceName.Text = "Thermy-" + randomInt.ToString
        ElseIf cmbImage.SelectedItem = "Motionsensor" Then
            txtDeviceName.Text = "EioMotion-" + randomInt.ToString
        End If
    End Sub
End Class
