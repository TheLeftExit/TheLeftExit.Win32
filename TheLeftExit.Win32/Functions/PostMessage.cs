namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-postmessagew")]
    public static BOOL PostMessage(
        HWND hWnd,
        UINT msg,
        WPARAM wParam,
        LPARAM lParam
    ) => __PostMessage(hWnd, msg, wParam, lParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "PostMessageW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __PostMessage(
        HWND hWnd,
        UINT msg,
        WPARAM wParam,
        LPARAM lParam
    );
}

