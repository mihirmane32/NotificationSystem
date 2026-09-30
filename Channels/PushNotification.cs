namespace NotificationSystem.Channels
{
    public class PushNotification : INotificationChannel
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"[PUSH] Sending: {message}");
        }
    }
}
