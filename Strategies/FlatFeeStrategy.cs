namespace NotificationSystem.Strategies
{
    public class FlatFeeStrategy : IFeeStrategy
    {
        public decimal CalculateFee(decimal distanceKm, decimal orderTotal)
        {
            return 5.00m;
        }
    }
}
