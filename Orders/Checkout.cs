using NotificationSystem.Strategies;

namespace NotificationSystem.Orders
{
    public class Checkout
    {
        private readonly IFeeStrategy _feeStrategy;

        public Checkout(IFeeStrategy feeStrategy)
        {
            _feeStrategy = feeStrategy;
        }

        public decimal GetDeliveryFee(decimal distanceKm, decimal orderTotal)
        {
            return _feeStrategy.CalculateFee(distanceKm, orderTotal);
        }
    }
}
