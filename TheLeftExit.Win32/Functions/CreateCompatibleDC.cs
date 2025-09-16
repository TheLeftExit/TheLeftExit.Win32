namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-createcompatibledc")]
    public static HDC CreateCompatibleDC(
        HDC hdc
    ) => __CreateCompatibleDC(hdc).ThrowOnError();

    [LibraryImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
    private static partial HDC __CreateCompatibleDC(
        HDC hdc
    );
}
