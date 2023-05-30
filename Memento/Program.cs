namespace Memento;

static class Program
{
    static void Main()
    {
        var account = new BankAccount(100);
        var mem = account.Deposit(50);
        var secondMem = account.Deposit(25);
        Console.WriteLine(account);
        
        // mem
        account.Restore(mem);
        Console.WriteLine(account);
        
        account.Restore(secondMem);
        Console.WriteLine(account);
    }
}