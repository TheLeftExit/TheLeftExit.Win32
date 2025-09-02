namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-nmlvodstatechange")]
public struct NMLVODSTATECHANGE
{
    public NMHDR hdr;
    public int iFrom;
    public int iTo;
    public UINT uNewState;
    public UINT uOldState;
}
