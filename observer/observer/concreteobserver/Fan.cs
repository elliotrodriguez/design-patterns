using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.observer;
using observer.subject;

namespace observer.concreteobserver
{
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified: {celebrity.FullName}: {celebrity.Message}");
        }
    }
}
