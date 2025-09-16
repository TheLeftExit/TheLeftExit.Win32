namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-dialogboxindirectparamw")]
    public static INT_PTR DialogBoxIndirectParam(
        HINSTANCE hInstance,
        LPCDLGTEMPLATE hDialogTemplate,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    ) => __DialogBoxIndirectParam(hInstance, hDialogTemplate, hWndParent, lpDialogFunc, dwInitParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "DialogBoxIndirectParamW", SetLastError = true)]
    private static partial INT_PTR __DialogBoxIndirectParam(
        HINSTANCE hInstance,
        LPCDLGTEMPLATE hDialogTemplate,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    );
}


