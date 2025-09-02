using System.ComponentModel;

namespace TheLeftExit.Win32;

public static class Win32ExceptionHelper
{
    public static void ThrowOnError()
    {
        var errorCode = Marshal.GetLastPInvokeError();
        if(errorCode is not 0)
        {
            Marshal.SetLastPInvokeError(0);
            throw new Win32Exception(errorCode);
        }
    }

    public static T ThrowOnError<T>(this T value)
    {
        ThrowOnError();
        return value;
    }
}
