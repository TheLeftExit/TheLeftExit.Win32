namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-systemparametersinfow")]
    public static BOOL SystemParametersInfoForDpi(
        UINT uiAction,
        UINT uiParam,
        PVOID pvParam,
        UINT fWinIni,
        UINT dpi
    ) => __SystemParametersInfoForDpi(uiAction, uiParam, pvParam, fWinIni, dpi).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "SystemParametersInfoForDpi", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __SystemParametersInfoForDpi(
        UINT uiAction,
        UINT uiParam,
        PVOID pvParam,
        UINT fWinIni,
        UINT dpi
    );
}


