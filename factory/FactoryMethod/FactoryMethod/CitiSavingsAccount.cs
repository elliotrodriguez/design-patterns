using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
}
