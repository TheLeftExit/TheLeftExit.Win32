namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-loadiconw")]
    public static HICON LoadIcon(
        HINSTANCE hInstance,
        LPCWSTR lpIconName
    ) => __LoadIcon(hInstance, lpIconName).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "LoadIconW", SetLastError = true)]
    private static partial HICON __LoadIcon(
        HINSTANCE hInstance,
        LPCWSTR lpIconName
    );
}


