namespace TheLeftExit.Win32;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Struct, AllowMultiple = false)]
public class DocsAttribute : Attribute
{
    public string Url { get; }
    public DocsAttribute(string url) => Url = url;
}