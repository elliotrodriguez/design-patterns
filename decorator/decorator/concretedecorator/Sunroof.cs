﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;
using decorator.decorator;

namespace decorator.concretedecorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 3378;
    }
}
