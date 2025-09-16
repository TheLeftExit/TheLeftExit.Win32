namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-removepropw")]
    public static HANDLE RemoveProp(
        HWND hWnd,
        LPCWSTR lpString
    ) => __RemoveProp(hWnd, lpString).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "RemovePropW", SetLastError = true)]
    private static partial HANDLE __RemoveProp(
        HWND hWnd,
        LPCWSTR lpString
    );
}


