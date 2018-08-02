using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftAidCalculator.TestConsole.CalculateGiftAid;
using GiftAidCalculator.TestConsole.EventGiftAidSupplement;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.TaxRate;
using Moq;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class CalculateGiftAidTest
    {
        private ICalculateGiftAid _calculateGiftAid;        

        [Test]
        public void Should_Correctly_Calculate_Gift_Aid_Using_New_Rates()
        {            
            var taxRateService = new Mock<ITaxRateService>();
            var giftAidService = new Mock<IGiftAidService>();
            var eventGiftAidSupplementService = new Mock<IEventGiftAidSupplementService>();
            
            taxRateService.Setup(x => x.SaveTaxRate(10));
            _calculateGiftAid = new CalculateGiftAid(eventGiftAidSupplementService.Object,giftAidService.Object,
                taxRateService.Object);
            _calculateGiftAid.GetTotalGiftAid(5);

            taxRateService.Verify(x => x.GetTaxRate(), Times.Once);
            
        }
    }
}
