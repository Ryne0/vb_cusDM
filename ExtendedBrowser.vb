Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Namespace custom_download_manager
    Public Class ExtendedBrowser
        Inherits WebBrowser

        Protected NotInheritable Class WebBrowserControlSite
            Inherits WebBrowserSite
            Implements IServiceProvider

            Private manager As DownloadManagerImplementation

            Public Sub New(ByVal host As WebBrowser)
                MyBase.New(host)
                manager = New DownloadManagerImplementation
            End Sub

            Public Function QueryService(ByRef guidService As Guid, ByRef riid As Guid, <Out> ByRef ppvObject As IntPtr) As Integer Implements IServiceProvider.QueryService
                Dim SID_SDownloadManager = New Guid("988934A4-064B-11D3-BB80-00104B35E7F9")
                Dim IID_IDownloadManager = New Guid("988934A4-064B-11D3-BB80-00104B35E7F9")

                If guidService = IID_IDownloadManager AndAlso riid = IID_IDownloadManager Then
                    ppvObject = Marshal.GetComInterfaceForObject(manager, GetType(IDownloadManager))
                    Return 0
                End If

                ppvObject = IntPtr.Zero

                Return &H80004002
                ''' Cannot convert CheckedExpressionSyntax, CONVERSION ERROR: Conversion for UncheckedExpression not implemented, please report this issue in 'unchecked((int)0x80004002)' at character 1245
                '''    於 ICSharpCode.CodeConverter.VB.NodesVisitor.DefaultVisit(SyntaxNode node)
                '''    於 Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitCheckedExpression(CheckedExpressionSyntax node)
                '''    於 Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
                '''    於 Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
                '''    於 ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
                ''' 
                ''' Input:
                ''' unchecked((int)0x80004002)
                ''' 
            End Function
        End Class

        Protected Overrides Function CreateWebBrowserSiteBase() As WebBrowserSiteBase
            Return New WebBrowserControlSite(Me)
        End Function
    End Class
End Namespace
