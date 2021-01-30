using Observer.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Subject
{
    public class EventManager : ISubject
    {
        private List<IObserver> Observers;

        public EventManager()
        {
            this.Observers = new List<IObserver>();
        }

        public void Notify(string eventData)
        {
            Console.WriteLine("Sending notification to observers...");
            this.Observers.ForEach(o => o.Update(eventData));
            Console.WriteLine("Notification sent.");
        }

        public void Register(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
    }
}
