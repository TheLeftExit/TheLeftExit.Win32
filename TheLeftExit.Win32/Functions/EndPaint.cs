namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-endpaint")]
    public static BOOL EndPaint(
        HWND hWnd,
        in PAINTSTRUCT lpPaint
    ) => __EndPaint(hWnd, lpPaint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "EndPaint", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __EndPaint(
        HWND hWnd,
        in PAINTSTRUCT lpPaint
    );
}

