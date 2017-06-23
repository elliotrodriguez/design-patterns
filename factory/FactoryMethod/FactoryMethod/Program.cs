using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // modify to support DI
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var natAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($@"Balance for Citi is ${citiAcct.Balance}, and for national its ${natAcct.Balance}");
        }
    }
}
