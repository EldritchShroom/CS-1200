using System.Reflection;

namespace BankAccounts;

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public void CalculateInterest()
    {
        decimal interest = _balance * InterestRate;
        _balance += interest;
    }

    public override void Withdraw(decimal amount)
    {
        if (_balance - amount >= 0)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal canceled.");
        } 
    }
}