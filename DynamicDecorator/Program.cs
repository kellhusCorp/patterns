using DynamicDecorator;

public class Demo
{
    public static void Main()
    {
        var circle = new Circle(2);
        Console.WriteLine(circle.AsString());

        var redCircle = new ColorShape(circle, "red");
        Console.WriteLine(redCircle.AsString());

        var redHTcircle = new TransparentShape(redCircle, 0.5f);
        Console.WriteLine(redHTcircle.AsString());
    }
}