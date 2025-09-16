namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-createcompatiblebitmap")]
    public static HBITMAP CreateCompatibleBitmap(
        HDC hdc,
        int cx,
        int cy
    ) => __CreateCompatibleBitmap(hdc, cx, cy).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap", SetLastError = true)]
    private static partial HBITMAP __CreateCompatibleBitmap(
        HDC hdc,
        int cx,
        int cy
    );
}


