<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutBox_divarchin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button_close As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox_divarchin))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.Label_name_and_licence = New System.Windows.Forms.Label()
        Me.Label_version = New System.Windows.Forms.Label()
        Me.LinkLabel_link_to_repo = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(481, 11)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(64, 64)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(20, 83)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(525, 151)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'Button_close
        '
        Me.Button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_close.Location = New System.Drawing.Point(20, 242)
        Me.Button_close.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(104, 32)
        Me.Button_close.TabIndex = 0
        Me.Button_close.Text = "بستن"
        '
        'Label_name_and_licence
        '
        Me.Label_name_and_licence.Location = New System.Drawing.Point(20, 11)
        Me.Label_name_and_licence.Name = "Label_name_and_licence"
        Me.Label_name_and_licence.Size = New System.Drawing.Size(526, 22)
        Me.Label_name_and_licence.TabIndex = 1
        Me.Label_name_and_licence.Text = "Label_name_and_licence"
        Me.Label_name_and_licence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_version
        '
        Me.Label_version.Location = New System.Drawing.Point(20, 33)
        Me.Label_version.Name = "Label_version"
        Me.Label_version.Size = New System.Drawing.Size(526, 22)
        Me.Label_version.TabIndex = 2
        Me.Label_version.Text = "Label_version"
        Me.Label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel_link_to_repo
        '
        Me.LinkLabel_link_to_repo.Location = New System.Drawing.Point(20, 55)
        Me.LinkLabel_link_to_repo.Name = "LinkLabel_link_to_repo"
        Me.LinkLabel_link_to_repo.Size = New System.Drawing.Size(526, 22)
        Me.LinkLabel_link_to_repo.TabIndex = 3
        Me.LinkLabel_link_to_repo.TabStop = True
        Me.LinkLabel_link_to_repo.Text = "دریافت کد منبع"
        Me.LinkLabel_link_to_repo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutBox_divarchin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_close
        Me.ClientSize = New System.Drawing.Size(561, 289)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.LinkLabel_link_to_repo)
        Me.Controls.Add(Me.Label_version)
        Me.Controls.Add(Me.Label_name_and_licence)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Button_close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox_divarchin"
        Me.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "درباره دیوارچین"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_name_and_licence As Label
    Friend WithEvents Label_version As Label
    Friend WithEvents LinkLabel_link_to_repo As LinkLabel
End Class
