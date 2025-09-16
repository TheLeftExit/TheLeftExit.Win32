namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowthreadprocessid")]
    public static uint GetWindowThreadProcessId(
        HWND hWnd,
        out DWORD lpdwProcessId
    ) => __GetWindowThreadProcessId(hWnd, out lpdwProcessId).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
    private static partial uint __GetWindowThreadProcessId(
        HWND hWnd,
        out DWORD lpdwProcessId
    );
}


