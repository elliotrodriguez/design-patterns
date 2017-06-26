using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;

namespace decorator.concretecomponent
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override string GetDescription() => Description;


        public override double GetCarPrice() => 10000;

    }
}
