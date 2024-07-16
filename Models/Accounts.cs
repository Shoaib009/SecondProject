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
        const int cashAvailable = 0;
        public string accountHolderName { get; set; }
        public int accountHolderId { get; set; }

        public string accountTitle { get; set; }

        public int CashDeposite(int amount) { return cashAvailable + amount; }
        public int CashWithdrawal(int amount) { return cashAvailable - amount; }
        public int CheckBalance() { return cashAvailable; }


    }
}
