namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-nmitemactivate")]
public struct NMITEMACTIVATE
{
    public NMHDR hdr;
    public int iItem;
    public int iSubItem;
    public UINT uNewState;
    public UINT uOldState;
    public UINT uChanged;
    public POINT ptAction;
    public LPARAM lParam;
    public UINT uKeyFlags;
}
