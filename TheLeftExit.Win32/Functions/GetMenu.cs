namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getmenu")]
    public static HMENU GetMenu(
        HWND hWnd
    ) => __GetMenu(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetMenu", SetLastError = true)]
    private static partial HMENU __GetMenu(
        HWND hWnd
    );
}


