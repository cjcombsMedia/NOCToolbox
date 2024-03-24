<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NOCToolboxMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblGPOReports = New Label()
        lblDiskReports = New Label()
        lblADTools = New Label()
        CommandInfoToolTip = New ToolTip(components)
        Label1 = New Label()
        lblBootTime = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        hashTXTBox = New TextBox()
        ToolTip1 = New ToolTip(components)
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        txtPortNumber = New TextBox()
        Button13 = New Button()
        Button14 = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(8, 5)
        lblTitle.Margin = New Padding(2, 0, 2, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(197, 32)
        lblTitle.TabIndex = 14
        lblTitle.Text = "ITS NOC Toolbox"
        ' 
        ' lblGPOReports
        ' 
        lblGPOReports.AutoSize = True
        lblGPOReports.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGPOReports.ForeColor = Color.White
        lblGPOReports.Location = New Point(11, 43)
        lblGPOReports.Margin = New Padding(2, 0, 2, 0)
        lblGPOReports.Name = "lblGPOReports"
        lblGPOReports.Size = New Size(103, 21)
        lblGPOReports.TabIndex = 15
        lblGPOReports.Text = "GPO Reports:"
        ' 
        ' lblDiskReports
        ' 
        lblDiskReports.AutoSize = True
        lblDiskReports.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDiskReports.ForeColor = Color.White
        lblDiskReports.Location = New Point(12, 155)
        lblDiskReports.Margin = New Padding(2, 0, 2, 0)
        lblDiskReports.Name = "lblDiskReports"
        lblDiskReports.Size = New Size(188, 21)
        lblDiskReports.TabIndex = 18
        lblDiskReports.Text = "Disk and Storage Reports:"
        ' 
        ' lblADTools
        ' 
        lblADTools.AutoSize = True
        lblADTools.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblADTools.ForeColor = Color.White
        lblADTools.Location = New Point(11, 300)
        lblADTools.Margin = New Padding(2, 0, 2, 0)
        lblADTools.Name = "lblADTools"
        lblADTools.Size = New Size(207, 21)
        lblADTools.TabIndex = 21
        lblADTools.Text = "Active Directory Commands:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 401)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 21)
        Label1.TabIndex = 24
        Label1.Text = "Networking Commands:"
        ' 
        ' lblBootTime
        ' 
        lblBootTime.AutoSize = True
        lblBootTime.ForeColor = Color.White
        lblBootTime.Location = New Point(24, 562)
        lblBootTime.Margin = New Padding(2, 0, 2, 0)
        lblBootTime.Name = "lblBootTime"
        lblBootTime.Size = New Size(57, 15)
        lblBootTime.TabIndex = 27
        lblBootTime.Text = "BOOTIME"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(298, 69)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 23)
        Button4.TabIndex = 28
        Button4.Text = "DNSTwist"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(298, 127)
        Button5.Name = "Button5"
        Button5.Size = New Size(147, 23)
        Button5.TabIndex = 29
        Button5.Text = "Azure Verify"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(298, 98)
        Button6.Name = "Button6"
        Button6.Size = New Size(147, 23)
        Button6.TabIndex = 30
        Button6.Text = "HASH Check"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(298, 155)
        Button7.Name = "Button7"
        Button7.Size = New Size(147, 23)
        Button7.TabIndex = 31
        Button7.Text = "PowerShell ISE"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(298, 185)
        Button8.Name = "Button8"
        Button8.Size = New Size(147, 23)
        Button8.TabIndex = 32
        Button8.Text = "PowerShell"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(12, 70)
        Button9.Name = "Button9"
        Button9.Size = New Size(188, 23)
        Button9.TabIndex = 33
        Button9.Text = "Show ALL GPO's"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(12, 99)
        Button10.Name = "Button10"
        Button10.Size = New Size(188, 23)
        Button10.TabIndex = 34
        Button10.Text = "Show SPADE GPO's"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(298, 42)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 21)
        Label2.TabIndex = 35
        Label2.Text = "General Tools:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 23)
        Button1.TabIndex = 36
        Button1.Text = "Large Files (PS)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(8, 525)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 21)
        Label3.TabIndex = 37
        Label3.Text = "System Information:"
        ' 
        ' hashTXTBox
        ' 
        hashTXTBox.Location = New Point(451, 98)
        hashTXTBox.Name = "hashTXTBox"
        hashTXTBox.Size = New Size(222, 23)
        hashTXTBox.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(298, 300)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(244, 21)
        Label4.TabIndex = 40
        Label4.Text = "Commands (Potential Disruption):"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(298, 325)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 23)
        Button2.TabIndex = 39
        Button2.Text = "Delete VSS Shadows ALL"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 23)
        Button3.TabIndex = 41
        Button3.Text = "View Admin Shares"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(13, 325)
        Button11.Name = "Button11"
        Button11.Size = New Size(187, 23)
        Button11.TabIndex = 44
        Button11.Text = "AD Account NOT Logged 90 Days"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(13, 427)
        Button12.Name = "Button12"
        Button12.Size = New Size(187, 23)
        Button12.TabIndex = 45
        Button12.Text = "Find Processes for Port:"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' txtPortNumber
        ' 
        txtPortNumber.Location = New Point(206, 427)
        txtPortNumber.MaxLength = 5
        txtPortNumber.Name = "txtPortNumber"
        txtPortNumber.Size = New Size(64, 23)
        txtPortNumber.TabIndex = 46
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(13, 456)
        Button13.Name = "Button13"
        Button13.Size = New Size(187, 23)
        Button13.TabIndex = 47
        Button13.Text = "View ALL Open Ports"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(298, 354)
        Button14.Name = "Button14"
        Button14.Size = New Size(147, 23)
        Button14.TabIndex = 48
        Button14.Text = "Clean Up CW Folder"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' NOCToolboxMAIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(103), CByte(178))
        ClientSize = New Size(686, 599)
        Controls.Add(Button14)
        Controls.Add(Button13)
        Controls.Add(txtPortNumber)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(hashTXTBox)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(lblADTools)
        Controls.Add(lblDiskReports)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(lblGPOReports)
        Controls.Add(lblBootTime)
        Controls.Add(lblTitle)
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "NOCToolboxMAIN"
        Text = "NOC Toolbox"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGPOReports As Label
    Friend WithEvents lblDiskReports As Label
    Friend WithEvents lblADTools As Label
    Friend WithEvents CommandInfoToolTip As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBootTime As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents hashTXTBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents txtPortNumber As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button

End Class
