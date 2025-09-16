namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-showwindow")]
    public static BOOL ShowWindow(
        HWND hWnd,
        int nCmdShow
    ) => __ShowWindow(hWnd, nCmdShow).ThrowOnError();

    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __ShowWindow(
        HWND hWnd,
        int nCmdShow
    );
}



