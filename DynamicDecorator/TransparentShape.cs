namespace DynamicDecorator;

public class TransparentShape : Shape
{
    private Shape shape;

    private float transparency;

    public TransparentShape(Shape shape, float transparency)
    {
        this.shape = shape;
        this.transparency = transparency;
    }

    public override string AsString()
    {
        return $"{shape.AsString()} has {transparency * 100.0f}% {nameof(transparency)}";
    }
}