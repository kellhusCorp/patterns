namespace MultipleInheritance.Entities;

public class Bird : IBird
{
    public int Age { get; set; }

    public void Fly()
    {
        if (Age >= 10)
        {
            Console.WriteLine("The bird is flying");
        }
    }
}