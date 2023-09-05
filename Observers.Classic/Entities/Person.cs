using Observers.Classic.Args;

namespace Observers.Classic.Entities
{
    public class Person
    {
        public event EventHandler<FallEventArgs> Fall; 
    
        public void GoUpstairs()
        {
            Fall?.Invoke(this, new FallEventArgs(DateTime.Now));
        }
    }
}