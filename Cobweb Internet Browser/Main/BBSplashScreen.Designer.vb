<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BBSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BBSplashScreen))
        Me.BbcSplashScreen1 = New BalfoursBusinessClassLibrary.BBUI.Controls.SplashScreen()
        Me.SuspendLayout()
        '
        'BbcSplashScreen1
        '
        Me.BbcSplashScreen1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BbcSplashScreen1.BackgroundImage = CType(resources.GetObject("BbcSplashScreen1.BackgroundImage"), System.Drawing.Image)
        Me.BbcSplashScreen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BbcSplashScreen1.ExpiryDate = New Date(CType(0, Long))
        Me.BbcSplashScreen1.Icon = CType(resources.GetObject("BbcSplashScreen1.Icon"), System.Drawing.Image)
        Me.BbcSplashScreen1.Location = New System.Drawing.Point(0, 0)
        Me.BbcSplashScreen1.Name = "BbcSplashScreen1"
        Me.BbcSplashScreen1.RegisterForm = Nothing
        Me.BbcSplashScreen1.RegistryLocation = "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser"
        Me.BbcSplashScreen1.Size = New System.Drawing.Size(474, 346)
        Me.BbcSplashScreen1.TabIndex = 0
        '
        'BBSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 346)
        Me.Controls.Add(Me.BbcSplashScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BBSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbcSplashScreen1 As BalfoursBusinessClassLibrary.BBUI.Controls.SplashScreen
End Class
