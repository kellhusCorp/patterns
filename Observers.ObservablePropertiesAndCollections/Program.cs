using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Person
    : INotifyPropertyChanged
{
    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            if (value == _age) return;
            _age = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangingEventHandler? PropertyChanging;
}

internal class Program
{
    public static void Main()
    {
        var person = new Person();
        person.PropertyChanged += PersonOnPropertyChanged;
        person.Age = 10;
    }

    private static void PersonOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        var person = sender as Person;
        Console.WriteLine($"{e.PropertyName} {person.Age}");
    }
}