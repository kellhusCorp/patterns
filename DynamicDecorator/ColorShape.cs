namespace DynamicDecorator;

public class ColorShape : Shape
{
    private Shape shape;

    private string color;

    public ColorShape(Shape shape, string color)
    {
        this.shape = shape;
        this.color = color;
    }

    public override string AsString()
    {
        return $"{shape.AsString()} has the color {color}";
    }
}