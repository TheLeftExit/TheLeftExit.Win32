namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-trackpopupmenuex")]
    public static int TrackPopupMenuEx(
        HMENU hMenu,
        UINT uFlags,
        int x,
        int y,
        HWND hwnd,
        in TPMPARAMS lptpm
    ) => __TrackPopupMenuEx(hMenu, uFlags, x, y, hwnd, lptpm).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "TrackPopupMenuEx", SetLastError = true)]
    private static partial int __TrackPopupMenuEx(
        HMENU hMenu,
        UINT uFlags,
        int x,
        int y,
        HWND hwnd,
        in TPMPARAMS lptpm
    );
}


