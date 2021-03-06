﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitiCreditUnion;
using Interfaces;
using NationalCreditUnion;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            if (accountNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory();}
            return null;

        }
    }
}
