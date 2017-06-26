using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;

namespace decorator.decorator
{
    public class CarDecorator: Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();
        public override string GetDescription() => _car.GetDescription();
    }
}
