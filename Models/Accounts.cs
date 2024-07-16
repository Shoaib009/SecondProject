using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal class Accounts
    {
        int availableCash = 0;
        int _accountHolderId;
        string _accountHolderName;
        string _accountName;

        public Accounts(int id, string accountHolderName, string accountName)
        {
            _accountHolderId = id;
            _accountHolderName = accountHolderName;
            _accountName = accountName;
        }
        public int DepositeCash(int amount) { 
            availableCash += amount;
            return availableCash;
        }
        public int WithdrawalCash(int amount)
        {
            availableCash -= amount;
            return availableCash;
        }
        public int BalanceInquiry() { return availableCash; }
    }
}
