namespace NotificationSystem.Observers
{
    public class CustomerEmailObserver : IOrderObserver
    {
        public void OnStatusChanged(string newStatus) 
        {
            Console.WriteLine($"Emailing customer: order is now {newStatus}");
        }
    }
}
