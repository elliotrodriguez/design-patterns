using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class ICreditUnionFactory
    {
        // the abstract factory creates the abstractions of the products
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }
}
