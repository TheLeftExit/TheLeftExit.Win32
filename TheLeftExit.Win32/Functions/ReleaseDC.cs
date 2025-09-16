namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasedc")]
    public static int ReleaseDC(
        HWND hWnd,
        HDC hDC
    ) => __ReleaseDC(hWnd, hDC).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "ReleaseDC", SetLastError = true)]
    private static partial int __ReleaseDC(
        HWND hWnd,
        HDC hDC
    );
}

