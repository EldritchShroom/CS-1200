using BankAccounts;

var savings = new SavingsAccount()
{
    AccountNumber = "00001",
    OwnerName = "Joe Atlas",
    BirthDate = new DateOnly(2006, 5, 15),
};

savings.Deposit(100M);
Console.WriteLine(savings.GetBalance());

savings.Withdraw(50M);
Console.WriteLine(savings.GetBalance());

savings.Withdraw(100M);
Console.WriteLine(savings.GetBalance());