namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerclassexw")]
    public static ATOM RegisterClassEx(
        in WNDCLASSEX unnamedParam1
    ) => __RegisterClassEx(in unnamedParam1).ThrowOnError();

    [LibraryImport("user32.dll", EntryPoint = "RegisterClassExW", SetLastError = true)]
    private static partial ATOM __RegisterClassEx(
        in WNDCLASSEX unnamedParam1
    );
}
