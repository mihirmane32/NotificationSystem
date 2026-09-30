namespace NotificationSystem.Channels
{
    public interface INotificationChannel
    {
        void SendNotification(string message);
    }
}
