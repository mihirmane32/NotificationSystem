namespace NotificationSystem.Strategies
{
    public interface IFeeStrategy
    {
        decimal CalculateFee(decimal distanceKm, decimal orderTotal);
    }
}
