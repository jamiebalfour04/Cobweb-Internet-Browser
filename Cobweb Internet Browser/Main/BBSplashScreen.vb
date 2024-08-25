Imports BalfoursBusinessClassLibrary.Classes.RegistryActions

Public Class BBSplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RegistryLocation As String = "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser"
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions

        Try

            If c.BooleanReadRegistry(RegistryType.CurrentUser, RegistryLocation, "usedSoftware") = False Then
                Try
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "theme", "4")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "TopColour", "255,51,51,51")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "BottomColour", "255,0,0,0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "buttonStyle", "0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "opacity", "1")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "historyLocation", Application.LocalUserAppDataPath & "\History")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "locOfMainX", "0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "locOfMainY", "0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "sizeOfMainWidth", "800")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "sizeOfMainHeight", "600")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "sizeMaxi", "False")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showStocks", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showFavBar", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "rssChannel1", "http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/front_page/rss.xml")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "newsPage", "http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/front_page/rss.xml")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "NYSECompany0", "AAPL")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "NYSECompany1", "GOOG")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "NYSECompany2", "HPQ")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "NYSECompany3", "MSFT")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "NYSECompany4", "YHOO")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviderSearchBox", "http://www.bing.com/search?q=searchterms&qs=n&form=QBLH&filt=all&pq=searchterms&sc=1-10&sp=-1&sk=")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviderHyperBox", "http://www.bing.com/search?q=searchterms&qs=n&form=QBLH&filt=all&pq=searchterms&sc=1-10&sp=-1&sk=")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "useHyperBox", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showSearchBox", "False")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchPage", "http://www.jamiebalfour.co.uk/software/cobweb/search.html")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "lang", "English (UK)")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "opacity", "1")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "pingHyperBoxOnLoad", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "buttonStyle", "Standard")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviders1", "http://www.amazon.co.uk/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=searchterms&x=0&y=0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviders2", "http://www.bing.com/search?q=searchterms&qs=n&form=QBLH&filt=all&pq=searchterms&sc=1-10&sp=-1&sk=")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviders3", "http://www.ebay.co.uk/sch/i.html?_sacat=0&_nkw=searchterms&_rusck=1")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviders4", "https://www.google.co.uk/#hl=en&gs_nf=1&cp=8&gs_id=u&xhr=t&q=searchterms&pf=p&sclient=psy-ab&oq=searchte&gs_l=&pbx=1&bav=on.2,or.r_gc.r_pw.r_qf.&fp=c84ce46124a7e2b8&biw=1280&bih=705")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "searchProviders5", "http://en.wikipedia.org/w/index.php?search=searchterms&button=&title=Special%3ASearch")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "mapProviders1", "http://maps.google.com/maps?q=searchterms")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "translateProviders1", "http://translate.google.co.uk/?hl=en&tab=wT#auto/en/searchterms")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "maxSearchCount", "20")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "maxURLCount", "20")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "buttonStyle", "Flat")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "FavBar", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "useFlyCatcher", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showStatusBar", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "recordHistory", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "PopupsOpenInNewWindow", "0")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "openFavesInNewTab", "False")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showTitleInHyperBox", "True")

                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showBackBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showForwardBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showStopBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showHomeBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showPrintBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showStocksBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showEmailBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showSearchPageBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showAddFavouritesBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showFavouritesBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showRSSBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showAddToLaterListBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showLaterListBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showQuickAccessBtn", "True")
                    c.WriteRegistry(RegistryType.CurrentUser, RegistryLocation, "showSettingsBtn", "True")

                Catch ex As Exception
                End Try
            End If

        Catch
        End Try

        '''Dim ExpireDate As Date = #12/30/2014#
        '''If Today = ExpireDate Or Today > ExpireDate Then
        '''MsgBox("This software has expired. Please contact Jamie Balfour", MsgBoxStyle.Information)
        '''End
        '''End If
    End Sub
End Class