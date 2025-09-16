namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/nf-commctrl-getwindowsubclass")]
    public static BOOL GetWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass,
        out DWORD_PTR plResult
    ) => __GetWindowSubclass(hWnd, pfnSubclass, uIdSubclass, out plResult).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "GetWindowSubclass", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __GetWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass,
        out DWORD_PTR plResult
    );
}


