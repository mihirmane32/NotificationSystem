using NotificationSystem.Channels;

namespace NotificationSystem.Factories
{
    public class NotificationFactory
    {
        public INotificationChannel CreateChannel(string type)
        {

            switch(type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SmsNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException($"Unknown notification type: {type}");

            }
        }
    }
}
