namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-createpopupmenu")]
    public static HMENU CreatePopupMenu()
        => __CreatePopupMenu().ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "CreatePopupMenu", SetLastError = true)]
    private static partial HMENU __CreatePopupMenu();
}


