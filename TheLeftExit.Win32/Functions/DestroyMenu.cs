namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-destroymenu")]
    public static BOOL DestroyMenu(
        HMENU hMenu
    ) => __DestroyMenu(hMenu).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "DestroyMenu", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __DestroyMenu(
        HMENU hMenu
    );
}

