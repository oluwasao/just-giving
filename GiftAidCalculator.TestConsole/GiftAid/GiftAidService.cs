using System;

namespace GiftAidCalculator.TestConsole.GiftAid
{
    public class GiftAidService : IGiftAidService
    {
        public decimal CalculateGiftAid(decimal donationAmount, decimal taxRate)
        {
            decimal giftAid = donationAmount * (taxRate / (100m - taxRate));
            return Math.Round(giftAid, 2);
        }        
    }
}
