Imports BalfoursBusinessClassLibrary.Classes.RegistryActions
Public Class CobwebUsageWarningDialog

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim fromT As String = DomainUpDownFrom.Text & ":" & DomainUpDownFrom2.Text
        Dim untilT As String = DomainUpDown2.Text & ":" & DomainUpDown1.Text
        Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
        c.WriteRegistry(RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeFrom", fromT)
        c.WriteRegistry(RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeUntil", untilT)

        Me.Close()
    End Sub

    Private Sub CobwebUsageWarningDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim c As New BalfoursBusinessClassLibrary.Classes.RegistryActions
            Dim l As String
            Dim q As String
            l = c.ReadRegistry(RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeFrom")
            q = c.ReadRegistry(RegistryType.CurrentUser, "Software\Balfour Enterprises\Elements Office Ultra\Cobweb Internet Browser", "curfewFreeUntil")
            Dim m() As String
            m = Split(l, ":")
            DomainUpDownFrom.Text = m(0)
            DomainUpDownFrom2.Text = m(1)
            m = Split(q, ":")
            DomainUpDown1.Text = m(1)
            DomainUpDown2.Text = m(0)
        Catch ex As Exception
        End Try
    End Sub
End Class