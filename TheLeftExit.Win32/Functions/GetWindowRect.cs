namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowrect")]
    public static BOOL GetWindowRect(
        HWND hWnd,
        out RECT lpRect
    ) => __GetWindowRect(hWnd, out lpRect).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetWindowRect", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __GetWindowRect(
        HWND hWnd,
        out RECT lpRect
    );
}

