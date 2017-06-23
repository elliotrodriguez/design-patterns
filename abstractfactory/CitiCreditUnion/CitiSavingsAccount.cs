using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CitiCreditUnion
{
    public class CitiSavingsAccount : ISavingsAccount
    {
        // concrete class
        public string AccountTypeMessage { get; }
        public CitiSavingsAccount()
        {
            this.AccountTypeMessage = "Returned Citi Savings Account";
        }
    }
}
