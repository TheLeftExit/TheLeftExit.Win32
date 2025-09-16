namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-translatemessage")]
    public static BOOL TranslateMessage(
        in MSG lpMsg
    ) => _TranslateMessage(lpMsg).ThrowOnError();

    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL _TranslateMessage(
        in MSG lpMsg
    );
}

