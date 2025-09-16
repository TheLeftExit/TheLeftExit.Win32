namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/nf-commctrl-defsubclassproc")]
    public static LRESULT DefSubclassProc(
        HWND hWnd,
        UINT uMsg,
        WPARAM wParam,
        LPARAM lParam
    ) => __DefSubclassProc(hWnd, uMsg, wParam, lParam).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "DefSubclassProc", SetLastError = true)]
    private static partial LRESULT __DefSubclassProc(
        HWND hWnd,
        UINT uMsg,
        WPARAM wParam,
        LPARAM lParam
    );
}


