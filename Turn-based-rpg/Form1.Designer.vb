<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(730, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Legends of Eldoria"
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlay.FlatAppearance.BorderSize = 0
        Me.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlay.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.ForeColor = System.Drawing.Color.Ivory
        Me.BtnPlay.Location = New System.Drawing.Point(865, 619)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(318, 76)
        Me.BtnPlay.TabIndex = 1
        Me.BtnPlay.Text = "PLAY"
        Me.BtnPlay.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.Ivory
        Me.btnSetting.Location = New System.Drawing.Point(943, 714)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(165, 76)
        Me.btnSetting.TabIndex = 2
        Me.btnSetting.Text = "Setting"
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Turn_based_rpg.My.Resources.Resources.Dark_Fantasy_Pixel_Art
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "Form1"
        Me.Text = "basic rpg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPlay As Button
    Friend WithEvents btnSetting As Button
End Class
