namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setpropw")]
    public static BOOL SetProp(
        HWND hWnd,
        LPCWSTR lpString,
        HANDLE hData
    ) => __SetProp(hWnd, lpString, hData).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetPropW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SetProp(
        HWND hWnd,
        LPCWSTR lpString,
        HANDLE hData
    );
}


