using Observer.Observers;
using Observer.Subject;
using System;

namespace Observer
{
    class Demo
    {
        static void Main(string[] args)
        {
            var eventManager = new EventManager();

            var logObserver = new LogObserver(eventManager);
            var alertObserver = new AlertObserver(eventManager);

            Console.WriteLine("New event raise: Event1");
            eventManager.Notify("Event1");

            Console.WriteLine("New event raise: Event2");
            eventManager.Notify("Event2");
        }
    }
}
