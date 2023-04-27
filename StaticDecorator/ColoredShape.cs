using DynamicDecorator;

namespace StaticDecorator;

public class ColoredShape<T> : Shape where T : Shape, new()
{
    private string color;

    private T shape = new T();

    public ColoredShape() : this("black")
    {
        
    }
    
    public ColoredShape(string color)
    {
        this.color = color;
    }

    public override string AsString() => $"{shape.AsString()} has the color {color}";
}