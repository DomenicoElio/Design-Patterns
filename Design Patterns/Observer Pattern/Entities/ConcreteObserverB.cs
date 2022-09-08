using Design_Patterns.Observer_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern.Entities
{
    internal class ConcreteObserverB : IObserver {
       public void Update(IObservable observable){
            if ((observable as Observable).State == 0  || (observable as Observable).State >= 2) {
                Console.WriteLine("The second observer has reacted to a change");
            }
        }
    }
}
