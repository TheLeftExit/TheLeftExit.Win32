namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-loadcursorw")]
    public static HCURSOR LoadCursor(
        HINSTANCE hInstance,
        LPCWSTR lpCursorName
    ) => __LoadCursor(hInstance, lpCursorName).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "LoadCursorW", SetLastError = true)]
    private static partial HCURSOR __LoadCursor(
        HINSTANCE hInstance,
        LPCWSTR lpCursorName
    );
}


