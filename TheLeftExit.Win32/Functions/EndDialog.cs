namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enddialog")]
    public static BOOL EndDialog(
        HWND hDlg,
        INT_PTR nResult
    ) => __EndDialog(hDlg, nResult).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "EndDialog", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __EndDialog(
        HWND hDlg,
        INT_PTR nResult
    );
}


