namespace TheLeftExit.Win32;

[Docs("https://learn.microsoft.com/en-us/windows/win32/api/windef/ns-windef-rect")]
public struct RECT
{
    public LONG left;
    public LONG top;
    public LONG right;
    public LONG bottom;

    public static implicit operator System.Drawing.Rectangle(RECT rect) => new(
        x: rect.left,
        y: rect.top,
        width: rect.right - rect.left,
        height: rect.bottom - rect.top
    );

    public static implicit operator RECT(System.Drawing.Rectangle rect) => new()
    {
        left = rect.X,
        top = rect.Y,
        right = rect.X + rect.Width,
        bottom = rect.Y + rect.Height,
    };
}
