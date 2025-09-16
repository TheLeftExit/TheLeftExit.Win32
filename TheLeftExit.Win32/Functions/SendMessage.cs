namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessagew")]
    public static LRESULT SendMessage(
        HWND hWnd,
        UINT msg,
        WPARAM wParam,
        LPARAM lParam
    ) => __SendMessage(hWnd, msg, wParam, lParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
    private static partial LRESULT __SendMessage(
        HWND hWnd,
        UINT msg,
        WPARAM wParam,
        LPARAM lParam
    );
}


