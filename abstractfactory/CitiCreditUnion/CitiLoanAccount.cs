using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CitiCreditUnion
{
    public class CitiLoanAccount : ILoanAccount
    {
        // concrete class B
        public string AccountTypeMessage { get;  }
        public CitiLoanAccount()
        {
            this.AccountTypeMessage = "Returned Citi Loan Account";
        }
    }
}
