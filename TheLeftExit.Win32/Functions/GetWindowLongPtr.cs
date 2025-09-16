namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowlongptrw")]
    public static LONG_PTR GetWindowLongPtr(
        HWND hWnd,
        int nIndex
    )
    {
        if (Environment.Is64BitProcess)
        {
            return __GetWindowLongPtr(hWnd, nIndex).ThrowOnError();
        }
        else
        {
            return __GetWindowLong(hWnd, nIndex).ThrowOnError();
        }
    }

    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongPtrW", SetLastError = true)]
    private static partial LONG_PTR __GetWindowLongPtr(
        HWND hWnd,
        int nIndex
    );

    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowlongw
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongW", SetLastError = true)]
    private static partial LONG __GetWindowLong(
        HWND hWnd,
        int nIndex
    );
}
