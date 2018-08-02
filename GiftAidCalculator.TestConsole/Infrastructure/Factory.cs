using GiftAidCalculator.TestConsole.EventGiftAidSupplement;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.TaxRate;

namespace GiftAidCalculator.TestConsole.Infrastructure
{
    public static class Factory
    {
        public static IEventGiftAidSupplementService CreateEventGiftAidSupplementService(EventType eventType)
        {
            switch (eventType)
            {
                case EventType.Running:
                    return new RunningEventGiftAidSupplementService();
                case EventType.Swimming:
                    return new SwimmingEventGiftAidSupplementService();
            }
            return new OtherEventGiftAidSupplementService();
        }

        public static IGiftAidService CreateGiftAidService()
        {
            return new GiftAidService();
        }

        public static ITaxRateService CreateTaxRateService()
        {
            return new TaxRateService();
        }

    }
}
