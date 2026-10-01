namespace NotificationSystem.Observers
{
    public interface IOrderObserver
    {
        void OnStatusChanged(string newStatus);
    }
}
