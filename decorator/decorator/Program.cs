using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using decorator.component;
using decorator.concretecomponent;
using decorator.concretedecorator;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car _theCar = new CompactCar();
            _theCar = new Navigation(_theCar);
            _theCar = new LeatherSeats(_theCar);
            _theCar = new Sunroof(_theCar);
            Console.WriteLine(_theCar.GetDescription());
            Console.WriteLine($"{_theCar.GetCarPrice():C2}");
            Console.ReadKey();
        }
    }
}
