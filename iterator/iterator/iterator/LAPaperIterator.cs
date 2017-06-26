using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator.iterator
{
    public class LAPaperIterator : IIterator
    {
        private readonly string[] _reporters;
        private int _currentElement;

        public LAPaperIterator(string[] reporters)
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
            return _reporters[_currentElement++];
        }

        public bool IsDone()
        {
            return _currentElement >= _reporters.Length;
        }

        public string CurrentItem()
        {
            return _reporters[_currentElement];
        }
    }
}
