using System;

namespace ConsoleAppObserver
{
    class ConcreteObserver : Observer
    {
        public string Name { get; }
        public string ObserverState { get; set; }
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver( ConcreteSubject subject, string name)
        {
            Subject = subject;
            Name = name;
        }

        public override void Update()
        {
            ObserverState = Subject.SubjectState;

            Console.WriteLine($"Observer {Name}'s new state is {ObserverState}");
        }
    }
}
