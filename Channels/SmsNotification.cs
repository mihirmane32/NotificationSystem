namespace NotificationSystem.Channels
{
    public class SmsNotification : INotificationChannel
    {
        public void SendNotification(string message)
        {
            if (message.Length > 160)
            {
                message = message.Substring(0, 160);
            }

            Console.WriteLine($"[SMS] Sending: {message}");
        }
    }
}
