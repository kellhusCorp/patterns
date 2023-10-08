using Observers.Classic.Args;
using Observers.Classic.Entities;

namespace Observers.Classic
{
    public static class Program
    {
        public static void Main()
        {
            var person = new Person();
        
            person.Fall += PersonOnFall;
        
            person.GoUpstairs();
        }

        private static void PersonOnFall(object? sender, FallEventArgs e)
        {
            Console.WriteLine($"Person has fallen {e.HappenDate}");
        }
    }
}