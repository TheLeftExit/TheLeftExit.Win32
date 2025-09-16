namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setmenu")]
    public static BOOL SetMenu(
        HWND hWnd,
        HMENU hMenu
    ) => __SetMenu(hWnd, hMenu).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetMenu", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SetMenu(
        HWND hWnd,
        HMENU hMenu
    );
}

