using SecondProject.Models;
using System;

Accounts accounts = new Accounts();
accounts.accountTitle = "Salary Account";
accounts.accountHolderName = "Max";
accounts.accountHolderId = 121;
Console.WriteLine(accounts.CashDeposite(5000));
Console.WriteLine(accounts.CashWithdrawal(2000));
Console.WriteLine(accounts.CheckBalance());
