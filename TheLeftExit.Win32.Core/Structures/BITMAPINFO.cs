namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-bitmapinfo")]
public struct BITMAPINFO
{
    public BITMAPINFOHEADER bmiHeader;
    public nint bmiColors; // Deviation from MS docs, but it's a hard-to-translate variable length array that's not really used today.
}
