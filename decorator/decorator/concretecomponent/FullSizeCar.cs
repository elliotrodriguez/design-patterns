using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;

namespace decorator.concretecomponent
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full size car";
        }

        public override string GetDescription() => Description;

        public override double GetCarPrice() => 30000;

    }
}
