<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.AddPlayerButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.StartTournamentButton = New System.Windows.Forms.Button()
        Me.PlayerList = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.SyncTimeLabel = New System.Windows.Forms.Label()
        Me.RefreshPlayersButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MainLayoutPanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(3, 3)
        Me.AddPlayerButton.Name = "AddPlayerButton"
        Me.AddPlayerButton.Size = New System.Drawing.Size(94, 29)
        Me.AddPlayerButton.TabIndex = 1
        Me.AddPlayerButton.Text = "Add player"
        Me.AddPlayerButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(203, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 29)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'StartTournamentButton
        '
        Me.StartTournamentButton.Location = New System.Drawing.Point(303, 3)
        Me.StartTournamentButton.Name = "StartTournamentButton"
        Me.StartTournamentButton.Size = New System.Drawing.Size(133, 29)
        Me.StartTournamentButton.TabIndex = 6
        Me.StartTournamentButton.Text = "Start tournament"
        Me.StartTournamentButton.UseVisualStyleBackColor = True
        '
        'PlayerList
        '
        Me.PlayerList.AutoScroll = True
        Me.PlayerList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PlayerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayerList.Location = New System.Drawing.Point(3, 41)
        Me.PlayerList.Name = "PlayerList"
        Me.PlayerList.Size = New System.Drawing.Size(966, 617)
        Me.PlayerList.TabIndex = 3
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.ColumnCount = 1
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainLayoutPanel.Controls.Add(Me.ButtonPanel, 0, 0)
        Me.MainLayoutPanel.Controls.Add(Me.PlayerList, 0, 1)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 2
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(972, 661)
        Me.MainLayoutPanel.TabIndex = 7
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.SyncTimeLabel)
        Me.ButtonPanel.Controls.Add(Me.AddPlayerButton)
        Me.ButtonPanel.Controls.Add(Me.StartTournamentButton)
        Me.ButtonPanel.Controls.Add(Me.RefreshPlayersButton)
        Me.ButtonPanel.Controls.Add(Me.SaveButton)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPanel.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(966, 32)
        Me.ButtonPanel.TabIndex = 0
        '
        'SyncTimeLabel
        '
        Me.SyncTimeLabel.AutoSize = True
        Me.SyncTimeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.SyncTimeLabel.Location = New System.Drawing.Point(442, 7)
        Me.SyncTimeLabel.Name = "SyncTimeLabel"
        Me.SyncTimeLabel.Size = New System.Drawing.Size(172, 20)
        Me.SyncTimeLabel.TabIndex = 7
        Me.SyncTimeLabel.Text = "(Last saved at T:T M/D/Y)"
        '
        'RefreshPlayersButton
        '
        Me.RefreshPlayersButton.Location = New System.Drawing.Point(103, 3)
        Me.RefreshPlayersButton.Name = "RefreshPlayersButton"
        Me.RefreshPlayersButton.Size = New System.Drawing.Size(94, 29)
        Me.RefreshPlayersButton.TabIndex = 2
        Me.RefreshPlayersButton.Text = "Refresh"
        Me.RefreshPlayersButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(972, 661)
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.Name = "MainForm"
        Me.Text = "Game Tournament Manager"
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.ButtonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddPlayerButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents StartTournamentButton As Button
    Friend WithEvents PlayerList As FlowLayoutPanel
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshPlayersButton As Button
    Friend WithEvents SyncTimeLabel As Label
End Class
