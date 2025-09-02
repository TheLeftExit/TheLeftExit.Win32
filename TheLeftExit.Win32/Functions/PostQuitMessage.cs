namespace TheLeftExit.Win32;

public static unsafe partial class Win32
{
    [Docs("https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-postquitmessage")]
    public static void PostQuitMessage(
        int nExitCode
    )
    {
        PostQuitMessage(nExitCode);
        Win32ExceptionHelper.ThrowOnError();
    }

    [LibraryImport("user32.dll", EntryPoint = "PostQuitMessage")]
    private static partial void _PostQuitMessage(
        int nExitCode
    );
}