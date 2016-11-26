using System.Collections.Generic;

namespace ConsoleAppObserver
{

    abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in Observers)
            {
                observer.Update();
            }
        }
    }

}