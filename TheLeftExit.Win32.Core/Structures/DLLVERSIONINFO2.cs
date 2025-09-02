namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/shlwapi/ns-shlwapi-dllversioninfo2")]
public struct DLLVERSIONINFO2
{
    public DLLVERSIONINFO info1;
    public DWORD dwFlags;
    public ULONGLONG ullVersion;
}
