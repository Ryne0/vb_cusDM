Imports System
Imports System.Runtime.InteropServices

Namespace custom_download_manager
    <ComImport, ComVisible(True)>
    <Guid("6d5140c1-7436-11ce-8034-00aa006009fa")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Friend Interface IServiceProvider

        <PreserveSig>
        Function QueryService(
        <[In]> ByRef guidService As Guid,
        <[In]> ByRef riid As Guid,
        <Out> ByRef ppvObject As IntPtr) As <MarshalAs(UnmanagedType.I4)> Integer
    End Interface
End Namespace
