namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getdc")]
    public static HDC GetDC(
        HWND hWnd
    ) => __GetDC(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
    private static partial HDC __GetDC(
        HWND hWnd
    );
}


