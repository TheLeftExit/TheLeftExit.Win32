namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getdlgitem")]
    public static HWND GetDlgItem(
        HWND hDlg,
        int nIDDlgItem
    ) => __GetDlgItem(hDlg, nIDDlgItem).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "GetDlgItem", SetLastError = true)]
    private static partial HWND __GetDlgItem(
        HWND hDlg,
        int nIDDlgItem
    );
}
