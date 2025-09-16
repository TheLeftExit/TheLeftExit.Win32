namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getclientrect")]
    public static BOOL GetClientRect(
        HWND hWnd,
        out RECT lpRect
    ) => __GetClientRect(hWnd, out lpRect).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetClientRect", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __GetClientRect(
        HWND hWnd,
        out RECT lpRect
    );
}

