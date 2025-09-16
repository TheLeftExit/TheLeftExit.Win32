namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setfocus")]
    public static HWND SetFocus(
        HWND hWnd
    ) => __SetFocus(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetFocus", SetLastError = true)]
    private static partial HWND __SetFocus(
        HWND hWnd
    );
}


