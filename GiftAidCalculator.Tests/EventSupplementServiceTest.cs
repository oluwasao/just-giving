using GiftAidCalculator.TestConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class EventSupplementServiceTest
    {
        IEventSupplementService _eventSupplementService;
        [Test]
        public void Should_Return_Twenty_Five_When_Donation_Is_Hundred_And_Event_Type_Is_Other()
        {
            _eventSupplementService = new EventSupplementService(EventType.Other);
            decimal giftAid = 100m;            

            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(100m, totalGiftAid);
        }

        [Test]
        public void Should_Return_Twelve_Point_Five_When_Donation_Is_Fifty_And_Event_Type_Is_Running()
        {
            _eventSupplementService = new EventSupplementService(EventType.Running);
            decimal giftAid = 50m;

            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(12.5m, totalGiftAid);
        }

        [Test]
        public void Should_Return_Six_Point_Two_Five_When_Donation_Is_Twenty_Five_And_Event_Type_Is_Swimming()
        {
            _eventSupplementService = new EventSupplementService(EventType.Swimming);
            decimal giftAid = 25m;                        
            decimal totalGiftAid = _eventSupplementService.AddSupplement(giftAid);
            Assert.AreEqual(6.25m, giftAid);
        }
    }
}
