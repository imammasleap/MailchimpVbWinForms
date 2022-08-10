<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Me.components = New System.ComponentModel.Container()
        Me.txtMcApiKey = New Sunny.UI.UITextBox()
        Me.lbl = New Sunny.UI.UILabel()
        Me.btnConfigure = New Sunny.UI.UIButton()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMcApiKey
        '
        Me.txtMcApiKey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMcApiKey.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.txtMcApiKey.Location = New System.Drawing.Point(13, 58)
        Me.txtMcApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMcApiKey.MaxLength = 36
        Me.txtMcApiKey.MinimumSize = New System.Drawing.Size(1, 16)
        Me.txtMcApiKey.Name = "txtMcApiKey"
        Me.txtMcApiKey.ShowText = False
        Me.txtMcApiKey.Size = New System.Drawing.Size(279, 35)
        Me.txtMcApiKey.TabIndex = 1
        Me.txtMcApiKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtMcApiKey.Watermark = ""
        Me.txtMcApiKey.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lbl.Location = New System.Drawing.Point(8, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(284, 23)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Enter mailchimp API key."
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnConfigure
        '
        Me.btnConfigure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigure.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnConfigure.Location = New System.Drawing.Point(12, 101)
        Me.btnConfigure.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(102, 35)
        Me.btnConfigure.TabIndex = 3
        Me.btnConfigure.Text = "Confirm"
        Me.btnConfigure.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(308, 148)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtMcApiKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMcApiKey As Sunny.UI.UITextBox
    Friend WithEvents lbl As Sunny.UI.UILabel
    Friend WithEvents btnConfigure As Sunny.UI.UIButton
    Friend WithEvents errorProvider As ErrorProvider
End Class
