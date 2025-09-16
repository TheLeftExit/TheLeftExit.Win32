namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-createdialogindirectparamw")]
    public static HWND CreateDialogIndirectParam(
        HINSTANCE hInstance,
        LPCDLGTEMPLATE hDialogTemplate,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    ) => __CreateDialogIndirectParam(hInstance, hDialogTemplate, hWndParent, lpDialogFunc, dwInitParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "CreateDialogIndirectParamW", SetLastError = true)]
    private static partial HWND __CreateDialogIndirectParam(
        HINSTANCE hInstance,
        LPCDLGTEMPLATE hDialogTemplate,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    );
}


