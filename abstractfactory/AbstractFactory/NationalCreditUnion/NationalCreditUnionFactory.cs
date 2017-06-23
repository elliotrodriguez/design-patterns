using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace NationalCreditUnion
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ISavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingsAccount();
        }

        public override ILoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }
    }
}
