using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern.Interfaces
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        // defining the method that will be used to add an observer

        void Detach(IObserver observer);
        // defining the method that will be used to remove an observer
        void Notify();
        // defining the method that will be used to notify the program of a change in state to one of the observers
    }
}
