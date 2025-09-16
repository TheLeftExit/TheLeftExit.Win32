namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-createmenu")]
    public static HMENU CreateMenu()
        => __CreateMenu().ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "CreateMenu", SetLastError = true)]
    private static partial HMENU __CreateMenu();
}


