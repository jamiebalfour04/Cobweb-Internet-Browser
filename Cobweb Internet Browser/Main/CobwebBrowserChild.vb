Imports BalfoursBusinessClassLibrary.Classes.RegistryActions
Imports BalfoursBusinessClassLibrary.Classes.SpecialisedFunctions
Public Class CobwebBrowserChild
    Public Property MyTabPage As BalfoursBusinessClassLibrary.Controls.TabPage
    Dim RegistryLoc As String = "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser"
    Private Sub CobwebBrowserChild_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions

        LoadingInformation()

        If c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "useLightTheme") = True Then
            Me.BackColor = Color.FromKnownColor(KnownColor.Control)
            Me.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
            BbcYorkshirehillWebBrowser1.HyperBoxBackColour = Color.White
            BbcYorkshirehillWebBrowser1.BrowserSearchBoxInitialColour = Color.Silver
            BbcYorkshirehillWebBrowser1.BrowserSearchBoxSecondaryColour = Color.Black
            BbcYorkshirehillWebBrowser1.SearchBoxBackColour = Color.White
            BbcYorkshirehillWebBrowser1.StatusBarBackColour = Me.BackColor
            BbcYorkshirehillWebBrowser1.StatusBarForeColour = Me.ForeColor
            BbcYorkshirehillWebBrowser1.GoButtonForeColour = Color.Black
            BbcYorkshirehillWebBrowser1.BackColor = Me.BackColor
            BbcYorkshirehillWebBrowser1.ForeColor = Me.ForeColor
            BbcYorkshirehillWebBrowser1.BrowserTextboxSecondaryColour = Color.Black
        End If

        If c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, "PopupsOpenInNewWindow") = "1" Then
            BbcYorkshirehillWebBrowser1.PopupsOpenInNewWindow = True
        Else
            BbcYorkshirehillWebBrowser1.PopupsOpenInNewWindow = False
        End If

        BbcYorkshirehillWebBrowser1.HyperBoxPingColour = My.Settings.PingColour

        For Each s As String In c.GetValueNames(RegistryType.CurrentUser, RegistryLoc)
            If s.StartsWith("searchProviders") Then
                BbcYorkshirehillWebBrowser1.AddSearchProvider(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If
            If s.StartsWith("mapProviders") Then
                BbcYorkshirehillWebBrowser1.AddMapProvider(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If
            If s.StartsWith("translateProviders") Then
                BbcYorkshirehillWebBrowser1.AddTranslateProvider(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If
            If s.StartsWith("rssChannel") Then
                BbcYorkshirehillWebBrowser1.AddRSSProvider(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If
        Next

        StartupTimer.Enabled = CobwebMain.RefreshNewsAutomatically

        My.Settings.UsedSoftware = True
        My.Settings.Save()


    End Sub
    Private Sub LoadingInformation()
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions

        BbcYorkshirehillWebBrowser1.ShowFavBar = CobwebMain.ShowFavBar
        BbcYorkshirehillWebBrowser1.ShowStocksBar = CobwebMain.ShowStocksBar
        BbcYorkshirehillWebBrowser1.ShowSearchBox = CobwebMain.ShowSearchBox
        BbcYorkshirehillWebBrowser1.UseHyperBox = CobwebMain.UseHyperBox
        BbcYorkshirehillWebBrowser1.ShowStatusBar = CobwebMain.ShowStatusBar
        BbcYorkshirehillWebBrowser1.CustomHistoryPath(CobwebMain.CustomHistoryPath)
        BbcYorkshirehillWebBrowser1.SearchLocationSearchBox = CobwebMain.SearchLocationSearchBox
        BbcYorkshirehillWebBrowser1.SearchLocationHyperBox = CobwebMain.SearchLocationHyperBox
        BbcYorkshirehillWebBrowser1.SearchPage = CobwebMain.SearchPage
        BbcYorkshirehillWebBrowser1.FlyCatcher3Enabled = CobwebMain.FlyCatcher3Enabled
        BbcYorkshirehillWebBrowser1.PingHyperBoxOnLoad = CobwebMain.PingHyperBoxOnLoad
        BbcYorkshirehillWebBrowser1.MaximumRecentSearches = CobwebMain.MaximumRecentSearches
        BbcYorkshirehillWebBrowser1.MaximumRecentURLs = CobwebMain.MaximumRecentURLs
        BbcYorkshirehillWebBrowser1.RecordHistory = CobwebMain.RecordHistory
        BbcYorkshirehillWebBrowser1.AutoHideTopBars = CobwebMain.AutoHideTopBars
        BbcYorkshirehillWebBrowser1.NewsPage = CobwebMain.NewsPage
        BbcYorkshirehillWebBrowser1.IgnoreClickedFavourites = CobwebMain.IgnoreClickedFavourites
        BbcYorkshirehillWebBrowser1.TabletMode = CobwebMain.TabletMode
        BbcYorkshirehillWebBrowser1.RefreshStocksAutomatically = CobwebMain.RefreshStocksAutomatically
        BbcYorkshirehillWebBrowser1.ShowDocumentTitleInHyperBox = CobwebMain.ShowTitleInHyperBox

        BbcYorkshirehillWebBrowser1.ShowBackButton = CobwebMain.ShowBackButton
        BbcYorkshirehillWebBrowser1.ShowForwardButton = CobwebMain.ShowForwardButton
        BbcYorkshirehillWebBrowser1.ShowStopButton = CobwebMain.ShowStopButton
        BbcYorkshirehillWebBrowser1.ShowPrintButton = CobwebMain.ShowPrintButton
        BbcYorkshirehillWebBrowser1.ShowStocksButton = CobwebMain.ShowStocksButton
        BbcYorkshirehillWebBrowser1.ShowWingMailButton = CobwebMain.ShowWingMailButton
        BbcYorkshirehillWebBrowser1.ShowSearchButton = CobwebMain.ShowSearchButton
        BbcYorkshirehillWebBrowser1.ShowAddToFavouritesButton = CobwebMain.ShowAddToFavouritesButton
        BbcYorkshirehillWebBrowser1.ShowDisplayFavouritesButton = CobwebMain.ShowDisplayFavouritesButton
        BbcYorkshirehillWebBrowser1.ShowRSSButton = CobwebMain.ShowRSSButton
        BbcYorkshirehillWebBrowser1.ShowLaterListButton = CobwebMain.ShowLaterListButton
        BbcYorkshirehillWebBrowser1.ShowAddToLaterListButton = CobwebMain.ShowAddToLaterListButton
        BbcYorkshirehillWebBrowser1.ShowReadOutButton = CobwebMain.ShowReadOutButton
        BbcYorkshirehillWebBrowser1.ShowQuickAccessBarButton = CobwebMain.ShowQuickAccessBarButton
        BbcYorkshirehillWebBrowser1.ShowChangeSettingsButton = CobwebMain.ShowChangeSettingsButton


        BbcYorkshirehillWebBrowser1.ButtonFlatStyle = CobwebMain.ButtonFlatStyle
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles BbcYorkshirehillWebBrowser1.DocumentCompleted
        MyTabPage.SendPing()
        'automatically sets the background
        If CobwebMain.AutoBack = True Then
            Me.BackColor = BbcYorkshirehillWebBrowser1.PageBackColor
            Me.ForeColor = BbcYorkshirehillWebBrowser1.PageForeColor
            BbcYorkshirehillWebBrowser1.BrowserTextboxInitialColour = BbcYorkshirehillWebBrowser1.PageForeColor
            BbcYorkshirehillWebBrowser1.HyperBoxBackColour = BbcYorkshirehillWebBrowser1.PageBackColor
        End If
        BbcYorkshirehillWebBrowser1.Select()

    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_HyperBoxSearchProviderChanged(ByVal ProviderURL As String) Handles BbcYorkshirehillWebBrowser1.HyperBoxSearchProviderChanged
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "searchProviderHyperBox", ProviderURL)
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_SearchBoxSearchProviderChanged(ByVal ProviderURL As String) Handles BbcYorkshirehillWebBrowser1.SearchBoxSearchProviderChanged
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "searchProviderSearchBox", ProviderURL)
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_NewTabRequest(ByVal URL As String) Handles BbcYorkshirehillWebBrowser1.NewTabRequest
        CobwebMain.NewChild(URL)
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_NewWindow2(ByRef ppDisp As Object, ByRef Cancel As Boolean) Handles BbcYorkshirehillWebBrowser1.NewWindow2
        Dim f As New CobwebBrowserChild
        f.Text = "Internet Browser"
        Dim l As BalfoursBusinessClassLibrary.Controls.TabPage
        l = CobwebMain.MainMDITabControl.TabPages.Add(f)
        f.MyTabPage = l
        f.BbcYorkshirehillWebBrowser1.RegisterAsBrowser = True
        ppDisp = f.BbcYorkshirehillWebBrowser1.WebApplication
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_NewWindow3(ByRef ppDisp As Object, ByRef Cancel As Boolean, ByVal dwFlags As UInteger, ByVal bstrUrlContext As String, ByVal bstrUrl As String) Handles BbcYorkshirehillWebBrowser1.NewWindow3
        Dim f As New CobwebBrowserChild
        f.Text = "Internet Browser"
        Dim l As BalfoursBusinessClassLibrary.Controls.TabPage
        l = CobwebMain.MainMDITabControl.TabPages.Add(f)
        f.MyTabPage = l
        f.BbcYorkshirehillWebBrowser1.RegisterAsBrowser = True
        ppDisp = f.BbcYorkshirehillWebBrowser1.WebApplication
    End Sub
    Private Sub BbcYorkshirehillWebBrowser1_NonCachedFavouriteClicked(ByVal URL As String) Handles BbcYorkshirehillWebBrowser1.NonCachedFavouriteClicked
        CobwebMain.NewChild(URL)
    End Sub
    Private Sub StartupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupTimer.Tick
        StartupTimer.Enabled = False
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim secs As Integer = Val(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, "newsTimer"))
        If secs = 0 Then
            secs = 5000
        End If
        BbcYorkshirehillWebBrowser1.RefreshRandomNewsFeed(secs)
    End Sub

End Class