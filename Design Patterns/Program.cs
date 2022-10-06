using Design_Patterns.Observer_Pattern.Entities;
using Design_Patterns.Observer_Pattern.Interfaces;
using Design_Patterns.Singleton_Pattern;
using Design_Patterns.Strategy_Pattern.Entities;
using Design_Patterns.Strategy_Pattern.Interfaces;
using System;
internal class Program
{
    /*//     ------------------------------Singleton------------------------------
    public static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
    //     ------------------------------Singleton------------------------------*/
    private static void Main(string[] args)
    {
        /*//     ------------------------------Singleton------------------------------

        Console.WriteLine(
            "{0}\n{1}\n\n{2}\n",
            "same values means singleton was reused (check comments about lock function to understand) (yay!)",
            "If you see different values, then 2 singletons were created (booo!!) (thread locking didnt work properly)",
            "RESULT:"
        );

        Thread firstProcess = new Thread(() => { 
            TestSingleton("FOO");
        }); // first process launched
        Thread secondProcess = new Thread(() => {
            TestSingleton("BAR");
        }); // second process launched

        // whichever of the two arrived at the thread and triggers the lock first, will print twice and leave 
        // the other process stuck at the lock. Output will therefore be: BAR BAR or FOO FOO . 

        firstProcess.Start();
        secondProcess.Start();

        firstProcess.Join();
        secondProcess.Join();
        //     ------------------------------Singleton------------------------------
        //the key to a singleton, is the fact that whilst the constructor is private (it cant be called in the main)
        //being the constructor static, a variable of singleton type is created in the clas, and then used to call the singleton.
        //     ------------------------------Singleton------------------------------*/

        /* //     ------------------------------Observer Pattern------------------------------

        Observable subject = new Observable();
        ConcreteObserverA firstObserver = new ConcreteObserverA();
        subject.Attach(firstObserver);

        ConcreteObserverB secondObserver = new ConcreteObserverB();
        subject.Attach(secondObserver);

        subject.BusinessLogic();
        subject.BusinessLogic();

        subject.Detach(secondObserver);
        subject.BusinessLogic();
        //     ------------------------------Observer Pattern------------------------------ */

        //     ------------------------------Strategy Pattern------------------------------

        var context = new Context();

        Console.WriteLine("Your algorythm will reverse sort any imput");
        context.SetStrategy(new ConcreteStrategyA());
        context.BusinessFunction();

        Console.WriteLine();

        Console.WriteLine("Your algorythm will reverse sort any imput");
        context.SetStrategy(new ConcreteStrategyB());
        context.BusinessFunction();


        //     ------------------------------Strategy Pattern------------------------------
    }
}
