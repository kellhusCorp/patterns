using DynamicDecorator;

namespace StaticDecorator;

internal static class StaticDecoratorProgram
{
    private static void Main()
    {
        var blueCircle = new ColoredShape<Circle>("blue");
        Console.WriteLine(blueCircle.AsString());

        var blackHalfCircle = new TransparentShape<ColoredShape<Circle>>(0.5f);
    }
}