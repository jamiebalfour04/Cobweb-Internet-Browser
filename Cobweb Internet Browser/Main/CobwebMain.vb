Imports BalfoursBusinessClassLibrary.Classes.BalfoursEnterprises
Imports BalfoursBusinessClassLibrary.Classes.Displays
Imports BalfoursBusinessClassLibrary.Classes.SpecialisedFunctions
Imports BalfoursBusinessClassLibrary.Classes.Administration
Imports BalfoursBusinessClassLibrary.Classes.RegistryActions
Imports System.Runtime.InteropServices
Imports System.IO.Pipes



Public Class CobwebMain
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Shared Function SendMessage(hwnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    Dim RegistryLoc As String = "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser"
    Dim mColour1 As Color = Color.White
    Dim mColour2 As Color = Color.FromArgb(255, 51, 51, 51)
    Dim curfewFreeFrom(1) As Integer
    Dim curfewBegins(1) As Integer

    Public ShowFavBar As Boolean
    Public ShowStocksBar As Boolean
    Public ShowSearchBox As Boolean
    Public UseHyperBox As Boolean
    Public ShowStatusBar As Boolean
    Public CustomHistoryPath As String
    Public SearchLocationSearchBox As String
    Public SearchLocationHyperBox As String
    Public SearchPage As String
    Public FlyCatcher3Enabled As Boolean
    Public PingHyperBoxOnLoad As Boolean
    Public MaximumRecentSearches As Integer
    Public MaximumRecentURLs As Integer
    Public RecordHistory As Boolean
    Public AutoHideTopBars As Boolean
    Public RefreshStocksAutomatically As Boolean
    Public NewsPage As String
    Public IgnoreClickedFavourites As Boolean
    Public TabletMode As Boolean
    Public RefreshNewsAutomatically As Boolean
    Public ShowTitleInHyperBox As Boolean

    Public ShowBackButton As Boolean
    Public ShowForwardButton As Boolean
    Public ShowStopButton As Boolean
    Public ShowPrintButton As Boolean
    Public ShowStocksButton As Boolean
    Public ShowWingMailButton As Boolean
    Public ShowSearchButton As Boolean
    Public ShowAddToFavouritesButton As Boolean
    Public ShowDisplayFavouritesButton As Boolean
    Public ShowRSSButton As Boolean
    Public ShowLaterListButton As Boolean
    Public ShowAddToLaterListButton As Boolean
    Public ShowReadOutButton As Boolean
    Public ShowQuickAccessBarButton As Boolean
    Public ShowChangeSettingsButton As Boolean

    Public AutoBack As Boolean = False

    Public ButtonFlatStyle As Integer



#Region "Recommended sites"
    Private Sub AmazonUKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmazonUKToolStripMenuItem.Click
        NewChild("http://www.amazon.co.uk/")
    End Sub
    Private Sub AppleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppleToolStripMenuItem.Click
        NewChild("http://www.apple.com/")
    End Sub
    Private Sub BBCNewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBCNewsToolStripMenuItem.Click
        NewChild("http://www.bbc.co.uk/news")
    End Sub
    Private Sub EBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayToolStripMenuItem.Click
        NewChild("http://www.ebay.co.uk/")
    End Sub
    Private Sub FacebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacebookToolStripMenuItem.Click
        NewChild("http://www.facebook.com/")
    End Sub
    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        NewChild("http://www.google.com/")
    End Sub
    Private Sub JamieBalfourUKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JamieBalfourUKToolStripMenuItem.Click
        NewChild("http://www.jamiebalfour.co.uk/")
    End Sub
    Private Sub MicrosoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MicrosoftToolStripMenuItem.Click
        NewChild("http://www.microsoft.com/")
    End Sub
    Private Sub TwitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwitterToolStripMenuItem.Click
        NewChild("http://www.twitter.com/")
    End Sub
    Private Sub WikipediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WikipediaToolStripMenuItem.Click
        NewChild("http://www.wikipedia.org/")
    End Sub
    Private Sub YahooToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooToolStripMenuItem.Click
        NewChild("http://www.yahoo.co.uk/")
    End Sub
    Private Sub YoutubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoutubeToolStripMenuItem.Click
        NewChild("http://www.youtube.com/")
    End Sub
#End Region


    Public Sub NewChild(Optional ByVal Filename As String = Nothing)
        Dim f As New CobwebBrowserChild
        f.Text = "Internet Browser"
        Dim l As BalfoursBusinessClassLibrary.Controls.TabPage
        l = MainMDITabControl.TabPages.Add(f)
        f.MyTabPage = l
        If Filename Is Nothing Or Filename = "" Then
            f.BbcYorkshirehillWebBrowser1.GoHome()
        ElseIf Filename = "newopen" Then
            f.BbcYorkshirehillWebBrowser1.OpenResource()
        Else
            f.BbcYorkshirehillWebBrowser1.URL = New Uri(Filename)
        End If
    End Sub

    Public Sub ShowOptions()
        SidebarWithGlassPanel.Visible = InvertBoolean(SidebarWithGlassPanel.Visible)

    End Sub

    Private Sub CobwebMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If StartupTimer.Enabled = True Then
            e.Cancel = True
        End If
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim p As Integer = 0
        If c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "retainTabs") = True Then
            For Each t As BalfoursBusinessClassLibrary.Controls.TabPage In MainMDITabControl.TabPages
                Dim l As New CobwebBrowserChild
                l = t.Form
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\Load URLs")
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\Load URLs" & "\loadURL" & p, l.BbcYorkshirehillWebBrowser1.URL.ToString, False)
                p = p + 1
            Next
        End If

        ClosingFormCommands(Me, BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", e, MainMDITabControl)
    End Sub
    Private Sub CobwebMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim BPop As New BalfoursBusinessExtensionLibrary.Controls.PopUpMenu
        BPop.TransferTabControlToBBCPopUpMenu(TabControl1, Color.FromKnownColor(KnownColor.Highlight), mColour2)
        BPop.Visible = True
        OpeningCommands(Me, BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser")

        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions

        ShowFavBar = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "Favbar")
        ShowStocksBar = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showStocks")
        ShowSearchBox = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showSearchBox")
        UseHyperBox = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "useHyperBox")
        ShowStatusBar = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showStatusBar")
        CustomHistoryPath = RegistryRead(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "historyLocation")
        SearchLocationSearchBox = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "searchProviderSearchBox")
        SearchLocationHyperBox = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "searchProviderHyperBox")
        SearchPage = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "searchPage")
        FlyCatcher3Enabled = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "useFlyCatcher")
        PingHyperBoxOnLoad = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "pingHyperBox")
        MaximumRecentSearches = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "maxSearchCount")
        MaximumRecentURLs = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "maxURLCount")
        RecordHistory = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "recordHistory")
        AutoHideTopBars = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "autoHideFavBarAndStockBar")
        NewsPage = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "newsPage")
        IgnoreClickedFavourites = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "openFavesInNewTab")
        RefreshStocksAutomatically = c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, "refreshStocksMode")
        TabletMode = c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, "useTabletMode")
        RefreshNewsAutomatically = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "refreshNewsAutomatically")
        ShowTitleInHyperBox = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showTitleInHyperBox")


        ShowBackButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showBackBtn")
        ShowForwardButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showForwardBtn")
        ShowStopButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showStopBtn")
        ShowPrintButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showPrintBtn")
        ShowStocksButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showStocksBtn")
        ShowWingMailButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showEmailBtn")
        ShowSearchButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showSearchPageBtn")
        ShowAddToFavouritesButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showAddFavouritesBtn")
        ShowDisplayFavouritesButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showFavouritesBtn")
        ShowRSSButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showRSSBtn")
        ShowLaterListButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showAddToLaterListBtn")
        ShowAddToLaterListButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showLaterListBtn")
        ShowReadOutButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showReadBtn")
        ShowQuickAccessBarButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showQuickAccessBtn")
        ShowChangeSettingsButton = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "showSettingsBtn")
        AutoBack = c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLoc, "autoBack")

        ButtonFlatStyle = Val(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, "buttonStyle"))

        If My.Application.CommandLineArgs.Count = 0 Then
            If My.Settings.UsedSoftware = False Then
                NewChild("http://www.jamiebalfour.co.uk/software/extras/cobweb/")
            Else
                If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\Load URLs") Then
                    If My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\Load URLs").Count > 0 Then
                        For Each f As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\Load URLs")
                            NewChild(My.Computer.FileSystem.ReadAllText(f))
                            My.Computer.FileSystem.DeleteFile(f)
                        Next
                    Else
                        NewChild()
                    End If
                Else
                    NewChild()
                End If
            End If
        Else
            Try
                For Each arg As String In My.Application.CommandLineArgs
                    SendArguementData(arg)
                Next
            Catch ex As Exception
            End Try
        End If
        If c.BooleanReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "enableCurfew") = True Then
            Dim h() As String
            Try
                h = Split(c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeFrom"), ":")
                curfewFreeFrom(0) = h(0)
                curfewFreeFrom(1) = h(1)
                h = Split(c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeUntil"), ":")
                curfewBegins(0) = h(0)
                curfewBegins(1) = h(1)

            Catch ex As Exception
            End Try
            CurfewCheck()
            curfewTimer.Enabled = True
        End If
        If My.Settings.UsedSoftware = False Then
            NewChild("http://www.jamiebalfour.co.uk/software/extra/cobweb")
        End If
        My.Settings.UsedSoftware = True
    End Sub
    Private Sub StartupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupTimer.Tick
        StartupTimer.Enabled = False


        GiveAdminShield(cmdAssociateFiles)
        GiveAdminShield(cmdChangeHistoryLocation)
        GiveAdminShield(cmdCreateOracleFile)
        GiveAdminShield(cmdDeleteOracleFile)

    End Sub
    Public Sub SendArguementData(ByVal ArgumentIn As String)
        Select Case LCase(ArgumentIn)
            Case Is = "-silent"
                End
            Case Else
                Dim fileOpening As String = ArgumentIn.Replace("%20", " ")
                NewChild(fileOpening)

        End Select
    End Sub

    Private Sub YorkshireHillSettingsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YorkshireHillSettingsToolStripMenuItem1.Click
        Dim i As New BalfoursBusinessClassLibrary.Controls.YorkshirehillWebBrowser
        i.ChangeSettings()
    End Sub

    Private Sub MainMDITabControl_HelpButtonPressed() Handles MainMDITabControl.HelpButtonPressed
        NewChild("http://www.jamiebalfour.co.uk/software/help/cobweb")

    End Sub
    Private Sub MainMDITabControl_OpenDocumentButtonClicked() Handles MainMDITabControl.OpenDocumentButtonClicked
        NewChild("newopen")
    End Sub
    Private Sub MainMDITabControl_PreferrencesButtonClicked() Handles MainMDITabControl.PreferrencesButtonClicked
        ShowOptions()
    End Sub
    Private Sub MainMDITabControl_Tabs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMDITabControl.Tabs_DoubleClick
        NewChild()
    End Sub
    Private Sub cmdAssociateFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAssociateFiles.Click
        FileAssociation()
    End Sub
    Private Sub cmdCreateOracleFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateOracleFile.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.OracleConfigurations
        c.SaveGenericOracleConfigurationFile(MainMDITabControl.RegistryLocation)
    End Sub
    Private Sub cmdDeleteOracleFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteOracleFile.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.OracleConfigurations
        c.DeleteGenericOracleConfigurationFile(MainMDITabControl.RegistryLocation)
    End Sub
    Private Sub cmdSetSearchPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetSearchPage.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim bbInputText As String = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "searchPage")
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "searchPage", BBTextInputBox("Please insert the URL for the search page." & vbCrLf & " You currently use the following search URL: " & bbInputText, mColour1, mColour2))

    End Sub
    Private Sub ViewHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHistoryToolStripMenuItem.Click
        Try
            Dim i As New CobwebBrowserChild
            i = MainMDITabControl.SelectedForm
            i.BbcYorkshirehillWebBrowser1.GetHistory()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdChangeHistoryLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeHistoryLocation.Click
        If CheckIfRunningAsAdmin() Then
            Dim f As String = BBFileSelector(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            If My.Computer.FileSystem.DirectoryExists(f) Then
                Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
                c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "historyLocation", f)
            End If
        Else
            BBMsgBox("You must be an administrator to change settings", mColour1, mColour2)
        End If
    End Sub
    Private Sub cmdChangeRSSFeedChannel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeNewsFeedChannel.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim bbInputText As String = c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "newsPage")
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "newsPage", BBTextInputBox("Please insert the URL for the news provider." & vbCrLf & "You currently use the following RSS feed: " & bbInputText, mColour1, mColour2))
    End Sub
    Private Sub cmdSetBrowserLoadColour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetBrowserLoadColour.Click
        Dim cd1 As New ColorDialog
        cd1.Color = My.Settings.PingColour
        cd1.FullOpen = True
        If cd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.PingColour = cd1.Color
        End If
    End Sub
    Private Sub cmdUsageWarning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsageWarning.Click
        Dim i As New CobwebUsageWarningDialog
        i.ShowDialog()
    End Sub
    Private Sub CurfewCheck()
        If CheckIfRunningAsAdmin() = False Then
            Dim i As New Date(Today.Year, Today.Month, Today.Day, curfewFreeFrom(0), curfewFreeFrom(1), 0)
            Dim l As New Date(Today.Year, Today.Month, Today.Day, curfewBegins(0), curfewBegins(1), 0)
            Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
            If DateTime.Now.Hour > l.Hour OrElse DateTime.Now.Hour < i.Hour Or _
                (DateTime.Now.Hour = l.Hour And DateTime.Now.Minute >= l.Minute) Or (DateTime.Now.Hour < i.Hour And DateTime.Now.Minute <= i.Minute) Then
                curfewTimer.Enabled = False
                If c.BooleanReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "forcedCurfew") = True Then
                    MsgBox("Cobweb must close due to a curfew in place. To prevent this, run Cobweb as an administrator.", MsgBoxStyle.Information, "Curfew")
                    End
                Else
                    If BBCustomMsgBox("You have exceeded your usage. To continue to use the software you must press the continue button." & vbCrLf & vbCrLf & "The software will inform you again in 10 minutes.", mColour1, mColour2, "Cobweb Curfew", False, "Continue", Windows.Forms.DialogResult.OK, True, "Close", Windows.Forms.DialogResult.Cancel, , , , BbcTopBar1.MainImage) = Windows.Forms.DialogResult.OK Then
                        curfewTimer.Interval = 600000
                    Else
                        End
                    End If
                End If

            End If
        End If

    End Sub
    Private Sub backTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles curfewTimer.Tick
        CurfewCheck()
    End Sub

    Private Sub cmdAddHyperBoxProvider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddHyperBoxProvider.Click
        Dim i As New List(Of String)
        i.Add("Maps")
        i.Add("General search")
        i.Add("Translation")

        Dim l As String = BBComboInputBox("Please select which type of provider you wish to add", mColour1, mColour2, i)
        If l = Nothing Then
            Exit Sub
        End If
        Dim o As String
        If l = "Maps" Then
            o = "mapProviders"
        ElseIf l = "General search" Then
            o = "searchProviders"
        Else
            o = "Translation"
        End If

        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim pos As Integer = 1
        Do While Not c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, o & pos) Is Nothing
            pos = pos + 1
        Loop

        Dim b As String = BBTextInputBox("Please insert the provider URL. It must contain searchterms", mColour1, mColour2)
        If LCase(b).Contains("searchterms") Then
            c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, o & pos, b)

        Else
            BBMsgBox("The search URL was not valid. It may not have contained the term searchterms.", mColour1, mColour2)
        End If


    End Sub

    Private Sub cmdChangeHomepage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeHome.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim h As String = BBTextInputBox("You are about to change your home page. Your current homepage is " & c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "homepage"), mColour1, mColour2)
        c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "homepage", h)

    End Sub
    Private Sub cmdViewTempFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTempFiles.Click
        Process.Start(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData)
    End Sub

    Private Sub cmdCreateQuickFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateQuickFill.Click
        Dim i As New BalfoursBusinessClassLibrary.Controls.YorkshirehillWebBrowser
        i.AddQuickFill()
    End Sub

    Private Sub cmdImportIE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportIE.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions

        c.TransferRegistryValue(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Microsoft\Internet Explorer\TabbedBrowsing", "WarnOnClose", BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "askOnClose")
        c.TransferRegistryValue(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, "Software\Microsoft\Internet Explorer\TabbedBrowsing", "PopupsUseNewWindow", BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "PopupsOpenInNewWindow")

    End Sub

    Private Sub ViewTemporaryFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTemporaryFilesToolStripMenuItem.Click
        Process.Start(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData)
    End Sub

    Private Sub cmdRemoveSearchProvider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveSearchProvider.Click
        Dim q As New List(Of String)
        q.Add("Maps")
        q.Add("General search")
        q.Add("Translation")

        Dim l As String = BBComboInputBox("Please select which type of provider you wish to remove", mColour1, mColour2, q)
        If l = Nothing Then
            Exit Sub
        End If

        Dim reg As String
        If l = "Maps" Then
            reg = "mapProviders"
        ElseIf l = "General search" Then
            reg = "searchProviders"
        Else
            reg = "Translation"
        End If


        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim i As New List(Of String)
        For Each s As String In c.GetValueNames(RegistryType.CurrentUser, RegistryLoc)
            If s.StartsWith(reg) Then
                i.Add(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If

        Next
        Dim o As String = BBComboInputBox("Please select which provider to remove", mColour1, mColour2, i, "Remove search provider")
        For Each s As String In c.GetValueNames(RegistryType.CurrentUser, RegistryLoc)
            If s.StartsWith(reg) Then
                If c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s) = o Then
                    c.DeleteRegistryValue(RegistryType.CurrentUser, RegistryLoc, s)
                    Exit For
                End If
            End If

        Next
    End Sub

    Private Sub cmdAddRSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRSS.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim pos As Integer = 1
        Do While Not c.ReadRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "rssChannel" & pos) Is Nothing
            pos = pos + 1
        Loop
        Dim b As String = BBTextInputBox("Please insert the RSS channel. It must be in XML format", mColour1, mColour2)
        If b = "" Then
        Else
            c.WriteRegistry(BalfoursBusinessClassLibrary.Classes.RegistryActions.RegistryType.CurrentUser, RegistryLoc, "rssChannel" & pos, b)
        End If
    End Sub

    Private Sub cmdRemoveRSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveRSS.Click
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        Dim i As New List(Of String)
        For Each s As String In c.GetValueNames(RegistryType.CurrentUser, RegistryLoc)
            If s.StartsWith("rssChannel") Then
                i.Add(c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s))
            End If

        Next
        Dim o As String = BBComboInputBox("Please select which RSS channel to remove", mColour1, mColour2, i, "Remove RSS channel")
        For Each s As String In c.GetValueNames(RegistryType.CurrentUser, RegistryLoc)
            If s.StartsWith("rssChannel") Then
                If c.ReadRegistry(RegistryType.CurrentUser, RegistryLoc, s) = o Then
                    c.DeleteRegistryValue(RegistryType.CurrentUser, RegistryLoc, s)
                    Exit For
                End If
            End If

        Next
    End Sub

    Private Sub ForceTo1024X600netbookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1024X600netbookToolStripMenuItem.Click
        Me.Size = New Size(1024, 600)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1280X720HD720ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1280X720HD720ToolStripMenuItem.Click
        Me.Size = New Size(1280, 720)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1280X800notebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1280X800notebookToolStripMenuItem.Click
        Me.Size = New Size(1280, 800)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1366X768wideNotebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1366X768wideNotebookToolStripMenuItem.Click
        Me.Size = New Size(1366, 768)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1440X900wideNotebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1440X900wideNotebookToolStripMenuItem.Click
        Me.Size = New Size(1440, 900)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1680X1050widescreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1680X1050widescreenToolStripMenuItem.Click
        Me.Size = New Size(1680, 1050)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ForceTo1920X1080FullHD1080ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceTo1920X1080FullHD1080ToolStripMenuItem.Click
        Me.Size = New Size(1920, 1080)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
