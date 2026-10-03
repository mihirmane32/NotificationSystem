namespace NotificationSystem.PaymentProviders
{
    public class PayPalProcessor
    {
        public void SendPayment(double total, string currencyCode)
        {
            Console.WriteLine($"[PayPal] Sent {total} {currencyCode}");
        }
    }
}
