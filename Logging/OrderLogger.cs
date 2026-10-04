namespace NotificationSystem.Logging
{
    public class OrderLogger
    {
        private static OrderLogger _instance;
        private int _eventCount = 0;

        private OrderLogger() { }

        public static OrderLogger Instance
        {
            get
            {
                _instance ??= new OrderLogger();
                return _instance;
            }
        }

        public void Log(string message)
        {
            _eventCount++;
            Console.WriteLine($"[LOG #{_eventCount}] {message}");
        }
    }
}
