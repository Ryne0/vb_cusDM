Imports custom_download_manager

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Dim browser = New ExtendedBrowser()
        Me.Controls.Add(browser)
        browser.Dock = System.Windows.Forms.DockStyle.Fill
        browser.Navigate("http://stackoverflow.com")
    End Sub
End Class