using Bridge.Exercise.Renderers;

namespace Bridge.Exercise.Shapes;

internal class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer)
    {
        Name = "Square";
    }
}