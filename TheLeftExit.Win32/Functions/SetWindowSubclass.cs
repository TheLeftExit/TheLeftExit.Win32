namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/nf-commctrl-setwindowsubclass")]
    public static BOOL SetWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass,
        DWORD_PTR dwRefData
    ) => __SetWindowSubclass(hWnd, pfnSubclass, uIdSubclass, dwRefData).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "SetWindowSubclass", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SetWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass,
        DWORD_PTR dwRefData
    );
}


