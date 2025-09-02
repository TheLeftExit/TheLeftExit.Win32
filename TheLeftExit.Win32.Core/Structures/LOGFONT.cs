namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-logfontw")]
public unsafe struct LOGFONT
{
    public LONG lfHeight;
    public LONG lfWidth;
    public LONG lfEscapement;
    public LONG lfOrientation;
    public LONG lfWeight;
    public BYTE lfItalic;
    public BYTE lfUnderline;
    public BYTE lfStrikeOut;
    public BYTE lfCharSet;
    public BYTE lfOutPrecision;
    public BYTE lfClipPrecision;
    public BYTE lfQuality;
    public BYTE lfPitchAndFamily;
    public fixed WCHAR lfFaceName[32];
}
