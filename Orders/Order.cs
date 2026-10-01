using NotificationSystem.Observers;

namespace NotificationSystem.Orders
{
    public class Order
    {
        private readonly List<IOrderObserver> _observers = new();
        public string Status { get; private set; } = "Pending";

        public void Subscribe(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;

            foreach (var observer in _observers)
            {
                observer.OnStatusChanged(newStatus);
            }
        }
    }
}
