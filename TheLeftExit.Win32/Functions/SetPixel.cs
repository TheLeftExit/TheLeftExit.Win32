namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-setpixel")]
    public static COLORREF SetPixel(
        HDC hdc,
        int x,
        int y,
        COLORREF color
    ) => __SetPixel(hdc, x, y, color).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "SetPixel", SetLastError = true)]
    private static partial COLORREF __SetPixel(
        HDC hdc,
        int x,
        int y,
        COLORREF color
    );
}


