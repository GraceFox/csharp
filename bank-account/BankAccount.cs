using System;

public class BankAccount
{
    public decimal accountBalance;
    private bool bankAccountClosed;
    private readonly object _lock = new object();

    public void Open()
    {
        accountBalance = 0;
    }

    public void Close()
    {
        bankAccountClosed = true;
    }

    public decimal Balance
    {
        get
        {
            if (bankAccountClosed)
            {
                throw new InvalidOperationException();
            }
            return accountBalance;
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock (_lock)
        {
            accountBalance += change;
        }
    }
}
