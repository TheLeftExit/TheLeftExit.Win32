namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-deleteobject")]
    public static BOOL DeleteObject(
        HGDIOBJ ho
    ) => __DeleteObject(ho).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "DeleteObject", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __DeleteObject(
        HGDIOBJ ho
    );
}


