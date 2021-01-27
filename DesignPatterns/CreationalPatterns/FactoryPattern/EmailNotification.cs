using System;

namespace FactoryPattern
{
    class EmailNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Email Notification");
        }
    }
}
