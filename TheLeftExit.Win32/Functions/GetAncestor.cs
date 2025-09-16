namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getancestor")]
    public static HWND GetAncestor(
        HWND hwnd,
        UINT gaFlags
    ) => __GetAncestor(hwnd, gaFlags).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetAncestor", SetLastError = true)]
    private static partial HWND __GetAncestor(
        HWND hwnd,
        UINT gaFlags
    );
}

