<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainpage
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MAIN = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayM = New System.Windows.Forms.Button()
        Me.PlayC = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComputerT = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tile4 = New System.Windows.Forms.Button()
        Me.tile3 = New System.Windows.Forms.Button()
        Me.MULTIPLAYERT = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t4 = New System.Windows.Forms.Button()
        Me.t3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MAIN.SuspendLayout()
        Me.ComputerT.SuspendLayout()
        Me.MULTIPLAYERT.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 125)
        Me.Panel1.TabIndex = 0
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
        'Button13
        '
        Me.Button13.Image = Global.tick_tak_toe_part_2.My.Resources.Resources.pngwing_com__3_
        Me.Button13.Location = New System.Drawing.Point(51, 17)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(94, 78)
        Me.Button13.TabIndex = 1
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Image = Global.tick_tak_toe_part_2.My.Resources.Resources.pngwing_com__2_
        Me.Button12.Location = New System.Drawing.Point(51, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 74)
        Me.Button12.TabIndex = 0
        Me.Button12.UseVisualStyleBackColor = True
        '
        'MAIN
        '
        Me.MAIN.Controls.Add(Me.Label2)
        Me.MAIN.Controls.Add(Me.PlayM)
        Me.MAIN.Controls.Add(Me.PlayC)
        Me.MAIN.Location = New System.Drawing.Point(154, 183)
        Me.MAIN.Name = "MAIN"
        Me.MAIN.Size = New System.Drawing.Size(819, 254)
        Me.MAIN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(55, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(742, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Want to play Tick Tak Toe game with ?"
        '
        'PlayM
        '
        Me.PlayM.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayM.Location = New System.Drawing.Point(259, 182)
        Me.PlayM.Name = "PlayM"
        Me.PlayM.Size = New System.Drawing.Size(276, 53)
        Me.PlayM.TabIndex = 1
        Me.PlayM.Text = "Multiplayer"
        Me.PlayM.UseVisualStyleBackColor = True
        '
        'PlayC
        '
        Me.PlayC.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayC.Location = New System.Drawing.Point(259, 113)
        Me.PlayC.Name = "PlayC"
        Me.PlayC.Size = New System.Drawing.Size(277, 53)
        Me.PlayC.TabIndex = 0
        Me.PlayC.Text = "Computer"
        Me.PlayC.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'ComputerT
        '
        Me.ComputerT.Controls.Add(Me.Label3)
        Me.ComputerT.Controls.Add(Me.tile4)
        Me.ComputerT.Controls.Add(Me.tile3)
        Me.ComputerT.Location = New System.Drawing.Point(139, 238)
        Me.ComputerT.Name = "ComputerT"
        Me.ComputerT.Size = New System.Drawing.Size(883, 287)
        Me.ComputerT.TabIndex = 3
        Me.ComputerT.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(68, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(665, 108)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Want to play Tick Tak Toe game in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 3 X 3 or 4 X 4 ?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tile4
        '
        Me.tile4.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tile4.Location = New System.Drawing.Point(275, 213)
        Me.tile4.Name = "tile4"
        Me.tile4.Size = New System.Drawing.Size(276, 53)
        Me.tile4.TabIndex = 4
        Me.tile4.Text = "4 X 4"
        Me.tile4.UseVisualStyleBackColor = True
        '
        'tile3
        '
        Me.tile3.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tile3.Location = New System.Drawing.Point(275, 144)
        Me.tile3.Name = "tile3"
        Me.tile3.Size = New System.Drawing.Size(277, 53)
        Me.tile3.TabIndex = 3
        Me.tile3.Text = "3 X 3"
        Me.tile3.UseVisualStyleBackColor = True
        '
        'MULTIPLAYERT
        '
        Me.MULTIPLAYERT.Controls.Add(Me.Label4)
        Me.MULTIPLAYERT.Controls.Add(Me.t4)
        Me.MULTIPLAYERT.Controls.Add(Me.t3)
        Me.MULTIPLAYERT.Location = New System.Drawing.Point(140, 269)
        Me.MULTIPLAYERT.Name = "MULTIPLAYERT"
        Me.MULTIPLAYERT.Size = New System.Drawing.Size(885, 287)
        Me.MULTIPLAYERT.TabIndex = 4
        Me.MULTIPLAYERT.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(107, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(665, 108)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Want to play Tick Tak Toe game in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 3 X 3 or 4 X 4 ?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't4
        '
        Me.t4.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.t4.Location = New System.Drawing.Point(314, 215)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(276, 53)
        Me.t4.TabIndex = 4
        Me.t4.Text = "4 X 4"
        Me.t4.UseVisualStyleBackColor = True
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.t3.Location = New System.Drawing.Point(314, 146)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(277, 53)
        Me.t3.TabIndex = 3
        Me.t3.Text = "3 X 3"
        Me.t3.UseVisualStyleBackColor = True
        '
        'Mainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1120, 586)
        Me.Controls.Add(Me.ComputerT)
        Me.Controls.Add(Me.MULTIPLAYERT)
        Me.Controls.Add(Me.MAIN)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mainpage"
        Me.Text = "tik tak toe by nishchey khajuria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MAIN.ResumeLayout(False)
        Me.MAIN.PerformLayout()
        Me.ComputerT.ResumeLayout(False)
        Me.ComputerT.PerformLayout()
        Me.MULTIPLAYERT.ResumeLayout(False)
        Me.MULTIPLAYERT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents exit1 As Button
    Friend WithEvents MAIN As Panel
    Friend WithEvents PlayM As Button
    Friend WithEvents PlayC As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComputerT As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tile4 As Button
    Friend WithEvents tile3 As Button
    Friend WithEvents MULTIPLAYERT As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents t4 As Button
    Friend WithEvents t3 As Button
End Class

