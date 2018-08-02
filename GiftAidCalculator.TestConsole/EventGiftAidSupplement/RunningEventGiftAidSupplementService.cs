using System;

namespace GiftAidCalculator.TestConsole.EventGiftAidSupplement
{
    public class RunningEventGiftAidSupplementService : IEventGiftAidSupplementService
    {
        public decimal AddSupplement(decimal giftAid)
        {
            decimal supplement = 5m;
            giftAid += (supplement / 100) * giftAid;
            return Math.Round(giftAid, 2);
        }        
    }
}
