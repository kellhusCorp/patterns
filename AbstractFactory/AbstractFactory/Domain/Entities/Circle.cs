using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Entities;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Basic circle");
    }
}