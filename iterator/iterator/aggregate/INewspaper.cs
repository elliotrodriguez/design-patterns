using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator.iterator;

namespace iterator.aggregate
{
    public interface INewspaper
    {
        IIterator CreateIterator();
    }
}
