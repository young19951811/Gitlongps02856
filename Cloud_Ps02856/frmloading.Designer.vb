<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloading
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
        Me.components = New System.ComponentModel.Container()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.prbloading = New System.Windows.Forms.ProgressBar()
        Me.pcb = New System.Windows.Forms.PictureBox()
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Interval = 500
        '
        'prbloading
        '
        Me.prbloading.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.prbloading.Location = New System.Drawing.Point(1, 359)
        Me.prbloading.Name = "prbloading"
        Me.prbloading.Size = New System.Drawing.Size(682, 29)
        Me.prbloading.TabIndex = 6
        '
        'pcb
        '
        Me.pcb.BackgroundImage = Global.Cloud_Ps02856.My.Resources.Resources._8
        Me.pcb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcb.Location = New System.Drawing.Point(1, -3)
        Me.pcb.Name = "pcb"
        Me.pcb.Size = New System.Drawing.Size(682, 363)
        Me.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb.TabIndex = 5
        Me.pcb.TabStop = False
        '
        'frmloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 384)
        Me.Controls.Add(Me.prbloading)
        Me.Controls.Add(Me.pcb)
        Me.Name = "frmloading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmloading"
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents prbloading As ProgressBar
    Friend WithEvents pcb As PictureBox
End Class
