using Observer.Abstractions;
using System;

namespace Observer.Observers
{
    public class LogObserver : IObserver
    {
        private ISubject Subject;

        public LogObserver(ISubject subject)
        {
            this.Subject = subject;
            this.Subject.Register(this);
        }

        public void Update(string eventData)
        {
            Console.WriteLine("Log Observer receive new event: " + eventData);
        }
    }
}
