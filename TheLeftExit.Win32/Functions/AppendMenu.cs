namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-appendmenuw")]
    public static BOOL AppendMenu(
        HMENU hMenu,
        UINT uFlags,
        UINT_PTR uIDNewItem,
        LPCWSTR lpNewItem
    ) => __AppendMenu(hMenu, uFlags, uIDNewItem, lpNewItem).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "AppendMenuW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __AppendMenu(
        HMENU hMenu,
        UINT uFlags,
        UINT_PTR uIDNewItem,
        LPCWSTR lpNewItem
    );
}

