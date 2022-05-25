<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFOUR
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Startm = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Startc = New System.Windows.Forms.Button()
        Me.OPLAYER1 = New System.Windows.Forms.CheckBox()
        Me.XPLAYER1 = New System.Windows.Forms.CheckBox()
        Me.Score2 = New System.Windows.Forms.Label()
        Me.Score1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.REest = New System.Windows.Forms.Button()
        Me.newgame = New System.Windows.Forms.Button()
        Me.OTURN = New System.Windows.Forms.Label()
        Me.XTURN = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tiktak = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Startm.SuspendLayout()
        Me.tiktak.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 125)
        Me.Panel1.TabIndex = 7
        '
        'exit1
        '
        Me.exit1.BackColor = System.Drawing.Color.Crimson
        Me.exit1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit1.Location = New System.Drawing.Point(966, 23)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(116, 70)
        Me.exit1.TabIndex = 3
        Me.exit1.Text = "EXIT"
        Me.exit1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(380, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 67)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TIK TAK TOE"
        '
        'Startm
        '
        Me.Startm.Controls.Add(Me.Label3)
        Me.Startm.Controls.Add(Me.TextBox1)
        Me.Startm.Controls.Add(Me.Startc)
        Me.Startm.Controls.Add(Me.OPLAYER1)
        Me.Startm.Controls.Add(Me.XPLAYER1)
        Me.Startm.Location = New System.Drawing.Point(12, 336)
        Me.Startm.Name = "Startm"
        Me.Startm.Size = New System.Drawing.Size(1184, 223)
        Me.Startm.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(195, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name of the Player "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(491, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 27)
        Me.TextBox1.TabIndex = 3
        '
        'Startc
        '
        Me.Startc.Location = New System.Drawing.Point(480, 157)
        Me.Startc.Name = "Startc"
        Me.Startc.Size = New System.Drawing.Size(211, 39)
        Me.Startc.TabIndex = 2
        Me.Startc.Text = "START"
        Me.Startc.UseVisualStyleBackColor = True
        '
        'OPLAYER1
        '
        Me.OPLAYER1.AutoSize = True
        Me.OPLAYER1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OPLAYER1.Location = New System.Drawing.Point(780, 71)
        Me.OPLAYER1.Name = "OPLAYER1"
        Me.OPLAYER1.Size = New System.Drawing.Size(53, 35)
        Me.OPLAYER1.TabIndex = 1
        Me.OPLAYER1.Text = "O"
        Me.OPLAYER1.UseVisualStyleBackColor = True
        '
        'XPLAYER1
        '
        Me.XPLAYER1.AutoSize = True
        Me.XPLAYER1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.XPLAYER1.Location = New System.Drawing.Point(723, 71)
        Me.XPLAYER1.Name = "XPLAYER1"
        Me.XPLAYER1.Size = New System.Drawing.Size(51, 35)
        Me.XPLAYER1.TabIndex = 0
        Me.XPLAYER1.Text = "X"
        Me.XPLAYER1.UseVisualStyleBackColor = True
        '
        'Score2
        '
        Me.Score2.AutoSize = True
        Me.Score2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Score2.Location = New System.Drawing.Point(203, 684)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(38, 45)
        Me.Score2.TabIndex = 16
        Me.Score2.Text = "0"
        '
        'Score1
        '
        Me.Score1.AutoSize = True
        Me.Score1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Score1.Location = New System.Drawing.Point(203, 622)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(38, 45)
        Me.Score1.TabIndex = 15
        Me.Score1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(26, 684)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 45)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Computer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 622)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 45)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Player 1"
        '
        'REest
        '
        Me.REest.Location = New System.Drawing.Point(863, 684)
        Me.REest.Name = "REest"
        Me.REest.Size = New System.Drawing.Size(202, 60)
        Me.REest.TabIndex = 12
        Me.REest.Text = "RESET"
        Me.REest.UseVisualStyleBackColor = True
        '
        'newgame
        '
        Me.newgame.Location = New System.Drawing.Point(863, 619)
        Me.newgame.Name = "newgame"
        Me.newgame.Size = New System.Drawing.Size(202, 60)
        Me.newgame.TabIndex = 11
        Me.newgame.Text = "NEW GAME"
        Me.newgame.UseVisualStyleBackColor = True
        '
        'OTURN
        '
        Me.OTURN.AutoSize = True
        Me.OTURN.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OTURN.Location = New System.Drawing.Point(795, 187)
        Me.OTURN.Name = "OTURN"
        Me.OTURN.Size = New System.Drawing.Size(162, 37)
        Me.OTURN.TabIndex = 10
        Me.OTURN.Text = "'s turn(O)"
        '
        'XTURN
        '
        Me.XTURN.AutoSize = True
        Me.XTURN.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.XTURN.Location = New System.Drawing.Point(795, 106)
        Me.XTURN.Name = "XTURN"
        Me.XTURN.Size = New System.Drawing.Size(158, 37)
        Me.XTURN.TabIndex = 9
        Me.XTURN.Text = "'s turn(X)"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Location = New System.Drawing.Point(428, 171)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 142)
        Me.Button7.TabIndex = 8
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(587, 171)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(153, 142)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(587, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 142)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button9.Location = New System.Drawing.Point(110, 319)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(153, 142)
        Me.Button9.TabIndex = 6
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(110, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 142)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(269, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 142)
        Me.Button6.TabIndex = 3
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(428, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 142)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(269, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 142)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(110, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 142)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tiktak
        '
        Me.tiktak.BackColor = System.Drawing.Color.Tan
        Me.tiktak.Controls.Add(Me.Button12)
        Me.tiktak.Controls.Add(Me.Button15)
        Me.tiktak.Controls.Add(Me.Button16)
        Me.tiktak.Controls.Add(Me.Button13)
        Me.tiktak.Controls.Add(Me.Button14)
        Me.tiktak.Controls.Add(Me.Button11)
        Me.tiktak.Controls.Add(Me.Button10)
        Me.tiktak.Controls.Add(Me.Score2)
        Me.tiktak.Controls.Add(Me.Score1)
        Me.tiktak.Controls.Add(Me.Label5)
        Me.tiktak.Controls.Add(Me.Label4)
        Me.tiktak.Controls.Add(Me.REest)
        Me.tiktak.Controls.Add(Me.newgame)
        Me.tiktak.Controls.Add(Me.OTURN)
        Me.tiktak.Controls.Add(Me.XTURN)
        Me.tiktak.Controls.Add(Me.Button7)
        Me.tiktak.Controls.Add(Me.Button8)
        Me.tiktak.Controls.Add(Me.Button9)
        Me.tiktak.Controls.Add(Me.Button4)
        Me.tiktak.Controls.Add(Me.Button5)
        Me.tiktak.Controls.Add(Me.Button6)
        Me.tiktak.Controls.Add(Me.Button3)
        Me.tiktak.Controls.Add(Me.Button2)
        Me.tiktak.Controls.Add(Me.Button1)
        Me.tiktak.Location = New System.Drawing.Point(15, 143)
        Me.tiktak.Name = "tiktak"
        Me.tiktak.Size = New System.Drawing.Size(1100, 759)
        Me.tiktak.TabIndex = 8
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button12.Location = New System.Drawing.Point(587, 319)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(153, 142)
        Me.Button12.TabIndex = 23
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button15.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button15.Location = New System.Drawing.Point(428, 467)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(153, 142)
        Me.Button15.TabIndex = 22
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button16.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button16.Location = New System.Drawing.Point(587, 467)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(153, 142)
        Me.Button16.TabIndex = 21
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button13.Location = New System.Drawing.Point(110, 467)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(153, 142)
        Me.Button13.TabIndex = 20
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button14.Location = New System.Drawing.Point(269, 467)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(153, 142)
        Me.Button14.TabIndex = 19
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button11.Location = New System.Drawing.Point(428, 319)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(153, 142)
        Me.Button11.TabIndex = 18
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button10.Location = New System.Drawing.Point(269, 319)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(153, 142)
        Me.Button10.TabIndex = 17
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'CFOUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1192, 927)
        Me.Controls.Add(Me.Startm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tiktak)
        Me.Name = "CFOUR"
        Me.Text = "CFOUR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Startm.ResumeLayout(False)
        Me.Startm.PerformLayout()
        Me.tiktak.ResumeLayout(False)
        Me.tiktak.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exit1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Score2 As Label
    Friend WithEvents Score1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents REest As Button
    Friend WithEvents newgame As Button
    Friend WithEvents OTURN As Label
    Friend WithEvents Startc As Button
    Friend WithEvents XTURN As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Startm As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents OPLAYER1 As CheckBox
    Friend WithEvents XPLAYER1 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tiktak As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button14 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button13 As Button
End Class
