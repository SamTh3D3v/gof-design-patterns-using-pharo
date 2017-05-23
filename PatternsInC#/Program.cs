using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gof.ObserverPattern;

namespace Gof
{   
    class Program
    {
        static void Main(string[] args)
        {
            //the observer pattern
            var subject=new Observable();
            var observer1=new Observer();
            var observer2=new Observer();

            subject.Register(observer1);
            subject.Register(observer2);
            subject.SomeData = "update data";

        }
    }
}
