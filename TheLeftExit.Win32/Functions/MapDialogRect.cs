namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapdialogrect")]
    public static BOOL MapDialogRect(
        HWND hDlg,
        ref RECT lpRect
    ) => __MapDialogRect(hDlg, ref lpRect).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "MapDialogRect", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __MapDialogRect(
        HWND hDlg,
        ref RECT lpRect
    );
}


