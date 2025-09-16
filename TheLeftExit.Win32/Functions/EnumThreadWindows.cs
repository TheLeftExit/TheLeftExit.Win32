namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enumthreadwindows")]
    public static BOOL EnumThreadWindows(
        DWORD dwThreadId,
        WNDENUMPROC lpfn,
        LPARAM lParam
    ) => __EnumThreadWindows(dwThreadId, lpfn, lParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "EnumThreadWindows", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __EnumThreadWindows(
        DWORD dwThreadId,
        WNDENUMPROC lpfn,
        LPARAM lParam
    );
}


