using System;

namespace FactoryPattern
{
    class SmsNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Sms Notification");
        }
    }
}
