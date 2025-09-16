namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/libloaderapi/nf-libloaderapi-findresourcew")]
    public static HRSRC FindResource(
        HMODULE hModule,
        LPCWSTR lpName,
        LPCWSTR lpType
    ) => __FindResource(hModule, lpName, lpType).ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "FindResourceW", SetLastError = true)]
    private static partial HRSRC __FindResource(
        HMODULE hModule,
        LPCWSTR lpName,
        LPCWSTR lpType
    );
}


