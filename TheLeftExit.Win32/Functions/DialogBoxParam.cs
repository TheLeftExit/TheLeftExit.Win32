namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-dialogboxparamw")]
    public static INT_PTR DialogBoxParam(
        HINSTANCE hInstance,
        LPCWSTR lpTemplateName,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    ) => __DialogBoxParam(hInstance, lpTemplateName, hWndParent, lpDialogFunc, dwInitParam).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "DialogBoxParamW", SetLastError = true)]
    private static partial INT_PTR __DialogBoxParam(
        HINSTANCE hInstance,
        LPCWSTR lpTemplateName,
        HWND hWndParent,
        DLGPROC lpDialogFunc,
        LPARAM dwInitParam
    );
}


