Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports System.Diagnostics

Public Class NOCToolboxMAIN
    Private xmlDoc As New XmlDocument()
    Private Function GetLastBootTime() As String
        Dim bootTime As String = ""

        Try
            ' Run the systeminfo command to get system information
            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c systeminfo | find ""System Boot Time"""
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.CreateNoWindow = True
            process.Start()

            ' Read the output of the command
            Dim output As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' Parse the output to extract the boot time
            Dim startIndex As Integer = output.IndexOf(":") + 2
            Dim endIndex As Integer = output.IndexOf(vbCrLf, startIndex)
            bootTime = output.Substring(startIndex, endIndex - startIndex)
        Catch ex As Exception
            MessageBox.Show("Error retrieving last boot time: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bootTime
    End Function


    Private Sub NOCToolboxMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load the XML document and populate the ComboBox

            ' Get the last boot time
            Dim lastBootTime As String = GetLastBootTime()

            ' Display the last boot time in the label
            lblBootTime.Text = "Last Boot Time of this Machine: " & lastBootTime
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub DeleteFilesForCurrentUser()
        ' Get the current user's documents folder path
        Dim documentsFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ConnectWiseControl\Files")

        ' Initialize counters for files and folders deleted
        Dim filesDeletedCount As Integer = 0
        Dim foldersDeletedCount As Integer = 0

        ' Check if the folder exists
        If Directory.Exists(documentsFolderPath) Then
            ' Delete all files in the folder
            Dim files As String() = Directory.GetFiles(documentsFolderPath)
            For Each fileItem As String In files
                Try
                    File.Delete(fileItem)
                    filesDeletedCount += 1
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Optionally, you can log or display an error message
                End Try
            Next

            ' Delete all subdirectories (folders) in the folder
            Dim directories As String() = Directory.GetDirectories(documentsFolderPath)
            For Each directoryItem As String In directories
                Try
                    Directory.Delete(directoryItem, True) ' 'True' indicates to delete recursively
                    foldersDeletedCount += 1
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting folder: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Optionally, you can log or display an error message
                End Try
            Next

            ' Display a message indicating the number of files and folders deleted
            MessageBox.Show(String.Format("Files Deleted: {0}{1}Folders Deleted: {2}", filesDeletedCount, Environment.NewLine, foldersDeletedCount), "Cleaned Up CW Files", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Optionally, you can log or display a message indicating that the folder doesn't exist
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim reportFolderPath = "c:\reports"
        Dim reportPath = Path.Combine(reportFolderPath, "gpo_report.html")

        ' Check if the reports folder exists, and create it if not
        If Not Directory.Exists(reportFolderPath) Then
            Directory.CreateDirectory(reportFolderPath)
        End If

        ' Run the gpresult command and save the output to the HTML file
        Dim process As New Process
        process.StartInfo.UseShellExecute = True
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Arguments = "/c gpresult /v /h """ & reportPath & """"
        process.Start()
        process.WaitForExit() ' Wait for the command to complete

        ' Open the generated report in the default web browser
        If File.Exists(reportPath) Then
            process.StartInfo.FileName = reportPath
            process.Start()
        Else
            MessageBox.Show("Report generation failed. Check folder permissions, or if an existing file is there.")
        End If

        Exit Sub
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim reportFolderPath As String = "c:\reports"
            Dim reportPath As String = Path.Combine(reportFolderPath, "gpo_report.txt")

            ' Check if the reports folder exists, and create it if not
            If Not Directory.Exists(reportFolderPath) Then
                Directory.CreateDirectory(reportFolderPath)
            End If

            ' Run the gpresult command and save the output to a text file
            Dim process As New Process()
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c gpresult /z > """ & reportPath & """"
            process.Start()
            process.WaitForExit() ' Wait for the command to complete

            ' Open the generated report using Notepad
            If File.Exists(reportPath) Then
                Process.Start("notepad.exe", reportPath)
            Else
                MessageBox.Show("Report generation failed. Check folder permissions, or if an existing file is there.")
            End If
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & ex.Message & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("powershell.exe", "-NoExit -ExecutionPolicy Bypass")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If hashTXTBox.Text = "" Then
            MsgBox("Enter the HASH to verify from a download." & vbCrLf & Application.ProductVersion, MsgBoxStyle.Exclamation, "Missing data!" & Application.ProductVersion)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim command = "Gwmi Win32_Share | ForEach-Object { '\\\\' + $_.PSComputerName + '\\' + $_.Name }"
            Dim process As New Process
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "powershell.exe"
            process.StartInfo.Arguments = "-NoExit -Command ""echo 'This is the command that will run: " & command & "' `r`n; " & command & """"
            process.Start()
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & Err.Description & vbCrLf & vbCrLf & Err.GetException.ToString & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
            'CaptureScreenshot()
        End Try
    End Sub

    Private Sub RunCommandAndGetOutput()
        Try
            Dim command As String = "Gwmi Win32_Share | ForEach-Object { '\\\\' + $_.PSComputerName + '\\' + $_.Name }"

            Dim process As New Process()
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True ' Enable redirection of Standard Error
            process.StartInfo.FileName = "powershell.exe"
            process.StartInfo.Arguments = "-NoExit -NonInteractive -Command ""$VerbosePreference = 'Continue'; " & command & """"

            process.Start()

            ' Read the output of the command and add it to the ListView
            Dim output As String = process.StandardOutput.ReadToEnd()

            ' Read the error output of the command
            Dim errorOutput As String = process.StandardError.ReadToEnd()

            ' Close the process after reading the output
            process.WaitForExit()

            ' Check for errors
            If Not String.IsNullOrEmpty(errorOutput) Then
                MsgBox("Error occurred: " & errorOutput)
            End If

            ' Add the output to the ListView
            AddOutputToListView(output)
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & ex.Message & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
        End Try
    End Sub
    Private Sub AddOutputToListView(output As String)
        ' Assuming you have a ListView named 'ListView1' with at least one column

        ' Clear the existing items in the ListView
        'lstResults.Items.Clear()

        ' Split the output by line breaks
        Dim lines() As String = output.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        ' Add each line to the ListView
        For Each line As String In lines
            Dim item As New ListViewItem(line)
            'lstResults.Items.Add(item)
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim command = "Get-ADUser -Filter {(Enabled -eq $True) -and (LastLogonDate -lt (Get-Date).AddDays(-90))}"
            Dim process As New Process
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "powershell.exe"
            process.StartInfo.Arguments = "-NoExit -Command ""echo 'This is the command that will run: " & command & "' `r`n; " & command & """"
            process.Start()
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & Err.Description & vbCrLf & vbCrLf & Err.GetException.ToString & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
            'CaptureScreenshot()
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            ' Get the port number from a TextBox named txtPortNumber
            Dim portNumber = txtPortNumber.Text.Trim

            ' Construct the PowerShell command with the variable port number
            Dim command = "Get-NetTCPConnection | Where-Object { $_.LocalPort -eq " & portNumber & " } | Select-Object OwningProcess, LocalAddress, LocalPort, @{Name='LocalAdapter';Expression={(Get-NetAdapter -InterfaceIndex $_.LocalAddress -ErrorAction SilentlyContinue).Name}} | Sort-Object OwningProcess | Get-Unique"

            ' Start the PowerShell process
            Dim process As New Process
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "powershell.exe"
            process.StartInfo.Arguments = "-NoExit -Command """ & command & """"
            process.Start()
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & ex.Message & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
            'CaptureScreenshot()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Get-NetTcpConnection -State Listen | Select-Object LocalAddress,LocalPort| Sort-Object -Property LocalPort | Format-Table
        Try
            Dim command = "Get-NetTcpConnection -State Listen | Select-Object LocalAddress,LocalPort| Sort-Object -Property LocalPort | Format-Table"
            Dim process As New Process
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "powershell.exe"
            process.StartInfo.Arguments = "-NoExit -Command ""echo 'This is the command that will run: " & command & "' `r`n; " & command & """"
            process.Start()
        Catch ex As Exception
            MsgBox("Error processing the command. The error was: " & vbCrLf & Err.Description & vbCrLf & vbCrLf & Err.GetException.ToString & vbCrLf & vbCrLf & "Please email or IM CJ Combs this error with version number information: NOC Launcher" & Application.ProductVersion, MsgBoxStyle.Exclamation, "Error - NOC Launcher" & Application.ProductVersion)
            'CaptureScreenshot()
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        DeleteFilesForCurrentUser()

    End Sub
End Class
