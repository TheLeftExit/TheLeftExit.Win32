namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-adjustwindowrectex")]
    public static BOOL AdjustWindowRectEx(
        ref RECT lpRect,
        DWORD dwStyle,
        BOOL bMenu,
        DWORD dwExStyle
    ) => __AdjustWindowRectEx(ref lpRect, dwStyle, bMenu, dwExStyle).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "AdjustWindowRectEx", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __AdjustWindowRectEx(
        ref RECT lpRect,
        DWORD dwStyle,
        [MarshalAs(UnmanagedType.Bool)] BOOL bMenu,
        DWORD dwExStyle
    );
}


