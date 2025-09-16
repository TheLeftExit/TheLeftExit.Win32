namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-fillrect")]
    public static BOOL FillRect(
        HDC hDC,
        in RECT lprc,
        HBRUSH hbr
    ) => __FillRect(hDC, lprc, hbr).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "FillRect", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __FillRect(
        HDC hDC,
        in RECT lprc,
        HBRUSH hbr
    );
}
