namespace NotificationSystem.Strategies
{
    public class DistanceFeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(decimal distanceKm, decimal orderTotal)
        {
            return distanceKm * 1.50m;
        }
    }
}
