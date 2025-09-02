namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-createstructw")]
public unsafe struct CREATESTRUCT
{
    public LPVOID lpCreateParams;
    public HINSTANCE hInstance;
    public HMENU hMenu;
    public HWND hwndParent;
    public int cy;
    public int cx;
    public int y;
    public int x;
    public LONG style;
    public LPCWSTR lpszName;
    public LPCWSTR lpszClass;
    public DWORD dwExStyle;
}
