namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-deletedc")]
    public static BOOL DeleteDC(
        HDC hdc
    ) => __DeleteDC(hdc).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "DeleteDC", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __DeleteDC(
        HDC hdc
    );
}
