namespace DynamicDecorator;

public sealed class Circle : Shape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public Circle()
    {
            
    }

    public void Resize(float factor)
    {
        radius *= factor;
    }

    public override string AsString()
    {
        return $"A circle has radius {radius}";
    }
}