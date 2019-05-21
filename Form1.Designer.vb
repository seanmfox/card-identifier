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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.picThreeHearts = New System.Windows.Forms.PictureBox()
        Me.picBlackJoker = New System.Windows.Forms.PictureBox()
        Me.picAceDiamonds = New System.Windows.Forms.PictureBox()
        Me.picNineHearts = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picThreeHearts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlackJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAceDiamonds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNineHearts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(334, 23)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(455, 39)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Click a Card to See Its Name"
        '
        'picThreeHearts
        '
        Me.picThreeHearts.Image = Global.Card_Identifier.My.Resources.Resources._3_Hearts
        Me.picThreeHearts.Location = New System.Drawing.Point(27, 70)
        Me.picThreeHearts.Name = "picThreeHearts"
        Me.picThreeHearts.Size = New System.Drawing.Size(195, 254)
        Me.picThreeHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThreeHearts.TabIndex = 1
        Me.picThreeHearts.TabStop = False
        '
        'picBlackJoker
        '
        Me.picBlackJoker.Image = Global.Card_Identifier.My.Resources.Resources.Joker_Black
        Me.picBlackJoker.Location = New System.Drawing.Point(246, 75)
        Me.picBlackJoker.Name = "picBlackJoker"
        Me.picBlackJoker.Size = New System.Drawing.Size(195, 249)
        Me.picBlackJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBlackJoker.TabIndex = 2
        Me.picBlackJoker.TabStop = False
        '
        'picAceDiamonds
        '
        Me.picAceDiamonds.Image = Global.Card_Identifier.My.Resources.Resources.Ace_Diamonds
        Me.picAceDiamonds.Location = New System.Drawing.Point(472, 75)
        Me.picAceDiamonds.Name = "picAceDiamonds"
        Me.picAceDiamonds.Size = New System.Drawing.Size(203, 249)
        Me.picAceDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAceDiamonds.TabIndex = 3
        Me.picAceDiamonds.TabStop = False
        '
        'picNineHearts
        '
        Me.picNineHearts.Image = Global.Card_Identifier.My.Resources.Resources._9_Hearts
        Me.picNineHearts.Location = New System.Drawing.Point(718, 75)
        Me.picNineHearts.Name = "picNineHearts"
        Me.picNineHearts.Size = New System.Drawing.Size(182, 249)
        Me.picNineHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNineHearts.TabIndex = 4
        Me.picNineHearts.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Card_Identifier.My.Resources.Resources.Jack_Diamonds
        Me.PictureBox5.Location = New System.Drawing.Point(926, 75)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(172, 249)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(27, 355)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(1071, 56)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(514, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 531)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picNineHearts)
        Me.Controls.Add(Me.picAceDiamonds)
        Me.Controls.Add(Me.picBlackJoker)
        Me.Controls.Add(Me.picThreeHearts)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picThreeHearts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlackJoker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAceDiamonds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNineHearts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents picThreeHearts As PictureBox
    Friend WithEvents picBlackJoker As PictureBox
    Friend WithEvents picAceDiamonds As PictureBox
    Friend WithEvents picNineHearts As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnExit As Button
End Class
