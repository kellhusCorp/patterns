using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Factories;

public class RoundedShapeFactory : ShapeFactory
{
    public override IShape Create(ShapeType shape)
    {
        return shape switch
        {
            ShapeType.Circle => new RoundedCircle(),
            ShapeType.Square => new RoundedSquare(),
            _ => throw new ArgumentOutOfRangeException(nameof(shape), shape, null)
        };
    }
}