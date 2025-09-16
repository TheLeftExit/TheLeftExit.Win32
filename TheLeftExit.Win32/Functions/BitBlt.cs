namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-bitblt")]
    public static BOOL BitBlt(
        HDC hdc,
        int x,
        int y,
        int cx,
        int cy,
        HDC hdcSrc,
        int x1,
        int y1,
        DWORD rop
    ) => __BitBlt(hdc, x, y, cx, cy, hdcSrc, x1, y1, rop).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __BitBlt(
        HDC hdc,
        int x,
        int y,
        int cx,
        int cy,
        HDC hdcSrc,
        int x1,
        int y1,
        DWORD rop
    );
}


