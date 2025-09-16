namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-activateactctx")]
    public static BOOL ActivateActCtx(
        HANDLE hActCtx,
        out ULONG_PTR lpCookie
    ) => __ActivateActCtx(hActCtx, out lpCookie).ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "ActivateActCtx", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial BOOL __ActivateActCtx(
        HANDLE hActCtx,
        out ULONG_PTR lpCookie
    );
}


