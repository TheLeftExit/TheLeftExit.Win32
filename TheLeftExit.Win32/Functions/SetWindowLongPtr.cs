namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowlongptrw")]
    public static LONG_PTR SetWindowLongPtr(
        HWND hWnd,
        int nIndex,
        LONG_PTR dwNewLong
    )
    {
        if (Environment.Is64BitProcess)
        {
            return _SetWindowLongPtr(hWnd, nIndex, dwNewLong).ThrowOnError();
        }
        else
        {
            return _SetWindowLong(hWnd, nIndex, (LONG)dwNewLong).ThrowOnError();
        }
    }

    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongPtrW")]
    private static partial LONG_PTR _SetWindowLongPtr(
        HWND hWnd,
        int nIndex,
        LONG_PTR dwNewLong
    );

    // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowlongw
    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongW")]
    private static partial LONG _SetWindowLong(
        HWND hWnd,
        int nIndex,
        LONG dwNewLong
    );
}
