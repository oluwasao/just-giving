using GiftAidCalculator.TestConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftAidCalculator.TestConsole.EventGiftAidSupplement;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class EventSupplementServiceTest
    {
        IEventGiftAidSupplementService _eventSupplementService;
        [Test]
        public void Should_Add_Correct_Supplement_When_Event_Type_Is_Other()
        {
            _eventSupplementService = new OtherEventGiftAidSupplementService();
            decimal giftAid = 100m;            

            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(100m, totalGiftAid);
        }

        [Test]
        public void Should_Add_Correct_Supplement_When_Event_Type_Is_Running()
        {
            _eventSupplementService = new RunningEventGiftAidSupplementService();
            decimal giftAid = 50m;

            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(52.5m, totalGiftAid);
        }

        [Test]
        public void Should_Add_Correct_Supplement_When_Event_Type_Is_Swimming()
        {
            _eventSupplementService = new SwimmingEventGiftAidSupplementService();
            decimal giftAid = 25m;                        
            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(25.75m, totalGiftAid);
        }
    }
}
