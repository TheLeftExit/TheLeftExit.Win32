namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-getcurrentthreadid")]
    public static DWORD GetCurrentThreadId()
        => __GetCurrentThreadId().ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "GetCurrentThreadId", SetLastError = true)]
    private static partial DWORD __GetCurrentThreadId();
}


