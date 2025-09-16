namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindow")]
    public static HWND GetWindow(
        HWND hWndParent,
        UINT uCmd
    ) => __GetWindow(hWndParent, uCmd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetWindow", SetLastError = true)]
    private static partial HWND __GetWindow(
        HWND hWndParent,
        UINT uCmd
    );
}


