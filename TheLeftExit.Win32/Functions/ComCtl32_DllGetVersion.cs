namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/shlwapi/nc-shlwapi-dllgetversionproc")]
    public static HRESULT ComCtl32_DllGetVersion(
        ref DLLVERSIONINFO2 unnamedParam1
    ) => __ComCtl32_DllGetVersion(ref unnamedParam1).ThrowOnError();

    [LibraryImport("comctl32.dll", EntryPoint = "DllGetVersion", SetLastError = true)]
    private static partial HRESULT __ComCtl32_DllGetVersion(
        ref DLLVERSIONINFO2 unnamedParam1
    );
}


