namespace NotificationSystem.Strategies
{
    public class SurgeFeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(decimal distanceKm, decimal orderTotal)
        {
            return (distanceKm * 1.50m) * 1.8m;
        }
    }
}
