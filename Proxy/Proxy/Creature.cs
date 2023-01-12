namespace Proxy;

public class Creature
{
    private readonly Property<int> speed =
        new Property<int>(10, nameof(Speed));

    public int Speed
    {
        get => speed.Value;
        set => speed.Value = value;
    }
}