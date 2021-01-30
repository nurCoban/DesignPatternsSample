using Observer.Abstractions;
using System;

namespace Observer.Observers
{
    public class AlertObserver : IObserver
    {
        private ISubject Subject;

        public AlertObserver(ISubject subject)
        {
            this.Subject = subject;
            this.Subject.Register(this);
        }

        public void Update(string eventData)
        {
            Console.WriteLine("Alert Observer receive new event: " + eventData);
        }
    }
}
