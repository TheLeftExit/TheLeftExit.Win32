namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-destroywindow")]
    public static BOOL DestroyWindow(
        HWND hWnd
    ) => __DestroyWindow(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __DestroyWindow(
        HWND hWnd
    );
}



