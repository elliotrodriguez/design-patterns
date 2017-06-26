using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.observer;
using observer.subject;

namespace observer.concretesubject
{
    public class KSpacey : ICelebrity
    {
        public string FullName { get; }
        public string Message { get; set; }
        public void Notify(string tweet)
        {
            throw new NotImplementedException();
        }

        public void AddFollower(IFan fan)
        {
            throw new NotImplementedException();
        }

        public void RemoveFollower(IFan fan)
        {
            throw new NotImplementedException();
        }
    }
}
