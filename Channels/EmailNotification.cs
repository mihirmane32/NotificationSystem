namespace NotificationSystem.Channels
{
    public class EmailNotification : INotificationChannel
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"[EMAIL] Sending: {message}");
        }
    }
}
