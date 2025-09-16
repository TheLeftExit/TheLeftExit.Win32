namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getmessagew")]
    public static BOOL GetMessage(
        out MSG lpMsg,
        HWND hWnd,
        UINT wMsgFilterMin,
        UINT wMsgFilterMax
    ) => __GetMessage(out lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetMessageW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __GetMessage(
        out MSG lpMsg,
        HWND hWnd,
        UINT wMsgFilterMin,
        UINT wMsgFilterMax
    );
}
