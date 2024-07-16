using SecondProject.Models;

Accounts accounts = new Accounts(12, "Max", "Salary Account" );
Console.WriteLine(accounts.DepositeCash(3333));
Console.WriteLine(accounts.WithdrawalCash(3000));
Console.WriteLine(accounts.BalanceInquiry());