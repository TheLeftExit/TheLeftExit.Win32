namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-tpmparams")]
public struct TPMPARAMS
{
    public UINT cbSize;
    public RECT rcExclude;
};
