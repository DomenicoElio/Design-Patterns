using Design_Patterns.Observer_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern.Entities
{
    public class Observable : IObservable
    {
        public int Sate { get; set; } = -0;
        // sets the default status and defines the get and set methods

        public List <IObserver> _observers = new List<IObserver> ();
        // creates a list of type IPbserver which wil store all of the observers

        public void Attach(IObserver observer){
            Console.WriteLine("A new observer has been attached to the observable");
            _observers.Add(observer);
        } // adds and observer from my list of observers

        public void Detach(IObserver observer){
            _observers.Remove(observer);    
            Console.WriteLine("A new observer has been detached to the observable");
        } // removes and observer from my list of observers

        public void Notify(){
            Console.WriteLine("All the observers have been updaed notified of the change");
            foreach (IObserver observer in _observers) { observer.Update(this); }
        } //updates the state of my observers part of the list of observers

        public void BusinessLogic() {
            Console.WriteLine("Simulating an important operation being executed (weather update on screen)");
            this.Sate = new Random().Next(0,5); //updates the state of the thread

            Thread.Sleep(15); //forces the thread to wait 15 milliseconds before reading the updated state

            Console.WriteLine("Time to notify the observers of the change and update the threads its state just changed");
            this.Notify(); //notifies the rest of the program that a change has happened
        }
    }
}
