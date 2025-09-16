namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enablewindow")]
    public static BOOL EnableWindow(
        HWND hWnd,
        [MarshalAs(UnmanagedType.Bool)] BOOL bEnable
    ) => __EnableWindow(hWnd, bEnable).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "EnableWindow", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __EnableWindow(
        HWND hWnd,
        [MarshalAs(UnmanagedType.Bool)] BOOL bEnable
    );
}
