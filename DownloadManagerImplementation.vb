Imports System
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms

Namespace custom_download_manager
    <ComVisible(True)>
    <Guid("bdb9c34c-d0ca-448e-b497-8de62e709744")>
    Public Class DownloadManagerImplementation
        Implements IDownloadManager

        Public Function Download(ByVal pmk As IMoniker, ByVal pbc As IBindCtx, ByVal dwBindVerb As UInteger, ByVal grfBINDF As Integer, ByVal pBindInfo As IntPtr, ByVal pszHeaders As String, ByVal pszRedir As String, ByVal uiCP As UInteger) As Integer Implements IDownloadManager.Download
            Dim name = String.Empty
            pmk.GetDisplayName(pbc, Nothing, name)

            If Not String.IsNullOrEmpty(name) Then
                Dim url As Uri = Nothing
                Dim result = Uri.TryCreate(name, UriKind.Absolute, url)

                If result Then
                    MessageBox.Show("Download URL is: " & url.ToString)
                    Return 0
                End If
            End If

            Return 1
        End Function
    End Class
End Namespace
