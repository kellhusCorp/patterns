using Bridge.Exercise.Renderers;

namespace Bridge.Exercise.Shapes;

internal class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer)
    {
        Name = "Triangle";
    }
}