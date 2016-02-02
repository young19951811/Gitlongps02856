<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdash
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
        Me.mns = New System.Windows.Forms.MenuStrip()
        Me.msitaikhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiquanlykhach = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiquanlysanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.msithoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sts = New System.Windows.Forms.StatusStrip()
        Me.lbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.mns.SuspendLayout()
        Me.sts.SuspendLayout()
        Me.SuspendLayout()
        '
        'mns
        '
        Me.mns.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mns.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.mns.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msitaikhoan, Me.msiquanlykhach, Me.msiquanlysanpham, Me.msithoat, Me.ThoátToolStripMenuItem})
        Me.mns.Location = New System.Drawing.Point(0, 0)
        Me.mns.Name = "mns"
        Me.mns.Size = New System.Drawing.Size(772, 45)
        Me.mns.TabIndex = 33
        Me.mns.Text = "MenuStrip1"
        '
        'msitaikhoan
        '
        Me.msitaikhoan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.msitaikhoan.Name = "msitaikhoan"
        Me.msitaikhoan.Size = New System.Drawing.Size(144, 41)
        Me.msitaikhoan.Text = "Tài Khoản"
        '
        'msiquanlykhach
        '
        Me.msiquanlykhach.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.msiquanlykhach.Name = "msiquanlykhach"
        Me.msiquanlykhach.Size = New System.Drawing.Size(141, 41)
        Me.msiquanlykhach.Text = "QL Khách"
        '
        'msiquanlysanpham
        '
        Me.msiquanlysanpham.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.msiquanlysanpham.Name = "msiquanlysanpham"
        Me.msiquanlysanpham.Size = New System.Drawing.Size(186, 41)
        Me.msiquanlysanpham.Text = "QL Sản Phẩm"
        '
        'msithoat
        '
        Me.msithoat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.msithoat.Name = "msithoat"
        Me.msithoat.Size = New System.Drawing.Size(175, 41)
        Me.msithoat.Text = "QL Hóa Đơn"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(97, 41)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'sts
        '
        Me.sts.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl})
        Me.sts.Location = New System.Drawing.Point(0, 427)
        Me.sts.Name = "sts"
        Me.sts.Size = New System.Drawing.Size(772, 30)
        Me.sts.TabIndex = 34
        Me.sts.Text = "StatusStrip1"
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(382, 25)
        Me.lbl.Text = "Copy by Vernom ,Trương Bảo Long-PS02856"
        '
        'Button5
        '
        Me.Button5.AllowDrop = True
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.BackgroundImage = Global.Cloud_Ps02856.My.Resources.Resources.Truyền_20hình_20FPT
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(146, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(472, 376)
        Me.Button5.TabIndex = 44
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'frmdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(772, 457)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.sts)
        Me.Controls.Add(Me.mns)
        Me.Name = "frmdash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdash"
        Me.mns.ResumeLayout(False)
        Me.mns.PerformLayout()
        Me.sts.ResumeLayout(False)
        Me.sts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mns As MenuStrip
    Friend WithEvents msitaikhoan As ToolStripMenuItem
    Friend WithEvents msiquanlykhach As ToolStripMenuItem
    Friend WithEvents msiquanlysanpham As ToolStripMenuItem
    Friend WithEvents msithoat As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sts As StatusStrip
    Friend WithEvents lbl As ToolStripStatusLabel
    Friend WithEvents Button5 As Button
End Class
