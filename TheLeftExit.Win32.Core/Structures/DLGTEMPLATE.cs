namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-dlgtemplate")]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DLGTEMPLATE
{
    public DWORD style;
    public DWORD dwExtendedStyle;
    public WORD cdit;
    public short x;
    public short y;
    public short cx;
    public short cy;
    // Menu (null-terminated), '\0' for us
    // Class (null-terminated)
    // Title (null-terminated)
    // Font size (ushort, if DS_SETFONT)
    // Font name (null-terminated, if DS_SETFONT)
}
