namespace TheLeftExit.Win32;

public static partial class Win32Macros
{
    public const int GWLx_STYLE = (-16);
    public const int GWLx_EXSTYLE = (-20);
    public const int GWLx_WNDPROC = (-4);
    public const int GWLx_HINSTANCE = (-6);
    public const int GWLx_HWNDPARENT = (-8);
    public const int GWLx_USERDATA = (-21);
    public const int GWLx_ID = (-12);

    public static unsafe readonly int DWLx_MSGRESULT = 0;
    public static unsafe readonly int DWLx_DLGPROC = DWLx_MSGRESULT + sizeof(LRESULT);
    public static unsafe readonly int DWLx_USER = DWLx_DLGPROC + sizeof(DLGPROC);
}
