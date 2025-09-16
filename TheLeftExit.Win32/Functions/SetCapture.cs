namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setcapture")]
    public static HWND SetCapture(
        HWND hWnd
    ) => __SetCapture(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetCapture", SetLastError = true)]
    private static partial HWND __SetCapture(
        HWND hWnd
    );
}


