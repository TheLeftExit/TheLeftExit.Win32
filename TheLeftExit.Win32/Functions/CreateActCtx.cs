namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-createactctxw")]
    public static HANDLE CreateActCtx(
        ref ACTCTX pActCtx
    ) => __CreateActCtx(ref pActCtx).ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "CreateActCtxW", SetLastError = true)]
    private static partial HANDLE __CreateActCtx(
        ref ACTCTX pActCtx
    );
}

