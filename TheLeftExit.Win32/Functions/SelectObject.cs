namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-selectobject")]
    public static HGDIOBJ SelectObject(
        HDC hdc,
        HGDIOBJ h
    ) => __SelectObject(hdc, h).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "SelectObject", SetLastError = true)]
    private static partial HGDIOBJ __SelectObject(
        HDC hdc,
        HGDIOBJ h
    );
}


