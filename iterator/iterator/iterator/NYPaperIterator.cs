using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator.iterator
{
    public class NYPaperIterator : IIterator
    {
        private readonly List<string> _reporters;
        private int _currentElement;

        public NYPaperIterator(List<string> reporters)
        {
            _reporters = reporters;
            _currentElement = 0;
        }
        
        public void First()
        {
            _currentElement = 0;
        }

        public string Next()
        {
            return _reporters.ElementAt(_currentElement++);
        }

        public bool IsDone()
        {
            return _currentElement >= _reporters.Count;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_currentElement);
        }
    }
}
