namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-defwindowprocw")]
    public static LRESULT DefWindowProc(
        HWND hWnd,
        UINT Msg,
        WPARAM wParam,
        LPARAM lParam
    ) => __DefWindowProc(hWnd, Msg, wParam, lParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "DefWindowProcW", SetLastError = true)]
    private static partial LRESULT __DefWindowProc(
        HWND hWnd,
        UINT Msg,
        WPARAM wParam,
        LPARAM lParam
    );
}
