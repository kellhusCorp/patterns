using Prototype.Extensions;

namespace Prototype.Domain.Entities;

public class Employee
{
    public Employee(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public Employee()
    {
    }

    public string Name { get; set; }

    public Address Address { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, " +
               $"{nameof(Address)}: {Address}";
    }
}

public class Address
{
    public string StreetAddress, City;

    public int Suite;

    public Address(string streetAddress, string city, int suite)
    {
        StreetAddress = streetAddress;
        City = city;
        Suite = suite;
    }

    public Address()
    {
    }

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, " +
               $"{nameof(City)}: {City}, {nameof(Suite)}: {Suite}";
    }
}

public class EmployeeFactory
{
    private static Employee main =
        new Employee(null, new Address("123 123 Street", "City", 0));
    
    private static Employee aux =
        new Employee(null, new Address("123 123 123 Street", "City2", 0));

    private static Employee NewEmployee(Employee prototype, string name, int suite)
    {
        var copy = prototype.DeepCopyXml();
        copy.Name = name;
        copy.Address.Suite = suite;
        return copy;
    }

    public static Employee NewMainOfficeEmployee(string name, int suite) => NewEmployee(main, name, suite);
    
    public static Employee NewAuxOfficeEmployee(string name, int suite) => NewEmployee(aux, name, suite);
}