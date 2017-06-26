using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.observer;
using observer.subject;

namespace observer.concretesubject
{
    public class DGrohl : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _message;

        public DGrohl(string message)
        {
            _message = message;
        }

        public string FullName => "Dave Grohl (" + _fans.Count + " followers)" ;

        public string Message
        {
            get { return _message; } set { Notify(value);}
        }

        public void Notify(string message)
        {
            _message = message;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
