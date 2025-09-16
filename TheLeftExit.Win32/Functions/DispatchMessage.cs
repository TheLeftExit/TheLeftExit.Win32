namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-dispatchmessagew")]
    public static LRESULT DispatchMessage(
        in MSG lpMsg
    ) => __DispatchMessage(lpMsg).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "DispatchMessageW", SetLastError = true)]
    private static partial LRESULT __DispatchMessage(
        in MSG lpMsg
    );
}

