using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftAidCalculator.TestConsole.EventGiftAidSupplement;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.TaxRate;

namespace GiftAidCalculator.TestConsole.CalculateGiftAid
{
    public class CalculateGiftAid : ICalculateGiftAid
    {
        private IEventGiftAidSupplementService _eventGiftAidSupplementService;
        private IGiftAidService _giftAidService;
        private ITaxRateService _taxRateService;
        public CalculateGiftAid(IEventGiftAidSupplementService eventGiftAidSupplementService, IGiftAidService giftAidService, ITaxRateService taxRateService)
        {
            _eventGiftAidSupplementService = eventGiftAidSupplementService;
            _giftAidService = giftAidService;
            _taxRateService = taxRateService;
        }

        public decimal GetTotalGiftAid(decimal donationAmount)
        {
            decimal giftAid = _giftAidService.CalculateGiftAid(donationAmount, _taxRateService.GetTaxRate());
            decimal totalGiftAid = _eventGiftAidSupplementService.AddSupplement(giftAid);
            return totalGiftAid;
        }
    }
}
