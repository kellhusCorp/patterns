using OCP.Entities;
using OCP.Enums;
using OCP.Specifications;

static class Program
{
    static void Main()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = { apple, tree, house };

        var bf = new BetterFilter();

        Console.WriteLine("Large products: ");

        var largeSpec = new SizeSpecification(Size.Large);
        foreach (var p in bf.Filter(products, largeSpec))
            Console.WriteLine($" - {p.Name} is {p.Size}");

        var largeBlueSpec = new AndSpecification<Product>(largeSpec, new ColorSpecification(Color.Blue));

        foreach (var p in bf.Filter(products, largeBlueSpec))
            Console.WriteLine($" - {p.Name} is large and blue");
    }
}