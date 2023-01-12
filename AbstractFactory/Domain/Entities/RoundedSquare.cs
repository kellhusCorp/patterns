using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Entities;

public class RoundedSquare : IShape
{
    public void Draw()
    {
        Console.WriteLine("Скругленный квадрат");
    }
}