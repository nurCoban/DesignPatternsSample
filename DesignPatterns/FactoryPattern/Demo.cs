using System;

namespace FactoryPattern
{
    class Demo
    {
        static void Main(string[] args)
        {
            var smsNotificationService = NotificationFactory.Create(NotificationType.SMS);
            smsNotificationService.Notify();

            var emailNotificationService = NotificationFactory.Create(NotificationType.EMAIL);
            emailNotificationService.Notify();

            Console.ReadLine();
        }
    }
}