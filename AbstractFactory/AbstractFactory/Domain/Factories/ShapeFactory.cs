using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Factories;

public abstract class ShapeFactory
{
    public abstract IShape Create(ShapeType shape);
}