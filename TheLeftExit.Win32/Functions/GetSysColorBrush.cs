namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getsyscolorbrush")]
    public static HBRUSH GetSysColorBrush(
        int nIndex
    ) => __GetSysColorBrush(nIndex).ThrowOnError();

    [LibraryImport("user32.dll", SetLastError = true)]
    private static partial HBRUSH __GetSysColorBrush(
        int nIndex
    );
}


