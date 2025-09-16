namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-peekmessagew")]
    public static BOOL PeekMessage(
        out MSG lpMsg,
        HWND hWnd,
        UINT wMsgFilterMin,
        UINT wMsgFilterMax,
        UINT wRemoveMsg
    ) => __PeekMessage(out lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "PeekMessageW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __PeekMessage(
        out MSG lpMsg,
        HWND hWnd,
        UINT wMsgFilterMin,
        UINT wMsgFilterMax,
        UINT wRemoveMsg
    );
}


