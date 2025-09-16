namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-iswindow")]
    public static BOOL IsWindow(
        HWND hWnd
    ) => __IsWindow(hWnd).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "IsWindow", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __IsWindow(
        HWND hWnd
    );
}


