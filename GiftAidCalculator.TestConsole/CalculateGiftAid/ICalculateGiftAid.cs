using GiftAidCalculator.TestConsole.EventGiftAidSupplement;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.TaxRate;

namespace GiftAidCalculator.TestConsole.CalculateGiftAid
{
    public interface ICalculateGiftAid
    {
        decimal GetTotalGiftAid(decimal donationAmount);
    }
}
