using LSP.Entities;

static class Program
{
    static void Main()
    {
        var rc = new Rectangle(3, 2);
        Demo.UseIt(rc);
        var sq = new Square(5);
        Demo.UseIt(sq);
    }
}