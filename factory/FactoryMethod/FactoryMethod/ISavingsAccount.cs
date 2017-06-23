using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class ISavingsAccount
    {
        // abstract interface product
        public decimal Balance { get; set; }
    }
}
