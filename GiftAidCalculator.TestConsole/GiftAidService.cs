namespace GiftAidCalculator.TestConsole
{
    public class GiftAidService : IGiftAidService
    {
        decimal _taxRate = 20;
        public EventType EventType = EventType.Other;
        
        EventSupplementService _eventSupplementService = new EventSupplementService();        
        public decimal CalculateGiftAid(decimal donationAmount)
        {
            decimal giftAid = donationAmount *(_taxRate / (100 - _taxRate));
            giftAid += AddSupplement(giftAid);
            return giftAid;
        }

        public decimal AddSupplement(decimal giftAid)
        {
            decimal supplement = _eventSupplementService.GetEventSupplement(EventType);
            giftAid += (supplement / 100) * giftAid;
            return 0;
        }
    }
}
