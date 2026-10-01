namespace NotificationSystem.Observers
{
    public class RestaurantDashboardObserver : IOrderObserver
    {
        public void OnStatusChanged(string newStatus)
        {
            Console.WriteLine($"Updating restaurant dashboard: {newStatus}");
        }
    }
}
