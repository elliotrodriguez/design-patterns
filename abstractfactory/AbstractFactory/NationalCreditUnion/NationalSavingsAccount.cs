using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace NationalCreditUnion
{
    public class NationalSavingsAccount : ISavingsAccount
    {
        public string AccountTypeMessage { get;  }

        public NationalSavingsAccount()
        {
            this.AccountTypeMessage = "National Savings Account created.";
        }
    }
}
