namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-lvcolumnw")]
public unsafe struct LVCOLUMN
{
    public UINT mask;
    public int fmt;
    public int cx;
    public LPWSTR pszText;
    public int cchTextMax;
    public int iSubItem;
    public int iImage;
    public int iOrder;
    public int cxMin;
    public int cxDefault;
    public int cxIdeal;
}
