﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomRulesUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxPostalCode = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelPostalCode = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextBoxDisplayMessage = New System.Windows.Forms.TextBox()
        Me.GroupBoxDisplayMessage = New System.Windows.Forms.GroupBox()
        Me.ButtonCheckRules = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.TextBoxCompanyPostalCode = New System.Windows.Forms.TextBox()
        Me.TextBoxCompanyName = New System.Windows.Forms.TextBox()
        Me.GroupBoxDisplayMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(12, 26)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFirstName.TabIndex = 0
        '
        'TextBoxPostalCode
        '
        Me.TextBoxPostalCode.Location = New System.Drawing.Point(224, 26)
        Me.TextBoxPostalCode.Name = "TextBoxPostalCode"
        Me.TextBoxPostalCode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPostalCode.TabIndex = 2
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(118, 26)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLastName.TabIndex = 1
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(9, 10)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LabelFirstName.TabIndex = 3
        Me.LabelFirstName.Text = "First Name"
        '
        'LabelPostalCode
        '
        Me.LabelPostalCode.AutoSize = True
        Me.LabelPostalCode.Location = New System.Drawing.Point(221, 10)
        Me.LabelPostalCode.Name = "LabelPostalCode"
        Me.LabelPostalCode.Size = New System.Drawing.Size(64, 13)
        Me.LabelPostalCode.TabIndex = 4
        Me.LabelPostalCode.Text = "Postal Code"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(115, 10)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(58, 13)
        Me.LabelLastName.TabIndex = 5
        Me.LabelLastName.Text = "Last Name"
        '
        'TextBoxDisplayMessage
        '
        Me.TextBoxDisplayMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDisplayMessage.Location = New System.Drawing.Point(3, 16)
        Me.TextBoxDisplayMessage.Multiline = True
        Me.TextBoxDisplayMessage.Name = "TextBoxDisplayMessage"
        Me.TextBoxDisplayMessage.Size = New System.Drawing.Size(505, 112)
        Me.TextBoxDisplayMessage.TabIndex = 6
        Me.TextBoxDisplayMessage.TabStop = False
        '
        'GroupBoxDisplayMessage
        '
        Me.GroupBoxDisplayMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDisplayMessage.Controls.Add(Me.TextBoxDisplayMessage)
        Me.GroupBoxDisplayMessage.Location = New System.Drawing.Point(12, 115)
        Me.GroupBoxDisplayMessage.Name = "GroupBoxDisplayMessage"
        Me.GroupBoxDisplayMessage.Size = New System.Drawing.Size(511, 131)
        Me.GroupBoxDisplayMessage.TabIndex = 7
        Me.GroupBoxDisplayMessage.TabStop = False
        Me.GroupBoxDisplayMessage.Text = "Display Message"
        '
        'ButtonCheckRules
        '
        Me.ButtonCheckRules.Location = New System.Drawing.Point(362, 24)
        Me.ButtonCheckRules.Name = "ButtonCheckRules"
        Me.ButtonCheckRules.Size = New System.Drawing.Size(97, 23)
        Me.ButtonCheckRules.TabIndex = 8
        Me.ButtonCheckRules.Text = "Check Rules"
        Me.ButtonCheckRules.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Postal Code"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(12, 55)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.LabelCompanyName.TabIndex = 11
        Me.LabelCompanyName.Text = "Company Name"
        '
        'TextBoxCompanyPostalCode
        '
        Me.TextBoxCompanyPostalCode.Location = New System.Drawing.Point(118, 71)
        Me.TextBoxCompanyPostalCode.Name = "TextBoxCompanyPostalCode"
        Me.TextBoxCompanyPostalCode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCompanyPostalCode.TabIndex = 5
        '
        'TextBoxCompanyName
        '
        Me.TextBoxCompanyName.Location = New System.Drawing.Point(12, 71)
        Me.TextBoxCompanyName.Name = "TextBoxCompanyName"
        Me.TextBoxCompanyName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCompanyName.TabIndex = 4
        '
        'CustomRulesUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 258)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Controls.Add(Me.TextBoxCompanyPostalCode)
        Me.Controls.Add(Me.TextBoxCompanyName)
        Me.Controls.Add(Me.ButtonCheckRules)
        Me.Controls.Add(Me.GroupBoxDisplayMessage)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelPostalCode)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.TextBoxPostalCode)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Name = "CustomRulesUI"
        Me.Text = "Custom Rules"
        Me.GroupBoxDisplayMessage.ResumeLayout(False)
        Me.GroupBoxDisplayMessage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxPostalCode As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents LabelPostalCode As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextBoxDisplayMessage As TextBox
    Friend WithEvents GroupBoxDisplayMessage As GroupBox
    Friend WithEvents ButtonCheckRules As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelCompanyName As Label
    Friend WithEvents TextBoxCompanyPostalCode As TextBox
    Friend WithEvents TextBoxCompanyName As TextBox
End Class
