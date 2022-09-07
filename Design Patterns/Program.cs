using Design_Patterns.Singleton_Pattern;
using System;
internal class Program
{

    public static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
    private static void Main(string[] args)
    {
        //     ------------------------------Singleton------------------------------

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
    }
}
