namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-movewindow")]
    public static BOOL MoveWindow(
        HWND hWnd,
        int X,
        int Y,
        int nWidth,
        int nHeight,
        [MarshalAs(UnmanagedType.Bool)] BOOL bRepaint
    ) => __MoveWindow(hWnd, X, Y, nWidth, nHeight, bRepaint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "MoveWindow", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __MoveWindow(
        HWND hWnd,
        int X,
        int Y,
        int nWidth,
        int nHeight,
        [MarshalAs(UnmanagedType.Bool)] BOOL bRepaint
    );
}
