<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.picRight = New System.Windows.Forms.PictureBox()
        Me.picMiddle = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScoreCom = New System.Windows.Forms.Label()
        Me.lblScorePlayer = New System.Windows.Forms.Label()
        Me.lblGameFinish = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRoundOne = New System.Windows.Forms.Button()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiddle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLeft
        '
        Me.picLeft.Location = New System.Drawing.Point(187, 88)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(81, 124)
        Me.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLeft.TabIndex = 0
        Me.picLeft.TabStop = False
        '
        'picRight
        '
        Me.picRight.Location = New System.Drawing.Point(515, 88)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(81, 124)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRight.TabIndex = 1
        Me.picRight.TabStop = False
        '
        'picMiddle
        '
        Me.picMiddle.Location = New System.Drawing.Point(349, 260)
        Me.picMiddle.Name = "picMiddle"
        Me.picMiddle.Size = New System.Drawing.Size(81, 124)
        Me.picMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMiddle.TabIndex = 0
        Me.picMiddle.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "電腦分數:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "玩家分數:"
        '
        'lblScoreCom
        '
        Me.lblScoreCom.AutoSize = True
        Me.lblScoreCom.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblScoreCom.Location = New System.Drawing.Point(99, 13)
        Me.lblScoreCom.Name = "lblScoreCom"
        Me.lblScoreCom.Size = New System.Drawing.Size(21, 24)
        Me.lblScoreCom.TabIndex = 2
        Me.lblScoreCom.Text = "0"
        '
        'lblScorePlayer
        '
        Me.lblScorePlayer.AutoSize = True
        Me.lblScorePlayer.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblScorePlayer.Location = New System.Drawing.Point(99, 37)
        Me.lblScorePlayer.Name = "lblScorePlayer"
        Me.lblScorePlayer.Size = New System.Drawing.Size(21, 24)
        Me.lblScorePlayer.TabIndex = 2
        Me.lblScorePlayer.Text = "0"
        '
        'lblGameFinish
        '
        Me.lblGameFinish.AutoSize = True
        Me.lblGameFinish.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblGameFinish.Location = New System.Drawing.Point(296, 13)
        Me.lblGameFinish.Name = "lblGameFinish"
        Me.lblGameFinish.Size = New System.Drawing.Size(90, 24)
        Me.lblGameFinish.TabIndex = 2
        Me.lblGameFinish.Text = "電腦分數:"
        '
        'Timer1
        '
        '
        'btnRoundOne
        '
        Me.btnRoundOne.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.btnRoundOne.Location = New System.Drawing.Point(515, 342)
        Me.btnRoundOne.Name = "btnRoundOne"
        Me.btnRoundOne.Size = New System.Drawing.Size(115, 42)
        Me.btnRoundOne.TabIndex = 3
        Me.btnRoundOne.Text = "再來一局"
        Me.btnRoundOne.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRoundOne)
        Me.Controls.Add(Me.lblScorePlayer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScoreCom)
        Me.Controls.Add(Me.lblGameFinish)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picMiddle)
        Me.Controls.Add(Me.picLeft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiddle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLeft As PictureBox
    Friend WithEvents picRight As PictureBox
    Friend WithEvents picMiddle As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScoreCom As Label
    Friend WithEvents lblScorePlayer As Label
    Friend WithEvents lblGameFinish As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnRoundOne As Button
End Class
