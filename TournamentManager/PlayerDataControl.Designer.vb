<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerDataControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.GamerTagLabel = New System.Windows.Forms.Label()
        Me.GamerTagTextBox = New System.Windows.Forms.TextBox()
        Me.WinsLabel = New System.Windows.Forms.Label()
        Me.WinsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LossesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LossesLabel = New System.Windows.Forms.Label()
        CType(Me.WinsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LossesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerNameTextBox
        '
        Me.PlayerNameTextBox.Location = New System.Drawing.Point(88, 3)
        Me.PlayerNameTextBox.Name = "PlayerNameTextBox"
        Me.PlayerNameTextBox.Size = New System.Drawing.Size(224, 27)
        Me.PlayerNameTextBox.TabIndex = 0
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(3, 6)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(49, 20)
        Me.PlayerNameLabel.TabIndex = 1
        Me.PlayerNameLabel.Text = "Player"
        '
        'GamerTagLabel
        '
        Me.GamerTagLabel.AutoSize = True
        Me.GamerTagLabel.Location = New System.Drawing.Point(3, 43)
        Me.GamerTagLabel.Name = "GamerTagLabel"
        Me.GamerTagLabel.Size = New System.Drawing.Size(79, 20)
        Me.GamerTagLabel.TabIndex = 2
        Me.GamerTagLabel.Text = "Gamer tag"
        '
        'GamerTagTextBox
        '
        Me.GamerTagTextBox.Location = New System.Drawing.Point(88, 40)
        Me.GamerTagTextBox.Name = "GamerTagTextBox"
        Me.GamerTagTextBox.Size = New System.Drawing.Size(224, 27)
        Me.GamerTagTextBox.TabIndex = 3
        '
        'WinsLabel
        '
        Me.WinsLabel.AutoSize = True
        Me.WinsLabel.Location = New System.Drawing.Point(3, 77)
        Me.WinsLabel.Name = "WinsLabel"
        Me.WinsLabel.Size = New System.Drawing.Size(41, 20)
        Me.WinsLabel.TabIndex = 4
        Me.WinsLabel.Text = "Wins"
        '
        'WinsNumericUpDown
        '
        Me.WinsNumericUpDown.Location = New System.Drawing.Point(88, 77)
        Me.WinsNumericUpDown.Name = "WinsNumericUpDown"
        Me.WinsNumericUpDown.Size = New System.Drawing.Size(224, 27)
        Me.WinsNumericUpDown.TabIndex = 5
        '
        'LossesNumericUpDown
        '
        Me.LossesNumericUpDown.Location = New System.Drawing.Point(88, 110)
        Me.LossesNumericUpDown.Name = "LossesNumericUpDown"
        Me.LossesNumericUpDown.Size = New System.Drawing.Size(224, 27)
        Me.LossesNumericUpDown.TabIndex = 7
        '
        'LossesLabel
        '
        Me.LossesLabel.AutoSize = True
        Me.LossesLabel.Location = New System.Drawing.Point(3, 110)
        Me.LossesLabel.Name = "LossesLabel"
        Me.LossesLabel.Size = New System.Drawing.Size(51, 20)
        Me.LossesLabel.TabIndex = 6
        Me.LossesLabel.Text = "Losses"
        '
        'PlayerDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LossesNumericUpDown)
        Me.Controls.Add(Me.LossesLabel)
        Me.Controls.Add(Me.WinsNumericUpDown)
        Me.Controls.Add(Me.WinsLabel)
        Me.Controls.Add(Me.GamerTagTextBox)
        Me.Controls.Add(Me.GamerTagLabel)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.PlayerNameTextBox)
        Me.Name = "PlayerDataControl"
        Me.Size = New System.Drawing.Size(318, 144)
        CType(Me.WinsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LossesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerNameTextBox As TextBox
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents GamerTagLabel As Label
    Friend WithEvents GamerTagTextBox As TextBox
    Friend WithEvents WinsLabel As Label
    Friend WithEvents WinsNumericUpDown As NumericUpDown
    Friend WithEvents LossesNumericUpDown As NumericUpDown
    Friend WithEvents LossesLabel As Label
End Class
