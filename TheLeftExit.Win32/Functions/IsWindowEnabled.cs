namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-iswindowenabled")]
    public static BOOL IsWindowEnabled(
        HWND hWnd
    ) => __IsWindowEnabled(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "IsWindowEnabled", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __IsWindowEnabled(
        HWND hWnd
    );
}


