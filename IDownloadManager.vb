Imports System
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes

Namespace custom_download_manager
    <ComVisible(False), ComImport>
    <Guid("988934A4-064B-11D3-BB80-00104B35E7F9")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Public Interface IDownloadManager

        <PreserveSig>
        Function Download(
        <[In], MarshalAs(UnmanagedType.Interface)> ByVal pmk As IMoniker,
        <[In], MarshalAs(UnmanagedType.Interface)> ByVal pbc As IBindCtx,
        <[In], MarshalAs(UnmanagedType.U4)> ByVal dwBindVerb As UInteger,
        <[In]> ByVal grfBINDF As Integer,
        <[In]> ByVal pBindInfo As IntPtr,
        <[In], MarshalAs(UnmanagedType.LPWStr)> ByVal pszHeaders As String,
        <[In], MarshalAs(UnmanagedType.LPWStr)> ByVal pszRedir As String,
        <[In], MarshalAs(UnmanagedType.U4)> ByVal uiCP As UInteger) As <MarshalAs(UnmanagedType.I4)> Integer
    End Interface
End Namespace
