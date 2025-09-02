namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-nmlistview")]
public struct NMLISTVIEW
{
    public NMHDR hdr;
    public int iItem;
    public int iSubItem;
    public UINT uNewState;
    public UINT uOldState;
    public UINT uChanged;
    public POINT ptAction;
    public LPARAM lParam;
}
