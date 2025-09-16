namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enumchildwindows")]
    public static BOOL EnumChildWindows(
        HWND hWndParent,
        WNDENUMPROC lpEnumFunc,
        LPARAM lParam
    ) => __EnumChildWindows(hWndParent, lpEnumFunc, lParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "EnumChildWindows", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __EnumChildWindows(
        HWND hWndParent,
        WNDENUMPROC lpEnumFunc,
        LPARAM lParam
    );
}


