namespace TheLeftExit.Win32;

// Since it's a Win32 convention that LPCWSTR fields/parameters can accept numeric atoms,
// we introduce a type that accepts a numeric value and marshals it into both of our managed representations of LPCWSTR,
// and we name it so it kind of feels like Win32.
public readonly unsafe struct IntResource
{
    private readonly char* _value;
    public IntResource(char* value)
    {
        _value = value;
    }
    public IntResource(ushort value) : this((char*)value) { }

    public static implicit operator char*(IntResource atom) => atom._value;
    public static implicit operator ReadOnlySpan<char>(IntResource atom) => new ReadOnlySpan<char>(atom._value, 0);
}
