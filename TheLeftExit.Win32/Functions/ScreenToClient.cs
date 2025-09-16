namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-screentoclient")]
    public static BOOL ScreenToClient(
        HWND hWnd,
        ref POINT lpPoint
    ) => __ScreenToClient(hWnd, ref lpPoint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "ScreenToClient", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __ScreenToClient(
        HWND hWnd,
        ref POINT lpPoint
    );
}


