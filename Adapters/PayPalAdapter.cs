using NotificationSystem.PaymentProviders;

namespace NotificationSystem.Adapters
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalProcessor _paypalProcessor;

        public PayPalAdapter(PayPalProcessor paypalProcessor)
        {
            _paypalProcessor = paypalProcessor;
        }

        public void Pay(decimal amount)
        {
            _paypalProcessor.SendPayment((double)amount, "USD");
        }
    }
}
