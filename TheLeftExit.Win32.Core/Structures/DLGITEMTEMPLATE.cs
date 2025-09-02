namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-dlgitemtemplate")]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DLGITEMTEMPLATE
{
    public DWORD style;
    public DWORD dwExtendedStyle;
    public short x;
    public short y;
    public short cx;
    public short cy;
    public WORD id;
    // Class (null-terminated)
    // Title (null-terminated)
    // lParam data (length-prefixed)
}
