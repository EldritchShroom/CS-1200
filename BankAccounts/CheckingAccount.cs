namespace BankAccounts;

// Allow user to withdraw over $100 extra but with a $5 overdraft charge.
// 

public class CheckingAccount : Account
{
    public override void Withdraw(decimal amount)
    {
        // _balance -= amount; this is what is in the normal code

        // I could deduct the amount from the balance then check that it is still less than -100
        //I could check if the smount exceeds the balance and then if it does how much does it exceed.
        if 
    }
}