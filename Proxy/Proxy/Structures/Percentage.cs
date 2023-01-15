namespace Proxy.Structures;

public readonly struct Percentage
{
    private readonly decimal value;
    
    public Percentage(decimal value)
    {
        this.value = value;
    }

    public static implicit operator Percentage(int value)
    {
        return value.Percent();
    }

    public static decimal operator *(decimal a, Percentage b)
    {
        return a * b.value;
    }

    public static Percentage operator +(Percentage a, Percentage b)
    {
        return new Percentage(a.value + b.value);
    }

    public override string ToString()
    {
        return $"{value * 100}%";
    }
}