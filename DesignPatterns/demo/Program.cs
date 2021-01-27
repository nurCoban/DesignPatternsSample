using FactoryPattern;
using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryPattern

            var smsNotificationService = NotificationFactory.Create(NotificationType.SMS);
            smsNotificationService.Notify();

            var emailNotificationService = NotificationFactory.Create(NotificationType.EMAIL);
            emailNotificationService.Notify();

            #endregion


            Console.ReadLine();

        }
    }
}
