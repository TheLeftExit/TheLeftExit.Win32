namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasecapture")]
    public static BOOL ReleaseCapture()
        => __ReleaseCapture().ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "ReleaseCapture", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __ReleaseCapture();
}
