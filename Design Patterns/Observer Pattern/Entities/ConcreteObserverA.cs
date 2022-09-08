using Design_Patterns.Observer_Pattern.Interfaces;
using Design_Patterns.Observer_Pattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern.Entities
{
    public class ConcreteObserverA : IObserver {
        public void Update(IObservable observable) {
            if ((observable as Observable).State < 3) {
                Console.WriteLine("The first observer has reacted to a change");
            }
        }
    }
}
