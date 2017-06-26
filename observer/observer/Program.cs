using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.concreteobserver;
using observer.concretesubject;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var grohl = new DGrohl("Check out our new single, Run");

            var firstFan = new Fan();
            var secondFan = new Fan();

            grohl.AddFollower(firstFan);
            grohl.AddFollower(secondFan);
            grohl.Message = "This is going to all my fans!";

            grohl.RemoveFollower(secondFan);

            grohl.Message = "Looks like I lost a fan.";

            grohl.AddFollower(secondFan);
            grohl.Message = "I got my fan back!";
            
            Console.Read();

        }
    }
}
