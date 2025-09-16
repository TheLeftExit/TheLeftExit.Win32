namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-beginpaint")]
    public static HDC BeginPaint(
        HWND hWnd,
        out PAINTSTRUCT lpPaint
    ) => __BeginPaint(hWnd, out lpPaint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "BeginPaint", SetLastError = true)]
    private static partial HDC __BeginPaint(
        HWND hWnd,
        out PAINTSTRUCT lpPaint
    );
}

