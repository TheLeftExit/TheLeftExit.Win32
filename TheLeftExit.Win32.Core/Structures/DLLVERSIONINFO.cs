namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/shlwapi/ns-shlwapi-dllversioninfo")]
public struct DLLVERSIONINFO
{
    public DWORD cbSize;
    public DWORD dwMajorVersion;
    public DWORD dwMinorVersion;
    public DWORD dwBuildNumber;
    public DWORD dwPlatformID;
}
