using NotificationSystem.PaymentProviders;

namespace NotificationSystem.Adapters
{
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly StripeGateway _stripGateway;

        public StripeAdapter(StripeGateway stripeGateway)
        {
            _stripGateway = stripeGateway;
        }

        public void Pay(decimal amount)
        {
            _stripGateway.MakePayment(amount);
        }
    }
}
