<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobwebBrowserChild
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobwebBrowserChild))
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BbcYorkshirehillWebBrowser1 = New BalfoursBusinessClassLibrary.Controls.YorkshirehillWebBrowser()
        Me.SuspendLayout()
        '
        'StartupTimer
        '
        Me.StartupTimer.Interval = 500
        '
        'BbcYorkshirehillWebBrowser1
        '
        Me.BbcYorkshirehillWebBrowser1.AllowDrop = True
        Me.BbcYorkshirehillWebBrowser1.AllowNavigation = True
        Me.BbcYorkshirehillWebBrowser1.AllowUsersToGetPass = True
        Me.BbcYorkshirehillWebBrowser1.AutoFillInformationPanelBackColour1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.AutoFillInformationPanelBackColour2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.AutoFillPagesEnabled = True
        Me.BbcYorkshirehillWebBrowser1.AutoHideTopBars = False
        Me.BbcYorkshirehillWebBrowser1.BlockPages = False
        Me.BbcYorkshirehillWebBrowser1.BrowserSearchBoxInitialColour = System.Drawing.Color.Silver
        Me.BbcYorkshirehillWebBrowser1.BrowserSearchBoxSecondaryColour = System.Drawing.Color.White
        Me.BbcYorkshirehillWebBrowser1.BrowserTextboxInitialColour = System.Drawing.Color.Silver
        Me.BbcYorkshirehillWebBrowser1.BrowserTextboxSecondaryColour = System.Drawing.Color.White
        Me.BbcYorkshirehillWebBrowser1.ButtonFlatAppearanceBorder = 0
        Me.BbcYorkshirehillWebBrowser1.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BbcYorkshirehillWebBrowser1.CacheFavouritesForOffline = False
        Me.BbcYorkshirehillWebBrowser1.ContextMenuStripRenderer = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BbcYorkshirehillWebBrowser1.DialogBackColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.DialogForeColour = System.Drawing.Color.White
        Me.BbcYorkshirehillWebBrowser1.DialogsTopMost = False
        Me.BbcYorkshirehillWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BbcYorkshirehillWebBrowser1.DocumentText = "<HTML></HTML>" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.BbcYorkshirehillWebBrowser1.EnableMetaRefresh = True
        Me.BbcYorkshirehillWebBrowser1.FavouritesGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.BbcYorkshirehillWebBrowser1.FlyCatcher3Enabled = True
        Me.BbcYorkshirehillWebBrowser1.FlyCatcherInformationPanelBackColour1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.FlyCatcherInformationPanelBackColour2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.FlyCatcherInformationPanelForeColour = System.Drawing.Color.White
        Me.BbcYorkshirehillWebBrowser1.FlyCatcherInformationPanelText = "A popup has been blocked. Click here to refresh the page and enable popups from t" & _
            "his page."
        Me.BbcYorkshirehillWebBrowser1.GoButtonForeColour = System.Drawing.SystemColors.ControlText
        Me.BbcYorkshirehillWebBrowser1.HTMLDebugMode = False
        Me.BbcYorkshirehillWebBrowser1.HyperBoxBackColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.HyperBoxLabelFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbcYorkshirehillWebBrowser1.HyperBoxLabelForeColour = System.Drawing.Color.DarkGray
        Me.BbcYorkshirehillWebBrowser1.HyperBoxPingColour = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.HyperMode = False
        Me.BbcYorkshirehillWebBrowser1.HyperURLBoxEnabled = True
        Me.BbcYorkshirehillWebBrowser1.IgnoreClickedFavourites = True
        Me.BbcYorkshirehillWebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.BbcYorkshirehillWebBrowser1.LaterListHoverBackground = CType(resources.GetObject("BbcYorkshirehillWebBrowser1.LaterListHoverBackground"), System.Drawing.Image)
        Me.BbcYorkshirehillWebBrowser1.LimitToSite = ""
        Me.BbcYorkshirehillWebBrowser1.LinkColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.BbcYorkshirehillWebBrowser1.MaximumRecentSearches = 20
        Me.BbcYorkshirehillWebBrowser1.MaximumRecentURLs = 40
        Me.BbcYorkshirehillWebBrowser1.Name = "BbcYorkshirehillWebBrowser1"
        Me.BbcYorkshirehillWebBrowser1.NewsPage = "www.bbc.co.uk/news/"
        Me.BbcYorkshirehillWebBrowser1.PingCount = 2
        Me.BbcYorkshirehillWebBrowser1.PingHyperBoxOnLoad = False
        Me.BbcYorkshirehillWebBrowser1.PingSpeed = 500
        Me.BbcYorkshirehillWebBrowser1.PopupsOpenInNewWindow = False
        Me.BbcYorkshirehillWebBrowser1.RecordHistory = True
        Me.BbcYorkshirehillWebBrowser1.RefreshStocksAutomatically = BalfoursBusinessClassLibrary.Controls.YorkshirehillWebBrowser.StocksRefreshMode.None
        Me.BbcYorkshirehillWebBrowser1.RegisterAsBrowser = True
        Me.BbcYorkshirehillWebBrowser1.RegistryLocation = "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser"
        Me.BbcYorkshirehillWebBrowser1.ScriptErrorsSuppressed = True
        Me.BbcYorkshirehillWebBrowser1.ScrollbarsEnabled = True
        Me.BbcYorkshirehillWebBrowser1.SearchBoxBackColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.SearchLocationHyperBox = resources.GetString("BbcYorkshirehillWebBrowser1.SearchLocationHyperBox")
        Me.BbcYorkshirehillWebBrowser1.SearchLocationSearchBox = "http://www.bing.com/search?q=SEARCHTERMS&qs=n&form=QBRE&filt=all&pq=searchterms&s" & _
            "c=1-12&sp=-1&sk="
        Me.BbcYorkshirehillWebBrowser1.SetParentFormText = True
        Me.BbcYorkshirehillWebBrowser1.ShowAddToFavouritesButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowAddToLaterListButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowBackButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowButtons = True
        Me.BbcYorkshirehillWebBrowser1.ShowChangeSettingsButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowDisplayFavouritesButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowDocumentTitleInHyperBox = True
        Me.BbcYorkshirehillWebBrowser1.ShowFavBar = True
        Me.BbcYorkshirehillWebBrowser1.ShowForwardButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowHideButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowHideButtonsBarButton = True
        Me.BbcYorkshirehillWebBrowser1.ShowHomeButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowHyperBox = True
        Me.BbcYorkshirehillWebBrowser1.ShowHyperBoxSearchGlyph = True
        Me.BbcYorkshirehillWebBrowser1.ShowLaterListButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowMainNavigationZone = True
        Me.BbcYorkshirehillWebBrowser1.ShowPrintButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowQuickAccessBarButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowRandomNewsFeedButton = True
        Me.BbcYorkshirehillWebBrowser1.ShowReadOutButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowRSSButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowSearchBox = False
        Me.BbcYorkshirehillWebBrowser1.ShowSearchButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowStatusBar = True
        Me.BbcYorkshirehillWebBrowser1.ShowStocksBar = True
        Me.BbcYorkshirehillWebBrowser1.ShowStocksButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowStopButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowTopSearchBar = True
        Me.BbcYorkshirehillWebBrowser1.ShowWingMailButton = False
        Me.BbcYorkshirehillWebBrowser1.ShowZoomBar = True
        Me.BbcYorkshirehillWebBrowser1.Size = New System.Drawing.Size(963, 624)
        Me.BbcYorkshirehillWebBrowser1.StatusBarBackColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.StatusBarForeColour = System.Drawing.Color.White
        Me.BbcYorkshirehillWebBrowser1.StocksDownForeColour = System.Drawing.Color.Red
        Me.BbcYorkshirehillWebBrowser1.StocksUpForeColour = System.Drawing.Color.LawnGreen
        Me.BbcYorkshirehillWebBrowser1.SubListBorderStyles = System.Windows.Forms.BorderStyle.None
        Me.BbcYorkshirehillWebBrowser1.TabIndex = 1
        Me.BbcYorkshirehillWebBrowser1.TabletMode = False
        Me.BbcYorkshirehillWebBrowser1.URL = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.BbcYorkshirehillWebBrowser1.UseCustomToolBarRenderer = False
        Me.BbcYorkshirehillWebBrowser1.UseFormAutoFavicon = True
        Me.BbcYorkshirehillWebBrowser1.UseHyperBox = True
        Me.BbcYorkshirehillWebBrowser1.VisitedLinkColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BbcYorkshirehillWebBrowser1.WebBrowserShortcutsEnabled = True
        Me.BbcYorkshirehillWebBrowser1.ZoomFactor = 100
        '
        'CobwebBrowserChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 624)
        Me.Controls.Add(Me.BbcYorkshirehillWebBrowser1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "CobwebBrowserChild"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartupTimer As System.Windows.Forms.Timer
    Friend WithEvents BbcYorkshirehillWebBrowser1 As BalfoursBusinessClassLibrary.Controls.YorkshirehillWebBrowser
End Class
