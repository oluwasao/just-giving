namespace GiftAidCalculator.TestConsole.GiftAid
{
    public interface IGiftAidService
    {
        decimal CalculateGiftAid(decimal donationAmount, decimal taxRate);
    }
}
