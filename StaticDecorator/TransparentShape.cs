using DynamicDecorator;

namespace StaticDecorator;

public class TransparentShape<T> : Shape where T : Shape, new()
{
    private readonly float transparency;

    private readonly T shape = new T();

    public TransparentShape(float transparency)
    {
        this.transparency = transparency;
    }

    public override string AsString()
    {
        return $"{shape.AsString()} has transparency {transparency * 100.0f}";
    }
}