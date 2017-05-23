using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.ObserverPattern
{
    public class Observer
    {
        public void Update()
        {
            Console.WriteLine("A notification from the subject has been received!");
        }
    }
}
