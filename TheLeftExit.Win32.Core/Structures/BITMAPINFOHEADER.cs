namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-bitmapinfoheader")]
public struct BITMAPINFOHEADER
{
    public DWORD biSize;
    public LONG biWidth;
    public LONG biHeight;
    public WORD biPlanes;
    public WORD biBitCount;
    public DWORD biCompression;
    public DWORD biSizeImage;
    public LONG biXPelsPerMeter;
    public LONG biYPelsPerMeter;
    public DWORD biClrUsed;
    public DWORD biClrImportant;
}