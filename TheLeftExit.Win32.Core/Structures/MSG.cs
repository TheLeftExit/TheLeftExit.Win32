namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-msg")]
public struct MSG
{
    public HWND hwnd;
    public UINT message;
    public WPARAM wParam;
    public LPARAM lParam;
    public DWORD time;
    public POINT pt;
    public DWORD lPrivate;
}
