namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-paintstruct")]
public unsafe struct PAINTSTRUCT
{
    public HDC hdc;
    public BOOL fErase;
    public RECT rcPaint;
    public BOOL fRestore;
    public BOOL fIncUpdate;
    public fixed BYTE rgbReserved[32];
}
