using System.Reactive.Linq;

public class Event
{
    
}

public class FallDownEvent : Event
{
    
}

public class Person : IObservable<Event>
{
    private readonly HashSet<Subscription> _subscriptions = new();
    
    public void FallDown()
    {
        foreach (Subscription subscription in _subscriptions)
        {
            subscription.Observer.OnNext(new FallDownEvent());
        }
    }
    
    public IDisposable Subscribe(IObserver<Event> observer)
    {
        var sub = new Subscription(this, observer);
        _subscriptions.Add(sub);
        return sub;
    }

    private class Subscription : IDisposable
    {
        private Person _person;

        public IObserver<Event> Observer;
        
        public Subscription(Person person, IObserver<Event> observer)
        {
            _person = person;
            Observer = observer;
        }

        public void Dispose()
        {
            _person._subscriptions.Remove(this);
        }
    }
}

public class Program
{
    public Program()
    {
        var person = new Person();
        
        person.OfType<FallDownEvent>()
            .Subscribe(_ => Console.WriteLine("We need a doctor"));
        
        person.FallDown();
    }
    
    public static void Main()
    {
        new Program();
    }

    public void OnCompleted()
    {
        
    }

    public void OnError(Exception error)
    {
        
    }

    public void OnNext(Event value)
    {
        if (value is FallDownEvent)
        {
            Console.WriteLine("Person has fallen down");
        }
    }
}