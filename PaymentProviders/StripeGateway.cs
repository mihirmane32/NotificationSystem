namespace NotificationSystem.PaymentProviders
{
    public class StripeGateway
    {
        public void MakePayment(decimal amountInDollars)
        {
            Console.WriteLine($"[Stripe] Charged ${amountInDollars}");
        }
    }
}
