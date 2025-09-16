namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getcursorpos")]
    public static BOOL GetCursorPos(
        out POINT lpPoint
    ) => __GetCursorPos(out lpPoint).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetCursorPos", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __GetCursorPos(
        out POINT lpPoint
    );
}


