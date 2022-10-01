using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Factories;


static class Program
{
    private static ShapeFactory GetFactory(bool rounded) => rounded ? new RoundedShapeFactory() : new BasicShapeFactory();

    static void Main()
    {
        var basicFactory = GetFactory(false);
        var basicCircle = basicFactory.Create(ShapeType.Circle);
        basicCircle.Draw();

        var roundedSquare = GetFactory(true).Create(ShapeType.Square);
        roundedSquare.Draw();
    }
}