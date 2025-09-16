namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-createfontindirectw")]
    public static HFONT CreateFontIndirect(
        in LOGFONT lplf
    ) => __CreateFontIndirect(lplf).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "CreateFontIndirectW", SetLastError = true)]
    private static partial HFONT __CreateFontIndirect(
        in LOGFONT lplf
    );
}

