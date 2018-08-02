using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.EventGiftAidSupplement
{
    public class SwimmingEventGiftAidSupplementService : IEventGiftAidSupplementService
    {
        public  decimal AddSupplement(decimal giftAid)
        {
            decimal supplement = 3m;
            giftAid += (supplement / 100) * giftAid;
            return Math.Round(giftAid, 2);
        }
    }
}
