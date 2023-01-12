using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Domain.Entities;

public class RoundedCircle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Скругленный круг");
    }
}