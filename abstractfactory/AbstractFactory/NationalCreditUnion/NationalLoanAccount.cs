using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace NationalCreditUnion
{
    public class NationalLoanAccount : ILoanAccount
    {
        public string AccountTypeMessage { get;  }

        public NationalLoanAccount()
        {
            this.AccountTypeMessage = "Created national loan account.";
        }
    }
}
