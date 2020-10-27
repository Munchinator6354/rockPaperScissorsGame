<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRockPaperScissorsGame
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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblHumanChoseText = New System.Windows.Forms.Label()
        Me.lblComputerChoseText = New System.Windows.Forms.Label()
        Me.lblHumanChoiceOutput = New System.Windows.Forms.Label()
        Me.lblComputerChoiceOutput = New System.Windows.Forms.Label()
        Me.lblWinnerText = New System.Windows.Forms.Label()
        Me.lblWinnerOutput = New System.Windows.Forms.Label()
        Me.grpRockPaperScissors = New System.Windows.Forms.GroupBox()
        Me.picHumanPicture = New System.Windows.Forms.PictureBox()
        Me.picComputerPicture = New System.Windows.Forms.PictureBox()
        Me.grpRockPaperScissors.SuspendLayout()
        CType(Me.picHumanPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(43, 351)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(222, 74)
        Me.btnRun.TabIndex = 8
        Me.btnRun.Text = "To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Battle!"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(280, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(222, 74)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Another" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Round?"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(521, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(222, 74)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Checked = True
        Me.radRock.Location = New System.Drawing.Point(70, 44)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(61, 21)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(70, 84)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(67, 21)
        Me.radPaper.TabIndex = 1
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(70, 126)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(82, 21)
        Me.radScissors.TabIndex = 2
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(9, 5)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(254, 51)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise#7 Rock Paper Scissors Game"
        '
        'lblHumanChoseText
        '
        Me.lblHumanChoseText.AutoSize = True
        Me.lblHumanChoseText.Location = New System.Drawing.Point(376, 48)
        Me.lblHumanChoseText.Name = "lblHumanChoseText"
        Me.lblHumanChoseText.Size = New System.Drawing.Size(126, 17)
        Me.lblHumanChoseText.TabIndex = 2
        Me.lblHumanChoseText.Text = "The Human Chose"
        '
        'lblComputerChoseText
        '
        Me.lblComputerChoseText.AutoSize = True
        Me.lblComputerChoseText.Location = New System.Drawing.Point(578, 48)
        Me.lblComputerChoseText.Name = "lblComputerChoseText"
        Me.lblComputerChoseText.Size = New System.Drawing.Size(142, 17)
        Me.lblComputerChoseText.TabIndex = 3
        Me.lblComputerChoseText.Text = "The Computer Chose"
        '
        'lblHumanChoiceOutput
        '
        Me.lblHumanChoiceOutput.AutoSize = True
        Me.lblHumanChoiceOutput.Location = New System.Drawing.Point(410, 74)
        Me.lblHumanChoiceOutput.Name = "lblHumanChoiceOutput"
        Me.lblHumanChoiceOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblHumanChoiceOutput.TabIndex = 4
        '
        'lblComputerChoiceOutput
        '
        Me.lblComputerChoiceOutput.AutoSize = True
        Me.lblComputerChoiceOutput.Location = New System.Drawing.Point(619, 74)
        Me.lblComputerChoiceOutput.Name = "lblComputerChoiceOutput"
        Me.lblComputerChoiceOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblComputerChoiceOutput.TabIndex = 5
        '
        'lblWinnerText
        '
        Me.lblWinnerText.AutoSize = True
        Me.lblWinnerText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerText.Location = New System.Drawing.Point(374, 263)
        Me.lblWinnerText.Name = "lblWinnerText"
        Me.lblWinnerText.Size = New System.Drawing.Size(198, 25)
        Me.lblWinnerText.TabIndex = 6
        Me.lblWinnerText.Text = "And the Winner Is......"
        Me.lblWinnerText.Visible = False
        '
        'lblWinnerOutput
        '
        Me.lblWinnerOutput.AutoSize = True
        Me.lblWinnerOutput.Location = New System.Drawing.Point(502, 304)
        Me.lblWinnerOutput.Name = "lblWinnerOutput"
        Me.lblWinnerOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblWinnerOutput.TabIndex = 7
        '
        'grpRockPaperScissors
        '
        Me.grpRockPaperScissors.Controls.Add(Me.radScissors)
        Me.grpRockPaperScissors.Controls.Add(Me.radPaper)
        Me.grpRockPaperScissors.Controls.Add(Me.radRock)
        Me.grpRockPaperScissors.Location = New System.Drawing.Point(43, 116)
        Me.grpRockPaperScissors.Name = "grpRockPaperScissors"
        Me.grpRockPaperScissors.Size = New System.Drawing.Size(302, 160)
        Me.grpRockPaperScissors.TabIndex = 1
        Me.grpRockPaperScissors.TabStop = False
        Me.grpRockPaperScissors.Text = "Choose Your Weapon!!!"
        '
        'picHumanPicture
        '
        Me.picHumanPicture.Location = New System.Drawing.Point(351, 116)
        Me.picHumanPicture.Name = "picHumanPicture"
        Me.picHumanPicture.Size = New System.Drawing.Size(184, 126)
        Me.picHumanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHumanPicture.TabIndex = 15
        Me.picHumanPicture.TabStop = False
        '
        'picComputerPicture
        '
        Me.picComputerPicture.Location = New System.Drawing.Point(559, 116)
        Me.picComputerPicture.Name = "picComputerPicture"
        Me.picComputerPicture.Size = New System.Drawing.Size(184, 126)
        Me.picComputerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComputerPicture.TabIndex = 15
        Me.picComputerPicture.TabStop = False
        '
        'frmRockPaperScissorsGame
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picComputerPicture)
        Me.Controls.Add(Me.picHumanPicture)
        Me.Controls.Add(Me.grpRockPaperScissors)
        Me.Controls.Add(Me.lblWinnerOutput)
        Me.Controls.Add(Me.lblWinnerText)
        Me.Controls.Add(Me.lblComputerChoiceOutput)
        Me.Controls.Add(Me.lblHumanChoiceOutput)
        Me.Controls.Add(Me.lblComputerChoseText)
        Me.Controls.Add(Me.lblHumanChoseText)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "frmRockPaperScissorsGame"
        Me.Text = "Rock Paper Scissors Game"
        Me.grpRockPaperScissors.ResumeLayout(False)
        Me.grpRockPaperScissors.PerformLayout()
        CType(Me.picHumanPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRun As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radRock As RadioButton
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents lblID As Label
    Friend WithEvents lblHumanChoseText As Label
    Friend WithEvents lblComputerChoseText As Label
    Friend WithEvents lblHumanChoiceOutput As Label
    Friend WithEvents lblComputerChoiceOutput As Label
    Friend WithEvents lblWinnerText As Label
    Friend WithEvents lblWinnerOutput As Label
    Friend WithEvents grpRockPaperScissors As GroupBox
    Friend WithEvents picHumanPicture As PictureBox
    Friend WithEvents picComputerPicture As PictureBox
End Class
