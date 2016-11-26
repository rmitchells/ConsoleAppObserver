using System;

namespace ConsoleAppObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sue = new ConcreteSubject();

            Sue.Attach(new ConcreteObserver(Sue, "Dave"));
            Sue.Attach(new ConcreteObserver(Sue, "Karen"));

            Sue.SubjectState = "real bad";
            Sue.Notify();

            Console.WriteLine("");
            Console.WriteLine("Press any key to make it all good");
            Console.ReadKey(true);
            Console.WriteLine("");


            Sue.SubjectState = "so good";
            Sue.Notify();

            Console.ReadKey(true);
        }
    }
}
