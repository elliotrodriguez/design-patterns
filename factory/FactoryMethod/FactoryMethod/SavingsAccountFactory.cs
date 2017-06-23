using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //concrete creators
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingsAccount();
            }
            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAccount();}

            throw new ArgumentException("No valid account");

        }
    }
}
