namespace MultipleInheritance.Entities;

public class Dragon : IBird, ILizard
{
    private readonly IBird bird;

    private readonly ILizard lizard;

    public Dragon(IBird bird, ILizard lizard)
    {
        this.bird = bird;
        this.lizard = lizard;
    }

    public int Age
    {
        get => bird.Age;
        set => bird.Age = lizard.Age = value;
    }
    
    public void Crawl()
    {
        lizard.Crawl();
    }

    public void Fly()
    {
        bird.Fly();
    }
}