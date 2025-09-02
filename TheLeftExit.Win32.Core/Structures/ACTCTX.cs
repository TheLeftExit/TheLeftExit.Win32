namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/winbase/ns-winbase-actctxw")]
public unsafe struct ACTCTX
{
    public ULONG cbSize;
    public DWORD dwFlags;
    public LPCWSTR lpSource;
    public USHORT wProcessorArchitecture;
    public LANGID wLangId;
    public LPCWSTR lpAssemblyDirectory;
    public LPCWSTR lpResourceName;
    public LPCWSTR lpApplicationName;
    public HMODULE hModule;
}
