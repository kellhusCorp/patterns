using Composite.Exercise.Entities;

class Program
{
    static void Main()
    {
        var firstValue = new SingleValue {Value = 5};
        var firstContainer = new ManyValues();
        firstContainer.AddRange(new[] {5, 4, 3, 2, 1});
        var secondContainer = new ManyValues();
        secondContainer.AddRange(new [] {5, 3, 2, 1});

        var bag = new List<IValueContainer>
        {
            firstValue,
            firstContainer,
            secondContainer
        };

        Console.WriteLine(bag.SuperSum());
    }
}