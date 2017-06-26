using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator.iterator;

namespace iterator.aggregate
{
    public class LAPaper : INewspaper
    {
        private string[] reporters;

        public LAPaper()
        {
            reporters = new[]
            {
                "Jimmy Breslin",
                "Woodward",
                "Bernstein"
            };
        }
        public IIterator CreateIterator()
        {
            return  new LAPaperIterator(reporters);
        }
    }
}
