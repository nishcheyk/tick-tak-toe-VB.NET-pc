<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MFOUR
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
        Me.OTURN = New System.Windows.Forms.Label()
        Me.XTURN = New System.Windows.Forms.Label()
        Me.Score2 = New System.Windows.Forms.Label()
        Me.Score1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.OPLAYER2 = New System.Windows.Forms.CheckBox()
        Me.XPLAYER2 = New System.Windows.Forms.CheckBox()
        Me.OPLAYER1 = New System.Windows.Forms.CheckBox()
        Me.XPLAYER1 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Start1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.tiktaktoe = New System.Windows.Forms.Panel()
        Me.REest = New System.Windows.Forms.Button()
        Me.newgame = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Start1.SuspendLayout()
        Me.tiktaktoe.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OTURN
        '
        Me.OTURN.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OTURN.Location = New System.Drawing.Point(760, 270)
        Me.OTURN.Name = "OTURN"
        Me.OTURN.Size = New System.Drawing.Size(286, 37)
        Me.OTURN.TabIndex = 17
        Me.OTURN.Text = "Player 2's turn(O)"
        Me.OTURN.UseWaitCursor = True
        '
        'XTURN
        '
        Me.XTURN.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.XTURN.Location = New System.Drawing.Point(760, 191)
        Me.XTURN.Name = "XTURN"
        Me.XTURN.Size = New System.Drawing.Size(280, 37)
        Me.XTURN.TabIndex = 16
        Me.XTURN.Text = "Player 1's turn(X)"
        Me.XTURN.UseWaitCursor = True
        '
        'Score2
        '
        Me.Score2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Score2.Location = New System.Drawing.Point(194, 738)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(38, 45)
        Me.Score2.TabIndex = 15
        Me.Score2.Text = "0"
        Me.Score2.UseWaitCursor = True
        '
        'Score1
        '
        Me.Score1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Score1.Location = New System.Drawing.Point(194, 680)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(38, 45)
        Me.Score1.TabIndex = 14
        Me.Score1.Text = "0"
        Me.Score1.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(210, 738)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 45)
        Me.Label7.TabIndex = 13
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(210, 680)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 45)
        Me.Label6.TabIndex = 12
        Me.Label6.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 738)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 45)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Player 2"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(25, 680)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 45)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Player 1"
        Me.Label4.UseWaitCursor = True
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Start.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Start.Location = New System.Drawing.Point(415, 187)
        Me.Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(283, 68)
        Me.Start.TabIndex = 8
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'OPLAYER2
        '
        Me.OPLAYER2.Location = New System.Drawing.Point(743, 102)
        Me.OPLAYER2.Margin = New System.Windows.Forms.Padding(10)
        Me.OPLAYER2.Name = "OPLAYER2"
        Me.OPLAYER2.Size = New System.Drawing.Size(42, 24)
        Me.OPLAYER2.TabIndex = 7
        Me.OPLAYER2.Text = "O"
        '
        'XPLAYER2
        '
        Me.XPLAYER2.Location = New System.Drawing.Point(701, 102)
        Me.XPLAYER2.Margin = New System.Windows.Forms.Padding(10)
        Me.XPLAYER2.Name = "XPLAYER2"
        Me.XPLAYER2.Size = New System.Drawing.Size(40, 24)
        Me.XPLAYER2.TabIndex = 6
        Me.XPLAYER2.Text = "X"
        '
        'OPLAYER1
        '
        Me.OPLAYER1.Location = New System.Drawing.Point(743, 62)
        Me.OPLAYER1.Margin = New System.Windows.Forms.Padding(10)
        Me.OPLAYER1.Name = "OPLAYER1"
        Me.OPLAYER1.Size = New System.Drawing.Size(42, 24)
        Me.OPLAYER1.TabIndex = 5
        Me.OPLAYER1.Text = "O"
        '
        'XPLAYER1
        '
        Me.XPLAYER1.Location = New System.Drawing.Point(701, 62)
        Me.XPLAYER1.Margin = New System.Windows.Forms.Padding(10)
        Me.XPLAYER1.Name = "XPLAYER1"
        Me.XPLAYER1.Size = New System.Drawing.Size(40, 24)
        Me.XPLAYER1.TabIndex = 4
        Me.XPLAYER1.Text = "X"
        '
        'TextBox2
        '
        Me.TextBox2.AccessibleName = "QBCDC"
        Me.TextBox2.Location = New System.Drawing.Point(483, 104)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 27)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(483, 61)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(307, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 45)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Player 2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(307, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Player 1"
        '
        'Start1
        '
        Me.Start1.Controls.Add(Me.Start)
        Me.Start1.Controls.Add(Me.OPLAYER2)
        Me.Start1.Controls.Add(Me.XPLAYER2)
        Me.Start1.Controls.Add(Me.OPLAYER1)
        Me.Start1.Controls.Add(Me.XPLAYER1)
        Me.Start1.Controls.Add(Me.TextBox2)
        Me.Start1.Controls.Add(Me.TextBox1)
        Me.Start1.Controls.Add(Me.Label3)
        Me.Start1.Controls.Add(Me.Label2)
        Me.Start1.Location = New System.Drawing.Point(28, 446)
        Me.Start1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Start1.Name = "Start1"
        Me.Start1.Size = New System.Drawing.Size(1130, 272)
        Me.Start1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Swis721 BT", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(323, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 101)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIK TAK TOE "
        '
        'exit1
        '
        Me.exit1.BackColor = System.Drawing.Color.Crimson
        Me.exit1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.exit1.Location = New System.Drawing.Point(1026, 19)
        Me.exit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(120, 62)
        Me.exit1.TabIndex = 11
        Me.exit1.Text = "EXIT"
        Me.exit1.UseVisualStyleBackColor = False
        '
        'tiktaktoe
        '
        Me.tiktaktoe.Controls.Add(Me.REest)
        Me.tiktaktoe.Controls.Add(Me.newgame)
        Me.tiktaktoe.Controls.Add(Me.Button1)
        Me.tiktaktoe.Controls.Add(Me.Button15)
        Me.tiktaktoe.Controls.Add(Me.Button16)
        Me.tiktaktoe.Controls.Add(Me.Button2)
        Me.tiktaktoe.Controls.Add(Me.Button14)
        Me.tiktaktoe.Controls.Add(Me.Button3)
        Me.tiktaktoe.Controls.Add(Me.Button4)
        Me.tiktaktoe.Controls.Add(Me.Button7)
        Me.tiktaktoe.Controls.Add(Me.Button8)
        Me.tiktaktoe.Controls.Add(Me.Button9)
        Me.tiktaktoe.Controls.Add(Me.Button5)
        Me.tiktaktoe.Controls.Add(Me.Button6)
        Me.tiktaktoe.Controls.Add(Me.Button11)
        Me.tiktaktoe.Controls.Add(Me.Button13)
        Me.tiktaktoe.Controls.Add(Me.Button12)
        Me.tiktaktoe.Controls.Add(Me.Button10)
        Me.tiktaktoe.Controls.Add(Me.OTURN)
        Me.tiktaktoe.Controls.Add(Me.XTURN)
        Me.tiktaktoe.Controls.Add(Me.Score2)
        Me.tiktaktoe.Controls.Add(Me.Score1)
        Me.tiktaktoe.Controls.Add(Me.Label7)
        Me.tiktaktoe.Controls.Add(Me.Label6)
        Me.tiktaktoe.Controls.Add(Me.Label5)
        Me.tiktaktoe.Controls.Add(Me.Label4)
        Me.tiktaktoe.Location = New System.Drawing.Point(44, 203)
        Me.tiktaktoe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tiktaktoe.Name = "tiktaktoe"
        Me.tiktaktoe.Size = New System.Drawing.Size(1088, 910)
        Me.tiktaktoe.TabIndex = 20
        Me.tiktaktoe.UseWaitCursor = True
        '
        'REest
        '
        Me.REest.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.REest.Location = New System.Drawing.Point(855, 745)
        Me.REest.Name = "REest"
        Me.REest.Size = New System.Drawing.Size(202, 60)
        Me.REest.TabIndex = 41
        Me.REest.Text = "RESET"
        Me.REest.UseVisualStyleBackColor = False
        Me.REest.UseWaitCursor = True
        '
        'newgame
        '
        Me.newgame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.newgame.Location = New System.Drawing.Point(855, 680)
        Me.newgame.Name = "newgame"
        Me.newgame.Size = New System.Drawing.Size(202, 60)
        Me.newgame.TabIndex = 40
        Me.newgame.Text = "NEW GAME"
        Me.newgame.UseVisualStyleBackColor = False
        Me.newgame.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(38, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 142)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button15.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button15.Location = New System.Drawing.Point(356, 469)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(153, 142)
        Me.Button15.TabIndex = 38
        Me.Button15.UseVisualStyleBackColor = False
        Me.Button15.UseWaitCursor = True
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button16.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button16.Location = New System.Drawing.Point(515, 469)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(153, 142)
        Me.Button16.TabIndex = 37
        Me.Button16.UseVisualStyleBackColor = False
        Me.Button16.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(197, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 142)
        Me.Button2.TabIndex = 36
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button14.Location = New System.Drawing.Point(197, 469)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(153, 142)
        Me.Button14.TabIndex = 35
        Me.Button14.UseVisualStyleBackColor = False
        Me.Button14.UseWaitCursor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(356, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 142)
        Me.Button3.TabIndex = 34
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.UseWaitCursor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(515, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 142)
        Me.Button4.TabIndex = 33
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.UseWaitCursor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Location = New System.Drawing.Point(356, 173)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 142)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.UseWaitCursor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(515, 173)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(153, 142)
        Me.Button8.TabIndex = 31
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.UseWaitCursor = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button9.Location = New System.Drawing.Point(38, 321)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(153, 142)
        Me.Button9.TabIndex = 30
        Me.Button9.UseVisualStyleBackColor = False
        Me.Button9.UseWaitCursor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(38, 173)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 142)
        Me.Button5.TabIndex = 29
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.UseWaitCursor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(197, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 142)
        Me.Button6.TabIndex = 28
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.UseWaitCursor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button11.Location = New System.Drawing.Point(356, 321)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(153, 142)
        Me.Button11.TabIndex = 27
        Me.Button11.UseVisualStyleBackColor = False
        Me.Button11.UseWaitCursor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button13.Location = New System.Drawing.Point(38, 469)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(153, 142)
        Me.Button13.TabIndex = 26
        Me.Button13.UseVisualStyleBackColor = False
        Me.Button13.UseWaitCursor = True
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button12.Location = New System.Drawing.Point(515, 321)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(153, 142)
        Me.Button12.TabIndex = 25
        Me.Button12.UseVisualStyleBackColor = False
        Me.Button12.UseWaitCursor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Symbol", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button10.Location = New System.Drawing.Point(197, 321)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(153, 142)
        Me.Button10.TabIndex = 24
        Me.Button10.UseVisualStyleBackColor = False
        Me.Button10.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 149)
        Me.Panel1.TabIndex = 19
        '
        'MFOUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1341, 1028)
        Me.Controls.Add(Me.Start1)
        Me.Controls.Add(Me.tiktaktoe)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MFOUR"
        Me.Text = "MFOUR"
        Me.Start1.ResumeLayout(False)
        Me.Start1.PerformLayout()
        Me.tiktaktoe.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OTURN As Label
    Friend WithEvents XTURN As Label
    Friend WithEvents Score2 As Label
    Friend WithEvents Score1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Start As Button
    Friend WithEvents OPLAYER2 As CheckBox
    Friend WithEvents XPLAYER2 As CheckBox
    Friend WithEvents OPLAYER1 As CheckBox
    Friend WithEvents XPLAYER1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Start1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents exit1 As Button
    Friend WithEvents tiktaktoe As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents REest As Button
    Friend WithEvents newgame As Button
End Class
