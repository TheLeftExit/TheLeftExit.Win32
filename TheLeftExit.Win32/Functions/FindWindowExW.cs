namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-findwindowexw")]
    public static HWND FindWindowExW(
        HWND hWndParent,
        HWND hWndChildAfter,
        LPCWSTR lpszClass,
        LPCWSTR lpszWindow
    ) => __FindWindowExW(hWndParent, hWndChildAfter, lpszClass, lpszWindow).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "FindWindowExW", SetLastError = true)]
    private static partial HWND __FindWindowExW(
        HWND hWndParent,
        HWND hWndChildAfter,
        LPCWSTR lpszClass,
        LPCWSTR lpszWindow
    );
}


