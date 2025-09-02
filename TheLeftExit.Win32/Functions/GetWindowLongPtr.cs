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
            return _GetWindowLongPtr(hWnd, nIndex).ThrowOnError();
        }
        else
        {
            return _GetWindowLong(hWnd, nIndex).ThrowOnError();
        }
    }

    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongPtrW")]
    private static partial LONG_PTR _GetWindowLongPtr(
        HWND hWnd,
        int nIndex
    );

    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowlongw
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongW")]
    private static partial LONG _GetWindowLong(
        HWND hWnd,
        int nIndex
    );
}