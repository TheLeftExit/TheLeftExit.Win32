namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messageboxw")]
    public static int MessageBox(
        HWND hWnd,
        LPCWSTR lpText,
        LPCWSTR lpCaption,
        UINT uType
    ) => __MessageBox(hWnd, lpText, lpCaption, uType).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "MessageBoxW", SetLastError = true)]
    private static partial int __MessageBox(
        HWND hWnd,
        LPCWSTR lpText,
        LPCWSTR lpCaption,
        UINT uType
    );
}
// Note: Return type is int (not BOOL), but still routed through ThrowOnError() for consistency.


