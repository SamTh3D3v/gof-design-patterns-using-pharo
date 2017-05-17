using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.ObserverPattern
{
    //The Subject
    public class Observable
    {  
        private string _someData;
        public string SomeData
        {
            get
            {
                return _someData;
            }

            set
            {
                if (_someData == value)
                {
                    return;
                }

                _someData = value;
                Notify();
            }
        }
        public List<Observer> Listeners { get; set; }
        public Observable()
        {
            Listeners = new List<Observer>();
        }
        public void Register(Observer observer)
        {
            Listeners.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            Listeners.Remove(observer);
        }
        //Another way of doing that is by using an event
        public void Notify()
        {
            Listeners.ForEach(l => l.Update());
        }
    }
}
