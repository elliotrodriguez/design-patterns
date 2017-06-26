using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator.aggregate;
using iterator.iterator;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            IIterator nyIterator = nyt.CreateIterator();
            IIterator laIterator = lat.CreateIterator();

            Console.WriteLine("-- NY Paper --");
            PrintReporters(nyIterator);

            Console.WriteLine("-- LA Paper --");
            PrintReporters(laIterator);

            Console.ReadLine();

        }

        private static void PrintReporters(IIterator paperIterator)
        {
            paperIterator.First();
            while(!paperIterator.IsDone())
            {
                Console.WriteLine(paperIterator.Next());
            }
        }
    }
}
