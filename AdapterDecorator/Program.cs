namespace AdapterDecorator;

static class AdapterDecoratorSolution
{
    static void Main()
    {
        MyStringBuilder s = "hello ";
        s += "world";
        Console.WriteLine(s);
    }
}