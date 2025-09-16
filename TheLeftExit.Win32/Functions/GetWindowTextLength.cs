namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowtextlengthw")]
    public static int GetWindowTextLength(
        HWND hWnd
    ) => __GetWindowTextLength(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetWindowTextLengthW", SetLastError = true)]
    private static partial int __GetWindowTextLength(
        HWND hWnd
    );
}

