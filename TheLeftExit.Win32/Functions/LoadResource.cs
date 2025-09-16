namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-loadresource")]
    public static HGLOBAL LoadResource(
        HMODULE hModule,
        HRSRC hResInfo
    ) => __LoadResource(hModule, hResInfo).ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "LoadResource", SetLastError = true)]
    private static partial HGLOBAL __LoadResource(
        HMODULE hModule,
        HRSRC hResInfo
    );
}


