namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowpos")]
    public static BOOL SetWindowPos(
        HWND hWnd,
        HWND hWndInsertAfter,
        int X,
        int Y,
        int cx,
        int cy,
        UINT uFlags
    ) => __SetWindowPos(hWnd, hWndInsertAfter, X, Y, cx, cy, uFlags).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetWindowPos", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SetWindowPos(
        HWND hWnd,
        HWND hWndInsertAfter,
        int X,
        int Y,
        int cx,
        int cy,
        UINT uFlags
    );
}

