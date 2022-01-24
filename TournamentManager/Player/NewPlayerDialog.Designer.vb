<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPlayerDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LossesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LossesLabel = New System.Windows.Forms.Label()
        Me.WinsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WinsLabel = New System.Windows.Forms.Label()
        Me.GamerTagTextBox = New System.Windows.Forms.TextBox()
        Me.GamerTagLabel = New System.Windows.Forms.Label()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.PlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LossesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(369, 422)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'LossesNumericUpDown
        '
        Me.LossesNumericUpDown.Location = New System.Drawing.Point(97, 113)
        Me.LossesNumericUpDown.Name = "LossesNumericUpDown"
        Me.LossesNumericUpDown.Size = New System.Drawing.Size(224, 27)
        Me.LossesNumericUpDown.TabIndex = 15
        '
        'LossesLabel
        '
        Me.LossesLabel.AutoSize = True
        Me.LossesLabel.Location = New System.Drawing.Point(12, 113)
        Me.LossesLabel.Name = "LossesLabel"
        Me.LossesLabel.Size = New System.Drawing.Size(51, 20)
        Me.LossesLabel.TabIndex = 14
        Me.LossesLabel.Text = "Losses"
        '
        'WinsNumericUpDown
        '
        Me.WinsNumericUpDown.Location = New System.Drawing.Point(97, 80)
        Me.WinsNumericUpDown.Name = "WinsNumericUpDown"
        Me.WinsNumericUpDown.Size = New System.Drawing.Size(224, 27)
        Me.WinsNumericUpDown.TabIndex = 13
        '
        'WinsLabel
        '
        Me.WinsLabel.AutoSize = True
        Me.WinsLabel.Location = New System.Drawing.Point(12, 80)
        Me.WinsLabel.Name = "WinsLabel"
        Me.WinsLabel.Size = New System.Drawing.Size(41, 20)
        Me.WinsLabel.TabIndex = 12
        Me.WinsLabel.Text = "Wins"
        '
        'GamerTagTextBox
        '
        Me.GamerTagTextBox.Location = New System.Drawing.Point(97, 43)
        Me.GamerTagTextBox.Name = "GamerTagTextBox"
        Me.GamerTagTextBox.Size = New System.Drawing.Size(224, 27)
        Me.GamerTagTextBox.TabIndex = 11
        '
        'GamerTagLabel
        '
        Me.GamerTagLabel.AutoSize = True
        Me.GamerTagLabel.Location = New System.Drawing.Point(12, 46)
        Me.GamerTagLabel.Name = "GamerTagLabel"
        Me.GamerTagLabel.Size = New System.Drawing.Size(79, 20)
        Me.GamerTagLabel.TabIndex = 10
        Me.GamerTagLabel.Text = "Gamer tag"
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(12, 9)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(49, 20)
        Me.PlayerNameLabel.TabIndex = 9
        Me.PlayerNameLabel.Text = "Player"
        '
        'PlayerNameTextBox
        '
        Me.PlayerNameTextBox.Location = New System.Drawing.Point(97, 6)
        Me.PlayerNameTextBox.Name = "PlayerNameTextBox"
        Me.PlayerNameTextBox.Size = New System.Drawing.Size(224, 27)
        Me.PlayerNameTextBox.TabIndex = 8
        '
        'NewPlayerDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 485)
        Me.Controls.Add(Me.LossesNumericUpDown)
        Me.Controls.Add(Me.LossesLabel)
        Me.Controls.Add(Me.WinsNumericUpDown)
        Me.Controls.Add(Me.WinsLabel)
        Me.Controls.Add(Me.GamerTagTextBox)
        Me.Controls.Add(Me.GamerTagLabel)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.PlayerNameTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewPlayerDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add a new player"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LossesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LossesNumericUpDown As NumericUpDown
    Friend WithEvents LossesLabel As Label
    Friend WithEvents WinsNumericUpDown As NumericUpDown
    Friend WithEvents WinsLabel As Label
    Friend WithEvents GamerTagTextBox As TextBox
    Friend WithEvents GamerTagLabel As Label
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents PlayerNameTextBox As TextBox
End Class
