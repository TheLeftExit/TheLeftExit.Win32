namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/nf-commctrl-initcommoncontrolsex")]
    public static BOOL InitCommonControlsEx(
        in INITCOMMONCONTROLSEX picce
    ) => __InitCommonControlsEx(picce).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "InitCommonControlsEx", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __InitCommonControlsEx(
        in INITCOMMONCONTROLSEX picce
    );
}


