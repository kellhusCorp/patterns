using NullObject;
using NullObject.Common;

static class Program
{
    static void Main()
    {
        var ba = new BankAccount(new ConsoleLog());
        ba.Deposit(100);
        ba.Deposit(300);
        ba.Withdraw(300);
        ba.Withdraw(1000);
    }
}