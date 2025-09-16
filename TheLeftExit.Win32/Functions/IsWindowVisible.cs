namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-iswindowvisible")]
    public static BOOL IsWindowVisible(
        HWND hWnd
    ) => __IsWindowVisible(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "IsWindowVisible", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __IsWindowVisible(
        HWND hWnd
    );
}


