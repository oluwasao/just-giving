using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole.EventGiftAidSupplement
{
    public class OtherEventGiftAidSupplementService : IEventGiftAidSupplementService
    {        
        public decimal AddSupplement(decimal giftAid)
        {            
            return Math.Round(giftAid, 2);
        }
    }
}
