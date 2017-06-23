using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Providers;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // start with a list of accounts to create
            List<string> accountsList = new List<string>
            {
                "CITI-456",
                "NATIONAL-982",
                "MUNI-722"
            };

            // loop through each, and create a concretion where the instance
            // is determined in the abstraction (based on acct num)
            // and use the provider to get the factory for us
            foreach (var accountNum in accountsList)
            {
                var abstractCreditUnionFactory =
                    CreditUnionFactoryProvider.GetCreditUnionFactory(accountNum);

                if (abstractCreditUnionFactory == null)
                {
                    Console.WriteLine($"This credit union number {accountNum} is invalid");
                }
                else
                {
                    var loan = abstractCreditUnionFactory.CreateLoanAccount();
                    Console.WriteLine(loan.AccountTypeMessage);
                    var savings = abstractCreditUnionFactory.CreateSavingsAccount();
                    Console.WriteLine(savings.AccountTypeMessage);
                }

            }
        }
    }
}
