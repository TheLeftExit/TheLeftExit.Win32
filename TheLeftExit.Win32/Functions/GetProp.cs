namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getpropw")]
    public static HANDLE GetProp(
        HWND hWnd,
        LPCWSTR lpString
    ) => __GetProp(hWnd, lpString).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetPropW", SetLastError = true)]
    private static partial HANDLE __GetProp(
        HWND hWnd,
        LPCWSTR lpString
    );
}


