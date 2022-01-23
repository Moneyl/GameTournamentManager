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
        Me.RefreshPlayersButton = New System.Windows.Forms.Button()
        Me.PlayerList = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(12, 11)
        Me.AddPlayerButton.Name = "AddPlayerButton"
        Me.AddPlayerButton.Size = New System.Drawing.Size(94, 29)
        Me.AddPlayerButton.TabIndex = 1
        Me.AddPlayerButton.Text = "Add player"
        Me.AddPlayerButton.UseVisualStyleBackColor = True
        '
        'RefreshPlayersButton
        '
        Me.RefreshPlayersButton.Location = New System.Drawing.Point(112, 11)
        Me.RefreshPlayersButton.Name = "RefreshPlayersButton"
        Me.RefreshPlayersButton.Size = New System.Drawing.Size(94, 29)
        Me.RefreshPlayersButton.TabIndex = 2
        Me.RefreshPlayersButton.Text = "Refresh"
        Me.RefreshPlayersButton.UseVisualStyleBackColor = True
        '
        'PlayerList
        '
        Me.PlayerList.AutoScroll = True
        Me.PlayerList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PlayerList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PlayerList.Location = New System.Drawing.Point(0, 46)
        Me.PlayerList.Name = "PlayerList"
        Me.PlayerList.Size = New System.Drawing.Size(800, 404)
        Me.PlayerList.TabIndex = 3
        Me.PlayerList.WrapContents = False
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(212, 11)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 29)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PlayerList)
        Me.Controls.Add(Me.RefreshPlayersButton)
        Me.Controls.Add(Me.AddPlayerButton)
        Me.Name = "MainForm"
        Me.Text = "Game Tournament Manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddPlayerButton As Button
    Friend WithEvents RefreshPlayersButton As Button
    Friend WithEvents PlayerList As FlowLayoutPanel
    Friend WithEvents SaveButton As Button
End Class
