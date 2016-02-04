<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lblUserid = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ptbUser = New System.Windows.Forms.PictureBox()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.ptbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(451, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 40)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(283, 434)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(148, 40)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "Đăng Nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtPassword.Location = New System.Drawing.Point(283, 367)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPassword.Size = New System.Drawing.Size(369, 49)
        Me.txtPassword.TabIndex = 24
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(277, 332)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(118, 32)
        Me.lblPassword.TabIndex = 23
        Me.lblPassword.Text = "Mật Khẩu"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(283, 280)
        Me.txtuser.Multiline = True
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtuser.Size = New System.Drawing.Size(369, 49)
        Me.txtuser.TabIndex = 22
        '
        'lblUserid
        '
        Me.lblUserid.AutoSize = True
        Me.lblUserid.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserid.Location = New System.Drawing.Point(277, 245)
        Me.lblUserid.Name = "lblUserid"
        Me.lblUserid.Size = New System.Drawing.Size(175, 32)
        Me.lblUserid.TabIndex = 21
        Me.lblUserid.Text = "Tên đăng nhập"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(143, 179)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(412, 46)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'ptbUser
        '
        Me.ptbUser.Image = CType(resources.GetObject("ptbUser.Image"), System.Drawing.Image)
        Me.ptbUser.Location = New System.Drawing.Point(12, 245)
        Me.ptbUser.Name = "ptbUser"
        Me.ptbUser.Size = New System.Drawing.Size(250, 229)
        Me.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUser.TabIndex = 19
        Me.ptbUser.TabStop = False
        '
        'ptbLogo
        '
        Me.ptbLogo.BackColor = System.Drawing.Color.White
        Me.ptbLogo.Image = CType(resources.GetObject("ptbLogo.Image"), System.Drawing.Image)
        Me.ptbLogo.Location = New System.Drawing.Point(12, 12)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(673, 180)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogo.TabIndex = 18
        Me.ptbLogo.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 505)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblUserid)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.ptbUser)
        Me.Controls.Add(Me.ptbLogo)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ptbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents lblUserid As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ptbUser As PictureBox
    Friend WithEvents ptbLogo As PictureBox
End Class
