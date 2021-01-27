namespace FactoryPattern
{
    public static class NotificationFactory
    {
        public static INotification Create(NotificationType type)
        {
            INotification notification;
            switch (type)
            {
                case NotificationType.SMS:
                    notification = new SmsNotification();
                    break;
                case NotificationType.EMAIL:
                    notification = new EmailNotification();
                    break;
                default:
                    notification = null;
                    break;
            }

            return notification;
        }
    }
}
