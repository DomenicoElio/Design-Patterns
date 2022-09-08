using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern.Interfaces
{
    public interface IObserver
    {
        void Update(IObservable observable);
        // defining the method that will update the program with all the changes sent from the notify method
    }
}
