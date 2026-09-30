using NotificationSystem.Channels;

namespace NotificationSystem.Factories
{
    public class NotificationFactory
    {
        public INotificationChannel CreateChannel(string type)
        {

            switch(type)
            {
                case "1":
                    return new EmailNotification();
                    break;
                default:
                    break;
            }
        }
    }
}
