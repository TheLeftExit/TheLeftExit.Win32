namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-clienttoscreen")]
    public static BOOL ClientToScreen(
        HWND hWnd,
        ref POINT lpPoint
    ) => __ClientToScreen(hWnd, ref lpPoint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "ClientToScreen", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __ClientToScreen(
        HWND hWnd,
        ref POINT lpPoint
    );
}


