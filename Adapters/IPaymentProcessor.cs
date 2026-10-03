namespace NotificationSystem.Adapters
{
    public interface IPaymentProcessor
    {
        void Pay(decimal amount);
    }
}
