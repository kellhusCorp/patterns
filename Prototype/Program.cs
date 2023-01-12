using Prototype.Domain.Entities;
using Prototype.Extensions;

namespace Prototype;

static class Program
{
    static void Main()
    {
        var firstFoo = new Foo {Stuff = 100, Whatever = "13"};

        var secondFoo = firstFoo.DeepCopyXml();

        secondFoo.Stuff = 111;
        secondFoo.Whatever = "155";

        Console.WriteLine(firstFoo);
        Console.WriteLine(secondFoo);

        var firstEmployee = EmployeeFactory.NewMainOfficeEmployee("First employee", 1234);
        Console.WriteLine(firstEmployee);
    }
}