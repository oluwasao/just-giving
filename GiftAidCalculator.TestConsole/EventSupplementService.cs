using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole
{
    public class EventSupplementService : IEventSupplementService
    {
        public EventType _eventType = EventType.Other;
        public EventSupplementService(EventType eventType)
        {
            _eventType = eventType;
        }
        public decimal GetEventSupplement()
        {
            decimal supplement = 0;
            switch (_eventType)
            {
                case EventType.Running:
                    supplement = 5;
                    break;
                case EventType.Swimming:
                    supplement = 3;
                    break;
            }
            return supplement;
        }

        public decimal AddSupplement(decimal giftAid)
        {
            decimal supplement = GetEventSupplement();
            giftAid += (supplement / 100) * giftAid;
            return giftAid;
        }        
    }
}
