<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.UiPanel1 = New Sunny.UI.UIPanel()
        Me.lblHelp1 = New Sunny.UI.UILabel()
        Me.imgBtnMailChimp = New Sunny.UI.UIImageButton()
        Me.lblHelp2 = New System.Windows.Forms.Label()
        Me.lblQNA = New System.Windows.Forms.Label()
        Me.txtMcApiKey = New Sunny.UI.UITextBox()
        Me.btnSignIn = New Sunny.UI.UIButton()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UiPanel1.SuspendLayout()
        CType(Me.imgBtnMailChimp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiPanel1
        '
        Me.UiPanel1.Controls.Add(Me.lblHelp1)
        Me.UiPanel1.Controls.Add(Me.imgBtnMailChimp)
        Me.UiPanel1.FillColor = System.Drawing.Color.White
        Me.UiPanel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.UiPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UiPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiPanel1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiPanel1.Name = "UiPanel1"
        Me.UiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None
        Me.UiPanel1.Size = New System.Drawing.Size(309, 59)
        Me.UiPanel1.Style = Sunny.UI.UIStyle.Custom
        Me.UiPanel1.TabIndex = 0
        Me.UiPanel1.Text = Nothing
        Me.UiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.UiPanel1.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblHelp1
        '
        Me.lblHelp1.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lblHelp1.Location = New System.Drawing.Point(58, 0)
        Me.lblHelp1.Name = "lblHelp1"
        Me.lblHelp1.Size = New System.Drawing.Size(248, 59)
        Me.lblHelp1.Style = Sunny.UI.UIStyle.Custom
        Me.lblHelp1.TabIndex = 19
        Me.lblHelp1.Text = "Sign In to your MailChimp account"
        Me.lblHelp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHelp1.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'imgBtnMailChimp
        '
        Me.imgBtnMailChimp.BackColor = System.Drawing.Color.Transparent
        Me.imgBtnMailChimp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgBtnMailChimp.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.imgBtnMailChimp.Image = CType(resources.GetObject("imgBtnMailChimp.Image"), System.Drawing.Image)
        Me.imgBtnMailChimp.Location = New System.Drawing.Point(12, 9)
        Me.imgBtnMailChimp.Name = "imgBtnMailChimp"
        Me.imgBtnMailChimp.Size = New System.Drawing.Size(40, 40)
        Me.imgBtnMailChimp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBtnMailChimp.Style = Sunny.UI.UIStyle.Custom
        Me.imgBtnMailChimp.TabIndex = 18
        Me.imgBtnMailChimp.TabStop = False
        Me.imgBtnMailChimp.Text = Nothing
        Me.imgBtnMailChimp.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblHelp2
        '
        Me.lblHelp2.AutoSize = True
        Me.lblHelp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp2.Location = New System.Drawing.Point(9, 71)
        Me.lblHelp2.Name = "lblHelp2"
        Me.lblHelp2.Size = New System.Drawing.Size(224, 15)
        Me.lblHelp2.TabIndex = 1
        Me.lblHelp2.Text = "Authenticate with the MailChimp API key"
        '
        'lblQNA
        '
        Me.lblQNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNA.Location = New System.Drawing.Point(9, 101)
        Me.lblQNA.Name = "lblQNA"
        Me.lblQNA.Size = New System.Drawing.Size(287, 125)
        Me.lblQNA.TabIndex = 2
        Me.lblQNA.Text = resources.GetString("lblQNA.Text")
        '
        'txtMcApiKey
        '
        Me.txtMcApiKey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMcApiKey.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.txtMcApiKey.Location = New System.Drawing.Point(12, 259)
        Me.txtMcApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMcApiKey.MaxLength = 36
        Me.txtMcApiKey.MinimumSize = New System.Drawing.Size(1, 16)
        Me.txtMcApiKey.Name = "txtMcApiKey"
        Me.txtMcApiKey.ShowText = False
        Me.txtMcApiKey.Size = New System.Drawing.Size(279, 35)
        Me.txtMcApiKey.TabIndex = 3
        Me.txtMcApiKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtMcApiKey.Watermark = "MailChimp API key"
        Me.txtMcApiKey.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnSignIn
        '
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnSignIn.Location = New System.Drawing.Point(100, 320)
        Me.btnSignIn.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(102, 35)
        Me.btnSignIn.TabIndex = 4
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 367)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtMcApiKey)
        Me.Controls.Add(Me.lblQNA)
        Me.Controls.Add(Me.lblHelp2)
        Me.Controls.Add(Me.UiPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        Me.UiPanel1.ResumeLayout(False)
        CType(Me.imgBtnMailChimp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UiPanel1 As Sunny.UI.UIPanel
    Friend WithEvents imgBtnMailChimp As Sunny.UI.UIImageButton
    Friend WithEvents lblHelp2 As Label
    Friend WithEvents lblQNA As Label
    Friend WithEvents txtMcApiKey As Sunny.UI.UITextBox
    Friend WithEvents btnSignIn As Sunny.UI.UIButton
    Friend WithEvents lblHelp1 As Sunny.UI.UILabel
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
