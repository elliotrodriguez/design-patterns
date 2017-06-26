using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;
using decorator.decorator;

namespace decorator.concretedecorator
{
    public class Navigation:CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override double GetCarPrice() => _car.GetCarPrice() + 2999;
        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
    }
}
