using NullObject.Common;
using NullObject.Interfaces;

namespace NullObject;

public class BankAccount
{
    private int balance;

    private ILog log;

    public BankAccount(ILog log = null)
    {
        this.log = new OptionalLog(log);
    }

    public void Deposit(int amount)
    {
        balance += amount;
        log.Info($"Внесено {amount}, баланс составляет {balance}");
    }

    public void Withdraw(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            log.Info($"Списано {amount}, на балансе осталось {balance}");
        }
        else
        {
            log.Warn($"Невозможно списать {amount}, так как баланс {balance} меньше суммы списания");
        }
    }
}