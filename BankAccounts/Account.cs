namespace BankAccounts;

public abstract class Account
{
    public string AccountNumber {get; set;}
    public string OwnerName { get; set; }
    public DateOnly BirthDate { get; set; }
    protected decimal _balance;

    public virtual void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        _balance -= amount;
    }
    
    public decimal GetBalance()
    {
        return _balance;
    }
}