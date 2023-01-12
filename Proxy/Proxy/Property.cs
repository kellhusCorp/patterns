namespace Proxy;

public class Property<T> where T : new()
{
    protected bool Equals(Property<T> other)
    {
        return EqualityComparer<T>.Default.Equals(value, other.value);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Property<T>) obj);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<T>.Default.GetHashCode(value);
    }

    private T value;
    private readonly string name;

    public T Value
    {
        get => value;
        set
        {
            if (Equals(this.value, value)) return;
            Console.WriteLine($"Присваивание значения {value} в {name}");
            this.value = value;
        }
    }

    public Property() : this(default)
    {
    }

    public Property(T value, string name = "")
    {
        this.value = value;
    }

    public static implicit operator T(Property<T> p)
    {
        return p.Value;
    }

    public static implicit operator Property<T>(T value)
    {
        return new Property<T>(value);
    }
}