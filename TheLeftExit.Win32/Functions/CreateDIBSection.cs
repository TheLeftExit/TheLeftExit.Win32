namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-createdibsection")]
    public static HBITMAP CreateDIBSection(
        HDC hdc,
        in BITMAPINFO pbmi,
        UINT usage,
        out void* ppvBits,
        HANDLE hSection,
        DWORD offset
    ) => __CreateDIBSection(hdc, pbmi, usage, out ppvBits, hSection, offset).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "CreateDIBSection", SetLastError = true)]
    private static partial HBITMAP __CreateDIBSection(
        HDC hdc,
        in BITMAPINFO pbmi,
        UINT usage,
        out void* ppvBits,
        HANDLE hSection,
        DWORD offset
    );
}


