using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NationalSavingsAccount : ISavingsAccount
    {
        //concrete product
        public NationalSavingsAccount()
        {
            Balance = 20000;
        }
    }
}
