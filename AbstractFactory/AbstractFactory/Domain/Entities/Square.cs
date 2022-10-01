using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Entities;

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Basic square");
    }
}