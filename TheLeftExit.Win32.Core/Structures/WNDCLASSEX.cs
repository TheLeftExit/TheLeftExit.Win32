namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-wndclassexw")]
public unsafe struct WNDCLASSEX
{
    public UINT cbSize;
    public UINT style;
    public WNDPROC lpfnWndProc;
    public int cbClsExtra;
    public int cbWndExtra;
    public HINSTANCE hInstance;
    public HICON hIcon;
    public HCURSOR hCursor;
    public HBRUSH hbrBackground;
    public LPCWSTR lpszMenuName;
    public LPCWSTR lpszClassName;
    public HICON hIconSm;
}
