using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;
using decorator.decorator;

namespace decorator.concretedecorator
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather seats";
        }

        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

    }
}
