using Proxy.Structures;

namespace Proxy;

public static class ExtensionsMethods
{
    public static Percentage Percent(this int value)
    {
        return new Percentage(value / 100.0m);
    }

    public static Percentage Percent(this decimal value)
    {
        return new Percentage(value / 100.0m);
    }
}