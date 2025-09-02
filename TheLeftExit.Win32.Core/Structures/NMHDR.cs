namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-nmhdr")]
public struct NMHDR
{
    public HWND hwndFrom;
    public UINT_PTR idFrom;
    public UINT code;
}
