namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-muldiv")]
    public static int MulDiv(
        int nNumber,
        int nNumerator,
        int nDenominator
    ) => __MulDiv(nNumber, nNumerator, nDenominator).ThrowOnError();

    [LibraryImport("kernel32.dll", EntryPoint = "MulDiv", SetLastError = true)]
    private static partial int __MulDiv(
        int nNumber,
        int nNumerator,
        int nDenominator
    );
}


