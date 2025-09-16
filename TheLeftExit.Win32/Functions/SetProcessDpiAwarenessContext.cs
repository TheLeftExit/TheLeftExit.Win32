namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setprocessdpiawarenesscontext")]
    public static BOOL SetProcessDpiAwarenessContext(
        HANDLE value
    ) => __SetProcessDpiAwarenessContext(value).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SetProcessDpiAwarenessContext", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SetProcessDpiAwarenessContext(
        HANDLE value
    );
}


