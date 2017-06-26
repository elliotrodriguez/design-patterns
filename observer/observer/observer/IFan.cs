using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.concreteobserver;
using observer.subject;

namespace observer.observer
{
    public interface IFan
    {
        void Update(ICelebrity celebrity);
    }
}
