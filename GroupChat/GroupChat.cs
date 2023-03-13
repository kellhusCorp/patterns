namespace GroupChat;

internal static class GroupChat
{
    private static void Main()
    {
        var room = new ChatRoom();

        var john = new Person("John");
        var roman = new Person("Roman");
        
        room.Join(john);
        room.Join(roman);
        
        john.Say("hi room");
        roman.Say("oh, hello");

        var simon = new Person("Simon");
        room.Join(simon);
        simon.Say("hi!");
        
        roman.PrivateMessage("Simon", "hi from private message");
    }
}

public class Person
{
    public string Name { get; set; }
        
    public ChatRoom Room { get; set; }

    private List<string> chatLog = new();

    public Person(string name)
    {
        Name = name;
    }

    public void Receive(string sender, string message)
    {
        string s = $"{sender}: '{message}'";
        Console.WriteLine($"[{Name}: {s}]");
        chatLog.Add(s);
    }

    public void Say(string message)
    {
        Room.Broadcast(Name, message);
    }

    public void PrivateMessage(string who, string message)
    {
        Room.Message(Name, who, message);
    }
}

public class ChatRoom
{
    private readonly List<Person> persons = new();

    public void Broadcast(string source, string message)
    {
        foreach (var person in persons.Where(person => person.Name != source))
        {
            person.Receive(source, message);
        }
    }

    public void Join(Person p)
    {
        var joinMessage = $"{p.Name} joined the chat";
        Broadcast("room", joinMessage);
        p.Room = this;
        persons.Add(p);
    }

    public void Message(string source, string destination, string message)
    {
        persons.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
    }
}