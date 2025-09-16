namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/nf-commctrl-removewindowsubclass")]
    public static BOOL RemoveWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass
    ) => __RemoveWindowSubclass(hWnd, pfnSubclass, uIdSubclass).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "RemoveWindowSubclass", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __RemoveWindowSubclass(
        HWND hWnd,
        SUBCLASSPROC pfnSubclass,
        UINT_PTR uIdSubclass
    );
}

