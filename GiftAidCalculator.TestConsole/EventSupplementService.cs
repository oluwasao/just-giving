using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole
{
    public class EventSupplementService
    {                
        public decimal GetEventSupplement(EventType eventType)
        {
            decimal supplement = 0;
            switch (eventType)
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
    }
}
