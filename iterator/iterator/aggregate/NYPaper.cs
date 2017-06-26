using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator.iterator;

namespace iterator.aggregate
{
    public class NYPaper : INewspaper
    {
        private List<string> reporters;

        public NYPaper()
        {
            reporters = new List<string>
            {

                "Mike Lupica",
                "Chuck Todd",
                "Dan Rather"
            };
        }

        
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(reporters);
        }
    }
}
