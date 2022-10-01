using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Factories;

public class BasicShapeFactory : ShapeFactory
{
    public override IShape Create(ShapeType shape)
    {
        return shape switch
        {
            ShapeType.Square => new Square(),
            ShapeType.Circle => new Circle(),
            _ => throw new ArgumentOutOfRangeException(nameof(shape), shape, null)
        };
    }
}