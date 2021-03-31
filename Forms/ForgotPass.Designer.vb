<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPass
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
        Me.panelMasterKey = New System.Windows.Forms.Panel()
        Me.panelResetPass = New System.Windows.Forms.Panel()
        Me.btnSubmitNewPass = New System.Windows.Forms.Button()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnterKey = New System.Windows.Forms.Button()
        Me.txtMasterKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmitSecQA = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSecQAnswer = New System.Windows.Forms.TextBox()
        Me.panelMasterKey.SuspendLayout()
        Me.panelResetPass.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMasterKey
        '
        Me.panelMasterKey.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelMasterKey.Controls.Add(Me.LinkLabel1)
        Me.panelMasterKey.Controls.Add(Me.btnEnterKey)
        Me.panelMasterKey.Controls.Add(Me.txtMasterKey)
        Me.panelMasterKey.Controls.Add(Me.Label2)
        Me.panelMasterKey.Controls.Add(Me.Label1)
        Me.panelMasterKey.Location = New System.Drawing.Point(12, 12)
        Me.panelMasterKey.Name = "panelMasterKey"
        Me.panelMasterKey.Size = New System.Drawing.Size(534, 397)
        Me.panelMasterKey.TabIndex = 4
        '
        'panelResetPass
        '
        Me.panelResetPass.Controls.Add(Me.btnSubmitNewPass)
        Me.panelResetPass.Controls.Add(Me.txtConfirmPass)
        Me.panelResetPass.Controls.Add(Me.txtNewPass)
        Me.panelResetPass.Controls.Add(Me.Label5)
        Me.panelResetPass.Controls.Add(Me.Label4)
        Me.panelResetPass.Controls.Add(Me.Label3)
        Me.panelResetPass.Location = New System.Drawing.Point(12, 12)
        Me.panelResetPass.Name = "panelResetPass"
        Me.panelResetPass.Size = New System.Drawing.Size(534, 397)
        Me.panelResetPass.TabIndex = 8
        Me.panelResetPass.Visible = False
        '
        'btnSubmitNewPass
        '
        Me.btnSubmitNewPass.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubmitNewPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNewPass.ForeColor = System.Drawing.Color.White
        Me.btnSubmitNewPass.Location = New System.Drawing.Point(222, 259)
        Me.btnSubmitNewPass.Name = "btnSubmitNewPass"
        Me.btnSubmitNewPass.Size = New System.Drawing.Size(90, 39)
        Me.btnSubmitNewPass.TabIndex = 5
        Me.btnSubmitNewPass.Text = "Submit"
        Me.btnSubmitNewPass.UseVisualStyleBackColor = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(261, 182)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(220, 28)
        Me.txtConfirmPass.TabIndex = 4
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(261, 133)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(220, 28)
        Me.txtNewPass.TabIndex = 3
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Reset Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEnterKey
        '
        Me.btnEnterKey.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEnterKey.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterKey.ForeColor = System.Drawing.Color.White
        Me.btnEnterKey.Location = New System.Drawing.Point(212, 183)
        Me.btnEnterKey.Name = "btnEnterKey"
        Me.btnEnterKey.Size = New System.Drawing.Size(90, 37)
        Me.btnEnterKey.TabIndex = 7
        Me.btnEnterKey.Text = "Enter"
        Me.btnEnterKey.UseVisualStyleBackColor = False
        '
        'txtMasterKey
        '
        Me.txtMasterKey.Location = New System.Drawing.Point(133, 125)
        Me.txtMasterKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMasterKey.Name = "txtMasterKey"
        Me.txtMasterKey.Size = New System.Drawing.Size(256, 28)
        Me.txtMasterKey.TabIndex = 6
        Me.txtMasterKey.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 340)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "*To get the master key, please contact the developers."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please enter the master key to reset your current password*:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkCyan
        Me.LinkLabel1.Location = New System.Drawing.Point(199, 237)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(121, 19)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Try Another Way"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSecQAnswer)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnSubmitSecQA)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 397)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'btnSubmitSecQA
        '
        Me.btnSubmitSecQA.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubmitSecQA.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitSecQA.ForeColor = System.Drawing.Color.White
        Me.btnSubmitSecQA.Location = New System.Drawing.Point(222, 216)
        Me.btnSubmitSecQA.Name = "btnSubmitSecQA"
        Me.btnSubmitSecQA.Size = New System.Drawing.Size(75, 36)
        Me.btnSubmitSecQA.TabIndex = 0
        Me.btnSubmitSecQA.Text = "Submit"
        Me.btnSubmitSecQA.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(294, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "What is the name of your first pet?"
        '
        'txtSecQAnswer
        '
        Me.txtSecQAnswer.Location = New System.Drawing.Point(133, 149)
        Me.txtSecQAnswer.Name = "txtSecQAnswer"
        Me.txtSecQAnswer.Size = New System.Drawing.Size(264, 28)
        Me.txtSecQAnswer.TabIndex = 2
        '
        'ForgotPass
        '
        Me.AcceptButton = Me.btnEnterKey
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(558, 421)
        Me.Controls.Add(Me.panelResetPass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMasterKey)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ForgotPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password?"
        Me.panelMasterKey.ResumeLayout(False)
        Me.panelMasterKey.PerformLayout()
        Me.panelResetPass.ResumeLayout(False)
        Me.panelResetPass.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMasterKey As Panel
    Friend WithEvents panelResetPass As Panel
    Friend WithEvents btnEnterKey As Button
    Friend WithEvents txtMasterKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmitNewPass As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSecQAnswer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSubmitSecQA As Button
End Class
