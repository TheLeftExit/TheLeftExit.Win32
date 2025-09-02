namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-lvitemw")]
public unsafe struct LVITEM
{
    public UINT mask;
    public int iItem;
    public int iSubItem;
    public UINT state;
    public UINT stateMask;
    public LPWSTR pszText;
    public int cchTextMax;
    public int iImage;
    public LPARAM lParam;
    public int iIndent;
    public int iGroupId;
    public UINT cColumns;
    public PUINT puColumns;
    public int* piColFmt;
    public int iGroup;
}
