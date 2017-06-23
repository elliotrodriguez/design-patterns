using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CitiCreditUnion
{
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        // this is the concrete factory class that handles citi credit union instantiations
        // the factory handles creating the concrete implementation based on the abstract
        // isavings and iloan classes
        public override ISavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }

        public override ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }
    }
}
